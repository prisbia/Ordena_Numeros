using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordena_Numero_1
{
    class Program
    {
        static void Main(string[] args)
        {
            cMetodos tarea = new cMetodos();
            tarea.Oracion();

            Console.WriteLine("Cuantos numeros desea Ordenar -> \r");
            int cantidad = int.Parse(Console.ReadLine());
            
            int suma = tarea.CargaValores(cantidad);
            int iteraciones = tarea.SumaCantidad(suma);
            tarea.Ordena(iteraciones, cantidad);

            Console.ReadKey();
        }

        //#########################################

        class cMetodos
        {

        int[] cargamatriz;
        int[] posiciones;

            public int CargaValores(int cant)
            {
                int a = 0;
                
                cargamatriz = new int[cant];
                posiciones  = new int[cant];
                Console.WriteLine("Ingrese los Numeros -> ");

                for (int j=0; j<cant; j++)
                {
                    cargamatriz[j] = int.Parse(Console.ReadLine());
                    a = a + 1;
                }
                
                return a;
            }
            public int SumaCantidad (int numero)
            {
                int a = --numero;
                int b = --numero;
                int c = 0;

                while (b > 0)
                {
                    c = a + b + c;
                    b = b - 1;
                    a = 0;
                }
                Console.WriteLine("\nOrdenado queda : \n");

                return c;
            }

            public int Ordena(int numero, int matriz_cantidad)
            {
                int m = 0; //Los Mayores
                int iter = 0;
                
                while (numero >= 0)
                {
                    matriz_cantidad = matriz_cantidad - 1;

                    for (int j = 0; j <= matriz_cantidad; j++)
                    {

                        for (int i = 0; i <= matriz_cantidad; i++)
                        {
                            if (cargamatriz[j] > cargamatriz[i])
                            {
                                numero = numero - 1;
                                m = m + 1;
                                iter++;
                            }
                            else { numero = numero - 1; }
                        }

                        posiciones[m] = cargamatriz[j];
                        m = 0;
                        iter = iter + 1;
                    }
                }
                
                for (int f = 0; f <= matriz_cantidad ; f++)
                {
                    Console.WriteLine("{0}\t\t{1}", cargamatriz[f], posiciones[f]);

                }
                Console.WriteLine("\nFueron {0} iteraciones", iter);
                
                return numero;
            }

            public void Oracion()
            {
            Console.WriteLine("Ordenando Numeros ! ! !\n");
            }

        }
            
    }
}
