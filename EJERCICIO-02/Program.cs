using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    class Program
    {
        public static decimal[] salarioActual = new decimal[5];
        public static decimal[] salarioAnterior = new decimal[5];
        public static decimal[] sumaTotal = new decimal[salarioActual.Length];
        static decimal totalDosArray = 0;
        static decimal sumaSalarioactual = 0;
        static decimal sumaSalarioAnterior = 0;
        static decimal promedioSalaAnterior = 0;
        static decimal promedioSalactual = 0;
        static decimal promedioTotal = 0;

        static void Main(string[] args)
        {

            sueldosActuales();
            sumatotalSalarioactual();
            salarioPromedio();
            sueldosAnetrior();
            sumaTotalsalAnterior();
            mostrarTotal();
          
           // Console.WriteLine("Total de salario actual: {0}", sumaSalarioactual);
            Console.ReadKey();
        }
        //ingresar los 20 salarios actuales
        public static decimal[] sueldosActuales()
        {
            Console.WriteLine("Ingrese salario actual : \n");

            for (int i = 0; i < salarioActual.Length; i++)
            {
                Console.WriteLine("Salario {0} ",i + 1);
                salarioActual[i] = decimal.Parse(Console.ReadLine());
            }

            return salarioActual;
        }
        //suma de salario actuales
        public static void sumatotalSalarioactual()
        {
           for(int i=0; i<salarioActual.Length; i++)
            {
                sumaSalarioactual += salarioActual[i];
            } 
        }
        //salario promedio
        private static void salarioPromedio()
        {
            promedioSalactual = sumaSalarioactual / salarioActual.Length;
            promedioSalaAnterior = sumaSalarioAnterior / salarioAnterior.Length;
            promedioTotal = totalDosArray / salarioActual.Length;
        }
        //sueldo anterior
        public static decimal[] sueldosAnetrior()
        {
            Console.WriteLine("Ingrese salario anterior\n");

            for (int i = 0; i < salarioAnterior.Length; i++)
            {
                Console.WriteLine("Salario {0}:",i + 1);
                salarioAnterior[i] = decimal.Parse(Console.ReadLine());
            }
            return salarioActual;

        }
        //suma salarios anteriores
        public static void sumaTotalsalAnterior()
        {
            for (int i = 0; i < salarioAnterior.Length; i++)
            {
                sumaSalarioAnterior += salarioAnterior[i];
            }
        }
        //Método para mostrar los salarios
        public static void mostrarTotal()
        {
            Console.WriteLine("\nSALARIO ANTERIOR\t\t SALARIO ACTUAL \t\tTOTAL");

            for (int i = 0; i < salarioActual.Length; i++)
            {
                sumaTotal[i] = salarioActual [i] + salarioAnterior[i];
                totalDosArray += sumaTotal[i];
                Console.WriteLine(" {0}\t\t\t\t {1} \t\t\t\t {2} ", salarioAnterior[i], salarioActual[i], sumaTotal[i]);
            }
            Console.WriteLine("\ntotal: {0}\t\t\t {1}\t\t\t\t {2}", sumaSalarioAnterior, sumaSalarioactual, totalDosArray);

            Console.WriteLine("\nPromedios: {0}\t\t\t {1} \t\t\t{2}", promedioSalaAnterior, promedioSalactual, promedioTotal);
        }

    }
}
