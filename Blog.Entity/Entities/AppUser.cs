using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities
{
    public class AppUser:IdentityUser<Guid>,IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; }=Guid.Parse("7C8DCD23-143F-4145-AC5D-3D2172E8B876");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
