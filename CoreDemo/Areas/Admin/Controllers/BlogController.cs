using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccesLayer.concrete;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var varkbook = new XLWorkbook())
            {
                var worksheet = varkbook.Worksheets.Add("Blog listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach(var item in getBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;

                }
                using (var stream = new MemoryStream()) {
                    varkbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadseehtml.sheet", "Calısma1.xlsx");
                
                }
            }
        }

        public List<BlogModel> getBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>()
            {
                new BlogModel { Id = 1, BlogName = "c# programalamaya giriş" },
                new BlogModel { Id = 2, BlogName = "Tesla Firmasının Araçları" },
                new BlogModel { Id = 3, BlogName = "2020 Olimpiyatları" }


            };
            return bm;
        
        }
        public IActionResult BlogListexcel() { 
            return View();
        
        }

        public IActionResult ExportDynamicExcelBlogList() {
            using (var varkbook = new XLWorkbook())
            {
                var worksheet = varkbook.Worksheets.Add("Blog listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;

                }
                using (var stream = new MemoryStream())
                {
                    varkbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadseehtml.sheet", "Calısma1.xlsx");

                }
            }
        }

        public List<BlogModel2> BlogTitleList() {
            List<BlogModel2> bm=new List<BlogModel2>();
            using (var c = new Context()) { 
                bm=c.Blogs.Select(x=>new BlogModel2{ 
                    Id=x.BlogId,
                    BlogName=x.BlogTitle
                
                }).ToList();
            
            }
            return bm;
        }
        public IActionResult BlogTitleListExcel()
        {
            return View();
        }

    }
}
