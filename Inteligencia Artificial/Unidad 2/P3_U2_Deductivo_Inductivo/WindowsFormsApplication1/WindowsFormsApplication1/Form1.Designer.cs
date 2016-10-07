namespace WindowsFormsApplication1
{
    partial class frmPal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPal));
            this.btnConclusion = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblPMay = new System.Windows.Forms.Label();
            this.lblPm = new System.Windows.Forms.Label();
            this.txtInicioPMay = new System.Windows.Forms.TextBox();
            this.txtInicioPremMen = new System.Windows.Forms.TextBox();
            this.txtSP2 = new System.Windows.Forms.TextBox();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.txt2daMay = new System.Windows.Forms.TextBox();
            this.txt3raMay = new System.Windows.Forms.TextBox();
            this.txtPredMay = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrem2daMen = new System.Windows.Forms.TextBox();
            this.txtPredMen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Deductivo = new System.Windows.Forms.Panel();
            this.panel_Inductivo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPredP3 = new System.Windows.Forms.TextBox();
            this.txtPredP1 = new System.Windows.Forms.TextBox();
            this.txtPredP2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEsP3 = new System.Windows.Forms.TextBox();
            this.txtEsP1 = new System.Windows.Forms.TextBox();
            this.txtEsP2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSP3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSP1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Deductivo.SuspendLayout();
            this.panel_Inductivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConclusion
            // 
            this.btnConclusion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConclusion.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConclusion.Location = new System.Drawing.Point(0, 567);
            this.btnConclusion.Name = "btnConclusion";
            this.btnConclusion.Size = new System.Drawing.Size(719, 53);
            this.btnConclusion.TabIndex = 0;
            this.btnConclusion.Text = "Conclusión";
            this.btnConclusion.UseVisualStyleBackColor = true;
            this.btnConclusion.Click += new System.EventHandler(this.btnConclusion_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(195, 164);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(45, 18);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Deductivo",
            "Inductivo"});
            this.cmbTipo.Location = new System.Drawing.Point(247, 161);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(275, 26);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblPMay
            // 
            this.lblPMay.AutoSize = true;
            this.lblPMay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMay.Location = new System.Drawing.Point(12, 61);
            this.lblPMay.Name = "lblPMay";
            this.lblPMay.Size = new System.Drawing.Size(50, 23);
            this.lblPMay.TabIndex = 3;
            this.lblPMay.Text = "P.M.";
            // 
            // lblPm
            // 
            this.lblPm.AutoSize = true;
            this.lblPm.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPm.Location = new System.Drawing.Point(12, 120);
            this.lblPm.Name = "lblPm";
            this.lblPm.Size = new System.Drawing.Size(49, 23);
            this.lblPm.TabIndex = 4;
            this.lblPm.Text = "P.m.";
            // 
            // txtInicioPMay
            // 
            this.txtInicioPMay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicioPMay.Location = new System.Drawing.Point(68, 58);
            this.txtInicioPMay.Name = "txtInicioPMay";
            this.txtInicioPMay.Size = new System.Drawing.Size(139, 29);
            this.txtInicioPMay.TabIndex = 5;
            // 
            // txtInicioPremMen
            // 
            this.txtInicioPremMen.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicioPremMen.Location = new System.Drawing.Point(68, 117);
            this.txtInicioPremMen.Name = "txtInicioPremMen";
            this.txtInicioPremMen.Size = new System.Drawing.Size(139, 29);
            this.txtInicioPremMen.TabIndex = 9;
            // 
            // txtSP2
            // 
            this.txtSP2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP2.Location = new System.Drawing.Point(68, 76);
            this.txtSP2.Name = "txtSP2";
            this.txtSP2.Size = new System.Drawing.Size(139, 29);
            this.txtSP2.TabIndex = 15;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.Location = new System.Drawing.Point(13, 79);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(49, 23);
            this.lblP3.TabIndex = 7;
            this.lblP3.Text = "P. 2:";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(51, 9);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(587, 144);
            this.lblInstrucciones.TabIndex = 9;
            this.lblInstrucciones.Text = resources.GetString("lblInstrucciones.Text");
            // 
            // txt2daMay
            // 
            this.txt2daMay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2daMay.Location = new System.Drawing.Point(213, 58);
            this.txt2daMay.Name = "txt2daMay";
            this.txt2daMay.Size = new System.Drawing.Size(91, 29);
            this.txt2daMay.TabIndex = 6;
            // 
            // txt3raMay
            // 
            this.txt3raMay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3raMay.Location = new System.Drawing.Point(310, 58);
            this.txt3raMay.Name = "txt3raMay";
            this.txt3raMay.Size = new System.Drawing.Size(139, 29);
            this.txt3raMay.TabIndex = 7;
            // 
            // txtPredMay
            // 
            this.txtPredMay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredMay.Location = new System.Drawing.Point(455, 58);
            this.txtPredMay.Name = "txtPredMay";
            this.txtPredMay.Size = new System.Drawing.Size(244, 29);
            this.txtPredMay.TabIndex = 8;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(95, 36);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(73, 13);
            this.lblInicio.TabIndex = 13;
            this.lblInicio.Text = "\"Todo, Toda\"";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "\"Sujeto\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Verbo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Predicado";
            // 
            // txtPrem2daMen
            // 
            this.txtPrem2daMen.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrem2daMen.Location = new System.Drawing.Point(213, 117);
            this.txtPrem2daMen.Name = "txtPrem2daMen";
            this.txtPrem2daMen.Size = new System.Drawing.Size(91, 29);
            this.txtPrem2daMen.TabIndex = 10;
            // 
            // txtPredMen
            // 
            this.txtPredMen.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredMen.Location = new System.Drawing.Point(310, 117);
            this.txtPredMen.Name = "txtPredMen";
            this.txtPredMen.Size = new System.Drawing.Size(139, 29);
            this.txtPredMen.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "\"Sujeto\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "\"Es, Tiene\"";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Predicado";
            // 
            // panel_Deductivo
            // 
            this.panel_Deductivo.Controls.Add(this.label6);
            this.panel_Deductivo.Controls.Add(this.label5);
            this.panel_Deductivo.Controls.Add(this.label4);
            this.panel_Deductivo.Controls.Add(this.txtPredMen);
            this.panel_Deductivo.Controls.Add(this.txtPrem2daMen);
            this.panel_Deductivo.Controls.Add(this.label3);
            this.panel_Deductivo.Controls.Add(this.label2);
            this.panel_Deductivo.Controls.Add(this.label1);
            this.panel_Deductivo.Controls.Add(this.lblInicio);
            this.panel_Deductivo.Controls.Add(this.txtPredMay);
            this.panel_Deductivo.Controls.Add(this.txt3raMay);
            this.panel_Deductivo.Controls.Add(this.txt2daMay);
            this.panel_Deductivo.Controls.Add(this.txtInicioPremMen);
            this.panel_Deductivo.Controls.Add(this.txtInicioPMay);
            this.panel_Deductivo.Controls.Add(this.lblPm);
            this.panel_Deductivo.Controls.Add(this.lblPMay);
            this.panel_Deductivo.Location = new System.Drawing.Point(2, 193);
            this.panel_Deductivo.Name = "panel_Deductivo";
            this.panel_Deductivo.Size = new System.Drawing.Size(715, 168);
            this.panel_Deductivo.TabIndex = 23;
            // 
            // panel_Inductivo
            // 
            this.panel_Inductivo.Controls.Add(this.label11);
            this.panel_Inductivo.Controls.Add(this.txtPredP3);
            this.panel_Inductivo.Controls.Add(this.txtPredP1);
            this.panel_Inductivo.Controls.Add(this.txtPredP2);
            this.panel_Inductivo.Controls.Add(this.label10);
            this.panel_Inductivo.Controls.Add(this.txtEsP3);
            this.panel_Inductivo.Controls.Add(this.txtEsP1);
            this.panel_Inductivo.Controls.Add(this.txtEsP2);
            this.panel_Inductivo.Controls.Add(this.label9);
            this.panel_Inductivo.Controls.Add(this.txtSP3);
            this.panel_Inductivo.Controls.Add(this.label8);
            this.panel_Inductivo.Controls.Add(this.txtSP1);
            this.panel_Inductivo.Controls.Add(this.label7);
            this.panel_Inductivo.Controls.Add(this.txtSP2);
            this.panel_Inductivo.Controls.Add(this.lblP3);
            this.panel_Inductivo.Location = new System.Drawing.Point(2, 381);
            this.panel_Inductivo.Name = "panel_Inductivo";
            this.panel_Inductivo.Size = new System.Drawing.Size(715, 168);
            this.panel_Inductivo.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "\"predicado\"";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPredP3
            // 
            this.txtPredP3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredP3.Location = new System.Drawing.Point(369, 127);
            this.txtPredP3.Name = "txtPredP3";
            this.txtPredP3.Size = new System.Drawing.Size(255, 29);
            this.txtPredP3.TabIndex = 20;
            // 
            // txtPredP1
            // 
            this.txtPredP1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredP1.Location = new System.Drawing.Point(369, 28);
            this.txtPredP1.Name = "txtPredP1";
            this.txtPredP1.Size = new System.Drawing.Size(255, 29);
            this.txtPredP1.TabIndex = 14;
            // 
            // txtPredP2
            // 
            this.txtPredP2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredP2.Location = new System.Drawing.Point(369, 76);
            this.txtPredP2.Name = "txtPredP2";
            this.txtPredP2.Size = new System.Drawing.Size(256, 29);
            this.txtPredP2.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "\"es, tiene, verbo\"";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEsP3
            // 
            this.txtEsP3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsP3.Location = new System.Drawing.Point(225, 127);
            this.txtEsP3.Name = "txtEsP3";
            this.txtEsP3.Size = new System.Drawing.Size(112, 29);
            this.txtEsP3.TabIndex = 19;
            // 
            // txtEsP1
            // 
            this.txtEsP1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsP1.Location = new System.Drawing.Point(225, 28);
            this.txtEsP1.Name = "txtEsP1";
            this.txtEsP1.Size = new System.Drawing.Size(112, 29);
            this.txtEsP1.TabIndex = 13;
            // 
            // txtEsP2
            // 
            this.txtEsP2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsP2.Location = new System.Drawing.Point(225, 76);
            this.txtEsP2.Name = "txtEsP2";
            this.txtEsP2.Size = new System.Drawing.Size(113, 29);
            this.txtEsP2.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "\"Sujeto\"";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSP3
            // 
            this.txtSP3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP3.Location = new System.Drawing.Point(68, 127);
            this.txtSP3.Name = "txtSP3";
            this.txtSP3.Size = new System.Drawing.Size(138, 29);
            this.txtSP3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "P. 3:";
            // 
            // txtSP1
            // 
            this.txtSP1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP1.Location = new System.Drawing.Point(68, 28);
            this.txtSP1.Name = "txtSP1";
            this.txtSP1.Size = new System.Drawing.Size(138, 29);
            this.txtSP1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "P. 1:";
            // 
            // frmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 620);
            this.Controls.Add(this.panel_Inductivo);
            this.Controls.Add(this.panel_Deductivo);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.btnConclusion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deductivo e Inductivo";
            this.panel_Deductivo.ResumeLayout(false);
            this.panel_Deductivo.PerformLayout();
            this.panel_Inductivo.ResumeLayout(false);
            this.panel_Inductivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConclusion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblPMay;
        private System.Windows.Forms.Label lblPm;
        private System.Windows.Forms.TextBox txtInicioPMay;
        private System.Windows.Forms.TextBox txtInicioPremMen;
        private System.Windows.Forms.TextBox txtSP2;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.TextBox txt2daMay;
        private System.Windows.Forms.TextBox txt3raMay;
        private System.Windows.Forms.TextBox txtPredMay;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrem2daMen;
        private System.Windows.Forms.TextBox txtPredMen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Deductivo;
        private System.Windows.Forms.Panel panel_Inductivo;
        private System.Windows.Forms.TextBox txtSP3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSP1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEsP3;
        private System.Windows.Forms.TextBox txtEsP1;
        private System.Windows.Forms.TextBox txtEsP2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPredP3;
        private System.Windows.Forms.TextBox txtPredP1;
        private System.Windows.Forms.TextBox txtPredP2;
    }
}

