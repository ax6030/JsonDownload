using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace JsonDownload.Models
{
    public class BusTaxi
    {
        [DisplayName("路線")]
        public string name { get; set; }

        [DisplayName("車隊")]
        public string company { get; set; }

        [DisplayName("連絡電話")]
        public string[] tel { get; set; }

        [DisplayName("圖片")]
        public string imgSrc { get; set; }

        [DisplayName("地區")]
        public string[] zone { get; set; }

        [DisplayName("起訖站")]
        public string[] route { get; set; }

        [DisplayName("路線長度")]
        public string[] length { get; set; }

        [DisplayName("班次")]
        public string[] shift { get; set; }
    }
}