using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoot.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet]

        public ActionResult Roots(){
            return View();
        }

        [HttpPost]

        public ActionResult Roots(string FirstNum, string SecondNum){

            int num1, num2, root1, root2;

            num1 = int.Parse(FirstNum);
            num2 = int.Parse(SecondNum);

            root1 = (int)Math.Sqrt(num1);
            root2 = (int)Math.Sqrt(num2);

            ViewBag.Result1 = root1;
            ViewBag.Result2 = root2;
            ViewBag.Result3 = num1;
            ViewBag.Result4 = num2;

            return View();
        }
    }
}