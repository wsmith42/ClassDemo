
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Microsoft.AspNet.Identity.EntityFramework;
#endregion
namespace Chinook.Data.Enitities.Security
{
    public class ApplicationUser : IdentityUser
    {
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
    }
}
