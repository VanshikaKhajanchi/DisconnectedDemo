using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisconnectedBAL;
using System.Data.SqlClient;//for connection
using System.Data;//for connection
using System.Configuration;//for using the connection string

namespace DiscontedDAL
{
    public class PrInfoDal
    {
        public bool InsertData(JobInfo info)
        {
            SqlConnection cn = new SqlConnection
                (ConfigurationManager.ConnectionStrings
                ["pubsConnectionString"].ToString());
            SqlDataAdapter da= new SqlDataAdapter
                ("select * from pub_info", cn);
            DataSet ds = new DataSet();
            da.Fill(ds,"pub_info");//here we are disconnected
            DataRow drow = null;//doesn't have constructor

            drow = ds.Tables[0].NewRow();
            drow[0] = info.JobId.ToString();
            drow[1] = (byte[])info.Logo;
            drow[2] = info.PrInfo;

            //here instead of 0 we can even write pub_info
            ds.Tables[0].Rows.Add(drow);
            //connected t odbserver for commit
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
           int i=da.Update(ds.Tables[0]);
            bool status = false;
            if (i > 0)
            {
                status = true;
            }
            return status;
        }
        //public bool UpdateData(JobInfo info)
        //{

        //}
        //public bool DeleteData(string id)
        //{

        //}

        //public List<JobInfo> ShowJobInfo()
        //{

        //}

    }
}
