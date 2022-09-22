using Microsoft.AspNetCore.Mvc;
using NguyenVanToan2109.Models;

namespace NguyenVanToan2109.Controllers
{
    public class HomeController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string hesoA, string hesoB)
        {

            double a = Convert.ToDouble(hesoA);
            double b = Convert.ToDouble(hesoB);
           


            string thongbao = gpt.GiaiPhuongTrinhBacNhat(a, b);
          
            ViewBag.ketqua = thongbao;
            return View();


        }
        //Phuong trinh bac 2
        public IActionResult Creat()
        {
            return View();
        }
        
        public IActionResult Index2(string hesoA, string hesoB,string hesoC)
        {
            double D = Convert.ToDouble(hesoA);
            double E = Convert.ToDouble(hesoB);
            double F = Convert.ToDouble(hesoC);
            string ThongBao = gpt.GiaiPhuongTrinhBac2(D, E, F);
            ViewBag.kq = ThongBao;
            return View();

        }
    }
}
