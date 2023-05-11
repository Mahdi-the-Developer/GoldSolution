using Gold.Core.Domain.Entities.Assets;
using Gold.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance;

public class UserGoldToCash
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public double GoldAmount { get; set; }
    public uint? GoldUnitPrice { get; set; }
    public DateTime DateTime { get; set; }
    public bool IsPayed { get; set; } = false;
    public bool IsDeleted { get; set; } = false;


    //navigation properties
    public UserGoldAsset? ToGoldAsset { get; set; }
    public ApplicationUser? ToAppUser { get; set; }
    public ICollection<UserSystemGoldToCashBill>? To2UserSystemGoldToCashBills { get; set; }

}
