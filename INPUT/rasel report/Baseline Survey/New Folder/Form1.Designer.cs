namespace ReportsApplication1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Table7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Table6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Table6TableAdapter = new ReportsApplication1.DataSet2TableAdapters.Table6TableAdapter();
            this.Table7TableAdapter = new ReportsApplication1.DataSet2TableAdapters.Table7TableAdapter();
            this.DataSet2 = new ReportsApplication1.DataSet2();
            this.Table8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Table8TableAdapter = new ReportsApplication1.DataSet2TableAdapters.Table8TableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new ReportsApplication1.DataSet2TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Table7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Table1"});
            this.comboBox1.Location = new System.Drawing.Point(160, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet2_DataTable1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 493);
            this.reportViewer1.TabIndex = 2;
            // 
            // Table6TableAdapter
            // 
            this.Table6TableAdapter.ClearBeforeFill = true;
            // 
            // Table7TableAdapter
            // 
            this.Table7TableAdapter.ClearBeforeFill = true;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Table8BindingSource
            // 
            this.Table8BindingSource.DataMember = "Table8";
            this.Table8BindingSource.DataSource = this.DataSet2;
            // 
            // Table8TableAdapter
            // 
            this.Table8TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet2;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Table6BindingSource;
        private ReportsApplication1.DataSet2TableAdapters.Table6TableAdapter Table6TableAdapter;
        private System.Windows.Forms.BindingSource Table7BindingSource;
        private ReportsApplication1.DataSet2TableAdapters.Table7TableAdapter Table7TableAdapter;
        private System.Windows.Forms.BindingSource Table8BindingSource;
        private DataSet2 DataSet2;
        private ReportsApplication1.DataSet2TableAdapters.Table8TableAdapter Table8TableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ReportsApplication1.DataSet2TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;

    }
}

