﻿using Asp.NetIntro_MVC.Models;
using Asp.NetIntro_MVC.ViewModels.Blog;

namespace Asp.NetIntro_MVC.Services.Interface
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync();
    }
}
