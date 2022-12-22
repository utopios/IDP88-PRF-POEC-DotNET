using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage.Classes
{
    public sealed class Chat : Mammifere
    {
        private string nomChat;
        private string typeChat;

        public Chat(string NomChat, string TypeChat) : base(NomChat, TypeChat)
        {
            this.nomChat = NomChat;
            this.typeChat = TypeChat;
        }

        public string NomChat { get => nomChat; set => nomChat = value; }
        public string TypeChat { get => typeChat; set => typeChat = value; }

        public override void Alimentation()
        {
            Console.WriteLine("Je mange des croquettes pour chat!");
        }
        public override void Expression()
        {
            base.Expression();
            Console.WriteLine("Miaou! Miaou !");
        }
    }
}
