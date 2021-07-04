using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Extensions
{
    public class EmailTagHelper : TagHelper
    {
        public string Domain { get; private set; } = "@gmail.com";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var content = await output.GetChildContentAsync();
            var target = $"{content.GetContent()}{this.Domain}";
            output.Attributes.SetAttribute("href",$"mailto:{target}");
            output.Content.SetHtmlContent(target);
        }
    }
}
