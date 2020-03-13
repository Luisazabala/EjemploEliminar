using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEliminar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();

            listaPersonas.Add(new Persona("Martin", 56));
            listaPersonas.Add(new Persona("Olmeiro", 89));
            listaPersonas.Add(new Persona("Felipe", 104));
            listaPersonas.Add(new Persona("Luisa", 18));
            listaPersonas.Add(new Persona("Carolina", 25));
            listaPersonas.Add(new Persona("Donante", 19));

            foreach (Persona per in listaPersonas)
            {
                //Console.WriteLine(per.nombre + " " + per.edad);
                Console.WriteLine(per.nombre);
            }

            int siseList = listaPersonas.Count;
            Console.WriteLine("longitud lista: " + siseList);

            Console.WriteLine("ingrese nombre a eliminar");

            string nombreDel = Console.ReadLine();

            for (int i = 0; i < siseList; i++)
            {

                if (listaPersonas[i].nombre.Equals(nombreDel))
                {
                    int indice = i;
                    listaPersonas.RemoveAt(indice);
                }
            }
            Console.WriteLine("nueva lista");

            foreach (Persona per in listaPersonas)
            {
                Console.WriteLine(per.nombre + " " + per.edad);

            }
            Console.ReadKey();
        }
    }
}
