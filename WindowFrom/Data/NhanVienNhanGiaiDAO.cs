﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Project_QuaySoMayMan.Common;

namespace WindowFrom.Data
{
    public class NhanVienNhanGiaiDAO
    {
        public List<NhanVienNhanGiai> nhanVienNhanGiais;
        public string path { get; set; }


        public NhanVienNhanGiaiDAO()
        {
            nhanVienNhanGiais = new List<NhanVienNhanGiai>();

            path = Cls_Main.pathNhanVienNhanGiai;
        }

        public void DocNoiDung(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    NhanVienNhanGiai nhanVienNhanGiai;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            nhanVienNhanGiai = new NhanVienNhanGiai()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                HoTen = vs[1],
                                PhongBan = vs[2],
                                Giai = vs[3]
                            };
                            
                            nhanVienNhanGiais.Add(nhanVienNhanGiai);
                        }
                    }
                }
            }
        }
        public void GhiNoiDung(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //Sử dụng cấu trúc using để khai báo đối tượng FileStream
                    foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
                    {
                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                        sw.WriteLine(string.Format("{0},{1},{2},{3}", item.ID, item.HoTen, item.PhongBan, item.Giai));
                    }
                }
            }
        }

        internal void XuatExcel(string path)
        {
            List<string> list = new List<string>();
            //code Xuất Excel 
            foreach (NhanVienNhanGiai item in nhanVienNhanGiais)
            {
                string line = string.Format("{0},{1},{2},{3}", item.ID, item.HoTen, item.PhongBan, item.Giai);
                list.Add(line);
            }
            string[] title = new string[]{
                "ID","Họ và tên","Phòng ban", "Giải"
            };
            XuatFileExcel.XuatExcel(path, list, "Danh sách nhân viên trúng giải", "Đã ký", title);
        }
    }
}
