using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PhanHe6NhomNghia.Model;

namespace PhanHe6NhomNghia.Utilities
{
    class Data
    {
        public List<DiemSV>loaddiemsv()
        {
            List<DiemSV> listdiemsv = new List<DiemSV>();
            using (BinaryReader reader = new BinaryReader(File.Open("@../../../Resource/DiemSV.txt", FileMode.Open)))
            {

            }
            return listdiemsv;
        }

        public static void saveDiemSV(List<DiemSV> listDiemSV)
        {
            using (BinaryReader write = new BinaryReader(File.Open("@../../../Resource/DiemSV.txt", FileMode.Open)))
            {

            }
        }
    }
}
