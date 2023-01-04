using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeDeserialize.Classes
{
    internal class CartLine
    {
        private Produit product;
        private int quantity;

        public CartLine( Produit product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        [JsonProperty("Quantity")]
        public int Quantity { get => quantity; set => quantity = value; }
        [JsonProperty("Product")]
        public Produit Product { get => product; set => product = value; }

        public override string ToString()
        {
            return $" \"Product\" :{product.ToString()}, \"Quantity\" : {quantity}";
        }

    }
}
