using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BetterBuiltWorkouts.TagHelpers
{

    [HtmlTargetElement("my-temp-message")]
    public class TempMessageTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var td = ViewCtx.TempData;
            if (td.Keys.Contains("message"))
            {
                output.BuildTag("h4", "bg-info text-center text-white p-2 rounded");
                output.Content.SetContent(td["message"].ToString());
            }
            else 
            {
                output.SuppressOutput();
            }
        }
    }
    
}
