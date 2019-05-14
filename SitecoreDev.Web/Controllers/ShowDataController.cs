﻿using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

namespace SitecoreDev.Web.Controllers
{
    public class ShowDataController : SitecoreController
    {
        // GET: ShowData
        public ViewResult ShowData()
        {
            Item contentItem = null;
            var database = Context.Database;
            if (database != null)
            {
                if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
                {
                    contentItem = database.GetItem(new Sitecore.Data.ID(RenderingContext.Current.Rendering.DataSource));
                }
            }
            return View(contentItem);
        }
    }
}