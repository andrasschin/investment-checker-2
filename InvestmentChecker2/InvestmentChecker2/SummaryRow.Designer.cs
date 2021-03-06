
namespace InvestmentChecker2
{
    partial class SummaryRow
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
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelInitialCapitalValue = new System.Windows.Forms.Label();
            this.labelCurrentCapitalValue = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelChangePercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrency
            // 
            this.labelCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrency.Location = new System.Drawing.Point(3, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(120, 65);
            this.labelCurrency.TabIndex = 6;
            this.labelCurrency.Text = "currency";
            this.labelCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInitialCapitalValue
            // 
            this.labelInitialCapitalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInitialCapitalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelInitialCapitalValue.Location = new System.Drawing.Point(129, 0);
            this.labelInitialCapitalValue.Name = "labelInitialCapitalValue";
            this.labelInitialCapitalValue.Size = new System.Drawing.Size(155, 65);
            this.labelInitialCapitalValue.TabIndex = 7;
            this.labelInitialCapitalValue.Text = "initialCV";
            this.labelInitialCapitalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentCapitalValue
            // 
            this.labelCurrentCapitalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentCapitalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelCurrentCapitalValue.Location = new System.Drawing.Point(283, 0);
            this.labelCurrentCapitalValue.Name = "labelCurrentCapitalValue";
            this.labelCurrentCapitalValue.Size = new System.Drawing.Size(155, 65);
            this.labelCurrentCapitalValue.TabIndex = 8;
            this.labelCurrentCapitalValue.Text = "currentCV";
            this.labelCurrentCapitalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChange
            // 
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelChange.Location = new System.Drawing.Point(444, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(130, 65);
            this.labelChange.TabIndex = 9;
            this.labelChange.Text = "change";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChangePercent
            // 
            this.labelChangePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChangePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelChangePercent.Location = new System.Drawing.Point(580, 0);
            this.labelChangePercent.Name = "labelChangePercent";
            this.labelChangePercent.Size = new System.Drawing.Size(120, 65);
            this.labelChangePercent.TabIndex = 10;
            this.labelChangePercent.Text = "change%";
            this.labelChangePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // summaryRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.labelChangePercent);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelCurrentCapitalValue);
            this.Controls.Add(this.labelInitialCapitalValue);
            this.Controls.Add(this.labelCurrency);
            this.Name = "summaryRow";
            this.Size = new System.Drawing.Size(700, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelInitialCapitalValue;
        private System.Windows.Forms.Label labelCurrentCapitalValue;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelChangePercent;
    }
}
