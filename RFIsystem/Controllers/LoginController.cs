using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;
using RFIsystem.Models;
using RFIsystem.Query;

namespace RFIsystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult LoginIndex()
        {


                return View();

        }
        [HttpPost]
        public ActionResult LoginIndex(LoginModel loginModel) {

            QueryCRUD query = new QueryCRUD();
            //dynamic dyall = new ExpandoObject();
            bool chk = query.CheckLogin(loginModel.User_name, loginModel.Password,loginModel.Job_no);
            LoginModel lm = new LoginModel();
            QueryCRUD qr = new QueryCRUD();

            LoginModel chkadmin = query.Get_T_SessionEmail(loginModel.User_name, loginModel.Password, loginModel.Job_no);

            if (chk == true) {

                if (chkadmin.First_name != "") {


                    //dyall.User_name = loginModel.User_name;
                    //dyall.Job_no = loginModel.Job_no;
                    //dyall.First_name = chkadmin.First_name;


                    //dynamic listTicPOn = new ExpandoObject();

                    //listTicPOn.T_Po = loginModel.Job_no;
                    //listTicPOn.T_Job = chkadmin.First_name;
                    HttpContext.Session.SetString("User_name", loginModel.User_name);
                    HttpContext.Session.SetString("Job_no", loginModel.Job_no);
                    HttpContext.Session.SetString("First_name", chkadmin.First_name);

                    return RedirectToAction("ShowDashBoard", "Show");
               
                }

            }
            else {

                TempData["mgs"] = "1";
                return View();

            }
           
            TempData["mgs"] = "1";
            return View();
        
        }
    }
}
