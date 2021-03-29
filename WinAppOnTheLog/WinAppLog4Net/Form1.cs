using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLog4Net
{
	public partial class Form1 : Form
	{
		private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public Form1()
		{
			InitializeComponent();
			logger.Info("Form1() InitializeComponent()");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			logger.Info("begin Form1_Load()");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			logger.Info("button1_Click()");
			Close();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			logger.Info("Form1_Shown()");
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			logger.Info("Form1_FormClosed()");
		}

		private void Form1_Click(object sender, EventArgs e)
		{
			logger.Info("Form1_Click()");
		}
	}
}
