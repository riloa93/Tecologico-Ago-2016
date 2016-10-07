using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPal : Form
    {
        public frmPal()
        {
            InitializeComponent();
        }

        private void btnConclusion_Click(object sender, EventArgs e)
        {
            ClsConclusiones objconclusion = new ClsConclusiones();
            if (cmbTipo.SelectedIndex == 0)
            {
                    MessageBox.Show("Conclusión: " + objconclusion.Deductivo(txtInicioPMay.Text.ToLower(), txt2daMay.Text.ToLower(), txt3raMay.Text.ToLower(), txtPredMay.Text.ToLower(), txtInicioPremMen.Text.ToLower(),
                    txtPrem2daMen.Text.ToLower(), txtPredMen.Text.ToLower()));
                    txtInicioPMay.Text = "";
                    txtInicioPremMen.Text = "";
                    txt2daMay.Text = "";
                    txt3raMay.Text = "";
                    txtPredMay.Text = "";
                    txtPrem2daMen.Text = "";
                    txtPredMen.Text = " ";
                    cmbTipo.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Conclusión: " + objconclusion.Inductivo(txtSP1.Text.ToLower(), txtEsP1.Text.ToLower(), txtPredP1.Text.ToLower(),
                    txtSP2.Text.ToLower(), txtEsP2.Text.ToLower(), txtPredP2.Text.ToLower(), txtSP3.Text.ToLower(), txtEsP3.Text.ToLower(),
                    txtPredP3.Text.ToLower()));
                txtSP1.Text = ""; txtSP2.Text = ""; txtSP3.Text = "";
                txtEsP1.Text = ""; txtEsP2.Text = ""; txtEsP3.Text = "";
                txtPredP1.Text = ""; txtPredP2.Text = ""; txtPredP3.Text = "";
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* switch (cmbTipo.SelectedIndex)
            {
                case 0:
                    panel_Deductivo.Visible = true;
                    panel_Inductivo.Visible = false;
                    break;
                case 1:
                    panel_Inductivo.Visible = true;
                    panel_Deductivo.Visible = false;
                    break;

                default:
                    break;
            }*/
        }
    }
}
