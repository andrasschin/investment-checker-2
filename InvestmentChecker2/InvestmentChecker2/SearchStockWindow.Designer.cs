
namespace InvestmentChecker2
{
    partial class SearchStockWindow
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
            this.labelSearchTicker = new System.Windows.Forms.Label();
            this.textInputTicker = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.btnOpenAddStockWindow = new System.Windows.Forms.Button();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelSearchedTicker = new System.Windows.Forms.Label();
            this.labelFoundName = new System.Windows.Forms.Label();
            this.labelFoundCurrentPrice = new System.Windows.Forms.Label();
            this.labelFoundCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSearchTicker
            // 
            this.labelSearchTicker.AutoSize = true;
            this.labelSearchTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelSearchTicker.Location = new System.Drawing.Point(35, 23);
            this.labelSearchTicker.Name = "labelSearchTicker";
            this.labelSearchTicker.Size = new System.Drawing.Size(97, 31);
            this.labelSearchTicker.TabIndex = 1;
            this.labelSearchTicker.Text = "Ticker:";
            // 
            // textInputTicker
            // 
            this.textInputTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInputTicker.ForeColor = System.Drawing.Color.Black;
            this.textInputTicker.Location = new System.Drawing.Point(138, 22);
            this.textInputTicker.Name = "textInputTicker";
            this.textInputTicker.Size = new System.Drawing.Size(223, 32);
            this.textInputTicker.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSearch.Location = new System.Drawing.Point(367, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 37);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.SearchStock);
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelTicker.Location = new System.Drawing.Point(124, 93);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(97, 31);
            this.labelTicker.TabIndex = 12;
            this.labelTicker.Text = "Ticker:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelName.Location = new System.Drawing.Point(124, 140);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 31);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name:";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrentPrice.Location = new System.Drawing.Point(36, 187);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(182, 31);
            this.labelCurrentPrice.TabIndex = 14;
            this.labelCurrentPrice.Text = "Current Price:";
            // 
            // btnOpenAddStockWindow
            // 
            this.btnOpenAddStockWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOpenAddStockWindow.FlatAppearance.BorderSize = 0;
            this.btnOpenAddStockWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnOpenAddStockWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnOpenAddStockWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAddStockWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenAddStockWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnOpenAddStockWindow.Location = new System.Drawing.Point(163, 302);
            this.btnOpenAddStockWindow.Name = "btnOpenAddStockWindow";
            this.btnOpenAddStockWindow.Size = new System.Drawing.Size(150, 50);
            this.btnOpenAddStockWindow.TabIndex = 15;
            this.btnOpenAddStockWindow.Text = "Add Stock";
            this.btnOpenAddStockWindow.UseVisualStyleBackColor = false;
            this.btnOpenAddStockWindow.Click += new System.EventHandler(this.OpenAddStockWindow);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrency.Location = new System.Drawing.Point(85, 233);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(133, 31);
            this.labelCurrency.TabIndex = 16;
            this.labelCurrency.Text = "Currency:";
            // 
            // labelSearchedTicker
            // 
            this.labelSearchedTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSearchedTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelSearchedTicker.Location = new System.Drawing.Point(227, 93);
            this.labelSearchedTicker.Name = "labelSearchedTicker";
            this.labelSearchedTicker.Size = new System.Drawing.Size(219, 31);
            this.labelSearchedTicker.TabIndex = 17;
            this.labelSearchedTicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFoundName
            // 
            this.labelFoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundName.Location = new System.Drawing.Point(227, 140);
            this.labelFoundName.Name = "labelFoundName";
            this.labelFoundName.Size = new System.Drawing.Size(219, 31);
            this.labelFoundName.TabIndex = 18;
            this.labelFoundName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFoundCurrentPrice
            // 
            this.labelFoundCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundCurrentPrice.Location = new System.Drawing.Point(227, 187);
            this.labelFoundCurrentPrice.Name = "labelFoundCurrentPrice";
            this.labelFoundCurrentPrice.Size = new System.Drawing.Size(219, 31);
            this.labelFoundCurrentPrice.TabIndex = 19;
            this.labelFoundCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFoundCurrency
            // 
            this.labelFoundCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundCurrency.Location = new System.Drawing.Point(227, 233);
            this.labelFoundCurrency.Name = "labelFoundCurrency";
            this.labelFoundCurrency.Size = new System.Drawing.Size(219, 31);
            this.labelFoundCurrency.TabIndex = 20;
            this.labelFoundCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchStockWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(502, 364);
            this.Controls.Add(this.labelFoundCurrency);
            this.Controls.Add(this.labelFoundCurrentPrice);
            this.Controls.Add(this.labelFoundName);
            this.Controls.Add(this.labelSearchedTicker);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.btnOpenAddStockWindow);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTicker);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textInputTicker);
            this.Controls.Add(this.labelSearchTicker);
            this.Name = "SearchStockWindow";
            this.Text = "Search Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchTicker;
        private System.Windows.Forms.TextBox textInputTicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.Button btnOpenAddStockWindow;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelSearchedTicker;
        private System.Windows.Forms.Label labelFoundName;
        private System.Windows.Forms.Label labelFoundCurrentPrice;
        private System.Windows.Forms.Label labelFoundCurrency;
    }
}