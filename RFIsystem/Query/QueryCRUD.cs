using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Data;
using RFIsystem.Models;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;

namespace RFIsystem.Query
{
    public class QueryCRUD : Connection
    {

        #region Sqlconnection
        public SqlConnection conn;
        private void connection()
        {

            string connectionStr = GetConnectionString();
            conn = new SqlConnection(connectionStr);
        }
        #endregion
        public bool CheckLogin(string User_name, string Password, string Job_no)
        {
            bool result = false;
            List<LoginModel> getlist = new List<LoginModel>();
            SqlCommand com = new SqlCommand();
            SqlDataReader rd = null;

            #region Connection Database
            SqlConnection con = new SqlConnection();

            con = connectionDB();

            com.Connection = con;
            #endregion

            #region Send Query

            com.CommandType = CommandType.Text;
            com.CommandText = "select count(cl.User_name) as User_name " +
                "from V_CheckLogin as cl " +
                "where cl.User_name = '" + User_name + "'" +
                "and cl.Password = '" + Password + "' " +
                "and cl.Job_no = '" + Job_no + "'";

            #endregion

            #region Return Data

            rd = com.ExecuteReader();

            if (rd != null && rd.HasRows)
            {
                while (rd.Read())
                {
                    int count = Convert.ToInt16(rd["User_name"].ToString());

                    if (count == 1)
                    {


                        result = true;


                    }


                }


            }

            #endregion

            return result;


        }
        public LoginModel Get_T_SessionEmail(string User_name, string Password, string Job_no)
        {

            try
            {
                connection();
                SqlConnection con = new SqlConnection();
                LoginModel getlist1 = new LoginModel();

                string GetQuery = "select cl.First_name as fn from V_CheckLogin as cl where cl.User_name = '"+User_name+"' and cl.Password = '"+Password+"' and cl.Job_no = '"+Job_no+"'";
                SqlCommand cmd = new SqlCommand(GetQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();


                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                foreach (DataRow dr in dt.Rows)
                {



                    getlist1.First_name = Convert.ToString(dr["fn"]);




                }

                return getlist1;


            }
            catch (Exception)
            {

                return null;

            }


        }
        public List<Showlistall> showonlylogin(/*string User_name, string Password*/)
        {

            try
            {
                connection();

                List<Showlistall> getlist1 = new List<Showlistall>();

                string GetQuery = "select vs.Descripline as Descripline,vs.Description as Descriptions,vs.KKS_Code as KKS_Code , vs.KKS_Description as KKS_Description, vs.OpenQty as OpenQty,vs.IssuedQty as IssuedQty,vs.AccQty as AccQty,vs.RejQty as RejQty, vs.OngoingQty as OngoingQty,vs.WaitingCloseQty as WaitingCloseQty,vs.WaitingCloseQtyClient as WaitingCloseQtyClient,vs.CloseQty as CloseQty,vs.CancelQty as CancelQty from V_sum as vs";    
                SqlCommand cmd = new SqlCommand(GetQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();


                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                foreach (DataRow dr in dt.Rows)
                {

                    getlist1.Add(
                        new Showlistall
                        {

                            Descripline = Convert.ToString(dr["Descripline"]),
                            Description = Convert.ToString(dr["Descriptions"]),
                            KKS_Code = Convert.ToString(dr["KKS_Code"]),
                            KKS_Description = Convert.ToString(dr["KKS_Description"]),
                            OpenQty = Convert.ToString(dr["OpenQty"]),
                            IssuedQty = Convert.ToString(dr["IssuedQty"]),
                            AccQty = Convert.ToString(dr["AccQty"]),
                            RejQty = Convert.ToString(dr["RejQty"]),
                            OngoingQty = Convert.ToString(dr["OngoingQty"]),
                            WaitingCloseQty = Convert.ToString(dr["WaitingCloseQty"]),
                            WaitingCloseQtyClient = Convert.ToString(dr["WaitingCloseQtyClient"]),
                            CloseQty = Convert.ToString(dr["CloseQty"]),
                            CancelQty = Convert.ToString(dr["CancelQty"]),
                            
                        });


                }
                return getlist1;



            }
            catch (Exception)
            {

                return null;

            }


        }
        public List<ShowBeforeApproved> showBeforeApproved(/*string User_name, string Password*/)
        {

            try
            {
                connection();

                List<ShowBeforeApproved> getlist1 = new List<ShowBeforeApproved>();

                string GetQuery = "select sa.Job_no as jn ,sa.User_name as un, sa.First_name as fn , sa.Prepared as pp ," +
                    " sa.PreparedDate as pd ,PreparedBy as pb , sa.Verified as vf ," +
                    " sa.VerifiedDate as vd , sa.VerifiedBy as vb , sa.Received as rc ," +
                    " ReceivedDate as rd , ReceivedBy as rb from showBeforeApproved as sa " +
                    "where  sa.First_name = 'Administrator' and sa.Job_no = 'J-BPRP1' and sa.Prepared = '0' or sa.Prepared = '1'";
                SqlCommand cmd = new SqlCommand(GetQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();


                conn.Open();
                adapter.Fill(dt);
                conn.Close();

                foreach (DataRow dr in dt.Rows)
                {

                    getlist1.Add(
                        new ShowBeforeApproved
                        {
                            Job_no = Convert.ToString(dr["jn"]),
                            User_name = Convert.ToString(dr["un"]),
                            Frist_name = Convert.ToString(dr["fn"]),
                            Prepared = Convert.ToString(dr["pp"]),
                            PreparedDate = Convert.ToDateTime(dr["pd"]),
                            PreparedBy = Convert.ToString(dr["pb"]),
                            Verified = Convert.ToString(dr["vf"]),
                            VerifiedDate = Convert.ToString(dr["vd"]),
                            VerifiedBy = Convert.ToString(dr["vb"]),
                            Received = Convert.ToString(dr["rc"]),
                            ReceivedDate = Convert.ToString(dr["rd"]),
                            ReceivedBy = Convert.ToString(dr["rb"]),
    
                        });


                }
                return getlist1;



            }
            catch (Exception)
            {

                return null;

            }


        }



    }
}
