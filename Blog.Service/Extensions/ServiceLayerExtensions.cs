﻿using Blog.Service.FluentValidations;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            var assembly=Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService,ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            
           services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();

            services.AddAutoMapper(assembly);


            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("tr");
            });

            return services;
        }
    }
}
