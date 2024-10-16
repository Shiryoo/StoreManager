﻿using CustomComponents;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Runtime.CompilerServices;
using StoreManager.Database;
using System.Windows.Forms;

namespace StoreManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.PnlNavigation = new System.Windows.Forms.Panel();
            this.BtnAnalytics = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.BtnInventory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.BtnCashier = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.PicBoxSettings = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlNavigation
            // 
            this.PnlNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlNavigation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlNavigation.Controls.Add(this.BtnAnalytics);
            this.PnlNavigation.Controls.Add(this.BtnInventory);
            this.PnlNavigation.Controls.Add(this.BtnCashier);
            this.PnlNavigation.Controls.Add(this.PicBoxSettings);
            this.PnlNavigation.Controls.Add(this.picBoxLogo);
            this.PnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.PnlNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.PnlNavigation.Name = "PnlNavigation";
            this.PnlNavigation.Size = new System.Drawing.Size(203, 682);
            this.PnlNavigation.TabIndex = 0;
            // 
            // BtnAnalytics
            // 
            this.BtnAnalytics.AllowAnimations = true;
            this.BtnAnalytics.AllowMouseEffects = true;
            this.BtnAnalytics.AllowToggling = true;
            this.BtnAnalytics.AnimationSpeed = 200;
            this.BtnAnalytics.AutoGenerateColors = false;
            this.BtnAnalytics.AutoRoundBorders = false;
            this.BtnAnalytics.AutoSizeLeftIcon = true;
            this.BtnAnalytics.AutoSizeRightIcon = true;
            this.BtnAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnalytics.BackColor1 = System.Drawing.Color.White;
            this.BtnAnalytics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAnalytics.BackgroundImage")));
            this.BtnAnalytics.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnAnalytics.ButtonText = "ANALYTICS";
            this.BtnAnalytics.ButtonTextMarginLeft = 0;
            this.BtnAnalytics.ColorContrastOnClick = 45;
            this.BtnAnalytics.ColorContrastOnHover = 45;
            this.BtnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnAnalytics.CustomizableEdges = borderEdges1;
            this.BtnAnalytics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAnalytics.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnAnalytics.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnAnalytics.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnAnalytics.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnAnalytics.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalytics.ForeColor = System.Drawing.Color.Black;
            this.BtnAnalytics.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnalytics.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnalytics.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.BtnAnalytics.IconMarginLeft = 11;
            this.BtnAnalytics.IconPadding = 10;
            this.BtnAnalytics.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnalytics.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnalytics.IconRightPadding = new System.Windows.Forms.Padding(2, 3, 7, 3);
            this.BtnAnalytics.IconSize = 50;
            this.BtnAnalytics.IdleBorderColor = System.Drawing.Color.White;
            this.BtnAnalytics.IdleBorderRadius = 5;
            this.BtnAnalytics.IdleBorderThickness = 1;
            this.BtnAnalytics.IdleFillColor = System.Drawing.Color.White;
            this.BtnAnalytics.IdleIconLeftImage = global::StoreManager.Properties.Resources.stats_icon;
            this.BtnAnalytics.IdleIconRightImage = null;
            this.BtnAnalytics.IndicateFocus = true;
            this.BtnAnalytics.Location = new System.Drawing.Point(12, 265);
            this.BtnAnalytics.Name = "BtnAnalytics";
            this.BtnAnalytics.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnAnalytics.OnDisabledState.BorderRadius = 5;
            this.BtnAnalytics.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnAnalytics.OnDisabledState.BorderThickness = 1;
            this.BtnAnalytics.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnAnalytics.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnAnalytics.OnDisabledState.IconLeftImage = null;
            this.BtnAnalytics.OnDisabledState.IconRightImage = null;
            this.BtnAnalytics.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnAnalytics.onHoverState.BorderRadius = 5;
            this.BtnAnalytics.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnAnalytics.onHoverState.BorderThickness = 1;
            this.BtnAnalytics.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.BtnAnalytics.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnAnalytics.onHoverState.IconLeftImage = null;
            this.BtnAnalytics.onHoverState.IconRightImage = null;
            this.BtnAnalytics.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.BtnAnalytics.OnIdleState.BorderRadius = 5;
            this.BtnAnalytics.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnAnalytics.OnIdleState.BorderThickness = 1;
            this.BtnAnalytics.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnAnalytics.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnAnalytics.OnIdleState.IconLeftImage = global::StoreManager.Properties.Resources.stats_icon;
            this.BtnAnalytics.OnIdleState.IconRightImage = null;
            this.BtnAnalytics.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnAnalytics.OnPressedState.BorderRadius = 5;
            this.BtnAnalytics.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnAnalytics.OnPressedState.BorderThickness = 1;
            this.BtnAnalytics.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnAnalytics.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnAnalytics.OnPressedState.IconLeftImage = null;
            this.BtnAnalytics.OnPressedState.IconRightImage = null;
            this.BtnAnalytics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnalytics.Size = new System.Drawing.Size(178, 55);
            this.BtnAnalytics.TabIndex = 3;
            this.BtnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnalytics.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAnalytics.TextMarginLeft = 0;
            this.BtnAnalytics.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnAnalytics.UseDefaultRadiusAndThickness = true;
            this.BtnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            // 
            // BtnInventory
            // 
            this.BtnInventory.AllowAnimations = true;
            this.BtnInventory.AllowMouseEffects = true;
            this.BtnInventory.AllowToggling = true;
            this.BtnInventory.AnimationSpeed = 200;
            this.BtnInventory.AutoGenerateColors = false;
            this.BtnInventory.AutoRoundBorders = false;
            this.BtnInventory.AutoSizeLeftIcon = true;
            this.BtnInventory.AutoSizeRightIcon = true;
            this.BtnInventory.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventory.BackColor1 = System.Drawing.Color.White;
            this.BtnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInventory.BackgroundImage")));
            this.BtnInventory.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnInventory.ButtonText = "INVENTORY";
            this.BtnInventory.ButtonTextMarginLeft = 0;
            this.BtnInventory.ColorContrastOnClick = 45;
            this.BtnInventory.ColorContrastOnHover = 45;
            this.BtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnInventory.CustomizableEdges = borderEdges2;
            this.BtnInventory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnInventory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnInventory.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnInventory.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnInventory.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnInventory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventory.ForeColor = System.Drawing.Color.Black;
            this.BtnInventory.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventory.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventory.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.BtnInventory.IconMarginLeft = 11;
            this.BtnInventory.IconPadding = 10;
            this.BtnInventory.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInventory.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventory.IconRightPadding = new System.Windows.Forms.Padding(2, 3, 7, 3);
            this.BtnInventory.IconSize = 50;
            this.BtnInventory.IdleBorderColor = System.Drawing.Color.White;
            this.BtnInventory.IdleBorderRadius = 5;
            this.BtnInventory.IdleBorderThickness = 1;
            this.BtnInventory.IdleFillColor = System.Drawing.Color.White;
            this.BtnInventory.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BtnInventory.IdleIconLeftImage")));
            this.BtnInventory.IdleIconRightImage = null;
            this.BtnInventory.IndicateFocus = true;
            this.BtnInventory.Location = new System.Drawing.Point(12, 204);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnInventory.OnDisabledState.BorderRadius = 5;
            this.BtnInventory.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnInventory.OnDisabledState.BorderThickness = 1;
            this.BtnInventory.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnInventory.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnInventory.OnDisabledState.IconLeftImage = null;
            this.BtnInventory.OnDisabledState.IconRightImage = null;
            this.BtnInventory.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnInventory.onHoverState.BorderRadius = 5;
            this.BtnInventory.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnInventory.onHoverState.BorderThickness = 1;
            this.BtnInventory.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.BtnInventory.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnInventory.onHoverState.IconLeftImage = null;
            this.BtnInventory.onHoverState.IconRightImage = null;
            this.BtnInventory.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.BtnInventory.OnIdleState.BorderRadius = 5;
            this.BtnInventory.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnInventory.OnIdleState.BorderThickness = 1;
            this.BtnInventory.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnInventory.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnInventory.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BtnInventory.OnIdleState.IconLeftImage")));
            this.BtnInventory.OnIdleState.IconRightImage = null;
            this.BtnInventory.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnInventory.OnPressedState.BorderRadius = 5;
            this.BtnInventory.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnInventory.OnPressedState.BorderThickness = 1;
            this.BtnInventory.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnInventory.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnInventory.OnPressedState.IconLeftImage = null;
            this.BtnInventory.OnPressedState.IconRightImage = null;
            this.BtnInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInventory.Size = new System.Drawing.Size(178, 55);
            this.BtnInventory.TabIndex = 2;
            this.BtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInventory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnInventory.TextMarginLeft = 0;
            this.BtnInventory.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnInventory.UseDefaultRadiusAndThickness = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnCashier
            // 
            this.BtnCashier.AllowAnimations = true;
            this.BtnCashier.AllowMouseEffects = true;
            this.BtnCashier.AllowToggling = true;
            this.BtnCashier.AnimationSpeed = 200;
            this.BtnCashier.AutoGenerateColors = false;
            this.BtnCashier.AutoRoundBorders = false;
            this.BtnCashier.AutoSizeLeftIcon = true;
            this.BtnCashier.AutoSizeRightIcon = true;
            this.BtnCashier.BackColor = System.Drawing.Color.Transparent;
            this.BtnCashier.BackColor1 = System.Drawing.Color.White;
            this.BtnCashier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCashier.BackgroundImage")));
            this.BtnCashier.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCashier.ButtonText = "CASHIERING";
            this.BtnCashier.ButtonTextMarginLeft = 0;
            this.BtnCashier.ColorContrastOnClick = 45;
            this.BtnCashier.ColorContrastOnHover = 45;
            this.BtnCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtnCashier.CustomizableEdges = borderEdges3;
            this.BtnCashier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCashier.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCashier.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCashier.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCashier.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnCashier.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCashier.ForeColor = System.Drawing.Color.Black;
            this.BtnCashier.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCashier.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCashier.IconLeftPadding = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.BtnCashier.IconMarginLeft = 11;
            this.BtnCashier.IconPadding = 10;
            this.BtnCashier.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCashier.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCashier.IconRightPadding = new System.Windows.Forms.Padding(2, 3, 7, 3);
            this.BtnCashier.IconSize = 50;
            this.BtnCashier.IdleBorderColor = System.Drawing.Color.White;
            this.BtnCashier.IdleBorderRadius = 5;
            this.BtnCashier.IdleBorderThickness = 1;
            this.BtnCashier.IdleFillColor = System.Drawing.Color.White;
            this.BtnCashier.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BtnCashier.IdleIconLeftImage")));
            this.BtnCashier.IdleIconRightImage = null;
            this.BtnCashier.IndicateFocus = true;
            this.BtnCashier.Location = new System.Drawing.Point(12, 143);
            this.BtnCashier.Name = "BtnCashier";
            this.BtnCashier.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCashier.OnDisabledState.BorderRadius = 5;
            this.BtnCashier.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCashier.OnDisabledState.BorderThickness = 1;
            this.BtnCashier.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCashier.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCashier.OnDisabledState.IconLeftImage = null;
            this.BtnCashier.OnDisabledState.IconRightImage = null;
            this.BtnCashier.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnCashier.onHoverState.BorderRadius = 5;
            this.BtnCashier.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCashier.onHoverState.BorderThickness = 1;
            this.BtnCashier.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.BtnCashier.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnCashier.onHoverState.IconLeftImage = null;
            this.BtnCashier.onHoverState.IconRightImage = null;
            this.BtnCashier.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.BtnCashier.OnIdleState.BorderRadius = 5;
            this.BtnCashier.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCashier.OnIdleState.BorderThickness = 1;
            this.BtnCashier.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnCashier.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnCashier.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BtnCashier.OnIdleState.IconLeftImage")));
            this.BtnCashier.OnIdleState.IconRightImage = null;
            this.BtnCashier.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.BtnCashier.OnPressedState.BorderRadius = 5;
            this.BtnCashier.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCashier.OnPressedState.BorderThickness = 1;
            this.BtnCashier.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.BtnCashier.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnCashier.OnPressedState.IconLeftImage = null;
            this.BtnCashier.OnPressedState.IconRightImage = null;
            this.BtnCashier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCashier.Size = new System.Drawing.Size(178, 55);
            this.BtnCashier.TabIndex = 1;
            this.BtnCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCashier.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCashier.TextMarginLeft = 0;
            this.BtnCashier.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnCashier.UseDefaultRadiusAndThickness = true;
            this.BtnCashier.Click += new System.EventHandler(this.BtnPos_Click);
            // 
            // PicBoxSettings
            // 
            this.PicBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PicBoxSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBoxSettings.BackgroundImage")));
            this.PicBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxSettings.Location = new System.Drawing.Point(3, 653);
            this.PicBoxSettings.Name = "PicBoxSettings";
            this.PicBoxSettings.Size = new System.Drawing.Size(33, 26);
            this.PicBoxSettings.TabIndex = 0;
            this.PicBoxSettings.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.BackgroundImage")));
            this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(178, 80);
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // PnlContent
            // 
            this.PnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlContent.Location = new System.Drawing.Point(203, 0);
            this.PnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1168, 682);
            this.PnlContent.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1370, 681);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlNavigation);
            this.Name = "MainWindow";
            this.Text = "CLC Store Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }


        //this.PnlOrdersPanel.AddOrder(new CartItem(123, "jed", "small", 240));

        //private 
        //private OrdersPanel PnlOrdersPanel;
        //private ProductsPanel PnlProductsPanel;

        #endregion
        private Panel PnlNavigation;
        private PictureBox picBoxLogo;
        private PictureBox PicBoxSettings;
        private Panel PnlContent;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnCashier;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnAnalytics;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnInventory;
    }
}
