using Gold.Core.Domain.Entities.Assets;
using Gold.Core.Domain.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.Domain.Entities.Finance;

public class UserCashToGold
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public decimal TotalCash { get; set; }
    public decimal LeftCash { get; set; }
    public decimal SpentCash { get; set; }
    public decimal UnitPrice { get; set; } = 0;
    [RegularExpression(@"^\d+(\.\d{1,4})?$", ErrorMessage = "حد اکثر 4 رقم اعشار قابل قبول است")]
    public double EarnedGold { get; set; }
    public DateTime DateTime { get; set; }= DateTime.Now;
    public DateTime ExecutionTime { get; set; }
    public long Delay { get; set; }
    public bool IsPayed { get; set; } = false;
    public bool IsActive { get; set; } = false;
    public bool IsDone { get; set; } = false;
    public UserCashToGold()
    {
        ToUserSystemCashToGoldBills = new HashSet<UserSystemCashToGoldBill>();
    }

    //navigation properties
    //public UserGoldAsset? ToGoldAsset { get; set; }
    public ApplicationUser ToAppUser { get; set; }
    public ICollection<UserSystemCashToGoldBill>? ToUserSystemCashToGoldBills { get; set; }
}
