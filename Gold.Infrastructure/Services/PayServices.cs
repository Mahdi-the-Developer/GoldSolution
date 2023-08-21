using Gold.Core.Domain.Entities.Finance;
using Gold.Core.Domain.IdentityEntities;
using Gold.Core.DTO.Finance;
using Gold.Core.ServiceContracts;
using Gold.Infrastructure.GoldDbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Gold.Infrastructure.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Gold.Core.DTO.AccountDTO;
using Gold.Core.Domain.Entities.Assets;
using Microsoft.AspNetCore.Routing.Tree;
using System.Diagnostics;
using Gold.Core.DTO.PayDTO;
using Gold.Infrastructure.Migrations;

namespace Gold.Infrastructure.Services
{
    public class PayServices : IPayServices
    {
        #region Injections
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public PayServices(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        #endregion

        public async Task<UserCashToGold?> getBuyBillbyId(string Id)
        {
            return await _context.UserCashGolds.SingleOrDefaultAsync(b => b.Id == Id);
        }

        public async Task<Transaction?> getTransactionById(string transactionId)
        {
            return await _context.Transactions.SingleOrDefaultAsync(t => t.Id == transactionId);
        }

        public async Task<UserAsset> getUserAssetByUser(ApplicationUser user)
        {
            return await _context.UserAssets.SingleOrDefaultAsync(ua => ua.ToAppUser == user);
        }

        public async Task setTransaction(PayBillDTO payBillDto, string transId)
        {
            Transaction trans = new Transaction()
            {
                Id = transId,
                Cash = payBillDto.FinalPayment,
                DateTime = DateTime.Now,
                AssetId = payBillDto.AssetId,
                DealType = "deposit",
                PayBillId = payBillDto.Id,
                DealName = "خرید طلا",
                AssetCash = payBillDto.UserCashAsset,
                PayType = payBillDto.PayType,
                IsPayed=false,
            };
             await _context.Transactions.AddAsync(trans);
             await _context.SaveChangesAsync();            
        }

        public async Task setTransactionIsPayedById(string transactionId)
        {
            Transaction trans = await this.getTransactionById(transactionId);
            trans.IsPayed = true;
            trans.ExecutionTime = DateTime.Now;
            await _context.SaveChangesAsync();
        }

        public async Task setUserAssetCashToZeroById(string assetId)
        {
            UserAsset asset = await _context.UserAssets.SingleOrDefaultAsync(a => a.Id == assetId);
            asset.Cash = 0;
            await _context.SaveChangesAsync();
        }

        public async Task setUserCashGoldIsPayedById(string billId)
        {
            UserCashToGold bill = await _context.UserCashGolds.SingleOrDefaultAsync(b => b.Id == billId);
            bill.IsPayed = true;
            await _context.SaveChangesAsync();
        }

        public async Task withdrawFromAssetByIdandAmount(string assetId, decimal moneyAmount)
        {
            UserAsset userAsset= await _context.UserAssets.SingleOrDefaultAsync(ua => ua.Id == assetId);
            userAsset.Cash-= moneyAmount;
            await _context.SaveChangesAsync();
        }
    }
}
