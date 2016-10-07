using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Semantica_P2_U2
{
    public partial class frmPal : Form
    {
        //Atributo animal y clase
        ClsSuperClase superclase = new ClsSuperClase();
        ClsAtributosAnimal atributosanimal = new ClsAtributosAnimal();

        //Atributo persona y clase
        ClsSubClaseAnimalPers subclasepersonas = new ClsSubClaseAnimalPers();
        ClsAtributosPersona atributospersona = new ClsAtributosPersona();

        //Atributo pajaro y clase
        ClsSubClaseAnimalP subclaseanimalpajaro = new ClsSubClaseAnimalP();
        ClsAtributosPajaro atributospajaro = new ClsAtributosPajaro();

        //Atributo canario y clase
        ClsSubClasePajaro subclasepajaro = new ClsSubClasePajaro();
        ClsAtributosCanario atributoscanario = new ClsAtributosCanario();

        ClsSubClaseCanario subclasecanario = new ClsSubClaseCanario();

        //if clase1.Animal = "Algo" && clase2.Animal = "Algo";
        // Preguntar por los constructores principales si es algo iual a otro
        public frmPal()
        {
            InitializeComponent();
        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            string[] palabras = new string[20]; 

            if (txtPregunta.Text != "")
            {
               palabras = txtPregunta.Text.Split(' ');
                //string concatenado = "";
                //bool encontro = false;
                for (int i = 0; i < palabras.Length; i++)
                {
                    switch (palabras[i])
                    {
                        case "es":
                            if (palabras[i+1] == "un")
                            {
                                if (palabras[i - 1] == subclasepersonas.Persona && superclase.Animal == subclasepersonas.Animal)
                                {
                                    lblRespuesta.Text = "Si, la " + subclasepersonas.Persona + " es un " + superclase.Animal;
                                    break;
                                }
                                else if (palabras[i - 1] == subclaseanimalpajaro.Pajaro && superclase.Animal == subclaseanimalpajaro.Animal)
                                {
                                    lblRespuesta.Text = "Si, el " + subclaseanimalpajaro.Pajaro + " es un " + superclase.Animal;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasepajaro.Canario && superclase.Animal == subclasepajaro.Animal)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasepajaro.Canario + " es un " + superclase.Animal;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasecanario.EsUn && superclase.Animal == subclasecanario.Animal)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasecanario.EsUn + " es un " + superclase.Animal;
                                    break;
                                }
                                if (palabras[i + 2] == superclase.Animal && subclasepersonas.Animal == superclase.Animal && subclaseanimalpajaro.Animal == superclase.Animal
                                 && subclasepajaro.Animal == superclase.Animal && subclasecanario.Animal == superclase.Animal) //Checarlo para que conteste sobre si el animal puede respirar y sobre que animales pueden
                                {
                                    lblRespuesta.Text = "La " + subclasepersonas.Persona + ", el " + subclaseanimalpajaro.Pajaro + ", el " + subclasepajaro.Canario + " y el " + subclasecanario.EsUn;
                                    break;
                                }
                                else
                                {
                                    lblRespuesta.Text = "Desconozco si es un animal.";
                                    break;
                                }
                            }
                            else
                            {
                                if (palabras[i-1] == subclasepajaro.Canario && subclasepajaro.Canario == atributoscanario.Canario)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasecanario.Canario + " es " + atributoscanario.Es;
                                    break;
                                }
                                else if(palabras[i-1] == subclasecanario.EsUn && subclasecanario.Canario == atributoscanario.Canario)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasecanario.EsUn + " es " + atributoscanario.Es;
                                    break;
                                }
                                else if(palabras[i -2] == subclaseanimalpajaro.Pajaro && subclaseanimalpajaro.Pajaro == atributoscanario.Pajaro)
                                {
                                    lblRespuesta.Text = "Si, hay un " + subclaseanimalpajaro.Pajaro + " que es " + atributoscanario.Es;
                                    break;
                                }
                                else if(palabras[i-1] == subclasepersonas.Persona && subclasepersonas.Animal != atributoscanario.Pajaro)
                                {
                                    lblRespuesta.Text = "No, la " + subclasepersonas.Persona + " no es " + atributoscanario.Es;
                                    break;
                                }
                                else if(palabras[i-1] == superclase.Animal && atributoscanario.Animal == superclase.Animal && subclasepajaro.Animal == superclase.Animal &&
                                    subclasecanario.Animal == superclase.Animal && subclaseanimalpajaro.Animal == superclase.Animal)
                                {
                                    lblRespuesta.Text = "El " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + " son " + atributoscanario.Es+"s.";
                                    break;
                                }
                            }
                            break;

                        case "puede":
                            if (palabras[i + 1] == atributosanimal.Puede)
                            {
                                if (palabras[i - 1] == superclase.Animal && superclase.Animal == atributosanimal.Animal) //Checarlo para que conteste sobre si el animal puede respirar y sobre que animales pueden
                                {
                                    if (palabras[0] == "El" || palabras[0] == "Un")
                                    {
                                        lblRespuesta.Text = "Si, el " + superclase.Animal + " puede " + atributosanimal.Puede;
                                        break;
                                    }
                                    else
                                    {
                                        if (subclasepersonas.Animal == superclase.Animal && subclaseanimalpajaro.Animal == superclase.Animal
                                        && subclasepajaro.Animal == superclase.Animal && subclasecanario.Animal == superclase.Animal)
                                        {
                                            lblRespuesta.Text = "La " + subclasepersonas.Persona + ", el " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + "y el " + subclaseanimalpajaro.Pajaro;
                                            break;
                                        }
                                    }
                                }
                                else if (palabras[i - 1] == subclasepersonas.Persona && subclasepersonas.Animal == atributosanimal.Animal)
                                {
                                    lblRespuesta.Text = "Si, la " + subclasepersonas.Persona + " puede " + atributosanimal.Puede;
                                    break;
                                }
                                else if (palabras[i - 1] == subclaseanimalpajaro.Pajaro && atributosanimal.Animal == subclaseanimalpajaro.Animal)
                                {
                                    lblRespuesta.Text = "Si, el " + subclaseanimalpajaro.Pajaro + " puede " + atributosanimal.Puede;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasepajaro.Canario && atributosanimal.Animal == subclasepajaro.Animal)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasepajaro.Canario + " puede " + atributosanimal.Puede;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasecanario.EsUn && atributosanimal.Animal == subclasecanario.Animal)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasecanario.EsUn + " puede " + atributosanimal.Puede;
                                    break;
                                }
                                else
                                {
                                    lblRespuesta.Text = "Desconozco si ese animal puede respirar.";
                                    break;
                                }

                            }
                            else if (palabras[i + 1] == atributoscanario.Puede)
                            {
                                if (palabras[i - 1] == subclaseanimalpajaro.Pajaro && subclaseanimalpajaro.Pajaro == atributoscanario.Pajaro || palabras[i - 1] == superclase.Animal && subclaseanimalpajaro.Animal == superclase.Animal) //Checarlo para que conteste sobre si el animal puede respirar y sobre que animales pueden
                                {
                                    if (palabras[0] == "El" || palabras[0] == "Un")
                                    {
                                        lblRespuesta.Text = "Si, el " + subclaseanimalpajaro.Pajaro + " puede " + atributoscanario.Puede;
                                        break;
                                    }
                                    else if(palabras[0] == "Que")
                                    {
                                        if (palabras[i-1] == subclaseanimalpajaro.Pajaro && atributoscanario.Pajaro == subclaseanimalpajaro.Pajaro && subclasecanario
                                            .Canario == atributoscanario.Canario && subclasepajaro.Canario == atributoscanario.Canario)
                                        {
                                            lblRespuesta.Text = "El " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + " y el " + subclaseanimalpajaro.Pajaro;
                                            break;
                                        }
                                        else if (palabras[i - 1] == superclase.Animal && atributoscanario.Animal == superclase.Animal)
                                        {
                                            lblRespuesta.Text = "El " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + " y el " + subclaseanimalpajaro.Pajaro;
                                            break;
                                        }
                                    }
                                }
                                else if (palabras[i - 1] == subclasepajaro.Canario && subclasecanario.Canario == atributoscanario.Canario)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasepajaro.Canario + "puede " + atributoscanario.Puede;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasecanario.EsUn && subclasecanario.Canario == subclasecanario.Canario)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasecanario.EsUn + "puede " + atributoscanario.Puede;
                                    break;
                                }
                                else if(palabras[i - 1] == subclasepersonas.Persona)
                                {
                                    lblRespuesta.Text = "No, una " + subclasepersonas.Persona + " no puede " + atributoscanario.Puede;
                                    break;
                                }
                                else
                                {
                                    lblRespuesta.Text = "Desconozco si ese animal puede cantar.";
                                    break;
                                }
                            }
                            else if(palabras[i+1] == atributospajaro.Puede)
                            {
                                if (palabras[i - 1] == subclaseanimalpajaro.Pajaro && subclaseanimalpajaro.Pajaro == atributoscanario.Pajaro || palabras[i - 1] == superclase.Animal && subclaseanimalpajaro.Animal == superclase.Animal) //Checarlo para que conteste sobre si el animal puede respirar y sobre que animales pueden
                                {
                                    if (palabras[0] == "El" || palabras[0] == "Un")
                                    {
                                        lblRespuesta.Text = "Si, el " + subclaseanimalpajaro.Pajaro + " puede " + atributospajaro.Puede;
                                        break;
                                    }
                                    else
                                    {
                                        if (palabras[i - 1] == subclaseanimalpajaro.Pajaro && atributospajaro.Pajaro == subclaseanimalpajaro.Pajaro && subclasecanario
                                            .Pajaro == atributospajaro.Pajaro && subclasepajaro.Pajaro == atributospajaro.Pajaro)
                                        {
                                            lblRespuesta.Text = "El " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + " y el " + subclaseanimalpajaro.Pajaro;
                                            break;
                                        }
                                        else if (palabras[i - 1] == superclase.Animal && atributospajaro.Animal == superclase.Animal)
                                        {
                                            lblRespuesta.Text = "El " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + " y el " + subclaseanimalpajaro.Pajaro;
                                            break;
                                        }
                                    }
                                }
                                else if (palabras[i - 1] == subclasepajaro.Canario && subclasecanario.Pajaro == atributospajaro.Pajaro)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasepajaro.Canario + "puede " + atributospajaro.Puede;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasecanario.EsUn && subclasecanario.Pajaro == atributospajaro.Pajaro)
                                {
                                    lblRespuesta.Text = "Si, el " + subclasecanario.EsUn + "puede " + atributospajaro.Puede;
                                    break;
                                }
                                else if (palabras[i - 1] == subclasepersonas.Persona)
                                {
                                    lblRespuesta.Text = "No, una " + subclasepersonas.Persona + " no puede " + atributospajaro.Puede;
                                    break;
                                }
                                else
                                {
                                    lblRespuesta.Text = "Desconozco si ese animal puede volar.";
                                    break;
                                }
                            }
                            
                            break;

                        case "tiene":
                                if (palabras[0] == "El" && palabras[i-1] == superclase.Animal && superclase.Animal == atributosanimal.Animal)
                                {
                                    lblRespuesta.Text = "Si el " + superclase.Animal + "tiene " + atributosanimal.Tiene;
                                    break;
                                }
                                else if (palabras[0] == "Que" && palabras[i-1] == superclase.Animal && superclase.Animal == atributosanimal.Animal && subclasepersonas.Animal == atributosanimal.Animal
                                && subclaseanimalpajaro.Animal == atributosanimal.Animal && subclasepajaro.Animal == atributosanimal.Animal && subclasecanario.Animal == atributosanimal.Animal)
                                {
                                lblRespuesta.Text = "El " + subclaseanimalpajaro.Pajaro + ", el " + subclasecanario.EsUn + ", el " + subclasepajaro.Canario + " y la " + subclasepersonas.Persona +
                                "tienen " + atributosanimal.Tiene;
                                    break;
                                }
                            break;

                        case "pone":
                            for (int j = 0; j < palabras.Length; j++)
                            {
                                if (palabras[j] == subclasepajaro.Pajaro && superclase.Animal == subclasepajaro.Animal)
                                {
                                    lblRespuesta.Text = "Pone " + atributospajaro.Pone;
                                    break;
                                }
                                else if (palabras[j] == subclaseanimalpajaro.Pajaro && superclase.Animal == subclaseanimalpajaro.Animal)
                                {
                                    lblRespuesta.Text = "Pone " + atributospajaro.Pone;
                                    break;
                                }
                                else if (palabras[j] == subclasecanario.EsUn && superclase.Animal == subclasecanario.Animal)
                                {
                                    lblRespuesta.Text = "Pone " + atributospajaro.Pone;
                                    break;
                                }
                                else if(palabras[j] == superclase.Animal && subclaseanimalpajaro.Animal == superclase.Animal && subclasecanario.Animal == superclase.Animal)
                                {
                                    lblRespuesta.Text = "El " + subclasecanario.EsUn + ", el " + subclasepajaro.Canario + " y el " + subclaseanimalpajaro.Pajaro;
                                    break;
                                }
                                else if (palabras[j] == subclasepersonas.Persona && subclasepersonas.Persona != atributospajaro.Pajaro)
                                {
                                    lblRespuesta.Text = "No, la " + subclasepersonas.Persona + " no pone " + atributospajaro.Pone;
                                    break;
                                }
                                else
                                {
                                    lblRespuesta.Text = "No se si ese animal pone huevos.";
                                }
                            }
                            break;

                        case "come":
                            if (palabras[i - 1] == superclase.Animal && superclase.Animal == atributosanimal.Animal) //Checarlo para que conteste sobre si el animal puede respirar y sobre que animales pueden
                            {
                                if (palabras[0] == "El" || palabras[0] == "Un")
                                {
                                    lblRespuesta.Text = "Si, el " + superclase.Animal + " come " + atributosanimal.Come;
                                    break;
                                }
                                else
                                {
                                    if (palabras[i - 1] == subclaseanimalpajaro.Animal && atributosanimal.Animal == subclaseanimalpajaro.Animal && subclasecanario
                                        .Animal == atributosanimal.Animal && subclasepajaro.Animal == atributosanimal.Animal && subclasepersonas.Animal == atributosanimal.Animal)
                                    {
                                        lblRespuesta.Text = "La " + subclasepersonas.Persona + ", el " + subclasepajaro.Canario + ", el " + subclasecanario.EsUn + " y el " + subclaseanimalpajaro.Pajaro;
                                        break;
                                    }
                                }
                            }
                            else if (palabras[i - 1] == subclasepajaro.Canario && subclasecanario.Animal == atributosanimal.Animal)
                            {
                                lblRespuesta.Text = "Si, el " + subclasepajaro.Canario + "come " + atributosanimal.Come;
                                break;
                            }
                            else if (palabras[i - 1] == subclaseanimalpajaro.Pajaro && subclaseanimalpajaro.Animal == atributosanimal.Animal)
                            {
                                lblRespuesta.Text = "Si, el " + subclaseanimalpajaro.Pajaro + "come " + atributosanimal.Come;
                                break;
                            }
                            else if (palabras[i - 1] == subclasecanario.EsUn && subclasecanario.Animal == atributosanimal.Animal)
                            {
                                lblRespuesta.Text = "Si, el " + subclasecanario.EsUn + "come " + atributosanimal.Come;
                                break;
                            }
                            else if (palabras[i - 1] == subclasepersonas.Persona && subclasepersonas.Animal == atributosanimal.Animal)
                            {
                                lblRespuesta.Text = "Si, una " + subclasepersonas.Persona + " come " + atributosanimal.Come;
                                break;
                            }
                            else
                            {
                                lblRespuesta.Text = "Desconozco si ese animal come alimentos.";
                                break;
                            }
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar una pregunta.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPregunta.Focus();
            }
        }
    }
}
