using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GUIA1_23082020PROGRA2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ALUMNO: KEVIN MIGUEL HENRIQUEZ PEREZ
             * CARRERA: LIC. EN COMPUTACIÓN
             * ASIGNATURA: PROGRAMACION II
             * CICLO 02-2020
             * GRUPO DE CLASE: 1
             * GUIA 1
             */
            //comentario

            expresionMate();
            expresionNumeroDos();

            Console.ReadKey();
        }

        //EJERCICIO 01
        public static void expresionMate()
        {
            Console.WriteLine("EJERCICIO 1.1 METODO 1\n\n");
            Console.WriteLine("ingrese la expresión");
            string expresion = Console.ReadLine().Trim(); //lee la expresion 
            int apertura = 0;
            int cierre = 0;
         
            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(') //evalua una expresion si solo hay una apertura pero sin cierre
                {
                    apertura++;
                }
          
                if (expresion[i] == ')')//evalua si tiene cierre y no apertura
                {
                    cierre++;
                }
            }
            if (apertura == cierre) //evalua si los parententesis de apertura es igual a los de cierre. en la expresion dada
            {
                Console.WriteLine("Expresion correcta");
            }
            else
            {
                Console.WriteLine("ERROR: Expresion no valida");
            }
        }

        //EJERCICIO 02
        public static void expresionNumeroDos()
        {
            Console.WriteLine("\n\nEJERCICIO 1.2 METODO 2\n\n");
            Console.WriteLine("ingrese la expresión");
            string expresion = Console.ReadLine().Trim(); //lee la expresion 
            int apertura = 0;
            int cierre = 0;
            bool operacionBasic = true;
            bool operacionBasicDos = true;
             
            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(') //evalua una expresion si solo hay una apertura pero sin cierre
                {
                    apertura++;
                    operacionBasic = false;
                }
                if (expresion[i] - 1 == '+' + ')' || expresion[i] - 1 == '-' + ')' || expresion[i] - 1 == '*' + ')' || expresion[i] - 1 == '/' + ')' || expresion[i] - 1 == '^' + ')')
                {
                    
                    operacionBasic = true;
                    
                }
                if (expresion[i] == ')')//evalua si tiene cierre y no apertura
                {
                    cierre++;
                    operacionBasicDos = false;
                }
                if (expresion[i] - 1 == '(' + '+' || expresion[i] - 1 == '(' + '-' || expresion[i] - 1 == '(' + '-' || expresion[i] - 1 == '(' + '/' || expresion[i] - 1 == '(' + '^')
                {
                    operacionBasicDos = true;
                }

            }

            if ((apertura == cierre) && operacionBasic == false) //evalua si los parententesis de apertura es igual a los de cierre. en la expresion dada
            {
                Console.WriteLine("Expresion correcta");
                // return  resultado = true;
            }
            else
            {
                Console.WriteLine("ERROR: Expresion no valida");
            }
 
            if(operacionBasic || operacionBasicDos)
            {
                Console.WriteLine("ERROR: Hay un operador antes o despues del parentesis");
            }
            
        }
    }
}
