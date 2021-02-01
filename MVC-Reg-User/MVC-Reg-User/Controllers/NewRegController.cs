using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Reg_User.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MVC_Reg_User.Controllers
{
    public class NewRegController : Controller
    {
        // GET: NewReg
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserClass uc,HttpPostedFileBase file)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into[dbo].[MVCregUser](Uname,NID,Date,Uimg) values(@Uname,@NID,@Date,@Uimg)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            return View();
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Uname", uc.Uname);
            sqlcomm.Parameters.AddWithValue("@NID", uc.NID);
            sqlcomm.Parameters.AddWithValue("@Date", uc.Date);
            sqlcomm.Parameters.AddWithValue("@Uimg", uc.Uimg);
            if(file!=null && file.ContentLength>0)
            {
                String filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/User-Images/"), filename);
                file.SaveAs(imgpath);
                
            }
            sqlcomm.Parameters.AddWithValue("@Uimg", "~/User-Images/"+file.FileName);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            ViewData["Message"] = "User Record" + uc.Uname + "Is saved successfully!";
            return View();
        }
    }
}