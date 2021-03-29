using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSeriLog
{
	static class Program
	{
		//for log Seq
		private const string SeqURI = "http://localhost:5341";
		private const string SeqAPIKey = "hAtqDhTDFYmqd0LbyJQV";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//\ set Config start to using Serilog;
			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Debug()
				//.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
				.WriteTo.Console(
					outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}"
					)
				.WriteTo.File("logs/myApp.log"
					, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
					, rollingInterval: RollingInterval.Day
					)
				.WriteTo.Seq(SeqURI, apiKey: SeqAPIKey)
				.WriteTo.Debug()
				.CreateLogger();

			//\ use
			Log.Information("> Starting! H e l l o, M a i n B e g i n P r o g r a m m e!");

			try
			{
				var xmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "WinAppSeriLog.XML";
				Log.Debug(" : " + xmlPath);

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			catch (Exception ex)
			{
				Log.Error(ex, "มีบางอย่างผิดพลาดคลาดเคลื่อน");
			}
			finally
			{
				Log.Information("> Ending. CloseAndFlush()");
				Log.CloseAndFlush();
			}
		}
	}
}
