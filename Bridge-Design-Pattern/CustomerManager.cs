using Bridge_Design_Pattern.Message;
using Bridge_Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Design_Pattern
{
    public class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }

        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new MessageBody() { Title = "Başlık", Text = "Açıklama" });
            Console.WriteLine("Customer Updated");
        }
    }
}
