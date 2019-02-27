using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace WebSiteExample
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            
            return "Hello World";
        }

        [WebMethod]
        public string UrunListesi()
        {
            dbClass db = new dbClass();
            try
            {
                DataSet test = db.LoadDataSet(string.Format("Select Id,Title,Description from Products"));

                string ds = "";
                if (test.Tables[0].Rows.Count > 0)
                {
                    ds = JsonConvert.SerializeObject(test.Tables[0]);
                }

                return ds;

            }
            catch
            {
                return null;
            }
            finally
            {
                db.Dispose();
            }
        }


        [WebMethod]
        public bool UrunYeniKayit(string Title, string Description)
        {
            dbClass db = new dbClass();
            try
            {
                return db.SQLExecute(string.Format("Insert Into Products (Title,Description) Values('{0}','{1}')", Title, Description));

            }
            catch
            {
                return false;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
