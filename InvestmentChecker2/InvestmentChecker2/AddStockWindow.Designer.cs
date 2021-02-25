
namespace InvestmentChecker2
{
    partial class AddStockWindow
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
            this.labelFoundTicker = new System.Windows.Forms.Label();
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelBuyingPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDateBought = new System.Windows.Forms.Label();
            this.textInputBuyingPrice = new System.Windows.Forms.TextBox();
            this.textInputQuantity = new System.Windows.Forms.TextBox();
            this.textInputDateBought = new System.Windows.Forms.TextBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.textInputName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFoundTicker
            // 
            this.labelFoundTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoundTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelFoundTicker.Location = new System.Drawing.Point(240, 56);
            this.labelFoundTicker.Name = "labelFoundTicker";
            this.labelFoundTicker.Size = new System.Drawing.Size(223, 32);
            this.labelFoundTicker.TabIndex = 2;
            this.labelFoundTicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelTicker.Location = new System.Drawing.Point(137, 56);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(97, 31);
            this.labelTicker.TabIndex = 3;
            this.labelTicker.Text = "Ticker:";
            // 
            // labelBuyingPrice
            // 
            this.labelBuyingPrice.AutoSize = true;
            this.labelBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelBuyingPrice.Location = new System.Drawing.Point(60, 152);
            this.labelBuyingPrice.Name = "labelBuyingPrice";
            this.labelBuyingPrice.Size = new System.Drawing.Size(174, 31);
            this.labelBuyingPrice.TabIndex = 4;
            this.labelBuyingPrice.Text = "Buying Price:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelQuantity.Location = new System.Drawing.Point(110, 200);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(124, 31);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelDateBought
            // 
            this.labelDateBought.AutoSize = true;
            this.labelDateBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelDateBought.Location = new System.Drawing.Point(61, 248);
            this.labelDateBought.Name = "labelDateBought";
            this.labelDateBought.Size = new System.Drawing.Size(173, 31);
            this.labelDateBought.TabIndex = 6;
            this.labelDateBought.Text = "Date Bought:";
            // 
            // textInputBuyingPrice
            // 
            this.textInputBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInputBuyingPrice.ForeColor = System.Drawing.Color.Black;
            this.textInputBuyingPrice.Location = new System.Drawing.Point(240, 153);
            this.textInputBuyingPrice.Name = "textInputBuyingPrice";
            this.textInputBuyingPrice.Size = new System.Drawing.Size(223, 32);
            this.textInputBuyingPrice.TabIndex = 8;
            // 
            // textInputQuantity
            // 
            this.textInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInputQuantity.ForeColor = System.Drawing.Color.Black;
            this.textInputQuantity.Location = new System.Drawing.Point(240, 202);
            this.textInputQuantity.Name = "textInputQuantity";
            this.textInputQuantity.Size = new System.Drawing.Size(223, 32);
            this.textInputQuantity.TabIndex = 9;
            // 
            // textInputDateBought
            // 
            this.textInputDateBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInputDateBought.ForeColor = System.Drawing.Color.Black;
            this.textInputDateBought.Location = new System.Drawing.Point(240, 251);
            this.textInputDateBought.Name = "textInputDateBought";
            this.textInputDateBought.Size = new System.Drawing.Size(223, 32);
            this.textInputDateBought.TabIndex = 10;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAddStock.Location = new System.Drawing.Point(165, 333);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(150, 50);
            this.btnAddStock.TabIndex = 16;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.AddStock);
            // 
            // textInputName
            // 
            this.textInputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInputName.ForeColor = System.Drawing.Color.Black;
            this.textInputName.Location = new System.Drawing.Point(240, 104);
            this.textInputName.Name = "textInputName";
            this.textInputName.Size = new System.Drawing.Size(223, 32);
            this.textInputName.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelName.Location = new System.Drawing.Point(140, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 31);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name:";
            // 
            // AddStockWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(511, 395);
            this.Controls.Add(this.textInputName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.textInputDateBought);
            this.Controls.Add(this.textInputQuantity);
            this.Controls.Add(this.textInputBuyingPrice);
            this.Controls.Add(this.labelDateBought);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelBuyingPrice);
            this.Controls.Add(this.labelTicker);
            this.Controls.Add(this.labelFoundTicker);
            this.Name = "AddStockWindow";
            this.Text = "Add Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFoundTicker;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelBuyingPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDateBought;
        private System.Windows.Forms.TextBox textInputBuyingPrice;
        private System.Windows.Forms.TextBox textInputQuantity;
        private System.Windows.Forms.TextBox textInputDateBought;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox textInputName;
        private System.Windows.Forms.Label labelName;
    }
}