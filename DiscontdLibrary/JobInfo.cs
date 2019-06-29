using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedBAL
{
    public class JobInfo
    {
        private string jobID;

        public string JobId
        {
            get { return jobID; }
            set {

                jobID = value;

                if (string.IsNullOrEmpty(jobID))
                {
                    throw new Exception("Null not Allowed");
                }
                else {
                    jobID = value;
                }
                   
                }
        }
        private byte[] logo;

        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        private string pr_info;

        public string  PrInfo
        {
            get { return pr_info; }
            set {

                pr_info = value;
                if (string.IsNullOrEmpty(pr_info))
                {
                    throw new Exception("Null not Allowed");
                }
                else
                {
                    pr_info = value;
                }
            }
        }



    }
}
