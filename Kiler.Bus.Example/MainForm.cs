using Kiler.Bus.Models.Configuration;
using Kiler.Bus.Models.EventModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Kiler.Bus.Example
{
    public partial class MainForm : Form
    {
        BusService busService;
        private bool isListening = false;

        public MainForm()
        {
            InitializeComponent();
            ToogleAllControlsEnable(isListening);
#if NETCOREAPP
            this.txtErpId.PlaceholderText = "Region Erp Id";
            this.txtCompany.PlaceholderText = "CompanyName";
            this.txtApiId.PlaceholderText = "ApiId";
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEventType.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApiId.Text))
            {
                MessageBox.Show("Please enter the server information correctly.");
            }
            else if (cbEventType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the event type");
            }
            else
            {
                StartOrStop();
            }
        }

        private void StartOrStop()
        {
            isListening = !isListening;
            ToogleAllControlsEnable(!isListening);
            if (isListening)
            {
                AppendText("Connecting...", Color.Black);
                StartEvent();
                btnStart.Text = "Stop";
            }
            else
            {
                AppendText("Stopping...", Color.Black);
                StopEvent();
                btnStart.Text = "Start";
            }

        }

        private void StopEvent()
        {
            busService.OnOrderCreated -= Service_OnOrderCreated;

            busService.Dispose();
        }

        private void StartEvent()
        {
            try
            {
                busService.OnConnectionStateChanged += BusService_OnConnectionStateChanged;

                if (cbEventType.SelectedIndex == 0)
                {
                    busService.OnOrderCreated += Service_OnOrderCreated;
                }
                else if (cbEventType.SelectedIndex == 1)
                {
                    busService.OnNewLog += BusService_OnNewLog;
                }
            }
            catch (Exception ex)
            {
                AppendText(ex.Message, Color.Red);
                StartOrStop();
            }
        }

        private void BusService_OnNewLog(LogContent log, string tid)
        {
            AppendText(tid + JsonConvert.SerializeObject(log), Color.DarkGreen);
        }

        private void Service_OnOrderCreated(OrderContent order, string tid)
        {
            AppendText(tid + JsonConvert.SerializeObject(order), Color.DarkGreen);
        }


        private void BusService_OnConnectionStateChanged(bool isConnected)
        {
            AppendText(isConnected ? "Connected" : "Disconnected", Color.Green);
            btnStart.Enabled = isConnected;
        }

        private void ToogleAllControlsEnable(bool isEnable)
        {
            txtErpId.Enabled = isEnable;
            cbEventType.Enabled = isEnable;
            btnDisableAll.Enabled = isEnable;
            btnGetCategoryTree.Enabled = isEnable;
            btnUpdateAllProduct.Enabled = isEnable;
            btnUpdateSingle.Enabled = isEnable;
            btnStart.Enabled = isEnable;
        }

        private void btnUpdateSingle_Click(object sender, EventArgs e)
        {
            List<ProductContent> products = new List<ProductContent>();
            products.Add(new ProductContent()
            {
                Active = true,
                Barcode = Guid.NewGuid().ToString(),
                Desi = new Random().Next(1, 15),
                ErpId = "001212121",
                InitialAmount = 1,
                ListPrice = 1.3m,
                MaxAmount = 15m,
                MinAmount = 1m,
                Name = "Test Product",
                Price = 1.3m,
                ProductUnit = 0,
                QuantityStep = 1m,
                Vat = 12m,
            });

            CatalogContent catalog = new CatalogContent()
            {
                FullSync = false, // Full sync false means update only products sent
                Products = products,
                RegionId = txtErpId.Text
            };

            var result = busService.UpdateCatalog(catalog);
            AppendText($"TotalItem Count: {result.TotalItemCount}", Color.Blue);
            AppendText($"Inserted Count: {result.InsertedItemCount}", Color.Blue);
            AppendText($"UpdatedItemCount: {result.UpdatedItemCount}", Color.Blue);
            AppendText($"Message: {result.Message}", Color.Blue);
            AppendText($"RemovedItemCount: {result.RemovedItemCount}", Color.Blue);
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {
            List<ProductContent> products = new List<ProductContent>(); // create an empty product list

            CatalogContent catalog = new CatalogContent()
            {
                FullSync = true, // Full sync true means make online catalog as same with products list. Since products is empty all online products will be disabled
                Products = products, // set catalog as empty product list
                RegionId = txtErpId.Text
            };

            var result = busService.UpdateCatalog(catalog);

            AppendText($"TotalItem Count: {result.TotalItemCount}", Color.Blue);
            AppendText($"Inserted Count: {result.InsertedItemCount}", Color.Blue);
            AppendText($"UpdatedItemCount: {result.UpdatedItemCount}", Color.Blue);
            AppendText($"Message: {result.Message}", Color.Blue);
            AppendText($"RemovedItemCount: {result.RemovedItemCount}", Color.Blue);
        }

        private void btnUpdateAllProduct_Click(object sender, EventArgs e)
        {
            List<ProductContent> products = new List<ProductContent>();
            products.Add(new ProductContent()
            {
                Active = true,
                Barcode = Guid.NewGuid().ToString(),
                Desi = new Random().Next(1, 15),
                ErpId = "001212121",
                InitialAmount = 1,
                ListPrice = 1.3m,
                MaxAmount = 15m,
                MinAmount = 1m,
                Name = "Test Product",
                Price = 1.3m,
                ProductUnit = 0,
                QuantityStep = 1,
                Vat = 12,
            });
            products.Add(new ProductContent()
            {
                Active = true,
                Barcode = Guid.NewGuid().ToString(),
                Desi = new Random().Next(1, 15),
                ErpId = "001212122",
                InitialAmount = 1,
                ListPrice = 1.3m,
                MaxAmount = 15m,
                MinAmount = 1m,
                Name = "Test Product 2",
                Price = 1.3m,
                ProductUnit = 0,
                QuantityStep = 1,
                Vat = 12,
            });
            products.Add(new ProductContent()
            {
                Active = true,
                Barcode = Guid.NewGuid().ToString(),
                Desi = new Random().Next(1, 15),
                ErpId = "001212123",
                InitialAmount = 1,
                ListPrice = 1.2m,
                MaxAmount = 15m,
                MinAmount = 1m,
                Name = "Test Product 3",
                Price = 1.3m,
                ProductUnit = 0,
                QuantityStep = 1,
                Vat = 12,
            });

            CatalogContent catalog = new CatalogContent()
            {
                FullSync = true,
                Products = products,
                RegionId = txtErpId.Text
            };
            var result = busService.UpdateCatalog(catalog);
            AppendText($"TotalItem Count: {result.TotalItemCount}", Color.Blue);
            AppendText($"Inserted Count: {result.InsertedItemCount}", Color.Blue);
            AppendText($"UpdatedItemCount: {result.UpdatedItemCount}", Color.Blue);
            AppendText($"Message: {result.Message}", Color.Blue);
            AppendText($"RemovedItemCount: {result.RemovedItemCount}", Color.Blue);
        }

        private void btnGetCategoryTree_Click(object sender, EventArgs e)
        {
            List<CategoryContent> categories = busService.GetCategoryTree();
            AppendText($"Total Category Count: {categories.Count}", Color.Blue);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ToogleAllControlsEnable(true);
            busService = new BusService(txtCompany.Text, txtApiId.Text);

        }

        public void AppendText(string text, Color color)
        {
            if (rtbData.InvokeRequired)
            {
                rtbData.Invoke(new Action(() =>
                {
                    rtbData.SelectionStart = rtbData.TextLength;
                    rtbData.SelectionLength = 0;

                    rtbData.SelectionColor = color;
                    rtbData.AppendText(text + Environment.NewLine);
                    rtbData.SelectionColor = rtbData.ForeColor;
                }));
            }
            else
            {
                rtbData.SelectionStart = rtbData.TextLength;
                rtbData.SelectionLength = 0;

                rtbData.SelectionColor = color;
                rtbData.AppendText(text + Environment.NewLine);
                rtbData.SelectionColor = rtbData.ForeColor;
            }
        }
    }
}
