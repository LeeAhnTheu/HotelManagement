﻿using HotelManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers.Manage
{
    [Route("Manage/[controller]/[action]")]
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        private static string GetViewPath(string viewName)
        {
            return $"~/Views/Manage/Statistics/{viewName}.cshtml";
        }

        public IActionResult Index()
        {
            return View(GetViewPath("Index"));
        }
    }
}
