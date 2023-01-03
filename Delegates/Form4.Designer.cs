
namespace Delegates
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.medLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.consLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.grandTotal = new System.Windows.Forms.Label();
            this.pricelabel1 = new System.Windows.Forms.Label();
            this.pricelabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pricelabel1);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.consLabel);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.medLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(60, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charge(RM)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // medLabel
            // 
            this.medLabel.AutoSize = true;
            this.medLabel.Location = new System.Drawing.Point(22, 34);
            this.medLabel.Name = "medLabel";
            this.medLabel.Size = new System.Drawing.Size(59, 13);
            this.medLabel.TabIndex = 1;
            this.medLabel.Text = "Medication";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // consLabel
            // 
            this.consLabel.AutoSize = true;
            this.consLabel.Location = new System.Drawing.Point(22, 57);
            this.consLabel.Name = "consLabel";
            this.consLabel.Size = new System.Drawing.Size(65, 13);
            this.consLabel.TabIndex = 3;
            this.consLabel.Text = "Consultation";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(22, 86);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 4;
            this.total.Text = "Total";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(225, 163);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // grandTotal
            // 
            this.grandTotal.AutoSize = true;
            this.grandTotal.Location = new System.Drawing.Point(67, 199);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(63, 13);
            this.grandTotal.TabIndex = 2;
            this.grandTotal.Text = "Grand Total";
            // 
            // pricelabel1
            // 
            this.pricelabel1.AutoSize = true;
            this.pricelabel1.Location = new System.Drawing.Point(59, 86);
            this.pricelabel1.Name = "pricelabel1";
            this.pricelabel1.Size = new System.Drawing.Size(24, 13);
            this.pricelabel1.TabIndex = 5;
            this.pricelabel1.Text = "RM";
            // 
            // pricelabel2
            // 
            this.pricelabel2.AutoSize = true;
            this.pricelabel2.Location = new System.Drawing.Point(137, 199);
            this.pricelabel2.Name = "pricelabel2";
            this.pricelabel2.Size = new System.Drawing.Size(24, 13);
            this.pricelabel2.TabIndex = 3;
            this.pricelabel2.Text = "RM";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this.pricelabel2);
            this.Controls.Add(this.grandTotal);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pricelabel1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label consLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label medLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label grandTotal;
        private System.Windows.Forms.Label pricelabel2;
    }
}