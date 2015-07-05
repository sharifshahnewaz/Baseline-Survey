namespace ReportsApplication1
{
    partial class Report
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
            this.button_Show = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox_Thana = new System.Windows.Forms.ComboBox();
            this.comboBox_report = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataSet2 = new ReportsApplication1.DataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(497, 12);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(75, 23);
            this.button_Show.TabIndex = 1;
            this.button_Show.Text = "Show";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1016, 675);
            this.reportViewer1.TabIndex = 3;
            // 
            // comboBox_Thana
            // 
            this.comboBox_Thana.FormattingEnabled = true;
            this.comboBox_Thana.Location = new System.Drawing.Point(104, 12);
            this.comboBox_Thana.Name = "comboBox_Thana";
            this.comboBox_Thana.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Thana.TabIndex = 4;
            this.comboBox_Thana.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_report
            // 
            this.comboBox_report.FormattingEnabled = true;
            this.comboBox_report.Items.AddRange(new object[] {
            "Report 1A",
            "Report 1",
            "Report 2",
            "Report 3",
            "Report 4",
            "Report 5",
            "Report 6",
            "Report 7",
            "Report 8",
            "Report 9",
            "Report 10",
            "Report 11",
            "Report 11A",
            "Report 11B",
            "Report 12",
            "Report 13",
            "Report 13A",
            "Report 13B",
            "Report 14",
            "Report 14B",
            "Report 14C",
            "Report 15",
            "Report 16",
            "Report 17",
            "Report 18",
            "Report 18A",
            "Report 18B",
            "Report 18C",
            "Report 18D",
            "Report 19",
            "Report 20",
            "Report 21",
            "Report 22"});
            this.comboBox_report.Location = new System.Drawing.Point(328, 12);
            this.comboBox_report.Name = "comboBox_report";
            this.comboBox_report.Size = new System.Drawing.Size(121, 21);
            this.comboBox_report.TabIndex = 5;
            this.comboBox_report.SelectedIndexChanged += new System.EventHandler(this.comboBox_report_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Report";
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 716);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_report);
            this.Controls.Add(this.comboBox_Thana);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_Show);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Show;
        private DataSet2 DataSet2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox_Thana;
        private System.Windows.Forms.ComboBox comboBox_report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}