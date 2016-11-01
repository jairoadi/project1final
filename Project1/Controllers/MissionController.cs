using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nomission()
        {
            return View();
        }

        public ActionResult Missions(string mission)
        {
            if (mission == "Angola")
            {
                ViewBag.Mission = "Angola Luanda Mission";
                ViewBag.Map = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d16037820.583532056!2d8.825026066004405!3d-11.07729435928459!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1a51f24ecaad8b27%3A0x590a289d0d4a4e3d!2sAngola!5e0!3m2!1sen!2spt!4v1477778698586";
                ViewBag.President = "Denelson Silva";
                ViewBag.Address = "Condominio Concha, de Talatona #77";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "Average Temperatures in Luanda, Angola. The mean annual temperature in Luanda, Angola is fairly hot at 25.1 degrees Celsius (77.2 degrees Fahrenheit). Mean monthly temperatures vary by 6.5 °C (11.7°F) which is a very low range.";          
                ViewBag.Religion = "Roman Catholics";
                ViewBag.Flag = "/Content/Images/Angolaflag.jpg";
            }
            else if (mission == "Colorado")
            {
                ViewBag.Mission = "Colorado Colorado Springs Mission";
                ViewBag.Map = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6352288.319765879!2d-110.03558412739633!3d38.97644277671854!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x874014749b1856b7%3A0xc75483314990a7ff!2sColorado%2C+USA!5e0!3m2!1sen!2spt!4v1477778998848";

                ViewBag.President = "J. Patrick Anderson";
                ViewBag.Address = "4090 Center Park Drive";
                ViewBag.Language = "English";
                ViewBag.Climate = "Dry winters with an occasional wind-blown snow. Some very cold temperatures alternating with some surprisingly warm days. Windy springs with highly changeable weather, an occasional blizzard, large temperature changes and an occasional gentle soaking rain or wet snow to help nurture the grasslands.";
                ViewBag.Religion =  "Roman Catholics";
                ViewBag.Flag = "/Content/Images/USflag.jpg";
            }
            else if (mission == "Portugal")
            {
                ViewBag.Mission = "Portugal Lisbon Mission";
                ViewBag.Map = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6307728.274891475!2d-12.345848302227383!3d39.47056112333465!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xb32242dbf4226d5%3A0x2ab84b091c4ef041!2sPortugal!5e0!3m2!1sen!2spt!4v1477778915230";
                ViewBag.President = "Victor Emanuel Engelhardt Tavares";
                ViewBag.Address = "Rua Jorge Barradas 14C";
                ViewBag.Language = "European Portuguese";
                ViewBag.Climate = "Portugal is mainly characterized by a warm temperate, mediterranean climate with a distinct wet season in winter. During winter, Portugal experiences a similar temperature pattern to the Spanish coastal towns, i.e. average daytime maxima of about 16°C (61°F).";
                ViewBag.Religion = "Roman Catholics";
                ViewBag.Flag = "/Content/Images/Portugalflag.jpg";
            }
            else
            {
                ViewBag.Mission = "Unlisted Mission";
            }

            return View();
        }
    }
}