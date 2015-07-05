namespace ReportsApplication1
{
    partial class Form2
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
            this.DataSet2 = new ReportsApplication1.DataSet2();
            this.UnionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new ReportsApplication1.DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Table7TableAdapter = new ReportsApplication1.DataSet2TableAdapters.Table7TableAdapter();
            this.Table8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Table8TableAdapter = new ReportsApplication1.DataSet2TableAdapters.Table8TableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new ReportsApplication1.DataSet2TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Table7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Table7BindingSource
            // 
            this.Table7BindingSource.DataMember = "Table7";
            this.Table7BindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UnionBindingSource
            // 
            this.UnionBindingSource.DataMember = "Union";
            this.UnionBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2_DataTable1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Table4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(62, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 327);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Table7TableAdapter
            // 
            this.Table7TableAdapter.ClearBeforeFill = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 381);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UnionBindingSource;
        private DataSet DataSet;
        private System.Windows.Forms.BindingSource Table7BindingSource;
        private DataSet2 DataSet2;
        private ReportsApplication1.DataSet2TableAdapters.Table7TableAdapter Table7TableAdapter;
        private System.Windows.Forms.BindingSource Table8BindingSource;
        private ReportsApplication1.DataSet2TableAdapters.Table8TableAdapter Table8TableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ReportsApplication1.DataSet2TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;

    }
}