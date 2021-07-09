﻿using Kiler.Bus.Models.Configuration;
using Kiler.Bus.Models.EventModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kiler.Bus.Example
{
    public partial class MainForm : Form
    {
        BusService busService;
        private bool isStarting = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEventType.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtServerAddress.Text)
                || string.IsNullOrEmpty(txtUsername.Text) || nudServerPort.Value == 0)
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
            isStarting = !isStarting;
            ToogleAllControlsEnable(!isStarting);
            if (isStarting)
            {
                AppendText("Connecting...", Color.Black);
                StartEvent();
            }
            else
            {
                AppendText("Stopping...", Color.Black);
                StopEvent();
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
                busService = new BusService(GenerateConfig());
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

        private void BusService_OnNewLog(Models.EventModels.LogContent log)
        {
            AppendText(JsonConvert.SerializeObject(log), Color.DarkGreen);
        }

        private void BusService_OnConnectionStateChanged(bool isConnected)
        {
            AppendText(isConnected ? "Connected" : "Disconnected", Color.Green);
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

        private void Service_OnOrderCreated(Models.EventModels.OrderContent order)
        {
            AppendText(JsonConvert.SerializeObject(order), Color.DarkGreen);
        }

        private void ToogleAllControlsEnable(bool isEnable)
        {
            txtPassword.Enabled = isEnable;
            txtServerAddress.Enabled = isEnable;
            txtUsername.Enabled = isEnable;
            cbEventType.Enabled = isEnable;
            nudServerPort.Enabled = isEnable;
            btnStart.Text = isEnable ? "Start" : "Stop";
        }

        private ConfigRabbitMq GenerateConfig()
        {
            ConfigRabbitMq config = new ConfigRabbitMq();
            config.HostAddres = txtServerAddress.Text;
            config.Port = (int)nudServerPort.Value;
            config.IsUsage = true;
            config.Password = txtPassword.Text;
            config.Username = txtUsername.Text;
            config.Prefix = "akyurt";
            return config;
        }

        private void btnUpdateSingle_Click(object sender, EventArgs e)
        {
            BusService services = new BusService(GenerateConfig());
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
            var result = services.UpdateCatalog(new Models.EventModels.CatalogContent()
            {
                FullSync = false,
                Products = products,
                RegionId = "800"
            });
            AppendText($"TotalItem Count: {result.TotalItemCount}", Color.Blue);
            AppendText($"Inserted Count: {result.InsertedItemCount}", Color.Blue);
            AppendText($"UpdatedItemCount: {result.UpdatedItemCount}", Color.Blue);
            AppendText($"Message: {result.Message}", Color.Blue);
            AppendText($"RemovedItemCount: {result.RemovedItemCount}", Color.Blue);
        }

        private void btnDisableAll_Click(object sender, EventArgs e)
        {
            Bus.BusService services = new BusService(GenerateConfig());
            List<ProductContent> products = new List<ProductContent>();
            var result = services.UpdateCatalog(new Models.EventModels.CatalogContent()
            {
                FullSync = true,
                Products = products,
                RegionId = "800"
            });

            AppendText($"TotalItem Count: {result.TotalItemCount}", Color.Blue);
            AppendText($"Inserted Count: {result.InsertedItemCount}", Color.Blue);
            AppendText($"UpdatedItemCount: {result.UpdatedItemCount}", Color.Blue);
            AppendText($"Message: {result.Message}", Color.Blue);
            AppendText($"RemovedItemCount: {result.RemovedItemCount}", Color.Blue);
        }

        private void btnUpdateAllProduct_Click(object sender, EventArgs e)
        {
            Bus.BusService services = new BusService(GenerateConfig());
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
            var result = services.UpdateCatalog(new Models.EventModels.CatalogContent()
            {
                FullSync = true,
                Products = products,
                RegionId = "800"
            });
            AppendText($"TotalItem Count: {result.TotalItemCount}", Color.Blue);
            AppendText($"Inserted Count: {result.InsertedItemCount}", Color.Blue);
            AppendText($"UpdatedItemCount: {result.UpdatedItemCount}", Color.Blue);
            AppendText($"Message: {result.Message}", Color.Blue);
            AppendText($"RemovedItemCount: {result.RemovedItemCount}", Color.Blue);
        }
    }
}
