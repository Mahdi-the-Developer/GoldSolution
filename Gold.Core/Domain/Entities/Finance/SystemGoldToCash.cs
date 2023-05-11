using Gold.Core.Domain.Entities.Assets;
using Gold.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance
{
    /// <summary>
    /// system offers amount of gold and unit price to sell gold to users
    /// </summary>

    public class SystemGoldToCash
    {       
        public string Id { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// the total amount of gold in gerams to be sold by system to users
        /// </summary>
        public double GoldWeight { get; set; }
        /// <summary>
        /// the total price that system payed to buy gold 
        /// </summary>
        public uint TotalBoughtPrice { get; set; }
        /// <summary>
        /// the price that is determined to sell one geram of gold to users
        /// </summary>
        public uint UnitSellPrice { get; set; }
        /// <summary>
        /// the amount of gold that has been sold in one bill until now
        /// </summary>
        public double SoldGoldWeight { get; set; }
        /// <summary>
        /// the total cash system earned in this bill from selling gold to users until now
        /// </summary>
        public uint EarnedCash { get; set; }        
        public DateTime DateTime { get; set; }
        /// <summary>
        /// is the whole bill sold?
        /// </summary>
        public bool IsOver { get; set; } = false;
        /// <summary>
        /// is this bill deactivated by admin?
        /// </summary>
        public bool IsActive { get; set; } = false;

        //navigation properties
        public ICollection<UserSystemGoldToCashBill>? ToUserSystemGoldToCashBills { get; set; }

    }
}
