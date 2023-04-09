using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;

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
        /// <summary>
        /// Паттерн фабрика создаем объект DBConnect.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DBException"></exception>
        public static DBConnect createDBConnect()
        {
            DBConnect Connect = new DBConnect(GlobalValues.ConnectionString);
            if (!String.IsNullOrEmpty(Connect.errorString))
            {
                throw new DBException("Ошибка подключения к Базе Данных", Connect.errorString);
            }
            return Connect;
        }
    }
    #endregion

    public class Employeer : СreateQuery
    {

        #region Получить работников
        /// <summary>
        /// Получить работников
        /// </summary>
        /// <returns></returns>
        public DataTable getWorkers()
        {
            string Query = "SELECT " +
                           " id as 'id'," +
                           " name as 'Имя'," +
                           " surname as 'Фамилия'," +
                           " middleName as 'Отчество'," +
                           " birthday as 'Дата рождения'," +
                           " telefon as 'Телефон'," +
                           " deleted as 'Уволен'" +
                           " FROM [dbo].[v_Workers]";
            return getContent(Query);
        }
        #endregion

        #region Записать работника
        /// <summary>
        /// Записать работника 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="middleNema">Отчество</param>
        /// <param name="birthday">День рождения</param>
        /// <param name="telefon">Телефон</param>
        /// <param name="photo">Путь до фото</param>
        /// <returns></returns>
        public string saveEmploeer(string name, string surname, string middleNema, string birthday, string telefon, string photo)
        {
            try
            {
                string Query = "exec [dbo].[AddEmployee] '" + name + "', '" + surname + "', '" + middleNema + "', '" + birthday + "', '" + telefon + "', '" + photo + "';";
                return executeRequestIsert(Query);

            }
            catch
            {
                return null;
            }
        }
        #endregion

        public List<string> informationWorker(string id)
        {
            string Query = "SELECT  name as 'name'," +
                           " surname as 'surname'," +
                           " middleName as 'middleName'," +
                           " birthday as 'bithday'," +
                           " telefon as 'telefon'," +
                           " photo as 'photo'" +
                           " FROM [dbo].[v_Workers] WHERE id = " + id + ";";
            return getElement(Query);
        }

        /// <summary>
        /// Получаем последний вставленный элемент в таблице Workers
        /// </summary>
        /// <returns></returns>
        public List<string> getIdLastInsertEmploeer()
        {
            string Query = "SELECT top 1 id FROM [dbo].[Workers] order by id desc"; //тут типа ошибка новичка но не очень такая существенная 
            return getElement(Query);
        }
    }

    public class MedicalForm : СreateQuery
    {
        /// <summary>
        /// Получить список медецинских центров
        /// </summary>
        /// <returns></returns>
        public List<string> getMedicalCenters()
        {
            string Query = "SELECT addres FROM v_MedicalCenter";
            return getElement(Query);
        }

        internal void UpdateCommision(object id_medicalCenter, string stMedicalCenter, string stCode, string stDateCreate, string stDatePeriod, string stDateRenewal)
        {
            string Query = "";
            executeRequest(Query);

        }
    }

    #region Класс DBService предостовляет робочую область выполнения запросов в пространстве "cправочников"
    public class DBServiceSpr : СreateQuery
    {
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
        /// <summary>
        /// удалям все ненужное из справочника
        /// </summary>
        /// <param name="id"></param>
        /// <param name="typeSpr"></param>
        /// <returns></returns>
        public bool deleteItemGridView(string id, string typeSpr)
        {
            string Query = "[dbo].[deleteFromSrp] " + id + ", '" + typeSpr + "' ";
            return executeRequest(Query);
        }

    }
    #endregion

    #region Запросы к БД
    public class СreateQuery
    {
        protected String ErrorString = "";
        private DBConnect Connect;

        public СreateQuery()
        {
            Connect = DBConnect.createDBConnect();
        }

        #region Выполняем запрос на изменения данных и возврат результата выполнения
        /// <summary>
        /// Выполняем запрос без возврата
        /// </summary>
        /// <param name="Query">Запрос</param>
        /// <returns>результа выполнения</returns>
        protected string executeRequestIsert(string Query)
        {
            string result = "";
            Connect.connect.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, Connect.connect);
                string st = cmd.ExecuteScalar().ToString();
                result = st;
            }
            catch (SqlException e)
            {
                ErrorString = e.Message;
                result = null;
            }
            finally
            {
                Connect.connect.Close();
            }
            return result;
        }
        #endregion

        #region Выполняем запрос на изменения данных
        /// <summary>
        /// Выполняем запрос без возврата
        /// </summary>
        /// <param name="Query">Запрос</param>
        /// <returns>результа выполнения</returns>
        protected bool executeRequest(string Query)
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
            finally
            {
                Connect.connect.Close();
            }
            return result;
        }
        #endregion

        #region Получить список записей по условию
        /// <summary>
        /// Получить список записей по условию
        /// </summary>
        /// <param name="Query">Запрос</param>
        /// <returns></returns>
        protected List<String> getElement(string Query)
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
                            // list.Add(reader.GetString(i).ToString());
                            list.Add(reader[i].ToString());
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
        protected DataTable getContent(string Query)
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
