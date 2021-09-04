using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using RegisterandLoginApp.Models;
using RegisterandLoginApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterandLoginApp.Controllers
{
    public class LoginController : Controller
    {

        ////private static Logger logger = LogManager.GetLogger("RegandLogApppRule");
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            Utility.MyLogger.GetInstance().Info("processing a login attempt");
            Utility.MyLogger.GetInstance().Info(userModel.toString());

            SecurityService securtiyservice = new SecurityService();

            if(securtiyservice.isValid(userModel))
            {
                Utility.MyLogger.GetInstance().Info("LoginSuccess");
                return View("LoginSuccess", userModel);
            } 
            else
            {
                Utility.MyLogger.GetInstance().Warning("LoginFailure");
                return View("LoginFailure", userModel);
            }
           
        }

       
    }
}
