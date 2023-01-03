
namespace WindowsFormsApp4
{
    partial class Form1
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
            this.age_label = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(55, 51);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(26, 13);
            this.age_label.TabIndex = 0;
            this.age_label.Text = "Age";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(87, 48);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(59, 20);
            this.tb_age.TabIndex = 1;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(71, 85);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 2;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 161);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.age_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_enter;
    }
}

