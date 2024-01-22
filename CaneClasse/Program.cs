using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaneClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane c = new Cane();
            c.Nome = "Ringhio";
            c.Razza = "Labrador";

            c.Proprietario = new Persona();
            c.Proprietario.Nome = "Rossi";

            Console.WriteLine("{0}, {1}, {2}", c.Nome, c.Razza, c.Proprietario.Nome);

            Console.ReadLine();
        }
    }
}
