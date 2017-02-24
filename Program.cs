using System;
using Xwt;

namespace XwtSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ObjCRuntime.Dlfcn.dlopen("/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/libxammac.dylib", 0);

			Application.Initialize(ToolkitType.XamMac);

			var mainWindow = new Window()
			{
				Title = "XwtSample",
				Width = 400,
				Height = 300
			};

			mainWindow.Show();

			Application.Run();
		}
	}
}
