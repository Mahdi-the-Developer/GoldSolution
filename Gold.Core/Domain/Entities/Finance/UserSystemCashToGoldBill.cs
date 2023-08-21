using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance
{
    public class UserSystemCashToGoldBill
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public decimal CashAmount { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,4})?$", ErrorMessage = "حد اکثر 4 رقم اعشار قابل قبول است")]
        public double GoldAmount { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;

        //navigation propertis
        public UserCashToGold ToUserCashToGold { get; set; }
        public SystemGoldToCash ToSystemGoldToCash { get; set; }
    }
}
