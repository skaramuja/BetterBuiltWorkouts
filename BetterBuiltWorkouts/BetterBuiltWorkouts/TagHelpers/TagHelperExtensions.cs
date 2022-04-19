using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuiltWorkouts.TagHelpers
{
    public static class TagHelperExtensions
    {
        public static void AppendCssClass(this TagHelperAttributeList list, string newCssClasses)
        {
            string oldCssClass = list["class"]?.Value?.ToString();
            string cssClasses = (string.IsNullOrEmpty(oldCssClass)) ?
                newCssClasses : $"{oldCssClass} {newCssClasses}";
            list.SetAttribute("class", cssClasses);
        }

        public static void BuildTag(this TagHelperOutput output,
            string tagName, string classNames)
        {
            output.TagName = tagName;
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.AppendCssClass(classNames);
        }

        public static void BuildLink(this TagHelperOutput output, 
            string url, string className = "")
        {
            output.BuildTag("a", className);
            output.Attributes.SetAttribute("href", url);
        }
    }
}
