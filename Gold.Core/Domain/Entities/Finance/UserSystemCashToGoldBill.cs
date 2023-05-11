using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance
{
    public class UserSystemCashToGoldBill
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public uint CashAmount { get; set; }
        public double GoldAmount { get; set; }

        //navigation propertis
        public UserCashToGold? ToUserCashToGold { get; set; }
        public SystemCashToGold? ToSystemCashToGold { get; set; }
    }
}
