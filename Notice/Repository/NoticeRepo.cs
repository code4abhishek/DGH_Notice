using HtmlAgilityPack;
using Newtonsoft.Json;
using Notice.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Notice.Repository
{
    public class NoticeRepo
    {
        public string GetNoticeDataJson()
        {
            string url = "http://dghindia.gov.in/index.php/all_story?type=1&page=notice";
            var web = new HtmlAgilityPack.HtmlWeb();
            HtmlDocument doc = web.Load(url);

            var allData = doc.DocumentNode.SelectNodes("//html[1]/body[1]/div[3]/div[3]/ul[1]/li/a");

            List<NoticeModel> noticeAllData = new List<NoticeModel>();

            foreach (HtmlNode node in allData)
            {
                NoticeModel noticeData = new NoticeModel();

                noticeData.Url = node.Attributes["href"].Value;
                noticeData.Title = node.InnerHtml;
                if (noticeData.Url.Contains("dghindia.gov.in"))
                {
                    noticeData.UrlType = "Internal";
                }
                else
                {
                    noticeData.UrlType = "External";
                }

                noticeAllData.Add(noticeData);
            }



            string jsondata = string.Empty;
            jsondata = JsonConvert.SerializeObject(noticeAllData);
            return jsondata;


        }

        public List<NoticeModel> GetNoticeData()
        {
            string url = "http://dghindia.gov.in/index.php/all_story?type=1&page=notice";
            var web = new HtmlAgilityPack.HtmlWeb();
            HtmlDocument doc = web.Load(url);

            var allData = doc.DocumentNode.SelectNodes("//html[1]/body[1]/div[3]/div[3]/ul[1]/li/a");

            List<NoticeModel> noticeAllData = new List<NoticeModel>();

            foreach (HtmlNode node in allData)
            {
                NoticeModel noticeData = new NoticeModel();

                noticeData.Url = node.Attributes["href"].Value;
                noticeData.Title = node.InnerHtml;
                if (noticeData.Url.Contains("dghindia.gov.in"))
                {
                    noticeData.UrlType = "Internal";
                }
                else
                {
                    noticeData.UrlType = "External";
                }

                noticeAllData.Add(noticeData);
            }
            return noticeAllData;


            //string jsondata = string.Empty;
            //jsondata = JsonConvert.SerializeObject(noticeAllData);
            //return jsondata;


        }
    }
}