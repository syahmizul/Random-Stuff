﻿
namespace LINQToSQL
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cookiesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cookiesOrderToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cookiesOrderToolStripMenuItem
            // 
            this.cookiesOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderInformationToolStripMenuItem,
            this.orderFormToolStripMenuItem});
            this.cookiesOrderToolStripMenuItem.Name = "cookiesOrderToolStripMenuItem";
            this.cookiesOrderToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.cookiesOrderToolStripMenuItem.Text = "Cookies Order";
            // 
            // orderInformationToolStripMenuItem
            // 
            this.orderInformationToolStripMenuItem.Name = "orderInformationToolStripMenuItem";
            this.orderInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderInformationToolStripMenuItem.Text = "Order Information";
            this.orderInformationToolStripMenuItem.Click += new System.EventHandler(this.orderInformationToolStripMenuItem_Click);
            // 
            // orderFormToolStripMenuItem
            // 
            this.orderFormToolStripMenuItem.Name = "orderFormToolStripMenuItem";
            this.orderFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderFormToolStripMenuItem.Text = "Order Form";
            this.orderFormToolStripMenuItem.Click += new System.EventHandler(this.orderFormToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cookiesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}