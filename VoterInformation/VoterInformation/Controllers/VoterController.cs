using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoterInformation.DAO;
using VoterInformation.Models;

namespace VoterInformation.Controllers
{
    public class VoterController : Controller
    {
        //GET: /Voter/Query
        public ActionResult Query()
        {
            return View();
        }
        //GET: /voter/Lookup
        public ActionResult Lookup()
        {
            string StreetName = Request.Params["Street"];
            if (StreetName == null || StreetName == String.Empty)
            {
                return View("Query");
            }

            VoterDAO thisDAO = new VoterDAO();
            List<VoterModel> voters = thisDAO.GetVoterByStreet(StreetName);

            return View(voters);
        }
    }
}