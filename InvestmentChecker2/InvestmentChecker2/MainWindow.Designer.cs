
namespace InvestmentChecker2
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
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.comboBoxSelectProfile = new System.Windows.Forms.ComboBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelStocks = new System.Windows.Forms.Panel();
            this.panelCurrencies = new System.Windows.Forms.Panel();
            this.panelColumnns = new System.Windows.Forms.Panel();
            this.btnHeaderQuantity = new System.Windows.Forms.Button();
            this.btnHeaderDateBought = new System.Windows.Forms.Button();
            this.btnHeaderChangePercent = new System.Windows.Forms.Button();
            this.btnHeaderPriceDifference = new System.Windows.Forms.Button();
            this.btnHeaderMarketValueDifference = new System.Windows.Forms.Button();
            this.btnHeaderCurrentMarketValue = new System.Windows.Forms.Button();
            this.btnHeaderCurrentPrice = new System.Windows.Forms.Button();
            this.btnHeaderBuyingMarkeValue = new System.Windows.Forms.Button();
            this.btnHeaderBuyingPrice = new System.Windows.Forms.Button();
            this.btnHeaderName = new System.Windows.Forms.Button();
            this.btnHeaderTicker = new System.Windows.Forms.Button();
            this.panelColumnns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddProfile.FlatAppearance.BorderSize = 0;
            this.btnAddProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAddProfile.Location = new System.Drawing.Point(216, 27);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(36, 37);
            this.btnAddProfile.TabIndex = 0;
            this.btnAddProfile.Text = "+";
            this.btnAddProfile.UseVisualStyleBackColor = false;
            this.btnAddProfile.Click += new System.EventHandler(this.OpenAddProfileWindow);
            // 
            // comboBoxSelectProfile
            // 
            this.comboBoxSelectProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.comboBoxSelectProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSelectProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.comboBoxSelectProfile.FormattingEnabled = true;
            this.comboBoxSelectProfile.Location = new System.Drawing.Point(24, 27);
            this.comboBoxSelectProfile.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSelectProfile.Name = "comboBoxSelectProfile";
            this.comboBoxSelectProfile.Size = new System.Drawing.Size(183, 39);
            this.comboBoxSelectProfile.TabIndex = 1;
            this.comboBoxSelectProfile.SelectedValueChanged += new System.EventHandler(this.onProfileChange);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAddStock.Location = new System.Drawing.Point(281, 24);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(159, 47);
            this.btnAddStock.TabIndex = 2;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.OpenSearchStockWindow);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSettings.Location = new System.Drawing.Point(440, 22);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(159, 47);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.OpenSettingsWindow);
            // 
            // panelStocks
            // 
            this.panelStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelStocks.AutoScroll = true;
            this.panelStocks.Location = new System.Drawing.Point(24, 174);
            this.panelStocks.Name = "panelStocks";
            this.panelStocks.Size = new System.Drawing.Size(1724, 348);
            this.panelStocks.TabIndex = 4;
            // 
            // panelCurrencies
            // 
            this.panelCurrencies.Location = new System.Drawing.Point(1754, 102);
            this.panelCurrencies.Name = "panelCurrencies";
            this.panelCurrencies.Size = new System.Drawing.Size(258, 420);
            this.panelCurrencies.TabIndex = 5;
            // 
            // panelColumnns
            // 
            this.panelColumnns.Controls.Add(this.btnHeaderPriceDifference);
            this.panelColumnns.Controls.Add(this.btnHeaderBuyingMarkeValue);
            this.panelColumnns.Controls.Add(this.btnHeaderQuantity);
            this.panelColumnns.Controls.Add(this.btnHeaderDateBought);
            this.panelColumnns.Controls.Add(this.btnHeaderChangePercent);
            this.panelColumnns.Controls.Add(this.btnHeaderMarketValueDifference);
            this.panelColumnns.Controls.Add(this.btnHeaderCurrentMarketValue);
            this.panelColumnns.Controls.Add(this.btnHeaderCurrentPrice);
            this.panelColumnns.Controls.Add(this.btnHeaderBuyingPrice);
            this.panelColumnns.Controls.Add(this.btnHeaderName);
            this.panelColumnns.Controls.Add(this.btnHeaderTicker);
            this.panelColumnns.Location = new System.Drawing.Point(24, 102);
            this.panelColumnns.Name = "panelColumnns";
            this.panelColumnns.Size = new System.Drawing.Size(1724, 66);
            this.panelColumnns.TabIndex = 6;
            // 
            // btnHeaderQuantity
            // 
            this.btnHeaderQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderQuantity.FlatAppearance.BorderSize = 0;
            this.btnHeaderQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderQuantity.Location = new System.Drawing.Point(302, 3);
            this.btnHeaderQuantity.Name = "btnHeaderQuantity";
            this.btnHeaderQuantity.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderQuantity.TabIndex = 17;
            this.btnHeaderQuantity.Text = "Quantity";
            this.btnHeaderQuantity.UseVisualStyleBackColor = false;
            // 
            // btnHeaderDateBought
            // 
            this.btnHeaderDateBought.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderDateBought.FlatAppearance.BorderSize = 0;
            this.btnHeaderDateBought.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderDateBought.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderDateBought.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderDateBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderDateBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderDateBought.Location = new System.Drawing.Point(1510, 3);
            this.btnHeaderDateBought.Name = "btnHeaderDateBought";
            this.btnHeaderDateBought.Size = new System.Drawing.Size(147, 60);
            this.btnHeaderDateBought.TabIndex = 16;
            this.btnHeaderDateBought.Text = "Date Bought";
            this.btnHeaderDateBought.UseVisualStyleBackColor = false;
            // 
            // btnHeaderChangePercent
            // 
            this.btnHeaderChangePercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderChangePercent.FlatAppearance.BorderSize = 0;
            this.btnHeaderChangePercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderChangePercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderChangePercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderChangePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderChangePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderChangePercent.Location = new System.Drawing.Point(1359, 3);
            this.btnHeaderChangePercent.Name = "btnHeaderChangePercent";
            this.btnHeaderChangePercent.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderChangePercent.TabIndex = 15;
            this.btnHeaderChangePercent.Text = "Change (%)";
            this.btnHeaderChangePercent.UseVisualStyleBackColor = false;
            // 
            // btnHeaderPriceDifference
            // 
            this.btnHeaderPriceDifference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderPriceDifference.FlatAppearance.BorderSize = 0;
            this.btnHeaderPriceDifference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderPriceDifference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderPriceDifference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderPriceDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderPriceDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderPriceDifference.Location = new System.Drawing.Point(755, 3);
            this.btnHeaderPriceDifference.Name = "btnHeaderPriceDifference";
            this.btnHeaderPriceDifference.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderPriceDifference.TabIndex = 14;
            this.btnHeaderPriceDifference.Text = "Price Difference";
            this.btnHeaderPriceDifference.UseVisualStyleBackColor = false;
            // 
            // btnHeaderMarketValueDifference
            // 
            this.btnHeaderMarketValueDifference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderMarketValueDifference.FlatAppearance.BorderSize = 0;
            this.btnHeaderMarketValueDifference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderMarketValueDifference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderMarketValueDifference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderMarketValueDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderMarketValueDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderMarketValueDifference.Location = new System.Drawing.Point(1208, 3);
            this.btnHeaderMarketValueDifference.Name = "btnHeaderMarketValueDifference";
            this.btnHeaderMarketValueDifference.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderMarketValueDifference.TabIndex = 13;
            this.btnHeaderMarketValueDifference.Text = "Market Value Difference";
            this.btnHeaderMarketValueDifference.UseVisualStyleBackColor = false;
            // 
            // btnHeaderCurrentMarketValue
            // 
            this.btnHeaderCurrentMarketValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderCurrentMarketValue.FlatAppearance.BorderSize = 0;
            this.btnHeaderCurrentMarketValue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderCurrentMarketValue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderCurrentMarketValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderCurrentMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderCurrentMarketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderCurrentMarketValue.Location = new System.Drawing.Point(1057, 3);
            this.btnHeaderCurrentMarketValue.Name = "btnHeaderCurrentMarketValue";
            this.btnHeaderCurrentMarketValue.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderCurrentMarketValue.TabIndex = 12;
            this.btnHeaderCurrentMarketValue.Text = "Current market value";
            this.btnHeaderCurrentMarketValue.UseVisualStyleBackColor = false;
            // 
            // btnHeaderCurrentPrice
            // 
            this.btnHeaderCurrentPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderCurrentPrice.FlatAppearance.BorderSize = 0;
            this.btnHeaderCurrentPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderCurrentPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderCurrentPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderCurrentPrice.Location = new System.Drawing.Point(604, 3);
            this.btnHeaderCurrentPrice.Name = "btnHeaderCurrentPrice";
            this.btnHeaderCurrentPrice.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderCurrentPrice.TabIndex = 11;
            this.btnHeaderCurrentPrice.Text = "Current price";
            this.btnHeaderCurrentPrice.UseVisualStyleBackColor = false;
            // 
            // btnHeaderBuyingMarkeValue
            // 
            this.btnHeaderBuyingMarkeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderBuyingMarkeValue.FlatAppearance.BorderSize = 0;
            this.btnHeaderBuyingMarkeValue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderBuyingMarkeValue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderBuyingMarkeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderBuyingMarkeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderBuyingMarkeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderBuyingMarkeValue.Location = new System.Drawing.Point(906, 3);
            this.btnHeaderBuyingMarkeValue.Name = "btnHeaderBuyingMarkeValue";
            this.btnHeaderBuyingMarkeValue.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderBuyingMarkeValue.TabIndex = 10;
            this.btnHeaderBuyingMarkeValue.Text = "Buying market value";
            this.btnHeaderBuyingMarkeValue.UseVisualStyleBackColor = false;
            // 
            // btnHeaderBuyingPrice
            // 
            this.btnHeaderBuyingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderBuyingPrice.FlatAppearance.BorderSize = 0;
            this.btnHeaderBuyingPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderBuyingPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderBuyingPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderBuyingPrice.Location = new System.Drawing.Point(453, 3);
            this.btnHeaderBuyingPrice.Name = "btnHeaderBuyingPrice";
            this.btnHeaderBuyingPrice.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderBuyingPrice.TabIndex = 9;
            this.btnHeaderBuyingPrice.Text = "Buying price";
            this.btnHeaderBuyingPrice.UseVisualStyleBackColor = false;
            // 
            // btnHeaderName
            // 
            this.btnHeaderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderName.FlatAppearance.BorderSize = 0;
            this.btnHeaderName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderName.Location = new System.Drawing.Point(151, 3);
            this.btnHeaderName.Name = "btnHeaderName";
            this.btnHeaderName.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderName.TabIndex = 8;
            this.btnHeaderName.Text = "Name";
            this.btnHeaderName.UseVisualStyleBackColor = false;
            // 
            // btnHeaderTicker
            // 
            this.btnHeaderTicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHeaderTicker.FlatAppearance.BorderSize = 0;
            this.btnHeaderTicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderTicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnHeaderTicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHeaderTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnHeaderTicker.Location = new System.Drawing.Point(0, 3);
            this.btnHeaderTicker.Name = "btnHeaderTicker";
            this.btnHeaderTicker.Size = new System.Drawing.Size(145, 60);
            this.btnHeaderTicker.TabIndex = 7;
            this.btnHeaderTicker.Text = "Ticker";
            this.btnHeaderTicker.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(2024, 548);
            this.Controls.Add(this.panelColumnns);
            this.Controls.Add(this.panelCurrencies);
            this.Controls.Add(this.panelStocks);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.comboBoxSelectProfile);
            this.Controls.Add(this.btnAddProfile);
            this.Name = "MainWindow";
            this.Text = "Investment Checker 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowClose);
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.panelColumnns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.ComboBox comboBoxSelectProfile;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelStocks;
        private System.Windows.Forms.Panel panelCurrencies;
        private System.Windows.Forms.Panel panelColumnns;
        private System.Windows.Forms.Button btnHeaderCurrentMarketValue;
        private System.Windows.Forms.Button btnHeaderCurrentPrice;
        private System.Windows.Forms.Button btnHeaderBuyingMarkeValue;
        private System.Windows.Forms.Button btnHeaderBuyingPrice;
        private System.Windows.Forms.Button btnHeaderName;
        private System.Windows.Forms.Button btnHeaderTicker;
        private System.Windows.Forms.Button btnHeaderPriceDifference;
        private System.Windows.Forms.Button btnHeaderMarketValueDifference;
        private System.Windows.Forms.Button btnHeaderChangePercent;
        private System.Windows.Forms.Button btnHeaderDateBought;
        private System.Windows.Forms.Button btnHeaderQuantity;
    }
}

