using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting;
using System.Web;
using MySql.Data.MySqlClient;
using P5WF;
using Renci.SshNet.Security.Cryptography;

namespace WebnhomNguyen.DAO
{
    public class DBConnection
    {
        List<sinh_vien> sinhvien;
        List<bacdt> bacdt;
        List<nganhdt> nganhdt;
        public MySqlConnection GetConnection()
        {
            string connString = "Server:localhost;database=phanhe5-04-10;port= 3306;ID=root;password=";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
        public List<sinh_vien> getListSV()
        {
            MySqlConnection con = new MySqlConnection();
            try
            {
                sinhvien = new List<sinh_vien>();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from `sinh_vien`", con);
                cmd.Prepare();
                MySqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    sinh_vien obj = new sinh_vien() ;
                    obj.MSSV = rd.GetString(0);
                    obj.MaNganh = rd.GetString(1);
                    obj.MaLop = rd.GetString(2);
                    obj.HoTenSV = rd.GetString(3);
                    obj.NgaySinhSV = rd.GetDateTime(4);
                    obj.GioiTinhSV = rd.GetString(5);
                    obj.DiaChiSV = rd.GetString(6);
                    obj.SDT = rd.GetString(7);
                    sinhvien.Add(obj);
                }
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
               
            }
            return null;
        }


        public List<nganhdt> getNganhdts()
        {
            MySqlConnection con = new MySqlConnection();
            try
            {
                nganhdt = new List<nganhdt>();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from `nganhdt`", con);
                cmd.Prepare();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    sinh_vien obj = new sinh_vien();
                    obj.MSSV = rd.GetString(0);
                    obj.MaNganh = rd.GetString(1);
                    obj.MaLop = rd.GetString(2);
                    obj.HoTenSV = rd.GetString(3);
                    obj.NgaySinhSV = rd.GetDateTime(4);
                    obj.GioiTinhSV = rd.GetString(5);
                    obj.DiaChiSV = rd.GetString(6);
                    obj.SDT = rd.GetString(7);
                    sinhvien.Add(obj);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();

            }
            return null;
        }
    
        public 


    }
}