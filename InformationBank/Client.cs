using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBank
{
    class Client
    {

        private long number;
        private string type;
        private double balance;

        public Client()
        {
         number = 5656454648465654;
         type = "";
         balance=23.2;


    }


        public long Number {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }

        }
        public string Type {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }

        }
        public double Balance {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }

        }
    }
}
