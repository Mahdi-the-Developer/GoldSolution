using Gold.Core.Domain.Entities.Assets;
using Gold.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance;

public class UserCashToGold
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public uint CashAmount { get; set; }
    public uint? GoldUnitPrice { get; set; }
    public DateTime DateTime { get; set; }= DateTime.Now;
    public bool IsPayed { get; set; } = false;
    public bool IsActive { get; set; } = false;


    //navigation properties
    public UserGoldAsset? ToGoldAsset { get; set; }
    public ApplicationUser? ToAppUser { get; set; }
    public ICollection<UserSystemCashToGoldBill>? To2UserSystemCashToGoldBills { get; set; }
}
