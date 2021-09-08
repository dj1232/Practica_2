using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglos_ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            for (int i = 0; i < list_arreglo.Items.Count; i++)
            {
                string valor = list_arreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)

                    {

                        mayorneg = numero;
                        txt_calculo1.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txt_calculo1.Text = "No hay números negativos pares";
                }
            }

            double cantidadnumeros = list_arreglo.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i < list_arreglo.Items.Count; i++)
            {
                string valor = list_arreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txt_calculo2.Text = porcentaje.ToString() + "%";

            double prom;
            double cantidadimpares = 0;
            double suma = 0;
            for (int i = 0; i < list_arreglo.Items.Count; i++)
            {
                string valor = list_arreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;

                    cantidadimpares = cantidadimpares + 1;

                }
            }
            prom = suma / cantidadimpares;
            txt_calculo3.Text = prom.ToString();

            int mayor = 0;
            for (int i = 0; i < list_arreglo.Items.Count; i++)
            {
                string valor = list_arreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            txt_calculo4.Text = mayor.ToString();
        }//fin funcion 1

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                list_arreglo.Items.Add(txt_ingresar.Text);
                txt_ingresar.Clear();
                txt_ingresar.Focus();
            }
           
        }
    }
}
