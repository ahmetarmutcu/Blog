using Blog.Entity.DTOs.Articles;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDTO>> GetAllArticlesWithCategoryNonDeleteAsync();
        Task<ArticleDTO> GetAllArticlesWithCategoryNonDeleteAsync(Guid articleId);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task<string> SafeDeleteArticleAsync(Guid articleId);
    }
}
