using ORPortal_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORPortal_MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Index()
        {
            using (ORPortal_Db db = new ORPortal_Db())
            {
                var model = from r in db.MachineGroups
                            select r;
                int total = model.Count();
                ViewBag.total = total;
                foreach (var item in model)
                {
                    return View(item);
                }
                return View();
            }
        }
        [HttpGet]
        public ActionResult Menu()
        {
            MachineGroup group = new MachineGroup();
            return View(group);
        }
        [HttpPost]
        public ActionResult Menu(MachineGroup group )
        {
            ViewBag.Name = group.Name;
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult MachineSelection()
        {
            using (ORPortal_Db db = new ORPortal_Db())
            {

                var machine = from r in db.Machines
                              select r.Name;
                int total = machine.Count();
                ViewBag.machine = total;
                List<Machine> name = new List<Machine>();
                foreach (var item in machine)
                {
                    Machine MachineList = new Machine();
                    MachineList.Name = item.ToString();

                    name.Add(MachineList);


                }
                return View(name);
                //return View();
            }

        }

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}

    }
}
