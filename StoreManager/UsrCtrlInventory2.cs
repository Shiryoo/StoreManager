﻿using StoreManager.CustomComponentsLinker;
using StoreManager.Database;
using LaundrySystem;
using StoreManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreObjects;

namespace StoreManager
{
    public partial class UsrCtrlInventory2 : UserControl
    {
        private DBConnect dbConnection;
        private GlobalProcedure gProc;

        string imgLocation;
        Boolean needImage, addProduct, editProduct, removeProduct, restock, disposeStock;

        public UsrCtrlInventory2(DBConnect dbConnection)
        {
            InitializeComponent();
            this.dbConnection = dbConnection;
            this.gProc = new GlobalProcedure();
            this.gProc.FncConnectToDatabase();
            StandardView();
            InitializeItemsGrid();
        }

        private void BtnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "Images Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif;)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofdPic.FileName;
                ImgItem.Image = new Bitmap(ofdPic.FileName);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            string currentDir = Environment.CurrentDirectory;
            string imageFolderDir = Path.Combine(currentDir, "..\\..\\ProductImages");

            string itemName = TxtName.Text;
            string size = CmbSizeInfo.Text;
            string type = CmbTypeInfo.Text;
            string imgLocation = this.imgLocation;
            string imgName = Path.GetFileName(imgLocation);
            string supplier = TxtSupplier.Text;
            int restockThreshold = int.Parse(TxtRestockThreshold.Text);
            int remainingStocks = int.Parse(TxtRemainingStocks.Text);
            double price = double.Parse(TxtPrice.Text);
            double costPerItem = double.Parse(TxtCostPerItem.Text);

            try 
            {
                if (needImage == true)
                {
                    File.Copy(this.imgLocation, Path.Combine(imageFolderDir, imgName), true);
                }
                

                if (addProduct == true)
                {
                    gProc.ProcAddItem(itemName, size, type, price, costPerItem, imgName, supplier, restockThreshold);
                    StandardView();
                }
               
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Message" + err.Message);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            EnabledAll();
            TxtRemainingStocks.Enabled = false;
            needImage = true;
            addProduct = true;
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            EnabledAll();
            TxtSupplier.Enabled = false;
            TxtCostPerItem.Enabled = false;
            TxtRemainingStocks.Enabled = false;
            needImage = true;
        }

        private void BtnRemoveProduct_Click(object sender, EventArgs e)
        {
            StandardView();
            BtnSubmit.Enabled = true;
        }

        private void BtnRestock_Click(object sender, EventArgs e)
        {
            EnabledAll();
            TxtName.Enabled = false;
            TxtRemainingStocks.Enabled = false;
            BtnUploadImg.Enabled = false;
            TxtQuantity.Visible = true;
            LblQuantity.Visible = true;
        }

        private void BtnDisposeStock_Click(object sender, EventArgs e)
        {
            StandardView();
            TxtQuantity.Visible = true;
            LblQuantity.Visible = true;
            BtnSubmit.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            StandardView();
        }

        private void TbNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            var regex = new Regex(@"[^.0-9\s]");

            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void InitializeItemsGrid()
        {
            List<Item> items = gProc.FncGetItems();
            this.DataGridItems.RowCount = items.Count;

            for (int i = 0; i < items.Count; i++)
            {
                this.DataGridItems.Rows[i].Cells[0].Value = items[i].Name;              // Name
                this.DataGridItems.Rows[i].Cells[1].Value = items[i].ItemCode;          // Item Code
                this.DataGridItems.Rows[i].Cells[2].Value = items[i].Price;             // Price
                this.DataGridItems.Rows[i].Cells[3].Value = items[i].CostPerItem;       // Cost per Item
                this.DataGridItems.Rows[i].Cells[4].Value = items[i].Size;              // Size
                this.DataGridItems.Rows[i].Cells[5].Value = items[i].Type;              // Type
                this.DataGridItems.Rows[i].Cells[6].Value = items[i].CurrentStocks;     // Current Stocks
                this.DataGridItems.Rows[i].Cells[7].Value = items[i].SupplierName;      // Supplier Name
                this.DataGridItems.Rows[i].Cells[8].Value = items[i].RestockThreshold;  // Restock Threshold
            }
        }

        private void TbInvSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            var regex = new Regex(@"[^a-zA-Z0-9\s]");

            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public void StandardView()
        {
            TxtName.Enabled = false;
            CmbSizeInfo.Enabled = false;
            CmbTypeInfo.Enabled = false;
            TxtPrice.Enabled = false;
            TxtCostPerItem.Enabled = false;
            TxtRestockThreshold.Enabled = false;
            TxtRemainingStocks.Enabled = false;
            TxtSupplier.Enabled = false;
            BtnUploadImg.Enabled = false;
            BtnSubmit.Enabled = false;
            TxtQuantity.Visible = false;
            LblQuantity.Visible = false;
            ClearAll();
        }

        public void EnabledAll()
        {
            TxtName.Enabled = true;
            CmbSizeInfo.Enabled = true;
            CmbTypeInfo.Enabled = true;
            TxtPrice.Enabled = true;
            TxtCostPerItem.Enabled = true;
            TxtRestockThreshold.Enabled = true;
            TxtRemainingStocks.Enabled = true;
            TxtSupplier.Enabled = true;
            BtnUploadImg.Enabled = true;
            BtnSubmit.Enabled = true;
            TxtQuantity.Visible = false;
            LblQuantity.Visible = false;
            ClearAll();
        }

        public void ClearAll()
        {
            TxtName.Clear();
            CmbSizeInfo.SelectedIndex = -1;
            CmbTypeInfo.SelectedIndex = -1;
            TxtPrice.Clear();
            TxtCostPerItem.Clear();
            TxtRestockThreshold.Clear();
            TxtRemainingStocks.Clear();
            TxtSupplier.Clear();
            TxtQuantity.Clear();
            ImgItem.Image = null;
            imgLocation = null;
            needImage = false;
            addProduct = false;
            editProduct = false;
            removeProduct = false;
            restock = false;
            disposeStock = false;
        }

    }
}

