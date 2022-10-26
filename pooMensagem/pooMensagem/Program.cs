using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alô mundo";

           /* msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo objeto";
            msg2.ExibirMensagem();*/
            Console.ReadKey();

        }
    }
}
