
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gold.Core.Domain.Entities.TicketDTO
{
    public class TicketMessageDto
    {
        public string MessageId { get; set; } = Guid.NewGuid().ToString();
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageTime { get; set; } = DateTime.Now;
    }
}
