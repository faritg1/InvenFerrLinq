using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvenFerrLinq.Methods;
public class Menu
{
    public void MenuMain(){
        int op = 0;
        bool entrando = true;
        FunctionEntitie entitie = new FunctionEntitie();
        do
        {
            try{
                
                Console.WriteLine("|------------------------Ferreteria Dev Farit---------------------------|");
                Console.WriteLine("|      1. LISTAR LOS PRODUCTOS DEL INVENTARIO                           |");
                Console.WriteLine("|      2. LISTAR LOS PRODUCTOS QUE ESTAN A PUNTO DE AGOTARSE            |");
                Console.WriteLine("|      3. LISTAR LOS PRODUCTOS QUE SE DEBEN COMPRAR                     |");
                Console.WriteLine("|      4. LISTAR EL TOTAL DE FACTURAS DEL MES DE ENERO DEL 2023         |");
                Console.WriteLine("|      5. LISTAR LOS PRODUCTOS VENDIDOS EN UNA DETERMINADA FACTURA      |");
                Console.WriteLine("|      6. CALCULAR EL VALOR TOTAL DEL INVENTARIO                        |");
                Console.WriteLine("|      0. Salir                                                         |");
                Console.WriteLine("|-----------------------------------------------------------------------|");
                Console.Write("--> ");
                op = int.Parse(Console.ReadLine());;

                switch (op){
                case 0:
                    Console.Clear();
                    Console.WriteLine("|--------------------------------------|");
                    Console.WriteLine("|    Gracias por usar este programa    |");
                    Console.WriteLine("|--------------------------------------|");
                    entrando = false;
                break;
                case 1:
                    entitie.Pregunta1();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 2:
                    entitie.Pregunta2();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 3:
                    entitie.Pregunta3();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 4:
                    entitie.Pregunta4();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 5:
                    entitie.Pregunta5();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 6:
                    entitie.Pregunta6();
                    Console.ReadKey();
                    Console.Clear();
                break;
                default:
                    Console.WriteLine("Te Saliste del RANGO");
                    Thread.Sleep(2000);
                    Console.Clear();
                break;
                }
            }
            catch (Exception ex){
                Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
                Thread.Sleep(2000);
                Console.Clear();
            }
        } while (entrando);
    }
}
