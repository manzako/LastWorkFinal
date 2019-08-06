namespace LastWorkBD
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LASTWORKBDDataSet = new LastWorkBD.LASTWORKBDDataSet();
            this.PARTICIPANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PARTICIPANTTableAdapter = new LastWorkBD.LASTWORKBDDataSetTableAdapters.PARTICIPANTTableAdapter();
            this.PLAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PLAGETableAdapter = new LastWorkBD.LASTWORKBDDataSetTableAdapters.PLAGETableAdapter();
            this.EDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EDITIONTableAdapter = new LastWorkBD.LASTWORKBDDataSetTableAdapters.EDITIONTableAdapter();
            this.CDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CDTableAdapter = new LastWorkBD.LASTWORKBDDataSetTableAdapters.CDTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LASTWORKBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARTICIPANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAGEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(163, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(363, 43);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(133, 44);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "Quitter";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(143, 44);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(133, 43);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Retour";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PARTICIPANTBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.PLAGEBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.EDITIONBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.CDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LastWorkBD.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 242);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(903, 246);
            this.reportViewer1.TabIndex = 1;
            // 
            // LASTWORKBDDataSet
            // 
            this.LASTWORKBDDataSet.DataSetName = "LASTWORKBDDataSet";
            this.LASTWORKBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PARTICIPANTBindingSource
            // 
            this.PARTICIPANTBindingSource.DataMember = "PARTICIPANT";
            this.PARTICIPANTBindingSource.DataSource = this.LASTWORKBDDataSet;
            // 
            // PARTICIPANTTableAdapter
            // 
            this.PARTICIPANTTableAdapter.ClearBeforeFill = true;
            // 
            // PLAGEBindingSource
            // 
            this.PLAGEBindingSource.DataMember = "PLAGE";
            this.PLAGEBindingSource.DataSource = this.LASTWORKBDDataSet;
            // 
            // PLAGETableAdapter
            // 
            this.PLAGETableAdapter.ClearBeforeFill = true;
            // 
            // EDITIONBindingSource
            // 
            this.EDITIONBindingSource.DataMember = "EDITION";
            this.EDITIONBindingSource.DataSource = this.LASTWORKBDDataSet;
            // 
            // EDITIONTableAdapter
            // 
            this.EDITIONTableAdapter.ClearBeforeFill = true;
            // 
            // CDBindingSource
            // 
            this.CDBindingSource.DataMember = "CD";
            this.CDBindingSource.DataSource = this.LASTWORKBDDataSet;
            // 
            // CDTableAdapter
            // 
            this.CDTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 509);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LASTWORKBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARTICIPANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAGEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PARTICIPANTBindingSource;
        private LASTWORKBDDataSet LASTWORKBDDataSet;
        private System.Windows.Forms.BindingSource PLAGEBindingSource;
        private System.Windows.Forms.BindingSource EDITIONBindingSource;
        private System.Windows.Forms.BindingSource CDBindingSource;
        private LASTWORKBDDataSetTableAdapters.PARTICIPANTTableAdapter PARTICIPANTTableAdapter;
        private LASTWORKBDDataSetTableAdapters.PLAGETableAdapter PLAGETableAdapter;
        private LASTWORKBDDataSetTableAdapters.EDITIONTableAdapter EDITIONTableAdapter;
        private LASTWORKBDDataSetTableAdapters.CDTableAdapter CDTableAdapter;
    }
}