using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisconnectedBAL;
using DiscontedDAL;
using System.IO;

namespace DisconnectedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobInfo info = new JobInfo();
            info.JobId = "9999";
           
            byte[] ar = null;
            string fname = @"C:\Users\TRG\Pictures\pexels-photo-853168.jpeg";
            FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            long b = new FileInfo(fname).Length;
            
            ar = br.ReadBytes((int)b);

            info.Logo = ar;
            info.PrInfo = "This is sample image";

            PrInfoDal dal = new PrInfoDal();
            dal.InsertData(info);

        }
    }
}
