using BetterBuiltWorkouts.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.TagHelpers
{
    [HtmlTargetElement("my-paging-link")]
    public class PagingLinkTagHelper : TagHelper
    {
        private LinkGenerator linkBuilder;
        public PagingLinkTagHelper(LinkGenerator lg) => linkBuilder = lg;

    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext ViewCtx { get; set; }

        public int Number { get; set; }
        public RouteDictonary Current { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var routes = Current.Clone();

            routes.PageNumber = Number;


            string ctlr = ViewCtx.RouteData.Values["controller"].ToString();
            string action = ViewCtx.RouteData.Values["action"].ToString();
            string url = linkBuilder.GetPathByAction(action, ctlr, routes);

            string linkClasses = "btn btn-outlinke-primary text-white bg-dark";
            if (Number == Current.PageNumber)
            {
                linkClasses += " active";
            }
            output.BuildLink(url, linkClasses);
            output.Content.SetContent(Number.ToString());
        }
    }
}