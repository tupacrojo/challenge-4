using System;

namespace challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Persona[] personas = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Ingrese el nombre N°" + (i+1) + ":");
                personas[i] = new Persona()
                {
                    Nombre = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
        }

        public class Persona
        {
            public string Nombre { get; set; }

            public override string ToString()
            {
                return "¡Hola! Mi nombres es " + Nombre;
            }
        }
    }
}