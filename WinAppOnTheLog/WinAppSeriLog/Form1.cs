using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSeriLog
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//\using Serilog
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				Log.Information("Serilog: test123.. start Form1_Load()");
				Close();
			}
			catch (Exception er)
			{
				throw new Exception(er.Message);
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Log.Information("Serilog: test123.. bye-bye Form1_FormClosed()");
			}
			catch (Exception er)
			{
				throw new Exception(er.Message);
			}
		}
	}
}
