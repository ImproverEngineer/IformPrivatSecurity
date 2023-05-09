using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using Microsoft.SqlServer.Server;

namespace AppInformPrivateSecurity.Data
{
    #region глобальные переменные, но так лучше не делать в реальных проектах это плохая практика.
    public static class GlobalValues
    {
        /// <summary>
        /// строка подключения 
        /// </summary>
        public static string ConnectionString = @"Server=RTDP-COMPUTERS;Database=InformPrivateSecure;Trusted_Connection=True;";
        /// <summary>
        /// Количество дней периода проверки следующей инспекции
        /// </summary>
        public static int ValidDayPeriodInspection = 12;
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

    #region Получение данных о работнике форма характеристика
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
                string Query = "EXEC [dbo].[AddEmployee] '" + name + "', '" + surname + "', '" + middleNema + "', '" + birthday + "', '" + telefon + "', '" + photo + "';";
                return executeRequestIsert(Query);

            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region получить данные работника
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
        #endregion

        #region Получить данные о медецинской комиссии
        /// <summary>
        /// Получить данные о медециннской комиссии работника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable MedicalCommission(string id)
        {
            string Query = @"SELECT m.[name] as 'Клиника', m.[code] as 'Код', m.[Date] as 'Дата прохождения', m.[valiedPeriod] as 'Количество мес. действия', DATEADD(MONTH,valiedPeriod,Date) as 'Дата продления'
                             FROM dbo.v_MedicalCommission m 
                             WHERE m.workersId = " + id;
            return getContent(Query);
        }
        #endregion
        /// <summary>
        /// Получаем последний вставленный элемент в таблице Workers
        /// </summary>
        /// <returns></returns>
        public List<string> getIdLastInsertEmploeer()
        {
            string Query = "SELECT top 1 id FROM [dbo].[Workers] ORDER BY id DESC"; //тут типа ошибка новичка но не очень такая существенная 
            return getElement(Query);
        }

        /// <summary>
        /// Заполнить Grid c Индитификатором работников
        /// </summary>
        /// <param name="id">ид работника</param>
        /// <returns></returns>
        internal DataTable IdentityCard(string id)
        {
            string Query = "SELECT * FROM v_IdentityCard WHERE id = " + id + "ORDER BY [Дата получения], [Срок действия до] DESC";
            return getContent(Query);
        }

        internal List<string> getWorker(string id)
        {
            string Query = "SELECT * FROM v_shortInfoAboutPerson where id = " + id;
            return getElement(Query);
        }

        internal bool setPeriodCommission(string id, string dateExam)
        {
            ///нужна проверка что у человека не назначена провека на другое число и если назначено то удаляем старое вставляем все по новый
            string Query = "SELECT id FROM PeriodicInspection WHERE workerId = " + id + " AND (DATECREATE BETWEEN GETDATE() AND '" + dateExam + "' OR DATECREATE>=GETDATE())";
            List<string> result = getElement(Query);
            if (result.Count > 0)
            {
                foreach (string str in result)
                {
                    /// Если мы тут у этого человека назначена проверка знания на какуюто другую дату между сегодня и новой датой сдачи.
                    /// Следовательно удаляем старую атестацию и назначаем по новой.
                    Query = "DELETE FROM PeriodicInspection WHERE id = " + str;
                    executeRequest(Query);
                }
            }
            ///Назначаем дату сдачи экзамена
            Query = "INSERT INTO PeriodicInspection(dateCreate, workerid) VALUES ('" + dateExam + "', " + id + ")";
            return executeRequest(Query);
        }
    }
    #endregion

    #region Получение данных об образовании работника (корочка охраника) дата окончания группа доспупа и.т.д
    class IdentityCardData : СreateQuery
    {
        // Возможно этот код нам еще понадобится так что применяем паттерн одиночка
        static IdentityCardData instance;
        public static IdentityCardData IdentityCard()
        {
            if (instance == null)
            {
                instance = new IdentityCardData();
            }
            return instance;
        }
        private IdentityCardData()
        {

        }

        //получить разряды в cmbDischarge
        public List<string> getDischarge()
        {
            string Query = "select discription from v_Discharge";
            return getElement(Query);
        }

        //Получить учебные заведения из списка учебных заведений
        public List<string> getEducationalInstitutions()
        {
            string Query = "select Name from dbo.EducationalInstitutions";
            return getElement(Query);
        }

        /// <summary>
        /// создаем удостоверение охраника.
        /// </summary>
        /// <param name="discarge"></param>
        /// <param name="dateCreates"></param>
        /// <param name="nTerm"></param>
        /// <param name="codeEducation"></param>
        /// <param name="dateEducations"></param>
        /// <param name="nameEducational"></param>
        internal void createIndentityCard(string id, string discarge, string dateCreates, string nTerm, string codeEducation, string dateEducations, string nameEducational)
        {
            string Query = "exec dbo.createIdentityCard " + id + ",'" + discarge + "', '" + dateCreates + "', " + nTerm + ", '" + codeEducation + "', '" + dateEducations + "', '" + nameEducational + "';";
            executeRequest(Query);

        }
        /// <summary>
        /// обновляем удостоверение охранника.
        /// </summary>
        /// <param name="id">id identity card</param>
        /// <param name="discarge"></param>
        /// <param name="dateCreates"></param>
        /// <param name="nTerm"></param>
        /// <param name="codeEducation"></param>
        /// <param name="dateEducations"></param>
        /// <param name="nameEducational"></param>
        public void updateIndentityCard(string id, string discarge, string dateCreates, string nTerm, string codeEducation, string dateEducations, string nameEducational)
        {
            string Query = "exec dbo.[updateIdentityCard] " + id + ",'" + discarge + "', '" + dateCreates + "', " + nTerm + ", '" + codeEducation + "', '" + dateEducations + "', '" + nameEducational + "';";
            executeRequest(Query);
        }
        public List<string> getIdentityCard(string id)
        {
            string Query = "select * from v_idenityCard where id = " + id; // найдем заслуги человека 
            return getElement(Query);
        }

    }
    #endregion

