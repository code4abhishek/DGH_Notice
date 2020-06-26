using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notice.Models
{
    public class NoticeModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string UrlType { get; set; }
    }
    public class NoticeData
    {
        public List<NoticeModel> noticeDetails { get; set; }
    }
}