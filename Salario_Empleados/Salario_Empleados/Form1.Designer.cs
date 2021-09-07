
namespace Salario_Empleados
{
    partial class frm_empleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_bruto = new System.Windows.Forms.Label();
            this.lb_descuento = new System.Windows.Forms.Label();
            this.lb_salario = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_bruto = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbr_descuento = new System.Windows.Forms.Label();
            this.lbr_neto = new System.Windows.Forms.Label();
            this.rbt_gerente = new System.Windows.Forms.RadioButton();
            this.rbt_subgerente = new System.Windows.Forms.RadioButton();
            this.rbt_secretaria = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(239, 363);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(133, 38);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(68, 53);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre:";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Location = new System.Drawing.Point(358, 53);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(79, 20);
            this.lb_apellido.TabIndex = 2;
            this.lb_apellido.Text = "Apellidos: ";
            // 
            // lb_bruto
            // 
            this.lb_bruto.AutoSize = true;
            this.lb_bruto.Location = new System.Drawing.Point(79, 136);
            this.lb_bruto.Name = "lb_bruto";
            this.lb_bruto.Size = new System.Drawing.Size(98, 20);
            this.lb_bruto.TabIndex = 3;
            this.lb_bruto.Text = "Salario bruto:";
            // 
            // lb_descuento
            // 
            this.lb_descuento.AutoSize = true;
            this.lb_descuento.Location = new System.Drawing.Point(55, 201);
            this.lb_descuento.Name = "lb_descuento";
            this.lb_descuento.Size = new System.Drawing.Size(132, 20);
            this.lb_descuento.TabIndex = 4;
            this.lb_descuento.Text = "Monto descuento: ";
            // 
            // lb_salario
            // 
            this.lb_salario.AutoSize = true;
            this.lb_salario.Location = new System.Drawing.Point(79, 269);
            this.lb_salario.Name = "lb_salario";
            this.lb_salario.Size = new System.Drawing.Size(92, 20);
            this.lb_salario.TabIndex = 5;
            this.lb_salario.Text = "Salario neto:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(154, 50);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(154, 27);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_bruto
            // 
            this.txt_bruto.Location = new System.Drawing.Point(195, 133);
            this.txt_bruto.Name = "txt_bruto";
            this.txt_bruto.Size = new System.Drawing.Size(125, 27);
            this.txt_bruto.TabIndex = 7;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(455, 53);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(234, 27);
            this.txt_apellido.TabIndex = 8;
            // 
            // lbr_descuento
            // 
            this.lbr_descuento.AutoSize = true;
            this.lbr_descuento.Location = new System.Drawing.Point(195, 201);
            this.lbr_descuento.Name = "lbr_descuento";
            this.lbr_descuento.Size = new System.Drawing.Size(18, 20);
            this.lbr_descuento.TabIndex = 9;
            this.lbr_descuento.Text = "...";
            // 
            // lbr_neto
            // 
            this.lbr_neto.AutoSize = true;
            this.lbr_neto.Location = new System.Drawing.Point(195, 269);
            this.lbr_neto.Name = "lbr_neto";
            this.lbr_neto.Size = new System.Drawing.Size(18, 20);
            this.lbr_neto.TabIndex = 10;
            this.lbr_neto.Text = "...";
            // 
            // rbt_gerente
            // 
            this.rbt_gerente.AutoSize = true;
            this.rbt_gerente.Location = new System.Drawing.Point(528, 148);
            this.rbt_gerente.Name = "rbt_gerente";
            this.rbt_gerente.Size = new System.Drawing.Size(82, 24);
            this.rbt_gerente.TabIndex = 11;
            this.rbt_gerente.TabStop = true;
            this.rbt_gerente.Text = "Gerente";
            this.rbt_gerente.UseVisualStyleBackColor = true;
            // 
            // rbt_subgerente
            // 
            this.rbt_subgerente.AutoSize = true;
            this.rbt_subgerente.Location = new System.Drawing.Point(528, 197);
            this.rbt_subgerente.Name = "rbt_subgerente";
            this.rbt_subgerente.Size = new System.Drawing.Size(106, 24);
            this.rbt_subgerente.TabIndex = 12;
            this.rbt_subgerente.TabStop = true;
            this.rbt_subgerente.Text = "Subgerente";
            this.rbt_subgerente.UseVisualStyleBackColor = true;
            // 
            // rbt_secretaria
            // 
            this.rbt_secretaria.AutoSize = true;
            this.rbt_secretaria.Location = new System.Drawing.Point(528, 249);
            this.rbt_secretaria.Name = "rbt_secretaria";
            this.rbt_secretaria.Size = new System.Drawing.Size(96, 24);
            this.rbt_secretaria.TabIndex = 13;
            this.rbt_secretaria.TabStop = true;
            this.rbt_secretaria.Text = "Secretaria";
            this.rbt_secretaria.UseVisualStyleBackColor = true;
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 476);
            this.Controls.Add(this.rbt_secretaria);
            this.Controls.Add(this.rbt_subgerente);
            this.Controls.Add(this.rbt_gerente);
            this.Controls.Add(this.lbr_neto);
            this.Controls.Add(this.lbr_descuento);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_bruto);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lb_salario);
            this.Controls.Add(this.lb_descuento);
            this.Controls.Add(this.lb_bruto);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.btn_calcular);
            this.Name = "frm_empleados";
            this.Text = "Ventana de empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Label lb_bruto;
        private System.Windows.Forms.Label lb_descuento;
        private System.Windows.Forms.Label lb_salario;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_bruto;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbr_descuento;
        private System.Windows.Forms.Label lbr_neto;
        private System.Windows.Forms.RadioButton rbt_gerente;
        private System.Windows.Forms.RadioButton rbt_subgerente;
        private System.Windows.Forms.RadioButton rbt_secretaria;
    }
}

