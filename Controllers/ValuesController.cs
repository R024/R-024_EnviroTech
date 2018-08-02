using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using hajj1.Models;

namespace hajj1.Controllers
{
    public class ValuesController : ApiController
    {
       
        public string IsFull(int c) // زيادة عدد ممتلئة
        {
            try
            {
                BaseModel.NumberOfIsFullStorages++;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }



        public string IsEmpty(int c) // زيادة عدد الفارغة
        {
            try
            {
                BaseModel.NumberOfIsEmpty++;
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }


        public string IncreaseNumberOfWiFiUser(int c) // زيادة عدد مستخدمي النت
        {
            try
            {
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }


        public string IncreaseQutaUsing(int c) // زيادة كمية البيانات المستهلكة
        {
            try
            {
                return "1";
            }
            catch (Exception)
            {

                return "0";
            }

        }




        // GET api/values/5
        public string Get1(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
