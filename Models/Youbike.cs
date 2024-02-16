using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace JsonDownload.Models
{

    public class Youbike
    {
        [DisplayName("編號")]
        public string sno { get; set; }

        [DisplayName("站點")]
        public string sna { get; set; }

        [DisplayName("總車位")]
        public int tot { get; set; }

        [DisplayName("可借車位")]
        public int sbi { get; set; }

        [DisplayName("區域")]
        public string sarea { get; set; }

        [DisplayName("資料更新時間")]
        public string mday { get; set; }

        [DisplayName("緯度")]
        public float lat { get; set; }

        [DisplayName("經度")]
        public float lng { get; set; }

        [DisplayName("地址")]
        public string ar { get; set; }

        [DisplayName("area")]
        public string sareaen { get; set; }

        [DisplayName("name")]
        public string snaen { get; set; }

        [DisplayName("address")]
        public string aren { get; set; }

        [DisplayName("可還空位數")]
        public int bemp { get; set; }

        public string act { get; set; }

        public string srcUpdateTime { get; set; }

        public string updateTime { get; set; }

        public string infoTime { get; set; }

        public string infoDate { get; set; }
    }

}