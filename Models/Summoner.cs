
using Microsoft.AspNetCore.Identity;

namespace PPSI.Models
{
    public class Summoner : IdentityUser
    {
        public DateOnly BirthDate { get; set; }
    }
}
