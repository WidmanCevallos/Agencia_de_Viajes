namespace Agencia_de_Viajes.Views.Destino
{
    partial class frm_Destinos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lst_destinos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "País";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(88, 168);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(292, 34);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(88, 275);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(292, 34);
            this.txt_pais.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(120, 390);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(137, 69);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(275, 390);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(137, 69);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lst_destinos
            // 
            this.lst_destinos.FormattingEnabled = true;
            this.lst_destinos.ItemHeight = 29;
            this.lst_destinos.Location = new System.Drawing.Point(421, 90);
            this.lst_destinos.Name = "lst_destinos";
            this.lst_destinos.Size = new System.Drawing.Size(597, 294);
            this.lst_destinos.TabIndex = 6;
            this.lst_destinos.SelectedIndexChanged += new System.EventHandler(this.lst_destinos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listas Destinos";
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(431, 390);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(137, 69);
            this.btn_reporte.TabIndex = 8;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // frm_Destinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 504);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_destinos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Destinos";
            this.Text = "frm_Destinos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ListBox lst_destinos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reporte;
    }
}