using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Encapsulation
{ //how can we Implement Encapsulations 
    public class Bank
    {
        private double balance;
        public string username;
        private int accountno;


        //Accessors
        public double GetAccno()
        {
            return accountno;
        }
        //Mutators
        public void SetAccno(int accountno)
        {
            if (accountno > 0)
            {
                this.accountno = accountno;
            }
            else
            {
                Console.WriteLine("Please Provaide Valid Account No");
            }

        }



        //Accessors
        public double GetBalance()
        {
            return balance;
        }
        //Mutators
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    };

    class User
    {
        static void Main(string[] args)
        {
            Bank SBI = new Bank();
            SBI.SetBalance(1000);
            SBI.username = "DEB";

            SBI.SetAccno(-256412551);

            Console.WriteLine(SBI.username);
            Console.WriteLine("SBI:" + SBI.GetBalance());


            Bank BOI = new Bank();
            BOI.SetBalance(500);
            BOI.username = "MIR";
            BOI.SetAccno(-22551);

            Console.WriteLine(BOI.username);
            Console.WriteLine("BOI:" + BOI.GetBalance());
            Bank HDFC = new Bank();
            HDFC.SetBalance(5000);
            HDFC.username = "ABIR";

            HDFC.SetAccno(4564551);

            Console.WriteLine(HDFC.username);
            Console.WriteLine("HDFC:" + HDFC.GetBalance());

            Console.WriteLine("Press any Key");
            Console.ReadKey();
        }
    }
}
