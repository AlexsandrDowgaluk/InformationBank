using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Alex = new Client();
            Alex.Number = 165654616445461;
            Alex.Type = " Расчетный счет ";
            Alex.Balance = 1516.156;
            Console.WriteLine(Alex.Number +"\n"+ Alex.Type + "\n"+Alex.Balance);
            Console.ReadKey();

        }
    }
}
