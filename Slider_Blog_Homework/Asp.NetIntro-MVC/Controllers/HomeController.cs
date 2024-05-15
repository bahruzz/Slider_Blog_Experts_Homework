using Asp.NetIntro_MVC.Data;
using Asp.NetIntro_MVC.Models;
using Asp.NetIntro_MVC.Services.Interface;
using Asp.NetIntro_MVC.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Asp.NetIntro_MVC.Controllers
{
    public class HomeController:Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly IExpertService _expertService;

        public HomeController(ISliderService sliderservice,
                              IBlogService blogService,
                              IExpertService expertService)
        {
            _sliderService = sliderservice;
            _blogService = blogService;
            _expertService = expertService;
            
        }

        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM()
            {
                Sliders = await _sliderService.GetAllAsync(),
                SliderInfo=await _sliderService.GetSliderInfoAsync(),
                Blogs=await _blogService.GetAllAsync(),
                Experts=await _expertService.GetAllAsync(),
            };
           
            return View(model);
        }

       
    }
}
