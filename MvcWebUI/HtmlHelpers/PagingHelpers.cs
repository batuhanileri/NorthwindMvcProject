using MvcWebUI;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMvcProject.MvcWebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString Pager(this HtmlHelper html,PagingInfo pagingInfo)
        {
            int totalPage = (int)Math.Ceiling((decimal)pagingInfo.TotalItems / pagingInfo.ItemsPerPage);
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < totalPage; i++)
            {
                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format("/Product/Index/?page={0}", i));
                tagBuilder.InnerHtml = i.ToString();
                stringBuilder.Append(tagBuilder);
            }
            return MvcHtmlString.Create(stringBuilder.ToString());
        }


    }
}