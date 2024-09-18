namespace Agencia_de_Viajes.Reporte
{
    partial class frm_reporte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.destinosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds1 = new Agencia_de_Viajes.Reporte.Ds1();
            this.destinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinosTableAdapter = new Agencia_de_Viajes.Reporte.Ds1TableAdapters.DestinosTableAdapter();
            this.ds1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds2 = new Agencia_de_Viajes.Reporte.Ds2();
            this.destinosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.destinosTableAdapter1 = new Agencia_de_Viajes.Reporte.Ds2TableAdapters.DestinosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.destinosBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Agencia_de_Viajes.Reporte.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // destinosBindingSource1
            // 
            this.destinosBindingSource1.DataMember = "Destinos";
            this.destinosBindingSource1.DataSource = this.ds1;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "Ds1";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinosBindingSource
            // 
            this.destinosBindingSource.DataMember = "Destinos";
            this.destinosBindingSource.DataSource = this.ds1;
            // 
            // destinosTableAdapter
            // 
            this.destinosTableAdapter.ClearBeforeFill = true;
            // 
            // ds1BindingSource
            // 
            this.ds1BindingSource.DataSource = this.ds1;
            this.ds1BindingSource.Position = 0;
            // 
            // ds2
            // 
            this.ds2.DataSetName = "Ds2";
            this.ds2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinosBindingSource2
            // 
            this.destinosBindingSource2.DataMember = "Destinos";
            this.destinosBindingSource2.DataSource = this.ds2;
            // 
            // destinosTableAdapter1
            // 
            this.destinosTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_reporte";
            this.Text = "frm_reporte";
            this.Load += new System.EventHandler(this.frm_reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Ds1 ds1;
        private System.Windows.Forms.BindingSource destinosBindingSource;
        private Ds1TableAdapters.DestinosTableAdapter destinosTableAdapter;
        private System.Windows.Forms.BindingSource ds1BindingSource;
        private System.Windows.Forms.BindingSource destinosBindingSource1;
        private Ds2 ds2;
        private System.Windows.Forms.BindingSource destinosBindingSource2;
        private Ds2TableAdapters.DestinosTableAdapter destinosTableAdapter1;
    }
}