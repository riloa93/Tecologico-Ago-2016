namespace P1_U2_BaseConocimiento
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
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRealizarPregunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(115, 12);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(156, 25);
            this.txtPregunta.TabIndex = 0;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(29, 15);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(80, 17);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Pregunta:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(20, 90);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(93, 22);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.Visible = false;
            // 
            // btnRealizarPregunta
            // 
            this.btnRealizarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPregunta.Location = new System.Drawing.Point(106, 48);
            this.btnRealizarPregunta.Name = "btnRealizarPregunta";
            this.btnRealizarPregunta.Size = new System.Drawing.Size(91, 32);
            this.btnRealizarPregunta.TabIndex = 3;
            this.btnRealizarPregunta.Text = "Preguntar";
            this.btnRealizarPregunta.UseVisualStyleBackColor = true;
            this.btnRealizarPregunta.Click += new System.EventHandler(this.btnRealizarPregunta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(302, 122);
            this.Controls.Add(this.btnRealizarPregunta);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.txtPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Conocimiento: BJJ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRealizarPregunta;
    }
}

