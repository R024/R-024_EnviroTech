using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using hajj1.Models;

namespace hajj1.Controllers
{
    public class TestEnviromentController : Controller
    {
        // GET: TestEnviroment
        public ActionResult Index()
        {

            return View();
        }


        public static void SMSSx()
        {


            using (var client = new HttpClient())
            {

                String url = "http://apps.gateway.sa/vendorsms/pushsms.aspx?user=jaber&password=Qwer!23456&msisdn=966566526520&sid=TESTHACHATO&msg=Check%20Container%20Number%201234&fl=1";
                string result;
                //refer to parameters to complete correct url string

                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
                objRequest.Method = "POST";
                objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
                objRequest.ContentType = "application/x-www-form-urlencoded";
                try
                {
                    myWriter = new StreamWriter(objRequest.GetRequestStream());
                    myWriter.Write(url);
                }
                catch (Exception ex)
                {
                    //return e.Message;
                }
                finally
                {
                    myWriter.Close();
                }

                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    // Close and clean up the StreamReader
                    sr.Close();
                }
                //return result;

            }
        }




        public string IsFull() // زيادة عدد ممتلئة
        {
            try
            {
                SMSSx();
                BaseModel.NumberOfIsFullStorages++;
                return "1";
            }
            catch (Exception ex)
            {

                return "0";
            }

        }



        public string IsEmpty(int c = 0) // زيادة عدد الفارغة
        {
            try
            {
                BaseModel.NumberOfCollected++;
                BaseModel.NumberOfIsFullStorages--;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }


        public string IncreaseNumberOfWiFiUser(int c = 0) // زيادة عدد مستخدمي النت
        {
            try
            {
                BaseModel.NumberOfWiFiUser++;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }


        public string IncreaseQutaUsing(int c = 0) // زيادة كمية البيانات المستهلكة
        {
            try
            {
                BaseModel.NumberOfQutaUsing++;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }

        public string SenTemperture(int degree = 35) // زيادة كمية البيانات المستهلكة
        {
            try
            {
                BaseModel.AverageTemperature = degree;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }


        public string NeedMintemamce(int c = 0) // زيادة عدد مستخدمي النت
        {
            try
            {
                BaseModel.NeedMientenance++;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }



    }
}