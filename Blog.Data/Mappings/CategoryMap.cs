using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("7C8DCD23-143F-4145-AC5D-3D2172E8B876"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("763C40B8-DE23-4AFA-BBA6-680F2DDE4B14"),
                Name = "ASP.NET Core2",
                CreatedBy = "Admin Test2",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }
            );
        }
    }
}
