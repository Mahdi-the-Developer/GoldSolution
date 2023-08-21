using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Ticket
{
    public class Ticket
    {
        public string TicketId { get; set; } = Guid.NewGuid().ToString();       
        public Status StatusEnum { get; set; }

        //nav props
        public IEnumerable<Ticket> Messages { get; set; }

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
