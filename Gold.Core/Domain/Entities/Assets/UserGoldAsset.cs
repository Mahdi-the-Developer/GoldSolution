
using Gold.Core.Domain.Entities.Finance;
using Gold.Core.Domain.IdentityEntities;

namespace Gold.Core.Domain.Entities.Assets;

public class UserGoldAsset
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public double GoldAmount { get; set; }
    /// <summary>
    /// total money user payed to system to get gold until now
    /// </summary>
    public double PayedTotalCash { get; set; }
    /// <summary>
    /// total money user taken from selling gold to system
    /// </summary>
    public double EarnedTotalCash { get; set; }
    /// <summary>
    /// total value of gold asset stored in user account
    /// </summary>
    public decimal TotalCashAsset { get; set; }

    //navigation properties
    public ICollection<UserCashToGold>? ToCashGolds { get; set; }
    public ICollection<UserGoldToCash>? ToGoldCashs { get; set; }
    public ApplicationUser? ToAppUser { get; set; }
}
