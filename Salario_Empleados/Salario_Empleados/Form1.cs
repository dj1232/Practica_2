using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario_Empleados
{
    
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_bruto.Clear();
            rbt_gerente.Checked = false;
            rbt_subgerente.Checked = false;
            rbt_secretaria.Checked = false;
        }//fin funcion limpiar

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, apellido;
            double s_bruto, descuento=0, s_neto=0;
            int cargo =0;

            //captura de datos
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            s_bruto = Convert.ToDouble(txt_bruto.Text);

            //validacion de datos
            if(nombre == "" || apellido == "")
            {
                MessageBox.Show("No puede dejar campos vacios, por favor reingrese los datos");
                limpiar();
            }
            if (s_bruto <= 0)
            {
                MessageBox.Show("No puede ingresar salario negativo o dejar el campo vacio, por favor reingrese los datos");
                limpiar();
            }

            if (rbt_gerente.Checked)
            {
                cargo = 1;
            }
            else if (rbt_subgerente.Checked)
            {
                cargo = 2;
            }
            else if (rbt_secretaria.Checked)
            {
                cargo = 3;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cargo, por favor reingrese los datos");
                limpiar();
            }

            //proceso de calculo
            switch (cargo)
            {
                case 1:
                    descuento = s_bruto * .20;
                    s_neto = s_bruto - descuento;
                    break;
                case 2:
                    descuento = s_bruto * .15;
                    s_neto = s_bruto - descuento;
                    break;
                case 3:
                    descuento = s_bruto * .5;
                    s_neto = s_bruto - descuento;
                    break;
            }//fin switch

            //impresion de resultados
            lbr_descuento.Text = "$" + descuento;
            lbr_neto.Text = "$" + s_neto;
        }
    }//fin funcion cilck calcular
   
}//fin programa

