using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConversorNumeroRomano.Teste
{
    public class NumeroRomano
    {
        private string romano;
        private int numero;
        public readonly static Dictionary<string, string> 
            base1 = new Dictionary<string, string>()
        {
            {"I", "1"},
            {"X", "10"},
            {"C", "100"},
            {"M", "1000"},

            {"1", "I"},
            {"10", "X"},
            {"100", "C"},
            {"1000", "M"}
        };

        public readonly static Dictionary<string, string> 
            base5 = new Dictionary<string, string>()
        {
            {"V", "5" },
            {"L", "50"},
            {"D", "500"},

            {"5", "V" },
            {"50", "L" },
            {"500", "D" }
        };
        public NumeroRomano(string numero)
        {
            this.romano = numero;
            ConverterRomanoDecimal();
            
        }
        public NumeroRomano(int numero)
        {
            this.numero = numero;
            ConverterDecimalRomano();
        }
        private void ConverterDecimalRomano()
        {
            string resultado = "";

            string temp = "";
            int casadecimal = romano.Length;
            for (int i = 0; i < romano.Length; i++)
            {
                casadecimal--;

                if (romano[i] == '4')
                {
                    resultado += base1[Math.Pow(10, casadecimal - 1).ToString()] + 
                        base5[Math.Pow(10, casadecimal).ToString()];
                }
                else if (romano[i] == '9')
                {
                    resultado += base1["2"] + base5["3"];
                }
            }
        }
        private void ConverterRomanoDecimal()
        {
            
        }
        public static int ConverterRomanoDecimal(string romano)
        {            
            return 2;
        }
        public static int ConverterDecimalRomano(string romano)
        {
            return 2;
            
        }
        public override string ToString()
        {            
            return romano;
        }

        public static bool NumeroValido(string numero)
        {
            return Regex.IsMatch(numero, "");
        }
        public static implicit operator NumeroRomano(int numero)
            => new NumeroRomano(numero);

        public static implicit operator string(NumeroRomano numero)
            => numero.romano;

        public static implicit operator int(NumeroRomano numero)
            => numero.numero;

        public static implicit operator NumeroRomano(string numero)
        {            
            if (int.TryParse(numero, out _))
            {
                return new NumeroRomano(numero);
            }
            else
                throw new ArgumentOutOfRangeException("O valor inserido contém caracteres" +
                    "inválidos");
        }
    }   
}
