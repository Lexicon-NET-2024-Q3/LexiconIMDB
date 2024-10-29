using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Text.Encodings.Web;

namespace LexiconIMDB.TagHelpers
{
    [HtmlTargetElement("star")]
    public class StarTagHelper : TagHelper
    {
        public float Rating { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            output.AddClass("star", HtmlEncoder.Default);

            var roundedRating = (int)Math.Round(Rating);

            int stars = roundedRating;
            bool isHalfStar = roundedRating % 2 == 1;

            string commons = "https://upload.wikimedia.org/wikipedia/commons/";
            string star = commons + "e/e5/Full_Star_Yellow.svg";
            string half = commons + "d/d6/Half_Star_Yellow.svg";

            var builder = new StringBuilder();

            for (int i = 0; i < stars; i++)
            {
                builder.Append($"<img src='{star}' />");
            }
            if (isHalfStar)
                builder.Append($"<img src='{half}' />");

            output.Content.SetHtmlContent(builder.ToString()); 
        }
    }
}
