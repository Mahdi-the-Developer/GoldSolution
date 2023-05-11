using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Product
{
    public class GoldPrice
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public double Price { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        //navigation props
    }
}
