using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeDeserialize.Classes
{
    internal class Cart
    {
        private List<CartLine> content;

        public Cart()
        {
            Content = new List<CartLine>();
        }
        public List<CartLine> Content { get => content; set => content = value; }

        public bool Add(CartLine c)
        {
            int counter = content.Count;
            content.Add(c);
            return content.Count - counter == 1;
        }
    }
}
