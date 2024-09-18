namespace Agencia_de_Viajes.Views.Turistas
{
    partial class frm_Turistas
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_IDViaje = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_viajes = new System.Windows.Forms.ComboBox();
            this.lst_turistas = new System.Windows.Forms.ListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(67, 78);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(181, 29);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre Turista";
            // 
            // lbl_IDViaje
            // 
            this.lbl_IDViaje.AutoSize = true;
            this.lbl_IDViaje.Location = new System.Drawing.Point(67, 190);
            this.lbl_IDViaje.Name = "lbl_IDViaje";
            this.lbl_IDViaje.Size = new System.Drawing.Size(96, 29);
            this.lbl_IDViaje.TabIndex = 1;
            this.lbl_IDViaje.Text = "ID Viaje";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(72, 127);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(277, 34);
            this.txt_nombre.TabIndex = 2;
            // 
            // cmb_viajes
            // 
            this.cmb_viajes.FormattingEnabled = true;
            this.cmb_viajes.Location = new System.Drawing.Point(72, 242);
            this.cmb_viajes.Name = "cmb_viajes";
            this.cmb_viajes.Size = new System.Drawing.Size(277, 37);
            this.cmb_viajes.TabIndex = 3;
            // 
            // lst_turistas
            // 
            this.lst_turistas.FormattingEnabled = true;
            this.lst_turistas.ItemHeight = 29;
            this.lst_turistas.Location = new System.Drawing.Point(403, 78);
            this.lst_turistas.Name = "lst_turistas";
            this.lst_turistas.Size = new System.Drawing.Size(552, 236);
            this.lst_turistas.TabIndex = 4;
            this.lst_turistas.SelectedIndexChanged += new System.EventHandler(this.lst_turistas_SelectedIndexChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(72, 354);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(151, 76);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(242, 354);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(151, 76);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(424, 354);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(151, 76);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(605, 354);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 76);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_Turistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 480);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lst_turistas);
            this.Controls.Add(this.cmb_viajes);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_IDViaje);
            this.Controls.Add(this.lbl_nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_Turistas";
            this.Text = "frm_Turistas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_IDViaje;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cmb_viajes;
        private System.Windows.Forms.ListBox lst_turistas;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}