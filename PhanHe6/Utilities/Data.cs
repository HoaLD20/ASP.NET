using PhanHe6.Management;
using PhanHe6.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhanHe6.Utilities
{
    class Data
    {
        public static List<DiemSV> loadDiemSV()
        {
            List<DiemSV> listDiemSV = new List<DiemSV>();
            using (BinaryReader reader = new BinaryReader(File.Open(@"../../../Resources/DiemSV.txt", FileMode.Open)))
            {
                string[] data = reader.ReadString().Split("@");
                foreach (string s in data)
                {
                    string[] data2 = s.Split("$");
                    if (data2.Length < 8)
                        break;
                    DiemSV obj = new DiemSV();
                    obj.Mssv = data2[0];
                    obj.Idmh = data2[1];
                    obj.MaGV = data2[2];
                    obj.Ma_hk = data2[3];
                    obj.DiemLan1 = Convert.ToDouble(data2[4]);
                    obj.DiemLan2 = Convert.ToDouble(data2[5]);
                    obj.DiemTichLuy = Convert.ToDouble(data2[6]);
                    obj.DiemChu = data2[7];
                    listDiemSV.Add(obj);

                }
            }
            return listDiemSV;
            

        }

        public static void saveDiemSV(List<DiemSV> listDiemSV)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"../../../Resources/DiemSV.txt", FileMode.Create)))
            {
                String s = "";
                foreach (DiemSV obj in listDiemSV)
                {
                   s+=obj.ToString() + "@";
                }
                writer.Write(s);

            }
        }

        public static List<GiangVien> loadGiangVien()
        {
            List<GiangVien> listGiangVien = new List<GiangVien>();
            using (BinaryReader reader = new BinaryReader(File.Open(@"../../../Resources/GiangVien.txt", FileMode.Open)))
            {
                string[] data = reader.ReadString().Split("%");
                foreach (string s in data)
                {
                    string[] data2 = s.Split("$");
                    if (data2.Length < 7)
                        break;
                    GiangVien obj = new GiangVien();
                    obj.MaGV = data2[0];
                    obj.TenGV = data2[1];
                    obj.GioiTinhGV = Convert.ToInt32(data2[2]);
                    obj.NamSinhGV = Convert.ToDateTime(data2[3]);
                    obj.TrinhDoGV = data2[4];
                    obj.EmailGV = data2[5];
                    obj.Sdt = data2[6];
                    listGiangVien.Add(obj);

                }
            }
            return listGiangVien;


        }

        public static void saveGiangVien(List<GiangVien> listGiangVien)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"../../../Resources/GiangVien.txt", FileMode.Create)))
            {
                String s = "";
                foreach (GiangVien obj in listGiangVien)
                {
                    s += obj.ToString() + "%";
                }
                writer.Write(s);

            }
        }

        public static List<MonHoc> loadMonHoc()
        {
            List<MonHoc> listMonHoc = new List<MonHoc>();
            using (BinaryReader reader = new BinaryReader(File.Open(@"../../../Resources/MonHoc.txt", FileMode.Open)))
            {
                string[] data = reader.ReadString().Split("@");
                foreach (string s in data)
                {
                    string[] data2 = s.Split("$");
                    if (data2.Length < 6)
                        break;
                    MonHoc obj = new MonHoc();
                    obj.Idmh = data2[0];
                    obj.Ma_hk = data2[1];
                    obj.TenMH = data2[2];
                    obj.SoTC = Convert.ToInt32(data2[3]);
                    obj.LyThuyet = Convert.ToInt32(data2[4]);
                    obj.ThucHanh = Convert.ToInt32(data2[5]);
                    listMonHoc.Add(obj);

                }
            }
            return listMonHoc;


        }

        public static void saveMonHoc(List<MonHoc> listMonHoc)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"../../../Resources/MonHoc.txt", FileMode.Create)))
            {
                String s = "";
                foreach (MonHoc obj in listMonHoc)
                {
                    s += obj.ToString() + "@";
                }
                writer.Write(s);

            }
        }


    }
}
