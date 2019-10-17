using System;
using System.Collections.Generic;
using System.Text;

namespace MessagingApp
{
    class WhatsApp
    {
        public LittleContact[] Contacts;
        public Message[] Messages;

        public void ListContacts()
        {
            foreach (LittleContact contact in Contacts)
            {
                Console.WriteLine("Nome    :", contact.Name);
                Console.WriteLine("Celular :", contact.Mobile);
            }
        }

        public void ListMessages()
        {
            foreach (Message message in Messages)
            {
                Console.WriteLine("Nome     :", message.Recipient.Name);
                Console.WriteLine("Celular  :", message.Recipient.Mobile);
                Console.WriteLine("Data     :", message.SentDate);
                Console.WriteLine("Mensagem :", message.Content);
            }
        }
    }
}
