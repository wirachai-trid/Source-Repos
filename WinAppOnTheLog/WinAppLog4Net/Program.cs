using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLog4Net
{
	static class Program
	{
		static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Log.Logger = new LoggerConfiguration()
				.WriteTo.Log4Net()
				.CreateLogger();

			Log.Information("Serilog: Serilog.WriteTo.Log4Net()");

			Logger.Info("Start Main()");
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			catch (Exception ex)
			{
				Log.Error(ex, "Serilog: มีบางอย่างผิดพลาดคลาดเคลื่อน");
			}
			finally
			{
				Log.CloseAndFlush();
			}
		}
	}
}
