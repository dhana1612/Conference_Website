﻿using Microsoft.AspNetCore.Mvc;

namespace Conference_Website.Controllers
{
    //Author_s_DeskController contain all action method in Author'sDesk dropdown
    public class Author_s_DeskController : Controller
    {

        public IActionResult Journal_Publication()
        {
            return View();
        }

        public IActionResult Key_Dates()
        {
            return View();
        }

        public IActionResult Registration_Details()
        {
            return View();
        }

        public IActionResult New_Paper_Submissions()
        {
            return View();
        }
    }
}
