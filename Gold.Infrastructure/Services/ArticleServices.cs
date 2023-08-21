using Gold.Core.Domain.Entities.Articles;
using Gold.Core.Domain.IdentityEntities;
using Gold.Core.DTO.AccountDTO;
using Gold.Infrastructure.GoldDbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.ServiceContracts
{
    public class ArticleServices : IArticleServices
    {
        private readonly ApplicationDbContext _Context;
        public ArticleServices(ApplicationDbContext context)
        {
                _Context = context;
        }
        public async Task<Article?> GetArticle(string Id)
        {
            Article article=await _Context.Articles.FindAsync(Id);
            return article;
        }
    }
}
