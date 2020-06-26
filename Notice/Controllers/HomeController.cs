using HtmlAgilityPack;
using Notice.Models;
using Notice.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Notice.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeRepo _notice= new NoticeRepo();
        public HomeController()
        {

        }
        public HomeController(NoticeRepo notice)
        {
            _notice = notice;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notice()
        {
             
            NoticeData data = new NoticeData();
            data.noticeDetails = _notice.GetNoticeData();
            return View(data);
        }

        public string GetNoticeData()
        {
            string data = _notice.GetNoticeDataJson();
            return data;
        }

       
    }
}