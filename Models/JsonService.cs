using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;

namespace JsonDownload.Models
{
    public static class JsonService
    {
        public static async Task<List<Youbike>> GetDataAsync_Youbike()
        {
            List<Youbike> result = new List<Youbike>();
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Get;
                    request.RequestUri = new Uri("https://tcgbusfs.blob.core.windows.net/dotapp/youbike/v2/youbike_immediate.json");
                    var response = await client.SendAsync(request);
                    var responseBody = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<Youbike>>(responseBody);
                }
                return result;
            }
        }

        public static async Task<List<TravelPlace>> GetDataAsync_TravelPlace()
        {
            List<TravelPlace> result = new List<TravelPlace>();
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Get;
                    request.RequestUri = new Uri("https://media.taiwan.net.tw/XMLReleaseALL_public/hotel_E_f.json");
                    var response = await client.SendAsync(request);
                    var responseBody = await response.Content.ReadAsStringAsync();

                    //先反序列化成JSON物件
                    var JsonObject = JsonConvert.DeserializeObject<JObject>(responseBody);

                    //抓取Info裡面的資料並轉換成<List<TravelPlace>>物件，其他外層資料沒有抓取
                    var token = JsonObject["XML_Head"]["Infos"]["Info"];
                    result = token.ToObject<List<TravelPlace>>();
                }
                return result;
            }
        }

        public static async Task<List<BusTaxi>> GetDataAsync_BusTaxi()
        {
            List<BusTaxi> result = new List<BusTaxi>();
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Get;
                    request.RequestUri = new Uri("https://data.kcg.gov.tw/dataset/82ef292a-5e96-4c99-a1ca-acae712e3805/resource/482fbc04-8666-4031-8dcf-13b5b4d35860/download/bustaxi.json");
                    var response = await client.SendAsync(request);
                    var responseBody = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<BusTaxi>>(responseBody);
                }
                return result;
            }
        }
    }
}