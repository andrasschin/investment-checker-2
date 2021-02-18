
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
            this.textInputProfileName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelFoundTicker = new System.Windows.Forms.Label();
            this.labelFoundName = new System.Windows.Forms.Label();
            this.labelFoundCurrentPrice = new System.Windows.Forms.Label();
            this.btnOpenAddStockWindow = new System.Windows.Forms.Button();
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
            // textInputProfileName
            // 
            this.textInputProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInputProfileName.ForeColor = System.Drawing.Color.Black;
            this.textInputProfileName.Location = new System.Drawing.Point(138, 22);
            this.textInputProfileName.Name = "textInputProfileName";
            this.textInputProfileName.Size = new System.Drawing.Size(223, 32);
            this.textInputProfileName.TabIndex = 2;
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
            // 
            // labelFoundTicker
            // 
            this.labelFoundTicker.AutoSize = true;
            this.labelFoundTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundTicker.Location = new System.Drawing.Point(147, 93);
            this.labelFoundTicker.Name = "labelFoundTicker";
            this.labelFoundTicker.Size = new System.Drawing.Size(97, 31);
            this.labelFoundTicker.TabIndex = 12;
            this.labelFoundTicker.Text = "Ticker:";
            // 
            // labelFoundName
            // 
            this.labelFoundName.AutoSize = true;
            this.labelFoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundName.Location = new System.Drawing.Point(147, 141);
            this.labelFoundName.Name = "labelFoundName";
            this.labelFoundName.Size = new System.Drawing.Size(94, 31);
            this.labelFoundName.TabIndex = 13;
            this.labelFoundName.Text = "Name:";
            // 
            // labelFoundCurrentPrice
            // 
            this.labelFoundCurrentPrice.AutoSize = true;
            this.labelFoundCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundCurrentPrice.Location = new System.Drawing.Point(59, 189);
            this.labelFoundCurrentPrice.Name = "labelFoundCurrentPrice";
            this.labelFoundCurrentPrice.Size = new System.Drawing.Size(182, 31);
            this.labelFoundCurrentPrice.TabIndex = 14;
            this.labelFoundCurrentPrice.Text = "Current Price:";
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
            this.btnOpenAddStockWindow.Location = new System.Drawing.Point(164, 240);
            this.btnOpenAddStockWindow.Name = "btnOpenAddStockWindow";
            this.btnOpenAddStockWindow.Size = new System.Drawing.Size(150, 50);
            this.btnOpenAddStockWindow.TabIndex = 15;
            this.btnOpenAddStockWindow.Text = "Add Stock";
            this.btnOpenAddStockWindow.UseVisualStyleBackColor = false;
            this.btnOpenAddStockWindow.Click += new System.EventHandler(this.OpenAddStockWindow);
            // 
            // SearchStockWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(502, 300);
            this.Controls.Add(this.btnOpenAddStockWindow);
            this.Controls.Add(this.labelFoundCurrentPrice);
            this.Controls.Add(this.labelFoundName);
            this.Controls.Add(this.labelFoundTicker);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textInputProfileName);
            this.Controls.Add(this.labelSearchTicker);
            this.Name = "SearchStockWindow";
            this.Text = "Search Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchTicker;
        private System.Windows.Forms.TextBox textInputProfileName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelFoundTicker;
        private System.Windows.Forms.Label labelFoundName;
        private System.Windows.Forms.Label labelFoundCurrentPrice;
        private System.Windows.Forms.Button btnOpenAddStockWindow;
    }
}