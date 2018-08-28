﻿using ControllerExtensibility.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : AsyncController
    {
        public async Task<ActionResult> Data()
        {
            string data = await Task<string>.Factory.StartNew(() =>
                {
                    return new RemoteService().GetRemoteData();
                });
            return View((object)data);
        }
    }
}