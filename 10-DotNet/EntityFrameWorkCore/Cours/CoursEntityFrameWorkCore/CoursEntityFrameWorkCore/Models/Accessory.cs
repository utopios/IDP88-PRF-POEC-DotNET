using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWorkCore.Models
{
    public class Accessory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<AccessoryCar> Cars { get; set; }

    }
}
