
namespace arreglos_ej4
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txt_calculo3 = new System.Windows.Forms.TextBox();
            this.txt_calculo2 = new System.Windows.Forms.TextBox();
            this.txt_calculo1 = new System.Windows.Forms.TextBox();
            this.list_arreglo = new System.Windows.Forms.ListBox();
            this.caja_arreglo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_calculo4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ingresar = new System.Windows.Forms.TextBox();
            this.caja_arreglo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(397, 104);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(102, 35);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Mostrar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt_calculo3
            // 
            this.txt_calculo3.Location = new System.Drawing.Point(266, 142);
            this.txt_calculo3.Name = "txt_calculo3";
            this.txt_calculo3.ReadOnly = true;
            this.txt_calculo3.Size = new System.Drawing.Size(125, 27);
            this.txt_calculo3.TabIndex = 5;
            // 
            // txt_calculo2
            // 
            this.txt_calculo2.Location = new System.Drawing.Point(266, 85);
            this.txt_calculo2.Name = "txt_calculo2";
            this.txt_calculo2.ReadOnly = true;
            this.txt_calculo2.Size = new System.Drawing.Size(125, 27);
            this.txt_calculo2.TabIndex = 8;
            // 
            // txt_calculo1
            // 
            this.txt_calculo1.Location = new System.Drawing.Point(266, 27);
            this.txt_calculo1.Name = "txt_calculo1";
            this.txt_calculo1.ReadOnly = true;
            this.txt_calculo1.Size = new System.Drawing.Size(125, 27);
            this.txt_calculo1.TabIndex = 9;
            // 
            // list_arreglo
            // 
            this.list_arreglo.FormattingEnabled = true;
            this.list_arreglo.ItemHeight = 20;
            this.list_arreglo.Location = new System.Drawing.Point(79, 113);
            this.list_arreglo.Name = "list_arreglo";
            this.list_arreglo.Size = new System.Drawing.Size(150, 264);
            this.list_arreglo.TabIndex = 10;
            // 
            // caja_arreglo
            // 
            this.caja_arreglo.Controls.Add(this.label5);
            this.caja_arreglo.Controls.Add(this.label4);
            this.caja_arreglo.Controls.Add(this.label3);
            this.caja_arreglo.Controls.Add(this.label2);
            this.caja_arreglo.Controls.Add(this.txt_calculo4);
            this.caja_arreglo.Controls.Add(this.btn1);
            this.caja_arreglo.Controls.Add(this.txt_calculo2);
            this.caja_arreglo.Controls.Add(this.txt_calculo1);
            this.caja_arreglo.Controls.Add(this.txt_calculo3);
            this.caja_arreglo.Location = new System.Drawing.Point(283, 113);
            this.caja_arreglo.Name = "caja_arreglo";
            this.caja_arreglo.Size = new System.Drawing.Size(505, 276);
            this.caja_arreglo.TabIndex = 11;
            this.caja_arreglo.TabStop = false;
            this.caja_arreglo.Text = "OPERACIONES CON ARREGLO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mayor de los pares positivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Promedio de impares positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Porcentaje de ceros en el arreglo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero mayor de pares negativos";
            // 
            // txt_calculo4
            // 
            this.txt_calculo4.Location = new System.Drawing.Point(266, 206);
            this.txt_calculo4.Name = "txt_calculo4";
            this.txt_calculo4.ReadOnly = true;
            this.txt_calculo4.Size = new System.Drawing.Size(125, 27);
            this.txt_calculo4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese un valor al arreglo";
            // 
            // txt_ingresar
            // 
            this.txt_ingresar.Location = new System.Drawing.Point(211, 52);
            this.txt_ingresar.Name = "txt_ingresar";
            this.txt_ingresar.Size = new System.Drawing.Size(125, 27);
            this.txt_ingresar.TabIndex = 13;
            this.txt_ingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ingresar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caja_arreglo);
            this.Controls.Add(this.list_arreglo);
            this.Name = "Form1";
            this.Text = "Calculos basicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.caja_arreglo.ResumeLayout(false);
            this.caja_arreglo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt_calculo3;
        private System.Windows.Forms.TextBox txt_calculo2;
        private System.Windows.Forms.TextBox txt_calculo1;
        private System.Windows.Forms.ListBox list_arreglo;
        private System.Windows.Forms.GroupBox caja_arreglo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_calculo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ingresar;
    }
}

