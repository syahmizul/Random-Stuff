
namespace LINQToSQL
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cookiesDataSet = new LINQToSQL.CookiesDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new LINQToSQL.CookiesDataSetTableAdapters.CustomerTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQty = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.labelMinQty = new System.Windows.Forms.Label();
            this.textBoxMinQty = new System.Windows.Forms.TextBox();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.labelCustID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new LINQToSQL.CookiesDataSetTableAdapters.OrderTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sort Customer Details By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // cookiesDataSet
            // 
            this.cookiesDataSet.DataSetName = "CookiesDataSet";
            this.cookiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.cookiesDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxCustID);
            this.groupBox1.Controls.Add(this.labelCustID);
            this.groupBox1.Controls.Add(this.textBoxMinQty);
            this.groupBox1.Controls.Add(this.labelMinQty);
            this.groupBox1.Controls.Add(this.radioButtonID);
            this.groupBox1.Controls.Add(this.radioButtonQty);
            this.groupBox1.Location = new System.Drawing.Point(15, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Orders";
            // 
            // radioButtonQty
            // 
            this.radioButtonQty.AutoSize = true;
            this.radioButtonQty.Location = new System.Drawing.Point(40, 30);
            this.radioButtonQty.Name = "radioButtonQty";
            this.radioButtonQty.Size = new System.Drawing.Size(123, 17);
            this.radioButtonQty.TabIndex = 0;
            this.radioButtonQty.TabStop = true;
            this.radioButtonQty.Text = "By Minimum Quantity";
            this.radioButtonQty.UseVisualStyleBackColor = true;
            this.radioButtonQty.CheckedChanged += new System.EventHandler(this.radioButtonQty_CheckedChanged);
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(212, 30);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(98, 17);
            this.radioButtonID.TabIndex = 1;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "By Customer ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            this.radioButtonID.CheckedChanged += new System.EventHandler(this.radioButtonID_CheckedChanged);
            // 
            // labelMinQty
            // 
            this.labelMinQty.AutoSize = true;
            this.labelMinQty.Location = new System.Drawing.Point(37, 63);
            this.labelMinQty.Name = "labelMinQty";
            this.labelMinQty.Size = new System.Drawing.Size(90, 13);
            this.labelMinQty.TabIndex = 2;
            this.labelMinQty.Text = "Minimum Quantity";
            // 
            // textBoxMinQty
            // 
            this.textBoxMinQty.Location = new System.Drawing.Point(133, 60);
            this.textBoxMinQty.Name = "textBoxMinQty";
            this.textBoxMinQty.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinQty.TabIndex = 3;
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Location = new System.Drawing.Point(133, 86);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustID.TabIndex = 5;
            // 
            // labelCustID
            // 
            this.labelCustID.AutoSize = true;
            this.labelCustID.Location = new System.Drawing.Point(37, 89);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(65, 13);
            this.labelCustID.TabIndex = 4;
            this.labelCustID.Text = "Customer ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(283, 111);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 441);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(445, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.cookiesDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Order Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cookies Order Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CookiesDataSet cookiesDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CookiesDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Label labelCustID;
        private System.Windows.Forms.TextBox textBoxMinQty;
        private System.Windows.Forms.Label labelMinQty;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonQty;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private CookiesDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Label label5;
    }
}

