using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge_Design_Pattern.Models;

namespace Bridge_Design_Pattern.Message
{
    public class SmsSender : MessageSenderBase
    {
        public override void Send(MessageBody messageBody)
        {
            Console.WriteLine($"SmsSender title:{messageBody.Title}, text: {messageBody.Text}");
        }
    }
}
