namespace Agencia_de_Viajes.Views.Viajes
{
    partial class frm_Viajes
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
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmb_destinos = new System.Windows.Forms.ComboBox();
            this.lbl_IDDestino = new System.Windows.Forms.Label();
            this.cmb_guias = new System.Windows.Forms.ComboBox();
            this.lbl_IDGuia = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lst_viajes = new System.Windows.Forms.ListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_actualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(72, 421);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(289, 34);
            this.dtp_fecha.TabIndex = 0;
            // 
            // cmb_destinos
            // 
            this.cmb_destinos.FormattingEnabled = true;
            this.cmb_destinos.Location = new System.Drawing.Point(72, 182);
            this.cmb_destinos.Name = "cmb_destinos";
            this.cmb_destinos.Size = new System.Drawing.Size(289, 37);
            this.cmb_destinos.TabIndex = 4;
            // 
            // lbl_IDDestino
            // 
            this.lbl_IDDestino.AutoSize = true;
            this.lbl_IDDestino.Location = new System.Drawing.Point(67, 121);
            this.lbl_IDDestino.Name = "lbl_IDDestino";
            this.lbl_IDDestino.Size = new System.Drawing.Size(124, 29);
            this.lbl_IDDestino.TabIndex = 3;
            this.lbl_IDDestino.Text = "ID Destino";
            // 
            // cmb_guias
            // 
            this.cmb_guias.FormattingEnabled = true;
            this.cmb_guias.Location = new System.Drawing.Point(72, 302);
            this.cmb_guias.Name = "cmb_guias";
            this.cmb_guias.Size = new System.Drawing.Size(289, 37);
            this.cmb_guias.TabIndex = 6;
            // 
            // lbl_IDGuia
            // 
            this.lbl_IDGuia.AutoSize = true;
            this.lbl_IDGuia.Location = new System.Drawing.Point(67, 241);
            this.lbl_IDGuia.Name = "lbl_IDGuia";
            this.lbl_IDGuia.Size = new System.Drawing.Size(92, 29);
            this.lbl_IDGuia.TabIndex = 5;
            this.lbl_IDGuia.Text = "ID Guia";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(67, 365);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(80, 29);
            this.lbl_Fecha.TabIndex = 7;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lst_viajes
            // 
            this.lst_viajes.FormattingEnabled = true;
            this.lst_viajes.ItemHeight = 29;
            this.lst_viajes.Location = new System.Drawing.Point(449, 78);
            this.lst_viajes.Name = "lst_viajes";
            this.lst_viajes.Size = new System.Drawing.Size(574, 468);
            this.lst_viajes.TabIndex = 8;
            this.lst_viajes.SelectedIndexChanged += new System.EventHandler(this.lst_viajes_SelectedIndexChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(68, 570);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(128, 58);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(229, 570);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(128, 58);
            this.btn_actualizar.TabIndex = 10;
            this.btn_actualizar.Text = "Cancelar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(390, 570);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(128, 58);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(547, 570);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 58);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_actualiza
            // 
            this.btn_actualiza.Location = new System.Drawing.Point(700, 570);
            this.btn_actualiza.Name = "btn_actualiza";
            this.btn_actualiza.Size = new System.Drawing.Size(128, 58);
            this.btn_actualiza.TabIndex = 13;
            this.btn_actualiza.Text = "Actualizar";
            this.btn_actualiza.UseVisualStyleBackColor = true;
            this.btn_actualiza.Click += new System.EventHandler(this.btn_actualiza_Click);
            // 
            // frm_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 671);
            this.Controls.Add(this.btn_actualiza);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lst_viajes);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.cmb_guias);
            this.Controls.Add(this.lbl_IDGuia);
            this.Controls.Add(this.cmb_destinos);
            this.Controls.Add(this.lbl_IDDestino);
            this.Controls.Add(this.dtp_fecha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Viajes";
            this.Text = "frm_Viajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cmb_destinos;
        private System.Windows.Forms.Label lbl_IDDestino;
        private System.Windows.Forms.ComboBox cmb_guias;
        private System.Windows.Forms.Label lbl_IDGuia;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.ListBox lst_viajes;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_actualiza;
    }
}