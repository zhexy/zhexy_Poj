using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using WCF_Lib;

namespace WCF_WinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChannelFactory<IStockDao> f = new ChannelFactory<IStockDao>("http");
            IStockDao dao = f.CreateChannel();
            Stock s = dao.QueryByCode(this.textBox1.Text);
            if (s != null)
            {
                this.textBox2.Text = s.Name;
                this.textBox3.Text = s.Price.ToString();
            }
        }
    }
}
