﻿using System.Web.Mvc;

namespace ExploreGobal.Presentation.UI.Areas.Finance
{
    public class FinanceAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Finance";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Finance_default",
                "Finance/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}