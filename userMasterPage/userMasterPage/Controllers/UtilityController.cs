using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using userMasterPage.Models;

namespace userMasterPage.Controllers
{
    public class UtilityController : Controller
    {
        //
        // GET: /Utility/
        [System.Web.Http.HttpGet]
        public void getDataFromDataBase(string JsonString)
        {
            Company compObj = JsonConvert.DeserializeObject<Company>(JsonString);
            string compName = compObj.mstrCompanyName;
        }

    }
}
