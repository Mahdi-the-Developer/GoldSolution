using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Gold.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? CreatDateTime { get; set; } = DateTime.Now;

        //nav props
        public virtual ICollection<ApplicationUserClaim>? Claims { get; set; }
        public virtual ICollection<ApplicationUserLogin>? Logins { get; set; }
        public virtual ICollection<ApplicationUserToken>? Tokens { get; set; }
        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }

        //public ApplicationUser()
        //{
        //    Id=Guid.NewGuid().ToString();
        //}
    }
}
