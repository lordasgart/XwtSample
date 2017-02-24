using System;
using Xwt;

namespace XwtSample
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
                
#if __MonoCS__
            ObjCRuntime.Dlfcn.dlopen("/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/libxammac.dylib", 0);
            Application.Initialize(ToolkitType.XamMac);
#else
            Application.Initialize(ToolkitType.Wpf);
#endif

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
