using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RFIsystem.Models;
using RFIsystem.Query;
using Microsoft.AspNetCore.Http;



namespace RFIsystem.Controllers
{
    public class ShowController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
           
        public ActionResult ShowDashBoard() {
          
            var Job_no = this.HttpContext.Session.GetString("Job_no");
            var User_name = this.HttpContext.Session.GetString("User_name");
            var First_name = this.HttpContext.Session.GetString("First_name");
            dynamic dynamicModeling = new ExpandoObject();
            List<Showlistall> listTic = new List<Showlistall>();
            List<ShowBeforeApproved> listTic1 = new List<ShowBeforeApproved>();
            QueryCRUD qr = new QueryCRUD();

            dynamicModeling.Showlistall = qr.showonlylogin();
            dynamicModeling.ShowBeforeApproved = qr.showBeforeApproved();
            //listTic = qr.showonlylogin();
           
            //listTic1= qr.showBeforeApproved();
            try {
                if (listTic.Count == 0)
                {
                 
                    ViewBag.sumrepo = "0";
                    return View(dynamicModeling);
                }
                else {

                  

                    return View(dynamicModeling);
                }

            } catch  {

                return View(dynamicModeling);

            }


        }
    }
}
