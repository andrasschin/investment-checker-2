
namespace InvestmentChecker2
{
    partial class StockRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelBuyingPrice = new System.Windows.Forms.Label();
            this.labelBuyingMarketValue = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.labelPriceDifference = new System.Windows.Forms.Label();
            this.labelCurrentMarketValue = new System.Windows.Forms.Label();
            this.labelMarketValueDifference = new System.Windows.Forms.Label();
            this.labelChangePercent = new System.Windows.Forms.Label();
            this.labelDateBought = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemove.Location = new System.Drawing.Point(1680, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.RemoveStock);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnDetails.Location = new System.Drawing.Point(1642, 15);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(32, 30);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "D";
            this.btnDetails.UseVisualStyleBackColor = false;
            // 
            // labelTicker
            // 
            this.labelTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelTicker.Location = new System.Drawing.Point(-3, 0);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(100, 60);
            this.labelTicker.TabIndex = 4;
            this.labelTicker.Text = "label1";
            this.labelTicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelName.Location = new System.Drawing.Point(103, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 60);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "label2";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelQuantity.Location = new System.Drawing.Point(301, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(102, 60);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "label3";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuyingPrice
            // 
            this.labelBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelBuyingPrice.Location = new System.Drawing.Point(409, 0);
            this.labelBuyingPrice.Name = "labelBuyingPrice";
            this.labelBuyingPrice.Size = new System.Drawing.Size(120, 60);
            this.labelBuyingPrice.TabIndex = 7;
            this.labelBuyingPrice.Text = "label4";
            this.labelBuyingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBuyingMarketValue
            // 
            this.labelBuyingMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuyingMarketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelBuyingMarketValue.Location = new System.Drawing.Point(787, 0);
            this.labelBuyingMarketValue.Name = "labelBuyingMarketValue";
            this.labelBuyingMarketValue.Size = new System.Drawing.Size(145, 60);
            this.labelBuyingMarketValue.TabIndex = 8;
            this.labelBuyingMarketValue.Text = "label5";
            this.labelBuyingMarketValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrentPrice.Location = new System.Drawing.Point(535, 0);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(120, 60);
            this.labelCurrentPrice.TabIndex = 9;
            this.labelCurrentPrice.Text = "label6";
            this.labelCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPriceDifference
            // 
            this.labelPriceDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelPriceDifference.Location = new System.Drawing.Point(661, 0);
            this.labelPriceDifference.Name = "labelPriceDifference";
            this.labelPriceDifference.Size = new System.Drawing.Size(120, 60);
            this.labelPriceDifference.TabIndex = 10;
            this.labelPriceDifference.Text = "label7";
            this.labelPriceDifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentMarketValue
            // 
            this.labelCurrentMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentMarketValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrentMarketValue.Location = new System.Drawing.Point(938, 0);
            this.labelCurrentMarketValue.Name = "labelCurrentMarketValue";
            this.labelCurrentMarketValue.Size = new System.Drawing.Size(145, 60);
            this.labelCurrentMarketValue.TabIndex = 11;
            this.labelCurrentMarketValue.Text = "label8";
            this.labelCurrentMarketValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMarketValueDifference
            // 
            this.labelMarketValueDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarketValueDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelMarketValueDifference.Location = new System.Drawing.Point(1089, 0);
            this.labelMarketValueDifference.Name = "labelMarketValueDifference";
            this.labelMarketValueDifference.Size = new System.Drawing.Size(120, 60);
            this.labelMarketValueDifference.TabIndex = 12;
            this.labelMarketValueDifference.Text = "label9";
            this.labelMarketValueDifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChangePercent
            // 
            this.labelChangePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChangePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelChangePercent.Location = new System.Drawing.Point(1215, 0);
            this.labelChangePercent.Name = "labelChangePercent";
            this.labelChangePercent.Size = new System.Drawing.Size(120, 60);
            this.labelChangePercent.TabIndex = 13;
            this.labelChangePercent.Text = "label10";
            this.labelChangePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateBought
            // 
            this.labelDateBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelDateBought.Location = new System.Drawing.Point(1467, 0);
            this.labelDateBought.Name = "labelDateBought";
            this.labelDateBought.Size = new System.Drawing.Size(140, 60);
            this.labelDateBought.TabIndex = 14;
            this.labelDateBought.Text = "label11";
            this.labelDateBought.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrency
            // 
            this.labelCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrency.Location = new System.Drawing.Point(1341, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(120, 60);
            this.labelCurrency.TabIndex = 15;
            this.labelCurrency.Text = "label10";
            this.labelCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelDateBought);
            this.Controls.Add(this.labelChangePercent);
            this.Controls.Add(this.labelMarketValueDifference);
            this.Controls.Add(this.labelCurrentMarketValue);
            this.Controls.Add(this.labelPriceDifference);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.labelBuyingMarketValue);
            this.Controls.Add(this.labelBuyingPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTicker);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnRemove);
            this.Name = "StockRow";
            this.Size = new System.Drawing.Size(1734, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBuyingPrice;
        private System.Windows.Forms.Label labelBuyingMarketValue;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Label labelPriceDifference;
        private System.Windows.Forms.Label labelCurrentMarketValue;
        private System.Windows.Forms.Label labelMarketValueDifference;
        private System.Windows.Forms.Label labelChangePercent;
        private System.Windows.Forms.Label labelDateBought;
        private System.Windows.Forms.Label labelCurrency;
    }
}
