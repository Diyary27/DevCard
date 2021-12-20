using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>() {
                new Project(1, "طراحی سایت", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.", "مشنری"),
                new Project(2, "سایت فروشگاهی", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.", "مشنری"),
                new Project(3, "پروژه مدارس", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.", "مشنری"),
                new Project(4, "برنامه نویسی", "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است.", "مشنری"),

        };

            return View("_Projects", projects);
    }
}
}
