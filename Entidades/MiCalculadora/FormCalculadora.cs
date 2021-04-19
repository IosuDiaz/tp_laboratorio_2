using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Biblioteca;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {

            InitializeComponent();

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Al presionar el boton Limpiar, se limpian las cajas de texto y el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();

        }

        /// <summary>
        /// Borra las cajas de texto y el resultado.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.ResetText();
        }

        /// <summary>
        /// Realiza la operacion entre los dos numeros pasados por parametros.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            if(operador == "")
            {
                operador = " ";
            }

            return Calculadora.Operar(n1, n2, operador);
        }

        /// <summary>
        /// Al presionar el boton Operar, se calcula la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = FormCalculadora.Operar(this.txtNumero1.Text,
                                                            this.txtNumero2.Text,
                                                            this.cmbOperador.Text).ToString();
        }

        /// <summary>
        /// Al presionar el boton de cerrar se despliega un mensaje preguntando si esta seguro
        /// de cerrar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro?", "Cerrando",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte a binario el numero del resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "" && this.lblResultado.Text != "Valor invalido")
            {
                Numero resultado = new Numero();

                this.lblResultado.Text = resultado.DecimalBinario(this.lblResultado.Text);
            }
        }
        /// <summary>
        /// Convierte a decimal el numero del resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "" && this.lblResultado.Text != "Valor invalido")
            {
                Numero resultado = new Numero();

                this.lblResultado.Text = resultado.BinarioDecimal(this.lblResultado.Text);
            }
        }
    }
}
