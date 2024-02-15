using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonDownload.Models
{
    //public class TravelPlace
    //{
    //    public string Listname { get; set; }
    //    public string Language { get; set; }
    //    public string Orgname { get; set; }
    //    public DateTime Updatetime { get; set; }
    //    public Infos Infos { get; set; }
    //}

    //public class Infos
    //{
    //    public Info[] Info { get; set; }
    //}

    public class TravelPlace
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Name_c { get; set; }
        public string Description { get; set; }
        public string Grade { get; set; }
        public string Add { get; set; }
        public string Zipcode { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Gov { get; set; }
        public string Website { get; set; }
        public string Picture1 { get; set; }
        public string Picdescribe1 { get; set; }
        public string Picture2 { get; set; }
        public string Picdescribe2 { get; set; }
        public string Picture3 { get; set; }
        public string Picdescribe3 { get; set; }
        public float Px { get; set; }
        public float Py { get; set; }
        public string Class { get; set; }
        public string Map { get; set; }
        public string Spec { get; set; }
        public string Serviceinfo { get; set; }
        public string Parkinginfo { get; set; }
        public int TotalNumberofRooms { get; set; }
        public int LowestPrice { get; set; }
        public int CeilingPrice { get; set; }
        public string TaiwanHost { get; set; }
        public string IndustryEmail { get; set; }
        public int TotalNumberofPeople { get; set; }
        public int AccessibilityRooms { get; set; }
        public int? PublicToilets { get; set; }
        public int? LiftingEquipment { get; set; }
        public int ParkingSpace { get; set; }
    }

}