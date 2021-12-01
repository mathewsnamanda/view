using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GleamTech.DocumentUltimate;
using GleamTech.DocumentUltimate.AspNet;
using GleamTech.DocumentUltimate.AspNet.UI;

namespace view.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string url,string extension)
        {
            string projectRootPath = Server.MapPath("~/Documents/");
            ViewData["test"] = projectRootPath + @"\error1.pdf".ToString();

            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();

            using (var webClient = new WebClient())
                {
                    if (extension == "pptx")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.pptx");
                            ViewData["test"] = projectRootPath + @"\file.pptx".ToString();
                        ViewBag.test1 = "touched";
                    }
                        catch (Exception ex)
                        {
                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                    if (extension == "pdf")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.pdf");

                            ViewData["test"] = projectRootPath + @"\file.pdf".ToString();

                        ViewBag.test1 = "touched";
                    }
                        catch (Exception ex)
                        {

                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                    if (extension == "pub")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.pub");

                            ViewData["test"] = projectRootPath + @"\file.pub".ToString();
                        }
                        catch (Exception ex)
                        {

                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                    if (extension == "xls")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.xls");

                            ViewData["test"] = projectRootPath + @"\file.xls".ToString();
                        }
                        catch (Exception ex)
                        {

                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                    if (extension == "docx")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.docx");
                        }
                        catch (Exception ex)
                        {

                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();

                            ViewData["test"] = projectRootPath + @"\file.docx".ToString();
                        }

                    }
                    if (extension == "doc")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.doc");
                            ViewData["test"] = projectRootPath + @"\file.doc".ToString();
                        }
                        catch (Exception ex)
                        {
                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();

                        }

                    }
                    if (extension == "txt")
                    {

                        try
                        {

                            webClient.DownloadFile(url, projectRootPath + "file.txt");
                            ViewData["test"] = projectRootPath + @"\file.txt".ToString();
                        }
                        catch (Exception ex)
                        {
                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                    if (extension == "png")
                    {

                        try
                        {

                            webClient.DownloadFile(url, @"Documents/file.png");

                            ViewData["test"] = projectRootPath + @"\file.png".ToString();
                        }
                        catch (Exception ex)
                        {
                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                    if (extension == "xlsx")
                    {

                        try
                        {

                            webClient.DownloadFile(url, @"Documents/file.xlsx");

                            ViewData["test"] = projectRootPath + @"\file.xlsx".ToString();
                        }
                        catch (Exception ex)
                        {
                            ViewData["test"] = projectRootPath + @"\error.pdf".ToString();
                        }

                    }
                }
                
                return View();

           
        }
      
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}