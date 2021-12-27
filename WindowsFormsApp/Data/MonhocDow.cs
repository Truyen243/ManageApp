﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;

using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;


namespace WindowsFormsApp.Data
{
    class MonhocDow
    {
        public List<MonHoc> lstMon = new List<MonHoc>();
        
        public bool getMon()
        {
            
            String link = "https://qlsv.phamthanhnam.com/mh/get/all";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);

            httpWebRequest.Headers.Add("Authorization", "Bearer " + Cls_Main.adminStc.token);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";




            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);

                dynamic stuff = JsonConvert.DeserializeObject(result);

                JObject[] mons = stuff.data.ToObject<JObject[]>();
                foreach (JObject mon in mons)
                {
                    int id = (int)mon["id"];
                    String ten = (string)mon["ten"];
                    String ma = (string)mon["mamonhoc"];
                    int hs = (int)mon["hesodiem"];
                    int sotiet = (int)mon["sotiet"];
                    MonHoc k = new MonHoc(id, ma,ten, sotiet, hs);
                    this.lstMon.Add(k);
                }
                
                if (stuff.status == "success")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}