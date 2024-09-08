
using Microsoft.AspNetCore.Identity;

namespace InventoryManagement.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int ReferenceId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdate {  get; set; } 
    }
}
