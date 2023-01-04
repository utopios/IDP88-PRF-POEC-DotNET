using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvents.Class
{
    internal class Counter
    {
        private int total;
        private int limite;

        public Counter(int limiteValue) 
        {
            limite= limiteValue;
        }

        public event EventHandler ActionNotificationLimiteAtteinte;

        public void Add(int value) 
        {
            total += value;
            if (total >= limite )
            {
                ActionNotificationLimiteAtteinte?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
