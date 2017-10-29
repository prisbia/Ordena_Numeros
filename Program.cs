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
                Console.WriteLine("\nVan a ser {0} iteraciones.", c);

                return c;
            }
            public int Ordena(int numero, int matriz_cantidad)
            {
                Console.WriteLine("\n\nLas Iteraciones son {0} y la Matriz es por {1}\n\n",numero, matriz_cantidad);

                int m = 0; //Los Mayores
                int r = 0; //Los Menores
                int g = 0; //Iguales

                while (numero >= 0)
                {
                    int control = numero - 1;
                    matriz_cantidad = matriz_cantidad - 1;

                    for (int j = 0; j <= matriz_cantidad; j++)
                    {

                        for (int i = 0; i <= matriz_cantidad; i++)
                        {
                            if (cargamatriz[j] > cargamatriz[i])
                            {
                                Console.WriteLine("Posición {0} \tnúmero {1} \ty es \tM \ta \t{2}", j, cargamatriz[j], cargamatriz[i]);
                                numero = numero - 1;
                                m = m + 1;
                            }

                            if (cargamatriz[j] < cargamatriz[i])
                            {
                                Console.WriteLine("Posición {0} \tnúmero {1} \ty es \tR \ta \t{2}", j, cargamatriz[j], cargamatriz[i]);
                                numero = numero - 1;
                                r = r + 1;
                            }

                            if (cargamatriz[j] == cargamatriz[i])
                            {
                                Console.WriteLine("Posición {0} \tnúmero {1} \ty es \tG \ta \t{2}", j, cargamatriz[j], cargamatriz[i]);
                                numero = numero - 1;
                                g = g + 1;
                            }
                        }

                        posiciones[m] = cargamatriz[j];
                        Console.WriteLine("M = {0} \nR = {1} \nG = {2} En la posicion {3} Ordenado el --> {4}\n", m, r, g, m+g, posiciones[m]);
                        m = 0;
                        r = 0;
                        g = 0;
                    }

                }
                
                for (int f = 0; f <= matriz_cantidad ; f++)
                {
                    Console.WriteLine("{0}\t\t{1}", cargamatriz[f], posiciones[f]);

                }
                


                return numero;
            }

            public void Oracion()
            {
            Console.WriteLine("Ordenando Numeros ! ! !\n");
            }

        }
            
    }
}
