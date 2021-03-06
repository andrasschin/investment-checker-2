
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
            this.panelCurrencyExhanges = new System.Windows.Forms.Panel();
            this.panelStockColumns = new System.Windows.Forms.Panel();
            this.btnSHeaderCurrency = new System.Windows.Forms.Button();
            this.btnSHeaderPriceDifference = new System.Windows.Forms.Button();
            this.btnSHeaderBuyingMarkeValue = new System.Windows.Forms.Button();
            this.btnSHeaderQuantity = new System.Windows.Forms.Button();
            this.btnSHeaderDateBought = new System.Windows.Forms.Button();
            this.btnSHeaderChangePercent = new System.Windows.Forms.Button();
            this.btnSHeaderMarketValueDifference = new System.Windows.Forms.Button();
            this.btnSHeaderCurrentMarketValue = new System.Windows.Forms.Button();
            this.btnSHeaderCurrentPrice = new System.Windows.Forms.Button();
            this.btnSHeaderBuyingPrice = new System.Windows.Forms.Button();
            this.btnSHeaderName = new System.Windows.Forms.Button();
            this.btnSHeaderTicker = new System.Windows.Forms.Button();
            this.panelCurrencyExchangeColumns = new System.Windows.Forms.Panel();
            this.btnCEHeaderCurrencyTo = new System.Windows.Forms.Button();
            this.btnCEHeaderBuyingMarketValue = new System.Windows.Forms.Button();
            this.btnCEHeaderQuantity = new System.Windows.Forms.Button();
            this.btnCEHeaderDateBought = new System.Windows.Forms.Button();
            this.btnCEHeaderBuyingPrice = new System.Windows.Forms.Button();
            this.buttonCEHeaderCurrencyFrom = new System.Windows.Forms.Button();
            this.buttonAddCurrency = new System.Windows.Forms.Button();
            this.btnProfileSummary = new System.Windows.Forms.Button();
            this.panelStockColumns.SuspendLayout();
            this.panelCurrencyExchangeColumns.SuspendLayout();
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
            this.btnSettings.Location = new System.Drawing.Point(1621, 24);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(143, 47);
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
            this.panelStocks.Size = new System.Drawing.Size(1740, 424);
            this.panelStocks.TabIndex = 4;
            // 
            // panelCurrencyExhanges
            // 
            this.panelCurrencyExhanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrencyExhanges.AutoScroll = true;
            this.panelCurrencyExhanges.Location = new System.Drawing.Point(24, 700);
            this.panelCurrencyExhanges.Name = "panelCurrencyExhanges";
            this.panelCurrencyExhanges.Size = new System.Drawing.Size(920, 173);
            this.panelCurrencyExhanges.TabIndex = 5;
            // 
            // panelStockColumns
            // 
            this.panelStockColumns.Controls.Add(this.btnSHeaderCurrency);
            this.panelStockColumns.Controls.Add(this.btnSHeaderPriceDifference);
            this.panelStockColumns.Controls.Add(this.btnSHeaderBuyingMarkeValue);
            this.panelStockColumns.Controls.Add(this.btnSHeaderQuantity);
            this.panelStockColumns.Controls.Add(this.btnSHeaderDateBought);
            this.panelStockColumns.Controls.Add(this.btnSHeaderChangePercent);
            this.panelStockColumns.Controls.Add(this.btnSHeaderMarketValueDifference);
            this.panelStockColumns.Controls.Add(this.btnSHeaderCurrentMarketValue);
            this.panelStockColumns.Controls.Add(this.btnSHeaderCurrentPrice);
            this.panelStockColumns.Controls.Add(this.btnSHeaderBuyingPrice);
            this.panelStockColumns.Controls.Add(this.btnSHeaderName);
            this.panelStockColumns.Controls.Add(this.btnSHeaderTicker);
            this.panelStockColumns.Location = new System.Drawing.Point(24, 102);
            this.panelStockColumns.Name = "panelStockColumns";
            this.panelStockColumns.Size = new System.Drawing.Size(1740, 66);
            this.panelStockColumns.TabIndex = 6;
            // 
            // btnSHeaderCurrency
            // 
            this.btnSHeaderCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderCurrency.FlatAppearance.BorderSize = 0;
            this.btnSHeaderCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderCurrency.Location = new System.Drawing.Point(1345, 3);
            this.btnSHeaderCurrency.Name = "btnSHeaderCurrency";
            this.btnSHeaderCurrency.Size = new System.Drawing.Size(120, 60);
            this.btnSHeaderCurrency.TabIndex = 18;
            this.btnSHeaderCurrency.Text = "Currency";
            this.btnSHeaderCurrency.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderPriceDifference
            // 
            this.btnSHeaderPriceDifference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderPriceDifference.FlatAppearance.BorderSize = 0;
            this.btnSHeaderPriceDifference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderPriceDifference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderPriceDifference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderPriceDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderPriceDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderPriceDifference.Location = new System.Drawing.Point(665, 3);
            this.btnSHeaderPriceDifference.Name = "btnSHeaderPriceDifference";
            this.btnSHeaderPriceDifference.Size = new System.Drawing.Size(120, 60);
            this.btnSHeaderPriceDifference.TabIndex = 14;
            this.btnSHeaderPriceDifference.Text = "Price Difference";
            this.btnSHeaderPriceDifference.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderBuyingMarkeValue
            // 
            this.btnSHeaderBuyingMarkeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderBuyingMarkeValue.FlatAppearance.BorderSize = 0;
            this.btnSHeaderBuyingMarkeValue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderBuyingMarkeValue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderBuyingMarkeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderBuyingMarkeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderBuyingMarkeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderBuyingMarkeValue.Location = new System.Drawing.Point(791, 3);
            this.btnSHeaderBuyingMarkeValue.Name = "btnSHeaderBuyingMarkeValue";
            this.btnSHeaderBuyingMarkeValue.Size = new System.Drawing.Size(145, 60);
            this.btnSHeaderBuyingMarkeValue.TabIndex = 10;
            this.btnSHeaderBuyingMarkeValue.Text = "Buying market value";
            this.btnSHeaderBuyingMarkeValue.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderQuantity
            // 
            this.btnSHeaderQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderQuantity.FlatAppearance.BorderSize = 0;
            this.btnSHeaderQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderQuantity.Location = new System.Drawing.Point(305, 3);
            this.btnSHeaderQuantity.Name = "btnSHeaderQuantity";
            this.btnSHeaderQuantity.Size = new System.Drawing.Size(102, 60);
            this.btnSHeaderQuantity.TabIndex = 17;
            this.btnSHeaderQuantity.Text = "Quantity";
            this.btnSHeaderQuantity.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderDateBought
            // 
            this.btnSHeaderDateBought.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderDateBought.FlatAppearance.BorderSize = 0;
            this.btnSHeaderDateBought.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderDateBought.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderDateBought.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderDateBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderDateBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderDateBought.Location = new System.Drawing.Point(1471, 3);
            this.btnSHeaderDateBought.Name = "btnSHeaderDateBought";
            this.btnSHeaderDateBought.Size = new System.Drawing.Size(125, 60);
            this.btnSHeaderDateBought.TabIndex = 16;
            this.btnSHeaderDateBought.Text = "Date Bought";
            this.btnSHeaderDateBought.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderChangePercent
            // 
            this.btnSHeaderChangePercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderChangePercent.FlatAppearance.BorderSize = 0;
            this.btnSHeaderChangePercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderChangePercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderChangePercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderChangePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderChangePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderChangePercent.Location = new System.Drawing.Point(1219, 3);
            this.btnSHeaderChangePercent.Name = "btnSHeaderChangePercent";
            this.btnSHeaderChangePercent.Size = new System.Drawing.Size(120, 60);
            this.btnSHeaderChangePercent.TabIndex = 15;
            this.btnSHeaderChangePercent.Text = "Change (%)";
            this.btnSHeaderChangePercent.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderMarketValueDifference
            // 
            this.btnSHeaderMarketValueDifference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderMarketValueDifference.FlatAppearance.BorderSize = 0;
            this.btnSHeaderMarketValueDifference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderMarketValueDifference.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderMarketValueDifference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderMarketValueDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderMarketValueDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderMarketValueDifference.Location = new System.Drawing.Point(1093, 3);
            this.btnSHeaderMarketValueDifference.Name = "btnSHeaderMarketValueDifference";
            this.btnSHeaderMarketValueDifference.Size = new System.Drawing.Size(120, 60);
            this.btnSHeaderMarketValueDifference.TabIndex = 13;
            this.btnSHeaderMarketValueDifference.Text = "M. V. Difference";
            this.btnSHeaderMarketValueDifference.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderCurrentMarketValue
            // 
            this.btnSHeaderCurrentMarketValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderCurrentMarketValue.FlatAppearance.BorderSize = 0;
            this.btnSHeaderCurrentMarketValue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderCurrentMarketValue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderCurrentMarketValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderCurrentMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderCurrentMarketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderCurrentMarketValue.Location = new System.Drawing.Point(942, 3);
            this.btnSHeaderCurrentMarketValue.Name = "btnSHeaderCurrentMarketValue";
            this.btnSHeaderCurrentMarketValue.Size = new System.Drawing.Size(145, 60);
            this.btnSHeaderCurrentMarketValue.TabIndex = 12;
            this.btnSHeaderCurrentMarketValue.Text = "Current market value";
            this.btnSHeaderCurrentMarketValue.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderCurrentPrice
            // 
            this.btnSHeaderCurrentPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderCurrentPrice.FlatAppearance.BorderSize = 0;
            this.btnSHeaderCurrentPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderCurrentPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderCurrentPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderCurrentPrice.Location = new System.Drawing.Point(539, 3);
            this.btnSHeaderCurrentPrice.Name = "btnSHeaderCurrentPrice";
            this.btnSHeaderCurrentPrice.Size = new System.Drawing.Size(120, 60);
            this.btnSHeaderCurrentPrice.TabIndex = 11;
            this.btnSHeaderCurrentPrice.Text = "Current price";
            this.btnSHeaderCurrentPrice.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderBuyingPrice
            // 
            this.btnSHeaderBuyingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderBuyingPrice.FlatAppearance.BorderSize = 0;
            this.btnSHeaderBuyingPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderBuyingPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderBuyingPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderBuyingPrice.Location = new System.Drawing.Point(413, 3);
            this.btnSHeaderBuyingPrice.Name = "btnSHeaderBuyingPrice";
            this.btnSHeaderBuyingPrice.Size = new System.Drawing.Size(120, 60);
            this.btnSHeaderBuyingPrice.TabIndex = 9;
            this.btnSHeaderBuyingPrice.Text = "Buying price";
            this.btnSHeaderBuyingPrice.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderName
            // 
            this.btnSHeaderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderName.FlatAppearance.BorderSize = 0;
            this.btnSHeaderName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderName.Location = new System.Drawing.Point(107, 3);
            this.btnSHeaderName.Name = "btnSHeaderName";
            this.btnSHeaderName.Size = new System.Drawing.Size(192, 60);
            this.btnSHeaderName.TabIndex = 8;
            this.btnSHeaderName.Text = "Name";
            this.btnSHeaderName.UseVisualStyleBackColor = false;
            // 
            // btnSHeaderTicker
            // 
            this.btnSHeaderTicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSHeaderTicker.FlatAppearance.BorderSize = 0;
            this.btnSHeaderTicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderTicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSHeaderTicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHeaderTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSHeaderTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSHeaderTicker.Location = new System.Drawing.Point(1, 3);
            this.btnSHeaderTicker.Name = "btnSHeaderTicker";
            this.btnSHeaderTicker.Size = new System.Drawing.Size(100, 60);
            this.btnSHeaderTicker.TabIndex = 7;
            this.btnSHeaderTicker.Text = "Ticker";
            this.btnSHeaderTicker.UseVisualStyleBackColor = false;
            // 
            // panelCurrencyExchangeColumns
            // 
            this.panelCurrencyExchangeColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrencyExchangeColumns.Controls.Add(this.btnCEHeaderCurrencyTo);
            this.panelCurrencyExchangeColumns.Controls.Add(this.btnCEHeaderBuyingMarketValue);
            this.panelCurrencyExchangeColumns.Controls.Add(this.btnCEHeaderQuantity);
            this.panelCurrencyExchangeColumns.Controls.Add(this.btnCEHeaderDateBought);
            this.panelCurrencyExchangeColumns.Controls.Add(this.btnCEHeaderBuyingPrice);
            this.panelCurrencyExchangeColumns.Controls.Add(this.buttonCEHeaderCurrencyFrom);
            this.panelCurrencyExchangeColumns.Location = new System.Drawing.Point(24, 628);
            this.panelCurrencyExchangeColumns.Name = "panelCurrencyExchangeColumns";
            this.panelCurrencyExchangeColumns.Size = new System.Drawing.Size(920, 66);
            this.panelCurrencyExchangeColumns.TabIndex = 7;
            // 
            // btnCEHeaderCurrencyTo
            // 
            this.btnCEHeaderCurrencyTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCEHeaderCurrencyTo.FlatAppearance.BorderSize = 0;
            this.btnCEHeaderCurrencyTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderCurrencyTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderCurrencyTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEHeaderCurrencyTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCEHeaderCurrencyTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCEHeaderCurrencyTo.Location = new System.Drawing.Point(129, 3);
            this.btnCEHeaderCurrencyTo.Name = "btnCEHeaderCurrencyTo";
            this.btnCEHeaderCurrencyTo.Size = new System.Drawing.Size(120, 60);
            this.btnCEHeaderCurrencyTo.TabIndex = 19;
            this.btnCEHeaderCurrencyTo.Text = "Currency to";
            this.btnCEHeaderCurrencyTo.UseVisualStyleBackColor = false;
            // 
            // btnCEHeaderBuyingMarketValue
            // 
            this.btnCEHeaderBuyingMarketValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCEHeaderBuyingMarketValue.FlatAppearance.BorderSize = 0;
            this.btnCEHeaderBuyingMarketValue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderBuyingMarketValue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderBuyingMarketValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEHeaderBuyingMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCEHeaderBuyingMarketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCEHeaderBuyingMarketValue.Location = new System.Drawing.Point(507, 3);
            this.btnCEHeaderBuyingMarketValue.Name = "btnCEHeaderBuyingMarketValue";
            this.btnCEHeaderBuyingMarketValue.Size = new System.Drawing.Size(145, 60);
            this.btnCEHeaderBuyingMarketValue.TabIndex = 10;
            this.btnCEHeaderBuyingMarketValue.Text = "Buying market value";
            this.btnCEHeaderBuyingMarketValue.UseVisualStyleBackColor = false;
            // 
            // btnCEHeaderQuantity
            // 
            this.btnCEHeaderQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCEHeaderQuantity.FlatAppearance.BorderSize = 0;
            this.btnCEHeaderQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEHeaderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCEHeaderQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCEHeaderQuantity.Location = new System.Drawing.Point(381, 3);
            this.btnCEHeaderQuantity.Name = "btnCEHeaderQuantity";
            this.btnCEHeaderQuantity.Size = new System.Drawing.Size(120, 60);
            this.btnCEHeaderQuantity.TabIndex = 17;
            this.btnCEHeaderQuantity.Text = "Buying Price";
            this.btnCEHeaderQuantity.UseVisualStyleBackColor = false;
            // 
            // btnCEHeaderDateBought
            // 
            this.btnCEHeaderDateBought.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCEHeaderDateBought.FlatAppearance.BorderSize = 0;
            this.btnCEHeaderDateBought.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderDateBought.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderDateBought.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEHeaderDateBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCEHeaderDateBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCEHeaderDateBought.Location = new System.Drawing.Point(658, 3);
            this.btnCEHeaderDateBought.Name = "btnCEHeaderDateBought";
            this.btnCEHeaderDateBought.Size = new System.Drawing.Size(172, 60);
            this.btnCEHeaderDateBought.TabIndex = 16;
            this.btnCEHeaderDateBought.Text = "Date Bought";
            this.btnCEHeaderDateBought.UseVisualStyleBackColor = false;
            // 
            // btnCEHeaderBuyingPrice
            // 
            this.btnCEHeaderBuyingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCEHeaderBuyingPrice.FlatAppearance.BorderSize = 0;
            this.btnCEHeaderBuyingPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderBuyingPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCEHeaderBuyingPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEHeaderBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCEHeaderBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnCEHeaderBuyingPrice.Location = new System.Drawing.Point(255, 3);
            this.btnCEHeaderBuyingPrice.Name = "btnCEHeaderBuyingPrice";
            this.btnCEHeaderBuyingPrice.Size = new System.Drawing.Size(120, 60);
            this.btnCEHeaderBuyingPrice.TabIndex = 9;
            this.btnCEHeaderBuyingPrice.Text = "Quantity";
            this.btnCEHeaderBuyingPrice.UseVisualStyleBackColor = false;
            // 
            // buttonCEHeaderCurrencyFrom
            // 
            this.buttonCEHeaderCurrencyFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonCEHeaderCurrencyFrom.FlatAppearance.BorderSize = 0;
            this.buttonCEHeaderCurrencyFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonCEHeaderCurrencyFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonCEHeaderCurrencyFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCEHeaderCurrencyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCEHeaderCurrencyFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.buttonCEHeaderCurrencyFrom.Location = new System.Drawing.Point(3, 3);
            this.buttonCEHeaderCurrencyFrom.Name = "buttonCEHeaderCurrencyFrom";
            this.buttonCEHeaderCurrencyFrom.Size = new System.Drawing.Size(120, 60);
            this.buttonCEHeaderCurrencyFrom.TabIndex = 8;
            this.buttonCEHeaderCurrencyFrom.Text = "Currency from";
            this.buttonCEHeaderCurrencyFrom.UseVisualStyleBackColor = false;
            // 
            // buttonAddCurrency
            // 
            this.buttonAddCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAddCurrency.FlatAppearance.BorderSize = 0;
            this.buttonAddCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonAddCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonAddCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.buttonAddCurrency.Location = new System.Drawing.Point(446, 14);
            this.buttonAddCurrency.Name = "buttonAddCurrency";
            this.buttonAddCurrency.Size = new System.Drawing.Size(181, 67);
            this.buttonAddCurrency.TabIndex = 8;
            this.buttonAddCurrency.Text = "Add Currency Exchange";
            this.buttonAddCurrency.UseVisualStyleBackColor = false;
            this.buttonAddCurrency.Click += new System.EventHandler(this.OpenAddCurrencyExchangeWindow);
            // 
            // btnProfileSummary
            // 
            this.btnProfileSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnProfileSummary.FlatAppearance.BorderSize = 0;
            this.btnProfileSummary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnProfileSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnProfileSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfileSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnProfileSummary.Location = new System.Drawing.Point(633, 14);
            this.btnProfileSummary.Name = "btnProfileSummary";
            this.btnProfileSummary.Size = new System.Drawing.Size(159, 67);
            this.btnProfileSummary.TabIndex = 9;
            this.btnProfileSummary.Text = "Profile Summary";
            this.btnProfileSummary.UseVisualStyleBackColor = false;
            this.btnProfileSummary.Click += new System.EventHandler(this.OpenProfileSummaryWindow);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1786, 922);
            this.Controls.Add(this.btnProfileSummary);
            this.Controls.Add(this.buttonAddCurrency);
            this.Controls.Add(this.panelCurrencyExchangeColumns);
            this.Controls.Add(this.panelCurrencyExhanges);
            this.Controls.Add(this.panelStockColumns);
            this.Controls.Add(this.panelStocks);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.comboBoxSelectProfile);
            this.Controls.Add(this.btnAddProfile);
            this.Name = "MainWindow";
            this.Text = "Investment Checker 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowClose);
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.panelStockColumns.ResumeLayout(false);
            this.panelCurrencyExchangeColumns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.ComboBox comboBoxSelectProfile;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelStocks;
        private System.Windows.Forms.Panel panelCurrencyExhanges;
        private System.Windows.Forms.Panel panelStockColumns;
        private System.Windows.Forms.Button btnSHeaderCurrentMarketValue;
        private System.Windows.Forms.Button btnSHeaderCurrentPrice;
        private System.Windows.Forms.Button btnSHeaderBuyingMarkeValue;
        private System.Windows.Forms.Button btnSHeaderBuyingPrice;
        private System.Windows.Forms.Button btnSHeaderName;
        private System.Windows.Forms.Button btnSHeaderTicker;
        private System.Windows.Forms.Button btnSHeaderPriceDifference;
        private System.Windows.Forms.Button btnSHeaderMarketValueDifference;
        private System.Windows.Forms.Button btnSHeaderChangePercent;
        private System.Windows.Forms.Button btnSHeaderDateBought;
        private System.Windows.Forms.Button btnSHeaderQuantity;
        private System.Windows.Forms.Button btnSHeaderCurrency;
        private System.Windows.Forms.Panel panelCurrencyExchangeColumns;
        private System.Windows.Forms.Button btnCEHeaderBuyingMarketValue;
        private System.Windows.Forms.Button btnCEHeaderQuantity;
        private System.Windows.Forms.Button btnCEHeaderDateBought;
        private System.Windows.Forms.Button btnCEHeaderBuyingPrice;
        private System.Windows.Forms.Button buttonCEHeaderCurrencyFrom;
        private System.Windows.Forms.Button buttonAddCurrency;
        private System.Windows.Forms.Button btnCEHeaderCurrencyTo;
        private System.Windows.Forms.Button btnProfileSummary;
    }
}

