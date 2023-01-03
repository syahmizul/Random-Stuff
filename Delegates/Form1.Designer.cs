
namespace Delegates
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delegateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lambdaExpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builtInDelegatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourVetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practiceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delegateToolStripMenuItem,
            this.lambdaExpressionToolStripMenuItem,
            this.builtInDelegatesToolStripMenuItem});
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.practiceToolStripMenuItem.Text = "Practice";
            // 
            // delegateToolStripMenuItem
            // 
            this.delegateToolStripMenuItem.Name = "delegateToolStripMenuItem";
            this.delegateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delegateToolStripMenuItem.Text = "Delegate";
            this.delegateToolStripMenuItem.Click += new System.EventHandler(this.delegateToolStripMenuItem_Click);
            // 
            // lambdaExpressionToolStripMenuItem
            // 
            this.lambdaExpressionToolStripMenuItem.Name = "lambdaExpressionToolStripMenuItem";
            this.lambdaExpressionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lambdaExpressionToolStripMenuItem.Text = "Lambda Expression";
            this.lambdaExpressionToolStripMenuItem.Click += new System.EventHandler(this.lambdaExpressionToolStripMenuItem_Click);
            // 
            // builtInDelegatesToolStripMenuItem
            // 
            this.builtInDelegatesToolStripMenuItem.Name = "builtInDelegatesToolStripMenuItem";
            this.builtInDelegatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.builtInDelegatesToolStripMenuItem.Text = "Built-In Delegates";
            this.builtInDelegatesToolStripMenuItem.Click += new System.EventHandler(this.builtInDelegatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ourVetsToolStripMenuItem,
            this.ourLocationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ourVetsToolStripMenuItem
            // 
            this.ourVetsToolStripMenuItem.Name = "ourVetsToolStripMenuItem";
            this.ourVetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ourVetsToolStripMenuItem.Text = "Our Vets";
            this.ourVetsToolStripMenuItem.Click += new System.EventHandler(this.ourVetsToolStripMenuItem_Click);
            // 
            // ourLocationToolStripMenuItem
            // 
            this.ourLocationToolStripMenuItem.Name = "ourLocationToolStripMenuItem";
            this.ourLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ourLocationToolStripMenuItem.Text = "Our Location";
            this.ourLocationToolStripMenuItem.Click += new System.EventHandler(this.ourLocationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 441);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delegateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lambdaExpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builtInDelegatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourVetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourLocationToolStripMenuItem;
    }
}

