using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {
        public static readonly string connectionString = "";
        public static readonly string bancoEscolhido = "";
       

        static Db()
        {
            bancoEscolhido = ConfigurationManager.AppSettings["bancodedados"];
            connectionString = ConfigurationManager.ConnectionStrings[bancoEscolhido].ConnectionString;

        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            int id = 0;

            if (bancoEscolhido == "dbsqlite")
                id = DbSqlite.Insert(sql, parameters);

            if (bancoEscolhido == "DBeAgenda")
                id = DbSqlServer.Insert(sql, parameters);

            return id;
        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            if (bancoEscolhido == "dbsqlite")
                DbSqlite.Update(sql, parameters);

            if (bancoEscolhido == "DBeAgenda")
                DbSqlServer.Update(sql, parameters);

        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            if (bancoEscolhido == "dbsqlite")
                DbSqlite.Delete(sql, parameters);

            if (bancoEscolhido == "DBeAgenda")
                DbSqlServer.Delete(sql, parameters);



        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            
            if (bancoEscolhido == "dbsqlite")
                 return DbSqlite.GetAll<T>(sql, convert, parameters);

            if (bancoEscolhido == "DBeAgenda")
                return DbSqlServer.GetAll<T>(sql, convert, parameters);

            return new List<T>();
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            if (bancoEscolhido == "dbsqlite")
                return DbSqlite.Get<T>(sql, convert, parameters);

            if (bancoEscolhido == "DBeAgenda")
                return DbSqlServer.Get<T>(sql, convert, parameters);

            return default;
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            if (bancoEscolhido == "dbsqlite")
                return DbSqlite.Exists(sql, parameters);

            if (bancoEscolhido == "DBeAgenda")
                return DbSqlServer.Exists(sql, parameters);


            return false;
        }

        

       

       

    }
}
