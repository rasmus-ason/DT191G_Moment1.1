using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class RazorModel : PageModel
    {
        public List<string> MyList { get; set; }
        public string dateTimeWithoutSeconds { get; set; }
        public string currentWeekday { get; set; }

    public void OnGet()
        {
            //Get date & time
            DateTime now = DateTime.Now;
            dateTimeWithoutSeconds = now.ToString("dd/MM/yyyy HH:mm");

            //Get current weekday
            currentWeekday = DateTime.Now.DayOfWeek.ToString();

            //Store courses in list
            MyList = new List<string> {
                "Webbutveckling I - DT057G",
                "Introduktion till programmering i JavaScript - DT084G",
                "Digital bildbehandling för webb - DT163G",
                "Webbanvändbarhet - DT068G",
                "Databaser - DT003G",
                "Webbutveckling II - DT093G",
                "Webbdesign för CMS - DT197G",
                "Webbutveckling III - DT173G",
                "Projektledning - IK060G",
                "Fullstack-utveckling med ramverk - DT193G",
                "JavaScript-baserad webbutveckling - DT162G",
                "Programmering i C#.NET - Dt071G",
                "Webbutveckling med .NET - DT191G",
                "Affärsplaner och kommersialisering - IG021G",
                "Självständigt arbete - DT140G"


                };
        }





    }
}
