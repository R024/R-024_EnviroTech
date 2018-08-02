using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hajj1.Models;

namespace hajj1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var model = new DashBoardModel();

            model.numberAllStorages = BaseModel.NumberAllStorages;
            model.actualStoragesNumber = BaseModel.ActualStoragesNumber- BaseModel.NeedMientenance;


            model.averageTemperature   = BaseModel .AverageTemperature ;
            model.needMientenance   = BaseModel.NumberAllStorages - BaseModel.ActualStoragesNumber;

            model.numberOfIsEmpty   = BaseModel .NumberOfIsEmpty ;
            model.numberOfIsFullStorages   = BaseModel.NumberOfIsFullStorages  ;
            model.numberOfQutaUsing   = BaseModel.NumberOfQutaUsing  ;
            model.numberOfWiFiUser   = BaseModel.NumberOfWiFiUser;
            model.numberOfCollected = BaseModel.NumberOfCollected;
            model.needMientenance = BaseModel.NeedMientenance;




            return View(model);
        }
    }
}
