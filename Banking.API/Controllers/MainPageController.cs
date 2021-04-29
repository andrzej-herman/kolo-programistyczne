using Banking.API.Interfaces;
using Banking.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Controllers
{
    [ApiController]
    public class MainPageController : ControllerBase
    {
        private readonly IMainPageService _mainPageService;

        public MainPageController(IMainPageService service)
        {
            _mainPageService = service;
        }

        [HttpGet("/api/mainpage")]
        public string GetDataForMainPage()
        {
            var data = _mainPageService.GetMainPageData();
            return JsonConvert.SerializeObject(data);
        }
    }
}
