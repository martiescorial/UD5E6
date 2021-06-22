using System;

namespace UD5E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                String texto = "Introduce un numero positivo";
                numero = Convert.ToInt32(texto);
            } while (numero > 0);
            int numCifras = cuentaCifras(numero);
           
            if (numCifras == 1)
            {
                Console.WriteLine("El numero " + numero + " tiene " + numCifras + " cifra");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " tiene " + numCifras + " cifras");
            }
        }
        public static int cuentaCifras(int numero)
        {
            int contador = 0;
            for (int i = numero; i > 0; i /= 10)
            {
               
                contador++;
            }
            return contador;
            
        }
    }
}
