using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web_Core_2._2_Identity_Guid.Models.Identity;

namespace Web_Core_2._2_Identity_Guid.Data
{
    public class ApplicationDbContext : IdentityDbContext
        <ApplicationUser, ApplicationRole, Guid, 
        ApplicationUserClaim, ApplicationUserRole, 
        ApplicationUserLogin, ApplicationRoleClaim, 
        ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
