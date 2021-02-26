using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class Printer
    {
        public static string GetPerson(Pessoa pessoa)
        {
            return "Id:" + pessoa.Id + " Nome: " + pessoa.Nome;
        }
    }
}
