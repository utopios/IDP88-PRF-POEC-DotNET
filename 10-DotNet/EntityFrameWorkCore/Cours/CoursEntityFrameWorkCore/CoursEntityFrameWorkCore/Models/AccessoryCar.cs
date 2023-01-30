using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWorkCore.Models
{
    public class AccessoryCar
    {
        public int Id { get; set; }

        public int AccessoryId { get; set; }
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

        [ForeignKey(nameof(AccessoryId))]
        public Accessory Accessory { get; set; }

        public string Color { get; set; }
    }
}
