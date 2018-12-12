using Cardview_XF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Cardview_XF.Datas
{
    public class CardviewData
    {

        private static DateTime TodayAt(int hour, int minute)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute,0);
        }
        
        public List<CardviewModel> CardviewModel = new List<CardviewModel>()
        {
            new CardviewModel
            {
                Name="Elif Aybike Aslan",
                StatusImage="btnKirmizi",
                Time=TodayAt(08,00),
                AlertColor=Color.FromHex("#ffc400")
            },
            new CardviewModel
            {
                Name="Büşra Uğur",
                StatusImage="btnYesil",
                Time=TodayAt(11,30),
                AlertColor=Color.FromHex("#ffc400")
            },
            new CardviewModel
            {
                Name="Gazme Özdal",
                StatusImage="btnKirmizi",
                Time=TodayAt(12,45),
                AlertColor=Color.FromHex("#ffc400")
            },
            new CardviewModel
            {
                Name="Muhribe İnci Atila",
                StatusImage="btnYesil",
                Time=TodayAt(08,00),
                AlertColor=Color.FromHex("#ffc400")
            },
            new CardviewModel
            {
                Name="Dicle Zorlu",
                StatusImage="btnYesil",
                Time=TodayAt(21,00),
                AlertColor=Color.FromHex("#ffc400")
            },
            new CardviewModel
            {
                Name="Cemile Tabur",
                StatusImage="btnKirmizi",
                Time=TodayAt(08,30),
                AlertColor=Color.FromHex("#ffc400")
            }
        };
    }
}
