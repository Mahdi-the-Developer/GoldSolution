using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Gold.Core.Domain.Entities.Finance;
using Gold.Core.Domain.IdentityEntities;

namespace Gold.Core.Domain.Entities.Assets;

public class UserAsset
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public double Gold { get; set; } = 0;
    /// <summary>
    /// total value of gold asset stored in user account
    /// </summary>
    public decimal Cash { get; set; } = 0;

    //navigation properties
    public ApplicationUser? ToAppUser { get; set; }
}
