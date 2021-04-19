using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Biblioteca
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto. Asigna cero al atributo de clase.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor parametrizado. Asgina el double pasado por parametro al atributo de clase.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor parametrizado. Asgina el string pasado por parametro mediante la propiedad SetNumero.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        
        public string SetNumero { set => numero = ValidarNumero(value); }

        /// <summary>
        /// Convierte el string pasado por parametro a double. Si no puede hacer la conversion, retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno;


            if (!(double.TryParse(strNumero, out retorno)))
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Verifica si el string pasado por parametro contiene solamente 0 y 1
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Convierte el string pasado por parametro en un numero decimal. Si no puede hacer la conversion
        /// retornara "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";

            if (this.EsBinario(binario))
            {
                retorno = Convert.ToString(Convert.ToInt32(binario, 2),10);
                
            }

            return retorno;
        }

        /// <summary>
        /// Convierte el double pasado por parametro en un numero binario. Si no puede hacer la conversion
        /// retornara "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            int valorAbsoluto = Convert.ToInt32(Math.Abs(numero));
            string numeroBinario = Convert.ToString(valorAbsoluto, 2);

            if (!(this.EsBinario(numeroBinario)))
            {
                numeroBinario = "Valor invalido";
            }

            return numeroBinario;
        }


        /// <summary>
        /// Convierte el string pasado por parametro en un numero binario. Si no puede hacer la conversion
        /// retornara "Valor invalido"
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public string DecimalBinario(string strNumero)
        {
            double numero = 0;
            string retorno = "Valor invalido";

            if(double.TryParse(strNumero, out numero))
            {
                retorno = this.DecimalBinario(numero);
            }

            return retorno;
        }


        /// <summary>
        /// Resta dos objetos de la clase Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static double operator -(Numero numero1,Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }

        /// <summary>
        /// Suma dos objetos de la clase Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        /// <summary>
        /// Multiplica dos objetos de la clase Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }

        /// <summary>
        /// Divide dos objetos de la clase Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public static double operator /(Numero numero1, Numero numero2)
        {
            double retorno = 0;

            if(numero2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = numero1.numero / numero2.numero;
            }

            return retorno;
        }

    }
}
