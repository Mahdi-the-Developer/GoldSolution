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

public class Transaction
{
    [Key]
    public string Id { get; set; } = "";
    public string PayBillId { get; set; } = "";
    public string PayType { get; set; } = ""; // bank /bankwallet /wallet
    public string DealName { get; set; } = ""; // خرید طلا/افزایش موجودی
    public string DealType { get; set; } = ""; // deposit / withdraw / withdrawWallet
    public decimal Cash { get; set; } = 0;
    public decimal AssetCash { get; set; } = 0;
    public DateTime DateTime { get; set; }= DateTime.Now;
    public DateTime? ExecutionTime { get; set; }
    public bool IsPayed { get; set; } = false;
    public string AssetId { get; set; } = "";
}
