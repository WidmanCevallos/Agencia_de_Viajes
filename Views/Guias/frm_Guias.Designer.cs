namespace Agencia_de_Viajes.Views.Guias
{
    partial class frm_Guias
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
            this.lst_guias = new System.Windows.Forms.ListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres de los Guias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(105, 150);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(284, 34);
            this.txt_nombre.TabIndex = 2;
            // 
            // lst_guias
            // 
            this.lst_guias.FormattingEnabled = true;
            this.lst_guias.ItemHeight = 29;
            this.lst_guias.Location = new System.Drawing.Point(92, 277);
            this.lst_guias.Name = "lst_guias";
            this.lst_guias.Size = new System.Drawing.Size(562, 265);
            this.lst_guias.TabIndex = 3;
            this.lst_guias.SelectedIndexChanged += new System.EventHandler(this.lst_guias_SelectedIndexChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(92, 206);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(136, 65);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(234, 206);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(136, 65);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(376, 206);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(136, 65);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(518, 206);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(136, 65);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_Guias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 550);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lst_guias);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Guias";
            this.Text = "frm_Guias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ListBox lst_guias;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}