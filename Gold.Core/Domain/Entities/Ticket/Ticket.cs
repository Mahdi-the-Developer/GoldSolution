using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Ticket
{
    public class Ticket
    {
        [Key]
        public string TicketId { get; set; } = Guid.NewGuid().ToString();       
        public Status StatusEnum { get; set; }

        //nav props
        public IEnumerable<TicketMessage> Messages { get; set; }

        public Ticket()
        {            
        }

        public enum Status 
        {
            Pending,
            Replyed,
            Closed
        }
    }
}
