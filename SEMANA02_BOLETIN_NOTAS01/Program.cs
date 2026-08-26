using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA02_BOLETIN_NOTAS01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************");
            Console.WriteLine("\t SISTEMA DE NOTAS");
            Console.WriteLine("************");
            float suma_notas, cantidad_materias, nota_max, nota_min, nota, promedio;
            string materia_mayor, materia_menor, reporte_notas, continuar;
            promedio = 0;
            nota = 0;
            suma_notas = 0;
            cantidad_materias = 0;
            nota_max = -1;
            nota_min = 21;
            materia_mayor = "";
            materia_menor = "";
            reporte_notas = "";
            continuar = "s";
            while (continuar.ToLower() == "s")
            {
                Console.WriteLine("Materias: " + (cantidad_materias + 1));
                Console.WriteLine("ingresar nombre de materia: ");
                string materia = Console.ReadLine();
                Console.WriteLine("Ingresar nota[0-20]: ");
                nota = float.Parse(Console.ReadLine());
                if (nota < 0 || nota > 20 || materia == "")
                {
                    Console.WriteLine("ERROR: La nota debe estar entre 0 y 20, y la materia no puede ser vacia...");
                }
                else
                {
                    suma_notas += nota;
                    cantidad_materias = cantidad_materias + 1;
                    reporte_notas = reporte_notas + $"*{materia}:{nota}\n";
                    if (nota > nota_max)
                    {
                        nota_max = nota;
                        materia_mayor = materia;
                    }
                    if (nota < nota_min)
                    {
                        nota_min = nota;
                        materia_menor = materia;
                        Console.WriteLine("Materia registrada exitosamente...!!");
                    }
                    Console.WriteLine("¿Deseas continuar?...(s/n)");
                    continuar = Console.ReadLine();
                }
            }
            Console.WriteLine("**********");
            Console.WriteLine("\t\tBOLETIN DE NOTAS");
            Console.WriteLine("**********");
            if (cantidad_materias > 0)
            {
                promedio = suma_notas / cantidad_materias;
                Console.WriteLine("reporte de notas: " + reporte_notas);
                Console.WriteLine("Materias evaluadas:" + cantidad_materias);
                Console.WriteLine("Promedio General: " + promedio);
                Console.WriteLine("Nota Maxima: " + materia_mayor + " " + nota_max);
                Console.WriteLine("Nota Minima: " + materia_menor + " " + nota_min);
                if (promedio >= 13)
                {
                    Console.WriteLine("Condición academica: APROBADO");
                }
                else if (promedio >= 10.5)
                {
                    Console.WriteLine("Condicion academica: RECUPERACION");
                }
                else
                {
                    Console.WriteLine("Condicion academica: DESAPROBADO");
                }
            }
            else
            {
                Console.WriteLine("No registro materia");
            }
            Console.ReadKey();
        }
    }
}
