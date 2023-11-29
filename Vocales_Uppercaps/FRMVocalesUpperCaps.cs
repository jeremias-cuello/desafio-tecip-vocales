using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocales_Uppercaps
{
    public partial class FRMVocalesUpperCaps : Form
    {
        public FRMVocalesUpperCaps()
        {
            InitializeComponent();
        }

        private void RTXParrafo_In_TextChanged(object sender, EventArgs e)
        {
            ImprimirResultado();
            ImprimirCaracteresRestantes();

            if (RTXParrafo_In.Text == "")
            {
                ImprimirInstruccion();
            }
        }
        
        private void ImprimirResultado()
        {
            // Jeremias Cuello - 14/4/2022
            //
            // Resumen: 
            //      Imprime en RTXParrafo_Out RTXParrafo_In con sus vocales a mayuscula
            //      Imprime en LBLCantidad_Vocales la cantidad de vocales de RTXParrafo_Out

            RTXParrafo_Out.Text = RTXParrafo_In.Text.UppercapsVocales();
            LBLCantidad_Vocales.Text = String.Format("Cantidad de vocales del párrafo: {0:n0}", RTXParrafo_Out.Text.ContarVocales());
        }

        private void ImprimirCaracteresRestantes()
        {
            // Jeremias Cuello - 14/4/2022
            //
            // Resumen: 
            //      Imprime el tamanio de caracteres restantes de RTX_In
            
            LBLTamanioCaracteres.Text = String.Format("{0:n0}", RTXParrafo_In.MaxLength - RTXParrafo_In.TextLength);
        }

        private void ImprimirInstruccion()
        {
            // Jeremias Cuello - 14/4/2022
            //
            // Resumen: 
            //      Imprime la instruccion y asigna la cadena LBLTamanioCaracteres.Text a una cadena vacia

            LBLTamanioCaracteres.Text = "";
            RTXParrafo_Out.Text = "\n\n\n\n" + "                  Aquí aparecerá el párrafo introducido con" +
                                  "\n      " + "                       las vocales en mayúscula...";
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            // Jeremias Cuello - 14/4/2022
            //
            // Resumen: 
            //      Sale de la aplicacion

            Application.Exit();
        }
    }
}
