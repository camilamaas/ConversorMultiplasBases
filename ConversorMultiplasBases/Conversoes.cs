using System;
using System.Collections.Generic;

namespace ConversorMultiplasBases
{
    public class Conversoes

    {
        decimal resto = decimal.MaxValue;
        int divisor = 0;
        string result = string.Empty;
        List<int> listaValorConvertido = new List<int>();

        public string decimalParaBinario(string valorDecimal)
        {
            decimal dividendo = Convert.ToDecimal(valorDecimal);
            divisor = 2;
            limpaCampos();

            while (dividendo != 0)
            {
                resto = dividendo % divisor;
                dividendo = (int)dividendo / divisor;
                listaValorConvertido.Add(Convert.ToInt32(resto));
            }

            return inverteEMostra(listaValorConvertido);
        }

        public string decimalParaOctal(string valorDecimal)
        {
            decimal dividendo = Convert.ToDecimal(valorDecimal);
            divisor = 8;
            limpaCampos();

            while (dividendo >= divisor)
            {
                resto = dividendo % divisor;
                dividendo = (int)dividendo / divisor;

                listaValorConvertido.Add(Convert.ToInt32(resto));
            }

            listaValorConvertido.Add((int)Math.Floor((double)dividendo));

            return inverteEMostra(listaValorConvertido);
        }

        public string binarioParaDecimal(string valorBinario)
        {
            decimal dividendo = Convert.ToDecimal(valorBinario);
            limpaCampos();
            double valorDecimal = 0;
            string binarioInvertido = inverterString(valorBinario);

            for (int i = 0; i < binarioInvertido.Length; i++)
            {
                valorDecimal = valorDecimal + (Convert.ToInt32((binarioInvertido.Substring(i, 1))) * Math.Pow(2, i));
            }

            return valorDecimal + string.Empty;
        }

        public string binarioParaOctal(string valorBinario)
        {
            limpaCampos();
            return decimalParaOctal(binarioParaDecimal(valorBinario));
        }

        public string octalParaDecimal(string valorOctal)
        {
            decimal dividendo = Convert.ToDecimal(valorOctal);
            limpaCampos();

            double valorDecimal = 0;
            string octalInvertido = inverterString(valorOctal);

            for (int i = 0; i < octalInvertido.Length; i++)
            {
                valorDecimal = valorDecimal + (Convert.ToInt32((octalInvertido.Substring(i, 1))) * Math.Pow(8, i));
            }


            return valorDecimal + string.Empty;
        }

        public string octalParaBnario(string valorOctal)
        {
            limpaCampos();
            return decimalParaBinario(octalParaDecimal(valorOctal));
        }

        public string decimalParaHexadecimal(string valorDecimal)
        {
            limpaCampos();
            decimal dividendo = Convert.ToDecimal(valorDecimal);
            divisor = 16;
            listaValorConvertido.Clear();

            while (dividendo >= divisor)
            {
                resto = dividendo % divisor;
                dividendo = (int)dividendo / divisor;

                listaValorConvertido.Add(Convert.ToInt32(resto));
            }

            listaValorConvertido.Add((int)Math.Floor((double)dividendo));

            List<string> listaHexa = new List<string>();

            listaHexa = converterEmHexadecimal(listaValorConvertido);

            return inverteEMostra(listaHexa);
        }

        public string binarioParaHexadecimal(string valorBinario)
        {
            limpaCampos();
            return decimalParaHexadecimal(binarioParaDecimal(valorBinario));
        }

        public string octalParaHexadecimal(string valorOctal)
        {
            limpaCampos();
            return decimalParaHexadecimal(octalParaDecimal(valorOctal));
        }

        public string hexadecimalParaDecimal(string valorHexadecimal)
        {

            limpaCampos();
            valorHexadecimal = valorHexadecimal.ToUpper();
            valorHexadecimal = inverterString(valorHexadecimal);
            double valorDecimal = 0;
            int valorLetra = 0;

            for (int i = 0; i < valorHexadecimal.Length; i++)
            {
                valorLetra = encontrarValorLetra(valorHexadecimal.Substring(i, 1));
                valorDecimal = valorDecimal + (valorLetra*Math.Pow(16,i));
              
            }

            return valorDecimal + string.Empty;
        }

        public string hexadecimalParaBinario(string valorHexadecimal)
        {
            limpaCampos();
            return decimalParaBinario(hexadecimalParaDecimal(valorHexadecimal));
        }

        public string hexadecimalParaOctal(string valorHexadecimal)
        {
            limpaCampos();
            return decimalParaOctal(hexadecimalParaDecimal(valorHexadecimal));
        }

        private string inverterString(string Word)
        {
            char[] arrChar = Word.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;
        }

        private List<string> converterEmHexadecimal(List<int> valorDecimal)
        {

            List<string> listaHexa = new List<string>();

            foreach (int valor in valorDecimal)
            {
                if (valor == 10)
                {
                    listaHexa.Add("A");
                }
                else if (valor == 11)
                {
                    listaHexa.Add("B");
                }
                else if (valor == 12)
                {
                    listaHexa.Add("C");
                }
                else if (valor == 13)
                {
                    listaHexa.Add("D");
                }
                else if (valor == 14)
                {
                    listaHexa.Add("E");
                }
                else if (valor == 15)
                {
                    listaHexa.Add("F");
                }
                else
                {
                    listaHexa.Add(valor + string.Empty);
                }
            }

            return listaHexa;

        }

        private int encontrarValorLetra(string letra)
        {
            int valor;
            if (letra.Equals("A"))
            {
                valor = 10;
            }else if (letra.Equals("B"))
            {
                valor = 11;
            }else if (letra.Equals("C")){
                valor = 12;
            }else if (letra.Equals("D"))
            {
                valor = 13;
            }else if (letra.Equals("E"))
            {
                valor = 14;
            }else if (letra.Equals("F"))
            {
                valor = 15;
            }else
            {
                valor = Convert.ToInt32(letra);
            }
            return valor;
        }

        private string inverteEMostra(List<string> lista)
        {
            lista.Reverse();
            foreach (string valor in lista)
            {
                result = result + " " + valor;
            }
            return result;
        }

        private string inverteEMostra(List<int> lista)
        {
            lista.Reverse();
            foreach (int valor in lista)
            {
                result = result + " " + valor;
            }
            return result;
        }

        private void limpaCampos()
        {
            result = string.Empty;
            listaValorConvertido.Clear();
        }
    }
}
