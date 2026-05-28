using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class NumericService
    {
        public NumericService()
        {
            valores = new int[5];
            contador = 0;
        }
        public int[] valores;
        public int contador;

        public void Registrar(int valor)
        {
            valores[contador] = valor;
            contador++;
        }

        public int VerContador()
        {
            return contador;
        }

        public int VerValor(int idx)
        {
            return valores[idx];
        }

        public double Promedio()
        {
            int acumulador = 0;

            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }
            double promedio;
            promedio =acumulador / contador;
            return promedio;
        }

        public int MostrarValores(int contador)
        {
            for (int i = 0; i <= contador; i++)
            {
                return valores[i];
            }
            return 0;
        }

    }
}
