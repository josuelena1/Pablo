using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace CODIGO_FINA_PROYECTO_ENCRIPTADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] inv = { { "frijoles", "1.80", "10", "01" }, { "arroz", "0.85", "15", "02" }, { "salsas", "1.50", "12", "03" }, { "yogurts", "0.75", "50", "04" }, { "eneregizante", "1.00", "60", "05" }, { "cerveza", "1.00", "225", "06" }, { "cigarros", "1.75", "40", "07" }, { "platanos", "0.50", "50", "08" }, { "gatorade", "1.25", "25", "09" }, { "pan", "0.25", "200", "10" } };
            string usuario, respuesta = null, respuesta2 = null;
            double prod = 0, prod2 = 0, prod3 = 0, prod4 = 0, prod5 = 0, prod6 = 0, prod7 = 0, prod8 = 0, prod9 = 0, prod10 = 0, contador = 0;
            double codproducto = 0, menu = 0;
            double resta = 0;
            double cantidad = 0;
            double resta2 = 0;
            int cantidad2 = 0;
            double resta3 = 0;
            int cantidad3 = 0;
            double resta4 = 0;
            int cantidad4 = 0;
            double resta5 = 0;
            int cantidad5 = 0;
            double resta6 = 0;
            int cantidad6 = 0;
            double resta7 = 0;
            int cantidad7 = 0;
            double resta8 = 0;
            int cantidad8 = 0;
            double resta9 = 0;
            int cantidad9 = 0;
            double resta10 = 0;
            int cantidad10 = 0;
            int inventario = 2;
            const double frijoles = 10;
            const double arroz = 15;
            const double salsas = 12;
            const double yogurts = 50;
            const double energizante = 60;
            const double cerveza = 225;
            const double cigarros = 40;
            const double platanos = 50;
            const double gatorade = 25;
            const double pan = 200;
            Console.WriteLine("\t  ===================================================================================");
            Console.WriteLine("\t  ||                                    User                                       ||");
            Console.WriteLine("\t  ===================================================================================");
            usuario = (Console.ReadLine());
            Console.WriteLine("\t  ===================================================================================");
            Console.WriteLine("\t  ||                                  Password                                     ||");
            Console.WriteLine("\t  ===================================================================================");
            string passInUser = Console.ReadLine();
            int i;
            string passFileTxt = "0192023a7bbd73250516f069df18b500";
            string passFileTxt1 = "53dc6bd2e5d7eee211fefe431727be36";
            string passFileTxt2 = "ba1375daa7ad2de234b85b8d5f5f2b1d";
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(passInUser));
            for (i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            passInUser = sb.ToString();                  

            if ((usuario == "admin" && passInUser.Equals(passFileTxt)) || (usuario == "invitado" && passInUser.Equals(passFileTxt1)) || (usuario == "colaborador" && passInUser.Equals(passFileTxt2)))

            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t================¿A QUE MENU DESA INGRESAR?=====================");
                    Console.WriteLine("\t||_________________codigo: 01----inventario__________________||");
                    Console.WriteLine("\t===============================================================");
                    Console.WriteLine("\t||_________________codigo: 02----ventas______________________||");
                    Console.WriteLine("\t===============================================================");
                    menu = double.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO FRIJOLES");
                            Console.WriteLine("\t||_________________________PRECIO: 1 LB '$1.80'");
                            Console.WriteLine("\t||_________________________habia un total de " + frijoles + "LB");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta + " lb de frijoles");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO ARROZ");
                            Console.WriteLine("\t||_____________________________PRECIO: 1 LB '$0.85'");
                            Console.WriteLine("\t||_________________________habia un total de " + arroz + "LB");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta2 + " lb de arroz");
                            Console.WriteLine("\t============================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO SALSA");
                            Console.WriteLine("\t||_________________________PRECIIO: 1 UNIDAD '$1.50'");
                            Console.WriteLine("\t||_________________________habia un total de " + salsas + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta3 + " unidad de salsas");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO YOGURTS");
                            Console.WriteLine("\t||_________________________PRECIO: 1 UNIDAD '$0.75'");
                            Console.WriteLine("\t||_________________________habia un total de " + yogurts + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta4 + " unidad de yogurts ");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO ENERGIZANTE");
                            Console.WriteLine("\t||_________________________PRECIO: 1 UNIDAD '$1.00'");
                            Console.WriteLine("\t||_________________________habia un total de " + energizante + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta5 + " unidad de energizante");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO CERVEZA");
                            Console.WriteLine("\t||_________________________PRECIO: 1 UNIDAD '$1.00'");
                            Console.WriteLine("\t||_________________________habia un total de " + cerveza + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta6 + " unidad de cerveza");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO CIGARROS");
                            Console.WriteLine("\t||_________________________PRECIO: 1 UNIDAD '$1.75'");
                            Console.WriteLine("\t||_________________________habia un total de " + cigarros + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta7 + " personal de cigarros");
                            Console.WriteLine("\n\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO PLATANOS");
                            Console.WriteLine("\t||_________________________PRECIO: 1 UNIDAD '$0.50'");
                            Console.WriteLine("\t||_________________________habia un total de " + platanos + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta8 + " unidad de platanos");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO GATORADE");
                            Console.WriteLine("\t||_________________________PRECIO: 1 UNIDAD '$1.25'");
                            Console.WriteLine("\t||_________________________habia un total de " + gatorade + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta9 + " unidad de gatorade");
                            Console.WriteLine("\t===========================================================================================");

                            Console.WriteLine("\n\t===========================================================================================");
                            Console.WriteLine("\t||_________________________PRODUCTO PAN");
                            Console.WriteLine("\t||_________________________PRECIO: 1 PAQUETE '$0.25'");
                            Console.WriteLine("\t||_________________________habia un total de " + pan + "UND");
                            Console.WriteLine("\t||___________gracias a su compra, hay un total de " + resta10 + " unidad de pan");
                            Console.WriteLine("\t===========================================================================================");
                            Console.ReadKey();
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("\t============nuestros productos a la venta son:============");
                                Console.WriteLine("\t||_______________codigo: 01----Frijoles_________________||");
                                Console.WriteLine("\t||_______________codigo: 02----arroz____________________||");
                                Console.WriteLine("\t||_______________codigo: 03----salsas___________________||");
                                Console.WriteLine("\t||_______________codigo: 04----yogurts__________________||");
                                Console.WriteLine("\t||_______________codigo: 05----energizantes_____________||");
                                Console.WriteLine("\t||_______________codigo: 06----cerveza__________________||");
                                Console.WriteLine("\t||_______________codigo: 07----cigarros_________________||");
                                Console.WriteLine("\t||_______________codigo: 08----platanos_________________||");
                                Console.WriteLine("\t||_______________codigo: 09----getorade_________________||");
                                Console.WriteLine("\t||_______________codigo: 10----pan______________________||");
                                Console.WriteLine("\t==========================================================");
                                codproducto = int.Parse(Console.ReadLine());
                                Console.Clear();
                                switch (codproducto)
                                {
                                    case 1:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||_________________________PRODUCTO FRIJOLES");
                                        Console.WriteLine("\t||_________________________PRECIO: 1LB '$1.80'");
                                        Console.WriteLine("\n\t||___________________Hay un total de " + frijoles + " LB de frijoles");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta + "LB");
                                        Console.WriteLine("\t||_____________cuantas libras de frijoles desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad = double.Parse(Console.ReadLine());
                                        prod = 1.80 * cantidad;
                                        contador = contador + prod;
                                        resta = frijoles - cantidad;
                                        inv[0, inventario] = resta.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 2:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||_________________________PRODUCTO ARROZ");
                                        Console.WriteLine("\t||_________________________PRECIO: 1LB '$0.85'");
                                        Console.WriteLine("\n\t||___________________Hay un total de " + arroz + " lb de arroz");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta2 + "LB");
                                        Console.WriteLine("\t||_____________cuantas libras de arroz desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad2 = int.Parse(Console.ReadLine());
                                        prod2 = 0.85 * cantidad2;
                                        contador = contador + prod2;
                                        resta2 = arroz - cantidad;
                                        inv[0, inventario] = resta2.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 3:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||____________________________PRODUCTO SALSAS");
                                        Console.WriteLine("\t||________________________PRECIO DE UNIDAD: '$1.50'");
                                        Console.WriteLine("\n\t||_____________Hay un total de " + salsas + "unidad de salsas");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta3 + "LB");
                                        Console.WriteLine("\t||_____________cuantas unidades de salsas desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad3 = int.Parse(Console.ReadLine());
                                        prod3 = 1.50 * cantidad3;
                                        contador = contador + prod3;
                                        resta3 = salsas - cantidad3;
                                        inv[0, inventario] = resta3.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 4:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||____________________________PRODUCTO YOGURTS");
                                        Console.WriteLine("\t||_______________________PRECIO DE UNIDAD: '$0.75'");
                                        Console.WriteLine("\n\t||___________Hay un total de " + yogurts + "unidad de yogurts");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta4 + "LB");
                                        Console.WriteLine("\t||_____________cuantas unidades de yogurts desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad4 = int.Parse(Console.ReadLine());
                                        prod4 = 0.75 * cantidad4;
                                        contador = contador + prod4;
                                        resta4 = yogurts - cantidad4;
                                        inv[0, inventario] = resta4.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 5:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||_____________________________PRODUCTO ENERGIZANTE");
                                        Console.WriteLine("\t||___________________________PRECIO DE UNIDAD: '$1.00'");
                                        Console.WriteLine("\n\t||_____________Hay un total de " + energizante + "unidad de energizante");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta5 + "LB");
                                        Console.WriteLine("\t||_____________cuantas unidades de energizante desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad5 = int.Parse(Console.ReadLine());
                                        prod5 = 1.00 * cantidad5;
                                        contador = contador + prod5;
                                        resta5 = energizante - cantidad5;
                                        inv[0, inventario] = resta5.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 6:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||_____________________________PRODUCTO CERVEZA");
                                        Console.WriteLine("\t||_________________________PRECIO DE PERSONAL: '$1.00'");
                                        Console.WriteLine("\n\t||_______________Hay un total de " + cerveza + "unidades de cervezas");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta6 + "LB");
                                        Console.WriteLine("\t||_____________cuantas cajas de cervezas desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad6 = int.Parse(Console.ReadLine());
                                        prod6 = 1.00 * cantidad6;
                                        contador = contador + prod6;
                                        resta6 = cerveza - cantidad6;
                                        inv[0, inventario] = resta6.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 7:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||______________________________PRODUCTO CIGARROS");
                                        Console.WriteLine("\t||_________________________PECIO DE UNIDAD: '$1.75'");
                                        Console.WriteLine("\n\t||__________________Hay un total de " + cigarros + "unidades de cigarros");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta7 + "LB");
                                        Console.WriteLine("\t||_____________cuantos cigarros desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad7 = int.Parse(Console.ReadLine());
                                        prod7 = 1.75 * cantidad7;
                                        contador = contador + prod7;
                                        resta7 = cigarros - cantidad7;
                                        inv[0, inventario] = resta7.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 8:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t|_______________________________PRODUCTO PLATANOS");
                                        Console.WriteLine("\t||__________________________PRECIO DE UNIDAD: '$0.50'");
                                        Console.WriteLine("\n\t||_____________________Hay un total de " + platanos + "unidades de platanos");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta8 + "LB");
                                        Console.WriteLine("\n\t||________________cuantos platanos desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad8 = int.Parse(Console.ReadLine());
                                        prod8 = 0.50 * cantidad8;
                                        contador = contador + prod8;
                                        resta8 = platanos - cantidad8;
                                        inv[0, inventario] = resta8.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;

                                    case 9:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||________________________________PRODUCTO GATORADE");
                                        Console.WriteLine("\t||___________________________PRECIO DE UNIDAD: '$1.25'");
                                        Console.WriteLine("\n\t||________________Hay un total de " + gatorade + "unidades de gatorade");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta9 + "LB");
                                        Console.WriteLine("\t||________________cuantos getorade desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad9 = int.Parse(Console.ReadLine());
                                        prod9 = 1.25 * cantidad9;
                                        contador = contador + prod9;
                                        resta9 = gatorade - cantidad9;
                                        inv[0, inventario] = resta9.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;
                                    case 10:
                                        Console.WriteLine("\t===================================================================");
                                        Console.WriteLine("\t||_________________________________PRODUCTO PAN");
                                        Console.WriteLine("\t||_____________________________PRECIO DE PAQUETE: '$0.25'");
                                        Console.WriteLine("\n\t||_________________Hay un total de " + pan + "paquete de pan");
                                        Console.WriteLine("\t||_____________gracias a su compra, hay un total de " + resta10 + "LB");
                                        Console.WriteLine("\t||__________________cuantos paquetes de pan desea comprar?");
                                        Console.WriteLine("\t===================================================================");
                                        cantidad10 = int.Parse(Console.ReadLine());
                                        prod10 = 0.25 * cantidad10;
                                        contador = contador + prod10;
                                        resta10 = pan - cantidad10;
                                        inv[0, inventario] = resta10.
                                        ToString();

                                        Console.WriteLine("\tExistencias: " + inv[0, inventario]);
                                        Console.Clear();
                                        break;
                                }
                                Console.WriteLine("\t========================================================================================");
                                Console.WriteLine("\t||           digite 'Si' para regresar al menu ó 'No' para resivir su ticket          ||");
                                Console.WriteLine("\t========================================================================================");
                                respuesta = (Console.ReadLine());
                                Console.Clear();
                            } while (respuesta == "si");
                            double total = prod + prod2 + prod3 + prod4 + prod5 + prod6 + prod7 + prod8 + prod9 + prod10;
                            Console.WriteLine("\t=========================TICKET====================");
                            Console.WriteLine("\t||                     condigo: 01");
                            Console.WriteLine("\t||           descripcion: " + cantidad + " LB de frijoles.");
                            Console.WriteLine("\t||                     precio: $" + prod);
                            Console.WriteLine("\t||                     existencia: " + resta);
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||                    condigo: 02 ");
                            Console.WriteLine("\t||          descripcion: " + cantidad2 + " LB de arroz.");
                            Console.WriteLine("\t||                     precio: $" + prod2);
                            Console.WriteLine("\t||                     existencia: " + resta2);
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||                    condigo: 03 ");
                            Console.WriteLine("\t||          descripcion: " + cantidad3 + " LB de salsas.");
                            Console.WriteLine("\t||                     precio: $" + prod3);
                            Console.WriteLine("\t||                     existencia: " + resta3);
                            Console.WriteLine("\t||                    condigo: 04");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad4 + " LB de yogurts.");
                            Console.WriteLine("\t||                     precio: $" + prod4);
                            Console.WriteLine("\t||                     existencia: " + resta4);
                            Console.WriteLine("\t||                    condigo: 05 ");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad5 + " LB de energisantes.");
                            Console.WriteLine("\t||                     precio: $" + prod5);
                            Console.WriteLine("\t||                     existencia: " + resta5);
                            Console.WriteLine("\t||                    condigo: 06");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad6 + " LB de cervezas.");
                            Console.WriteLine("\t||                     precio: $" + prod6);
                            Console.WriteLine("\t||                     existencia: " + resta6);
                            Console.WriteLine("\t||                    condigo: 07 ");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad7 + " LB de cigarros.");
                            Console.WriteLine("\t||                     precio: $" + prod7);
                            Console.WriteLine("\t||                     existencia: " + resta7);
                            Console.WriteLine("\t||                    condigo: 08");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad8 + " LB de platanos.");
                            Console.WriteLine("\t||                     precio: $" + prod8);
                            Console.WriteLine("\t||                     existencia: " + resta8);
                            Console.WriteLine("\t||                    condigo: 09");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad9 + " LB de gatorade.");
                            Console.WriteLine("\t||                     precio: $" + prod9);
                            Console.WriteLine("\t||                     existencia: " + resta9);
                            Console.WriteLine("\t||                    condigo: 10");
                            Console.WriteLine("\t---------------------------------------------------");
                            Console.WriteLine("\t||          descripcion: " + cantidad10 + " LB de pan.");
                            Console.WriteLine("\t||                     precio: $" + prod10);
                            Console.WriteLine("\t||                     existencia: " + resta10);
                            Console.WriteLine("\n\t======================================================");
                            Console.WriteLine("\t||        todal a pagar:" + total);
                            Console.WriteLine("\t========================================================");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("\t========================================================================================");
                    Console.WriteLine("\t||           digite 'Si' para regresar al menu ó 'No' para salir del programa         ||");
                    Console.WriteLine("\t========================================================================================");
                    respuesta2 = (Console.ReadLine());
                    Console.Clear();
                } while (respuesta2 == "si" || respuesta2 == "SI");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\t  ====================================================================================");
                Console.WriteLine("\t  ||                                User Incorrecto                                 ||");
                Console.WriteLine("\t  ====================================================================================");
                Console.WriteLine("\t  ====================================================================================");
                Console.WriteLine("\t  ||                           Password Incorrecta                                  ||");
                Console.WriteLine("\t  ====================================================================================");
            }
            Console.ReadKey();
        }
    }
}
