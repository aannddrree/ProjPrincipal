using Control;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario()
            {
                Id = 144,
                Nome = "José",
                Telefone = "16 9 88778778"
            };

            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nome = "Luiz",
                Telefone = "16 9 88774545"
            };

            Console.WriteLine(Printer.GetPerson(funcionario));
            Console.WriteLine(Printer.GetPerson(cliente));

            Console.ReadKey();
        }
    }
}
