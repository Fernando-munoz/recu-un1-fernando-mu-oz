using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.clases
{
    internal class alumno
    {

        public string Nombre { get; set; }

        public string edad { get; set; }
        public string apellido { get; set; }

        public void contacto()
        {


            Console.WriteLine("Nombre");

            Nombre = Console.ReadLine();

            Console.WriteLine("Apellido");

            edad = Console.ReadLine();

            Console.WriteLine(" edad ");

            apellido = Console.ReadLine();

        }
        public void imprimir()
        {
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.apellido);
            Console.WriteLine(this.edad);

        }

    }
}
