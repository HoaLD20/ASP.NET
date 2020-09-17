using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProvider;

namespace DatabaseIO
{
    public class DBIO
    {
        MyDB myDB = new MyDB();
        public user getObjectUser(string username, string password)
        {
            //1. do not using param
            //string sql = "select * from user where username = '"+username+"' and passoword ='"+password+"'";
            //return myDB.Database.SqlQuery<user>(sql).FirstOrDefault();

            //2. using param
            
            return myDB.Database.SqlQuery<user>("select * from user where username = @u and passoword = @p", new SqlParameter("@u", username), new SqlParameter("@p", password)).FirstOrDefault();
            
        }
    }
}
