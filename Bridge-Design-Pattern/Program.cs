using Bridge_Design_Pattern.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.MessageSenderBase = new EmailSender();
            customerManager.MessageSenderBase = new SmsSender();
            customerManager.UpdateCustomer();
            
            Console.ReadLine();
        }
    }
}
