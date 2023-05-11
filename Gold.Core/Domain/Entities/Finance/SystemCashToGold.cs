using Gold.Core.Domain.Entities.Assets;
using Gold.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance
{
    /// <summary>
    /// system offers amount of money and unit price to buy gold from users
    /// </summary>
    public class SystemCashToGold
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();        
        /// <summary>
        /// total cash determined by system to buy gold from users
        /// </summary>
        public uint? TotalCash { get; set; }
        /// <summary>
        /// the price of one geram system pays to buy gold from users
        /// </summary>
        public uint GoldUnitPrice { get; set; }    
        /// <summary>
        /// the amount of gold system bought from users till now
        /// </summary>
        public double EarnedGoldWeight { get; set; }
        /// <summary>
        /// total cash payed to users till now
        /// </summary>
        public uint  SpentCash { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsOver { get; set; } = false;
        public bool IsActive { get; set; } = false;

        //navigation properties
        public ICollection<UserSystemCashToGoldBill>? ToUserSystemCashToGoldBills { get; set; }
    }
}
