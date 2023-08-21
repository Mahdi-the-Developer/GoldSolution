using Gold.Core.Domain.Entities.Articles;
using Gold.Core.Domain.IdentityEntities;
using Gold.Core.DTO.AccountDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Core.ServiceContracts
{
    public interface IArticleServices
    {
        public Task<Article?> GetArticle(string Id);    
    }
}
