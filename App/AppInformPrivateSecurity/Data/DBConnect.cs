using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Sockets;

namespace AppInformPrivateSecurity.Data
{
    #region глобальные переменные, но так лучше не делать в реальных проектах это плохая практика.
    public static class GlobalValues
    {
        public static string ConnectionString = @"Server=RTDP-COMPUTERS;Database=InformPrivateSecure;Trusted_Connection=True;";
    }
    #endregion

    #region Класс DBConnect предостовляет доступ к базе данных
    /// <summary>
    /// Класс предостовляет доступ к базе данных
    /// </summary>
    internal class DBConnect
    {
        private SqlConnection cn = null;
        public SqlConnection connect { get { return cn; } }

        public String errorString = "";
        /// <summary>
        /// подключаем базу 
        /// </summary>
        public DBConnect(string connectionString)
        {
            try
            {
                cn = new SqlConnection(connectionString);
            }
            catch (SqlException ex)
            {
                cn = null;
                errorString = ex.Message;
            }
        }
    }
    #endregion

    #region Класс DBServiceMedical предостовляет робочую область выполнения запросов в пространстве "cправочников"
    public class DBServiceSpr
    {
        public String ErrorString = "";
        private DBConnect Connect;
        public DBServiceSpr()
        {
            Connect = new DBConnect(GlobalValues.ConnectionString);
            if (!String.IsNullOrEmpty(Connect.errorString))
            {
                throw new DBException("Ошибка подключения к Базе Данных", Connect.errorString);
            }
        }
        /// <summary>
        /// Получаем медецинские центры. 
        /// </summary>
        /// <returns></returns>
        public DataTable getMedicalCenters()
        {
            string Query = "SELECT id as 'id', Name as 'Наименование', addres as 'Адрес', tel as 'Телефон'  FROM dbo.v_MedicalCenter;";
            return getContent(Query);
        }
        /// <summary>
        /// Получить данные по разрядам.
        /// </summary>
        /// <returns></returns>
        public DataTable getDischarge()
        {
            string Query = "SELECT ID as 'id' , code as 'Код', discription as 'Описание' FROM v_Discharge order by code asc;";
            return getContent(Query);
        }
        /// <summary>
        /// Получить учебные центры.
        /// </summary>
        /// <returns></returns>
        public DataTable getEducationCenters()
        {
            string Query = "SELECT id as 'id', name as 'Наименование', license as 'Лицензия', address as 'Адрес' FROM v_EducationalInstitutions";
            return getContent(Query);
        }

        /// <summary>
        /// Получаем элемент медецинское учереждение
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> getElementMedical(string id)
        {
            string Query = "SELECT Name as 'Наименование', addres as 'Адрес', tel as 'Телефон'  FROM dbo.v_MedicalCenter WHERE id = " + id + " ;";
            return getElement(Query);
        }
        /// <summary>
        /// Получаем элемент разряд
        /// </summary>
        /// <returns></returns>
        public List<string> getElementDischarge(string id)
        {
            string Query = "SELECT code as 'Код', discription as 'Описание' from v_Discharge WHERE id = " + id + " ;";
            return getElement(Query);
        }
        /// <summary>
        /// Получаем элемент учебное заведение
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> getElementEducationCenters(string id)
        {
            string Query = "SELECT name as 'Наименование', license as 'Лицензия', address as 'Адрес' FROM v_EducationalInstitutions WHERE id = " + id + " ;";
            return getElement(Query);
        }
        public bool saveMedical(string name, string addres, string tel, string id = null)
        {
            string Query = "[dbo].[AddMedicalCenter] '" + name + "', '" + addres + "','" + tel + "' " + (id == null ? "; " : ", " + id + " ;");
            return executeRequest(Query);
        }
        public bool saveDischarge(string code, string discription, string id = null)
        {
            string Query = "[dbo].[AddDischarge] '" + code + "', '" + discription + "' " + (id == null ? "; " : ", " + id + " ;");
            return executeRequest(Query);
        }
        public bool saveEducationInst(string name, string license, string addres, string id = null)
        {
            string Query = "[dbo].[AddEducationalInstitutions] '" + name + "', '" + license + "', '" + addres + "' " + (id == null ? "; " : ", " + id + " ;");
            return executeRequest(Query);
        }

        #region Выполняем запрос на изменения данных
        /// <summary>
        /// Выполняем запрос без возврата
        /// </summary>
        /// <param name="Query">Запрос</param>
        /// <returns>результа выполнения</returns>
        private bool executeRequest(string Query)
        {
            bool result = false;
            Connect.connect.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, Connect.connect);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
            {
                ErrorString = e.Message;
                result = false;
            }
            return result;
        }
        #endregion

        #region получение справочников по одной записи
        /// <summary>
        /// Получить список записей по условию
        /// </summary>
        /// <param name="Query">Запрос</param>
        /// <returns></returns>
        private List<String> getElement(string Query)
        {
            List<String> list = new List<String>();
            Connect.connect.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, Connect.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            list.Add(reader.GetString(i));
                        }
                    }
                }
                Connect.connect.Close();
                return list;
            }
            catch (SqlException ex)
            {
                this.ErrorString = ex.Message;
                Connect.connect.Close();
                return null;
            }

        }
        #endregion

        #region Получаем DataTable для заполнения полей GridView.
        private DataTable getContent(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect.connect.Open(); // открыть подключение
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, Connect.connect);
                dataAdapter.Fill(dt);
            }
            catch (DBException ex)
            {
                ErrorString = ex.Message;
                dt = null;
            }
            finally
            {
                Connect.connect.Close();
            }
            return dt;
        }
        #endregion

    }
    #endregion

    #region DBException для отлавливания разных ошибок.
    /// Отлавливаем разные ошибки будем знать где они произошли и что за ошибки.
    public class DBException : Exception
    {
        public string Error { get; }
        public DBException(string message, string Error) : base(message)
        {
            this.Error = Error;
        }
    }
    #endregion
}
