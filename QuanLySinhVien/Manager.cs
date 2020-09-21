using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{

    /**
     * Class nay de quan li tat ca cac chuc nang cua ung dung
     * 
     */

    class Manager
    {
        /**
         * Show menu
         */
        public static int Menu()
        {
            int choice;
            Console.WriteLine("1. CRUD Student");
            Console.WriteLine("2. CRUD Nganh Dao Tao");
            Console.WriteLine("3. CRUD Bac Dao Tao");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        /**
         * CRUD student
         */
        public static int CRUDStudent()
        {
            int choice;
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Edit student exist");
            Console.WriteLine("3. Delete student");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }
        /**
         * CRUD nganh dao tao
         */
        public static int CRUDNganhDaoTao()
        {
            int choice;
            Console.WriteLine("1. Add new major");
            Console.WriteLine("2. Edit major exist");
            Console.WriteLine("3. Delete major");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        /**
         * CRUD Bac Dao Tao
         */
        public static int CRUDBacDaoTao()
        {
            int choice;
            Console.WriteLine("1. Add new major");
            Console.WriteLine("2. Edit major exist");
            Console.WriteLine("3. Delete major");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }


    }
}
