using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedOnDate { get; set; } = DateTime.UtcNow;
        public int CreatedByUserId { get; set; }
        public DateTime UpdatedOnDate { get; set; } = DateTime.UtcNow;
        public int UpdatedByUserId { get; set; }
        public DateTime DeletedOnDate { get; set; } = DateTime.UtcNow;
        public int DeletedByUserId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
        public DateTime RefreshTokenExpiryDate { get; set; }

    }
}
