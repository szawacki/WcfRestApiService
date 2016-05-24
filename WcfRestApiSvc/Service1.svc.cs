using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestApiSvc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private String _connnection = String.Empty;

        /// <summary>
        /// Get Sales.vSalesPerson data
        /// </summary>
        /// <returns>List<SalesPersonObject></returns>
        public List<SalesPersonObject> SalesvSalesPerson()
        {
            _connnection = ConfigurationManager.ConnectionStrings["ADW2014"].ConnectionString;
            return QueryDB<SalesPersonObject>("Select * From Sales.vSalesPerson");
        }

        public List<IndividualCustomerObject> SalesvIndividualCustomer()
        {
            _connnection = ConfigurationManager.ConnectionStrings["ADW2014"].ConnectionString;
            return QueryDB<IndividualCustomerObject>("Select * From Sales.vIndividualCustomer");
        }

        /// <summary>
        /// Query Database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">String</param>
        /// <returns>List<T></returns>
        private List<T> QueryDB<T>(String query) where T : new()
        {
            List<T> resultList = new List<T>();

            using (SqlConnection SqlConn = new SqlConnection(_connnection))
            {
                SqlConn.Open();
                SqlCommand cmd = new SqlCommand(query, SqlConn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            resultList.Add(FillProperties<T>(dr));
                        }
                    }
                }
                SqlConn.Close();
            }
            return resultList;
        }

        /// <summary>
        /// Fill DataContract Properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr">SqlDataReader</param>
        /// <returns>T</returns>
        private T FillProperties<T>(SqlDataReader dr) where T : new()
        {
            PropertyInfo[] name = typeof(T).GetProperties();
            T obj = new T();
            foreach (PropertyInfo p in name)
            {
                if (dr[p.Name] != DBNull.Value)
                {
                    obj.GetType().GetProperty(p.Name).SetValue(obj, Convert.ChangeType(dr[p.Name], p.PropertyType));
                }
            }
            return obj;
        }
    }
}
