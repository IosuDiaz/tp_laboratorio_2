using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Biblioteca
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador con el que se va a realizar la operacion aritmetica
        /// En caso de que no sea un operador valido, se retornara "+"
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = operador.ToString();

            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                retorno = "+";
            }

            return retorno;
        }

        /// <summary>
        /// Realiza la operacion entre los numeros pasados por parametros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            char operadorNoValidado;
            string operadorValidado;

            if (!(object.Equals(numero1, null)) && !(object.Equals(numero2, null)) && char.TryParse(operador, out operadorNoValidado))
            {

                operadorValidado = Calculadora.ValidarOperador(operadorNoValidado);

                switch (operadorValidado)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    case "/":
                        resultado = numero1 / numero2;
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        break;
                }
            }
            return resultado;
        }
    }
}
