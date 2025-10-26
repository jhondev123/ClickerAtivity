using ClickerCounter.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClickerCounter.Controllers
{
    public class CounterController : Controller
    {
        public Counter _counter = new Counter();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Click(int nowValue)
        {
            int newValue = _counter.Click(nowValue);
            return Json(new { value = newValue });
        }
        public IActionResult Reset()
        {
            int newValue = _counter.Reset();
            return Json(new { value = newValue });
        }
    }
}
