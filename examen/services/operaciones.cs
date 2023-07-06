using examen.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.services
{
    internal class operaciones
    {

        public void datos()
        {
            alumno alumn = new alumno();
            alumn.contacto();
            alumn.imprimir();
            operaciones sum = new operaciones();
            sum.Menu();


        }
        public void Menu()
        {


            Console.WriteLine("ingresa la opcion para operacion");
            Console.WriteLine("cambio de dolar 1");
            Console.WriteLine("areadeltriangulo 2");
            Console.WriteLine("Tecla 3 suma \n telca 4 Resta" );
            string op = Console.ReadLine();

            switch (op)
            {
                case "3":
                 
                    Console.WriteLine("Ingresa el primer numero  del prodcuto");
                    int producto1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero del producto");
                    int producto2 = int.Parse(Console.ReadLine());

                    int resulto = sume(producto1, producto2);

                    Console.WriteLine($"La suma es: {(resulto)}");
                    break;


                case "4":
                    Console.WriteLine("Ingresa el primer numero  del prodcuto");
                    int produc1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero del producto");
                    int produc2 = int.Parse(Console.ReadLine());
                    int resultado = rest (produc1,produc2); 
                   
                    Console.WriteLine($"\n la resta de sus numeros son  : {(resultado)}");
                    break;

                case "2":

                    Console.WriteLine("Ingresa la base");
                    int base1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la altura");
                    int altu2 = int.Parse(Console.ReadLine());

                    int res = bxa(base1, altu2);
                    int resa = base1 * altu2;
                    Console.WriteLine($"\n el resultado es    : {(resa)}");
                    break;

                case "1":

                    Console.WriteLine("cuantos dolares va cambiar?");
                    int dollar = int.Parse(Console.ReadLine());
                    Console.WriteLine("dolar a 16 ");

                    int cambio = dollares(dollar);
                   
                    Console.WriteLine($"\n el total es   : {(cambio)}");
                    break;

            }

            return;
        }

        public int sume(int prduct1, int product2)
        {

            return prduct1 + product2;
        }

        public int rest(int prduct1, int product2)
        {

            return prduct1 - product2;
        }
        public int dollares(int dollar)
        {

            return dollar * 16;
        }
        public int bxa(int base1, int altu2)
        {

            return base1 * altu2;
        }

    }
}