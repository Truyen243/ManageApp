﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
namespace WindowsFormsApp.Data
{
    class khoadow
    {
        public List<Khoa> lstKhoa = new List<Khoa>();
        public bool getKhoa()
        {

            String link = "https://qlsv.phamthanhnam.com/khoa/get/all";
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
                Console.WriteLine(stuff.data[0].GetType());
                JObject[] Khoa = stuff.data.ToObject<JObject[]>();
                foreach (JObject kh in Khoa)
                {
                    int a = (int)kh["id"];
                    String b = (string)kh["ten"];
                    String c = (string)kh["makhoa"];
                    Khoa k = new Khoa(a,b,c);
                    this.lstKhoa.Add(k);
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
