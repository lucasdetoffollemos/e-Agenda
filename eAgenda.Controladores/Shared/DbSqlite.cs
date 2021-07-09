using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Controladores.Shared
{
    
    public static class DbSqlite
    {


        public static int Insert(string sql, Dictionary<string, object> parameters)
        {

            using (IDbConnection cnn = new  SQLiteConnection(Db.connectionString)) {


                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql.AppendSelectIdentitySqlite(), (SQLiteConnection)cnn))
                {
                    cmd.SetParameters(parameters);
                   
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    cnn.Close();
                    return id;
                }
            }
        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {

            using (IDbConnection cnn = new SQLiteConnection(Db.connectionString))
            {
                
                SQLiteCommand comand = new SQLiteCommand(sql, (SQLiteConnection)cnn);
                comand.SetParameters(parameters);

                cnn.Open();
                comand.ExecuteNonQuery();
                cnn.Close();
            }

        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            using (IDbConnection cnn = new SQLiteConnection(Db.connectionString))
            {

                SQLiteCommand command = new SQLiteCommand(sql, (SQLiteConnection)cnn);

                command.SetParameters(parameters);

                cnn.Open();

                var list = new List<T>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = convert(reader);
                        list.Add(obj);
                    }
                }

                cnn.Close();

                return list;
            }
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            using (IDbConnection cnn = new SQLiteConnection(Db.connectionString))
            {
                cnn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, (SQLiteConnection)cnn);
                command.SetParameters(parameters);

                T t = default;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        t = convert(reader);
                }

                cnn.Close();
                return t;

            }
           
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            using (IDbConnection cnn = new SQLiteConnection(Db.connectionString))
            {
                cnn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, (SQLiteConnection)cnn);
                command.SetParameters(parameters);

                int numberRows = Convert.ToInt32(command.ExecuteScalar());

                cnn.Close();
                return numberRows > 0;

            }
        }

        private static void SetParameters(this SQLiteCommand command, Dictionary<string, object> parameters)
            {
                if (parameters == null || parameters.Count == 0)
                    return;

                foreach (var parameter in parameters)
                {
                    string name = parameter.Key;

                    object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                    SQLiteParameter dbParameter = new SQLiteParameter(name, value);

                    command.Parameters.Add(dbParameter);
                }
            }

        private static string AppendSelectIdentitySqlite(this string sql)
        {
            return sql + ";SELECT last_insert_rowid()";
        }

        private static bool IsNullOrEmpty(this object value)
            {
                return (value is string && string.IsNullOrEmpty((string)value)) ||
                        value == null;
            }

        }
    
}