    #region Медецинская форма
    public class MedicalForm : СreateQuery
    {
        /// <summary>
        /// Получить список медецинских центров
        /// </summary>
        /// <returns></returns>
        public List<string> getMedicalCenters()
        {
            string Query = "SELECT name FROM v_MedicalCenter";
            return getElement(Query);
        }

        internal void UpdateCommission(object id_Worker, string stMedicalCenter, string stCode, string stDateCreate, string stDatePeriod)
        {
            string Query = "exec dbo.UpdateMedicalCommission " + id_Worker + ", '" + stMedicalCenter + "', '" + stCode + "', '" + stDateCreate + "', " + stDatePeriod + ";";
            executeRequest(Query);

        }
        public List<string> getCurrentMedicalProperties(string id)
        {
            string Query = @"select m.[name] as 'name', m.[code] as 'code', m.[Date] as 'Data', m.[valiedPeriod] as 'valiedPeriod', DATEADD(MONTH,valiedPeriod, Date)  as [extenxionDate] 
                             from [dbo].[v_MedicalCommission] m                             
                             where m.workersId = " + id + ";";
            return getElement(Query);
        }

    }
    #endregion

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

    #region Авторизация пользователей 
    class Authorization : СreateQuery
    {
        /// <summary>
        /// Получить список пользователей
        /// </summary>
        /// <returns></returns>
        public List<string> getUsers()
        {
            string Query = "select [name] from AppUser order by [name] asc";
            return getElement(Query);
        }

        internal bool checkPassword(string users, string password)
        {
            string Quer = "select * from AppUser where name = '" + users.Trim() + "'  and password ='" + password.Trim() + "'";
            if (getElement(Quer).Count > 0)
            {
                return true; // если что то есть то возвращаем истина.
            }
            else
            {
                return false; // если такого пользователя и пароля нет возврашаем лож.
            };
        }
    }
    #endregion

    #region Окно переодической инспекции инспекции 
    class InitialInspection : СreateQuery
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter">условия некоторого отбора</param>
        /// <returns></returns>
        public DataTable getInspection(string filter = null)
        {
            string Query = "";

            if (!string.IsNullOrEmpty(filter))
            {
                filter = "WHERE 1=1 " + filter;
                Query = "SELECT id as id, name as 'Ф.И.О', dateCreate as 'Дата назначения', result as 'Результать сдачи', code as 'Код удостоверения', discription as 'Разряд охраника', dateValidate as 'Дата следующей проверки' FROM v_PeriodicInspection " + filter;
            }
            else
            {
                Query = "SELECT id as id, name as 'Ф.И.О', dateCreate as 'Дата назначения', result as 'Результать сдачи', code as 'Код удостоверения', discription as 'Разряд охраника', dateValidate as 'Дата следующей проверки' FROM v_PeriodicInspection";
            }
            return getContent(Query);
        }
        #region Cписок работников у которых либо назначен либо уже был экзамен
        public List<string> getWorker()
        {
            string Query = "SELECT distinct name FROM v_PeriodicInspection ORDER BY name ASC";
            return getElement(Query);
        }
        #endregion

        #region Обновить результаты экзамена 
        internal bool UpdateResulExam(string id, string result)
        {
            string Query = @"UPDATE PeriodicInspection
                              set result = " + result + ", validate = " + GlobalValues.ValidDayPeriodInspection +
                             " where id = " + id + " ";
            return executeRequest(Query);
        }
        #endregion


    }
    #endregion

    #region Администрироване пользователей
    class AdministrationUsers : СreateQuery
    {
        public DataTable GetUsers()
        {
            string Query = "SELECT [id], [name] as 'Имя', [password] as 'Пароль' FROM AppUser  order by [name] asc";
            return getContent(Query);
        }
        /// <summary>
        /// Пробелы не учитываются
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        internal bool AddUsers(string name, string password)
        {
            string Query = "INSERT INTO AppUser([name], [password]) VALUES ('" + name.Trim() + "', '" + password.Trim() + "')";
            return executeRequest(Query);
        }

        internal bool DeleteUser(string userId)
        {
            string Qurey = "DELETE FROM [AppUser] where id = " + userId + "";
            return executeRequest(Qurey);
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
        /// Выполняем запрос возврат скалярной велечены
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

        #region Получить список (List()) записей по условию
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

    #region DBException для отлавливания (обработке) разных ошибок.
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
