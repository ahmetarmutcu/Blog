using Blog.Entity.DTOs.Categories;

namespace Blog.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
             
    }
}
