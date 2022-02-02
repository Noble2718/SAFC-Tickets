using System;
using Wisej.Web;
using WisejPWAWebApplication1;

namespace WisejPWAWebApplication1
{
	static class Program
	{
		/**
		 * PWA Template
		 * 
		 * This template includes a ready-made InstallAppPanel that you can use
		 * to show a custom PWA installation prompt (works only in Chrome) and a
		 * set of 8 flavors of the Offline pages.
		 * 
		 * Rename the "Offline-#" style that you want to use to just "Offline" and
		 * delete the others. Wisej will only use the file in "/Offline".
		 * 
		 * If you set "offlineUrl" to "" or delete it from Default.json, Wisej will
		 * show a simple "Offline" toast instead of the full offline page.
		 * 
		 * Don't forget to update the version AssemblyInfo/AssemblyFileVersion when
		 * you want to update the offline cache.
		 */

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new Page1();

			// NOTE: this event fires only in Chrome at this time. Other browsers, including
			// Edge/Chrome don't seem to support it yet.
			Application.BeforeInstallPrompt += Application_BeforeInstallPrompt;
		}

		private static void Application_BeforeInstallPrompt(object sender, EventArgs e)
		{
			Application.BeforeInstallPrompt -= Application_BeforeInstallPrompt;


			
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}