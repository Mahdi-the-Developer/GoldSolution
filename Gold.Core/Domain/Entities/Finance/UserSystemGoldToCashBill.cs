using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance
{
    public class UserSystemGoldToCashBill
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public uint CashAmount { get; set; }
        public double GoldAmount { get; set; }

        //navigation propertis
        public UserGoldToCash? ToUserGoldToCash { get; set; }
        public SystemGoldToCash? ToSystemGoldToCash { get; set; }
    }
}
