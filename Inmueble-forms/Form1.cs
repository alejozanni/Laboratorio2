using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmueble_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.botonPiso = new System.Windows.Forms.RadioButton();
            this.botonLocal = new System.Windows.Forms.RadioButton();
            this.textTipoInmueble = new System.Windows.Forms.GroupBox();
            this.textoPisoNro = new System.Windows.Forms.Label();
            this.ventanas = new System.Windows.Forms.TextBox();
            this.pisos = new System.Windows.Forms.TextBox();
            this.textoNrodeVentanas = new System.Windows.Forms.Label();
            this.textoDireccion = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.superficie = new System.Windows.Forms.TextBox();
            this.antiguedad = new System.Windows.Forms.TextBox();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.textoSuperficie = new System.Windows.Forms.Label();
            this.textoAntiguedad = new System.Windows.Forms.Label();
            this.textoPrecioBase = new System.Windows.Forms.Label();
            this.textoM2 = new System.Windows.Forms.Label();
            this.textoanios = new System.Windows.Forms.Label();
            this.texoCalcularPrecioFinal = new System.Windows.Forms.Button();
            this.textoPrecioFinal = new System.Windows.Forms.Label();
            this.textTipoInmueble.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonPiso
            // 
            this.botonPiso.AutoSize = true;
            this.botonPiso.Location = new System.Drawing.Point(34, 42);
            this.botonPiso.Name = "botonPiso";
            this.botonPiso.Size = new System.Drawing.Size(45, 17);
            this.botonPiso.TabIndex = 1;
            this.botonPiso.TabStop = true;
            this.botonPiso.Text = "Piso";
            this.botonPiso.UseVisualStyleBackColor = true;
            this.botonPiso.CheckedChanged += new System.EventHandler(this.botonPiso_CheckedChanged);
            // 
            // botonLocal
            // 
            this.botonLocal.AutoSize = true;
            this.botonLocal.Location = new System.Drawing.Point(190, 42);
            this.botonLocal.Name = "botonLocal";
            this.botonLocal.Size = new System.Drawing.Size(51, 17);
            this.botonLocal.TabIndex = 2;
            this.botonLocal.TabStop = true;
            this.botonLocal.Text = "Local";
            this.botonLocal.UseVisualStyleBackColor = true;
            this.botonLocal.CheckedChanged += new System.EventHandler(this.botonLocal_CheckedChanged);
            // 
            // textTipoInmueble
            // 
            this.textTipoInmueble.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textTipoInmueble.Controls.Add(this.textoPisoNro);
            this.textTipoInmueble.Controls.Add(this.ventanas);
            this.textTipoInmueble.Controls.Add(this.pisos);
            this.textTipoInmueble.Controls.Add(this.botonPiso);
            this.textTipoInmueble.Controls.Add(this.botonLocal);
            this.textTipoInmueble.Controls.Add(this.textoNrodeVentanas);
            this.textTipoInmueble.Location = new System.Drawing.Point(12, 12);
            this.textTipoInmueble.Name = "textTipoInmueble";
            this.textTipoInmueble.Size = new System.Drawing.Size(290, 153);
            this.textTipoInmueble.TabIndex = 3;
            this.textTipoInmueble.TabStop = false;
            this.textTipoInmueble.Text = "Tipo De Inmuble";
            // 
            // textoPisoNro
            // 
            this.textoPisoNro.AutoSize = true;
            this.textoPisoNro.Location = new System.Drawing.Point(34, 81);
            this.textoPisoNro.Name = "textoPisoNro";
            this.textoPisoNro.Size = new System.Drawing.Size(47, 13);
            this.textoPisoNro.TabIndex = 5;
            this.textoPisoNro.Text = "Piso Nro";
            // 
            // ventanas
            // 
            this.ventanas.Location = new System.Drawing.Point(190, 100);
            this.ventanas.Name = "ventanas";
            this.ventanas.ShortcutsEnabled = false;
            this.ventanas.Size = new System.Drawing.Size(51, 20);
            this.ventanas.TabIndex = 4;
            // 
            // pisos
            // 
            this.pisos.Location = new System.Drawing.Point(34, 100);
            this.pisos.Name = "pisos";
            this.pisos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pisos.Size = new System.Drawing.Size(42, 20);
            this.pisos.TabIndex = 3;
            // 
            // textoNrodeVentanas
            // 
            this.textoNrodeVentanas.AutoSize = true;
            this.textoNrodeVentanas.Location = new System.Drawing.Point(176, 81);
            this.textoNrodeVentanas.Name = "textoNrodeVentanas";
            this.textoNrodeVentanas.Size = new System.Drawing.Size(87, 13);
            this.textoNrodeVentanas.TabIndex = 10;
            this.textoNrodeVentanas.Text = "Nro de Ventanas";
            // 
            // textoDireccion
            // 
            this.textoDireccion.AutoSize = true;
            this.textoDireccion.Location = new System.Drawing.Point(9, 180);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(52, 13);
            this.textoDireccion.TabIndex = 5;
            this.textoDireccion.Text = "Dirección";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(12, 196);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(290, 20);
            this.direccion.TabIndex = 6;
            // 
            // superficie
            // 
            this.superficie.Location = new System.Drawing.Point(12, 279);
            this.superficie.Name = "superficie";
            this.superficie.Size = new System.Drawing.Size(54, 20);
            this.superficie.TabIndex = 7;
            // 
            // antiguedad
            // 
            this.antiguedad.Location = new System.Drawing.Point(135, 279);
            this.antiguedad.Name = "antiguedad";
            this.antiguedad.Size = new System.Drawing.Size(28, 20);
            this.antiguedad.TabIndex = 8;
            // 
            // precioBase
            // 
            this.precioBase.Location = new System.Drawing.Point(241, 279);
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(61, 20);
            this.precioBase.TabIndex = 9;
            // 
            // textoSuperficie
            // 
            this.textoSuperficie.AutoSize = true;
            this.textoSuperficie.Location = new System.Drawing.Point(12, 260);
            this.textoSuperficie.Name = "textoSuperficie";
            this.textoSuperficie.Size = new System.Drawing.Size(54, 13);
            this.textoSuperficie.TabIndex = 11;
            this.textoSuperficie.Text = "Superficie";
            // 
            // textoAntiguedad
            // 
            this.textoAntiguedad.AutoSize = true;
            this.textoAntiguedad.Location = new System.Drawing.Point(132, 260);
            this.textoAntiguedad.Name = "textoAntiguedad";
            this.textoAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.textoAntiguedad.TabIndex = 12;
            this.textoAntiguedad.Text = "Antiguedad";
            // 
            // textoPrecioBase
            // 
            this.textoPrecioBase.AutoSize = true;
            this.textoPrecioBase.Location = new System.Drawing.Point(238, 260);
            this.textoPrecioBase.Name = "textoPrecioBase";
            this.textoPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.textoPrecioBase.TabIndex = 13;
            this.textoPrecioBase.Text = "Precio Base";
            // 
            // textoM2
            // 
            this.textoM2.AutoSize = true;
            this.textoM2.Location = new System.Drawing.Point(72, 282);
            this.textoM2.Name = "textoM2";
            this.textoM2.Size = new System.Drawing.Size(27, 13);
            this.textoM2.TabIndex = 14;
            this.textoM2.Text = "(m2)";
            // 
            // textoanios
            // 
            this.textoanios.AutoSize = true;
            this.textoanios.Location = new System.Drawing.Point(169, 282);
            this.textoanios.Name = "textoanios";
            this.textoanios.Size = new System.Drawing.Size(36, 13);
            this.textoanios.TabIndex = 15;
            this.textoanios.Text = "(años)";
            // 
            // texoCalcularPrecioFinal
            // 
            this.texoCalcularPrecioFinal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.texoCalcularPrecioFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.texoCalcularPrecioFinal.Location = new System.Drawing.Point(12, 322);
            this.texoCalcularPrecioFinal.Name = "texoCalcularPrecioFinal";
            this.texoCalcularPrecioFinal.Size = new System.Drawing.Size(290, 46);
            this.texoCalcularPrecioFinal.TabIndex = 16;
            this.texoCalcularPrecioFinal.Text = "Calcular Precio Final";
            this.texoCalcularPrecioFinal.UseCompatibleTextRendering = true;
            this.texoCalcularPrecioFinal.UseVisualStyleBackColor = false;
            this.texoCalcularPrecioFinal.Click += new System.EventHandler(this.texoCalcularPrecioFinal_Click);
            // 
            // textoPrecioFinal
            // 
            this.textoPrecioFinal.AutoSize = true;
            this.textoPrecioFinal.Location = new System.Drawing.Point(15, 375);
            this.textoPrecioFinal.Name = "textoPrecioFinal";
            this.textoPrecioFinal.Size = new System.Drawing.Size(0, 13);
            this.textoPrecioFinal.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(314, 422);
            this.Controls.Add(this.textoPrecioFinal);
            this.Controls.Add(this.texoCalcularPrecioFinal);
            this.Controls.Add(this.textoanios);
            this.Controls.Add(this.textoM2);
            this.Controls.Add(this.textoPrecioBase);
            this.Controls.Add(this.textoAntiguedad);
            this.Controls.Add(this.textoSuperficie);
            this.Controls.Add(this.precioBase);
            this.Controls.Add(this.antiguedad);
            this.Controls.Add(this.superficie);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.textoDireccion);
            this.Controls.Add(this.textTipoInmueble);
            this.Name = "Form1";
            this.Text = "Form1";
            this.textTipoInmueble.ResumeLayout(false);
            this.textTipoInmueble.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void botonPiso_CheckedChanged(object sender, EventArgs e)
        {
            pisos.Visible = true;
            superficie.Visible = false;
            ventanas.Visible = false;
            
            
        }

        private void botonLocal_CheckedChanged(object sender, EventArgs e)
        {
            ventanas.Visible = true;
            superficie.Visible = true;
            pisos.Visible = false;
           
        }

        private void texoCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (botonPiso.Checked)
                {

                    int antigueda = Convert.ToInt32(antiguedad.Text);
                    int nroPiso = Convert.ToInt32(pisos.Text);
                    int preBase = Convert.ToInt32(precioBase.Text);
                    String direc = direccion.Text;

                    Piso piso1 = new Piso(preBase, antigueda, nroPiso, direc);


                    textoPrecioFinal.Text = "El precio final del Piso es: $" + piso1.calcularPrecioFinalPiso() + "\nCon direccion en " + piso1.Direccion;

                }
            }
            catch (Exception)
            {
                textoPrecioFinal.Text = "Error inesperado. \nVerifique llenar todos los datos de manera correcta.";
            }
          

            try
            {
                if (botonLocal.Checked)
                {
                    int antigueda = Convert.ToInt32(antiguedad.Text);
                    int preBase = Convert.ToInt32(precioBase.Text);
                    int metros = Convert.ToInt32(superficie.Text);
                    int vent = Convert.ToInt32(ventanas.Text);
                    String direc = direccion.Text;

                    Local local1 = new Local(preBase, antigueda, metros, vent, direc);

                    textoPrecioFinal.Text = "El precio final del Local es: $" + local1.calcularPrecioFinalLocal() + "\nCon direccion en " + local1.Direccion;

                }
            }
            catch (Exception)
            {
               textoPrecioFinal.Text = "Error inesperado. \nVerifique llenar todos los datos de manera correcta.";
            }
        }

      
    }
}
