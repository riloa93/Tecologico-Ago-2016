namespace P1_U2_BaseConocimiento
{
    partial class FrmAgregarBase
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
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefinicion = new System.Windows.Forms.TextBox();
            this.lstBDC = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkbEstatico = new System.Windows.Forms.CheckBox();
            this.chkbAuto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabra.Location = new System.Drawing.Point(107, 12);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(203, 25);
            this.txtPalabra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Palabra:";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Definición:";
            // 
            // txtDefinicion
            // 
            this.txtDefinicion.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinicion.Location = new System.Drawing.Point(107, 50);
            this.txtDefinicion.Name = "txtDefinicion";
            this.txtDefinicion.Size = new System.Drawing.Size(203, 25);
            this.txtDefinicion.TabIndex = 2;
            // 
            // lstBDC
            // 
            this.lstBDC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstBDC.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBDC.FormattingEnabled = true;
            this.lstBDC.ItemHeight = 18;
            this.lstBDC.Location = new System.Drawing.Point(0, 177);
            this.lstBDC.Name = "lstBDC";
            this.lstBDC.Size = new System.Drawing.Size(324, 238);
            this.lstBDC.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(16, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 33);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(176, 125);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 33);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkbEstatico
            // 
            this.chkbEstatico.AutoSize = true;
            this.chkbEstatico.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbEstatico.Location = new System.Drawing.Point(25, 89);
            this.chkbEstatico.Name = "chkbEstatico";
            this.chkbEstatico.Size = new System.Drawing.Size(107, 22);
            this.chkbEstatico.TabIndex = 7;
            this.chkbEstatico.Text = "Estático";
            this.chkbEstatico.UseVisualStyleBackColor = true;
            this.chkbEstatico.Click += new System.EventHandler(this.chkbEstatico_Click);
            // 
            // chkbAuto
            // 
            this.chkbAuto.AutoSize = true;
            this.chkbAuto.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbAuto.Location = new System.Drawing.Point(168, 89);
            this.chkbAuto.Name = "chkbAuto";
            this.chkbAuto.Size = new System.Drawing.Size(127, 22);
            this.chkbAuto.TabIndex = 8;
            this.chkbAuto.Text = "Automático";
            this.chkbAuto.UseVisualStyleBackColor = true;
            this.chkbAuto.Click += new System.EventHandler(this.chkbAuto_Click);
            // 
            // FrmAgregarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 415);
            this.Controls.Add(this.chkbAuto);
            this.Controls.Add(this.chkbEstatico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstBDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDefinicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalabra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definición de elementos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefinicion;
        private System.Windows.Forms.ListBox lstBDC;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkbEstatico;
        private System.Windows.Forms.CheckBox chkbAuto;
    }
}