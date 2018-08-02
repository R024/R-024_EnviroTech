using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hajj1.Models
{
    public class BaseModel
    {



        #region الحاويات
        public static int NumberAllStorages { get; set; } = 711;//الكلي
        public static int ActualStoragesNumber { get; set; } = 711;//الفعلي

        public static int NeedMientenance { get; set; } = 0;//بحاجة لصيانة
        public static float AverageTemperature { get; set; } = 38;//متوسط الحرارة


        public static int NumberOfIsFullStorages { get; set; } = 0;
        public static int NumberOfIsEmpty { get; set; } = 0;
        public static int NumberOfCollected { get; set; } = 0;

        #endregion

        #region stati  الإنترنت

        public static int NumberOfWiFiUser { get; set; } = 210;
        public static int NumberOfQutaUsing { get; set; } = 24;

        #endregion
    }

    public class DashBoardModel
    {
        public int numberAllStorages { get; set; }  //الكلي
        public int actualStoragesNumber { get; set; }  //الفعلي

        public int needMientenance { get; set; }  //بحاجة لصيانة
        public float averageTemperature { get; set; }  //متوسط الحرارة


        public int numberOfIsFullStorages { get; set; }
        public int numberOfIsEmpty { get; set; }
        public int numberOfCollected { get; set; }




        public int numberOfWiFiUser { get; set; }
        public int numberOfQutaUsing { get; set; }
        
    }
}