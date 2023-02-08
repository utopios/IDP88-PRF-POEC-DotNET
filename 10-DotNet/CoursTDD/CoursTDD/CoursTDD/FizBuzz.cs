using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class FizBuzz
    {
        private int number;

        public FizBuzz(int number)
        {
            this.number = number;
        }

        public string Run()
        {
            string result = "";
            if(number % 3 == 0 && number%5 == 0)
            {
                result = "fizbuzz";
            } 
            else if(number % 3 == 0)
            {
                result = "fiz";
            }
            else if(number % 5 == 0)
            {
                result = "buzz";
            }
            else
            {
                result = number.ToString();
            }
            return result;
        }
    }
}
