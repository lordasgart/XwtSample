# XwtSample

Switches via compiler directive between Xwt.XamMac and Xwt.Wpf

# MacOS

The clue is to add the NuGet packages to Xwt.XamMac

and then

your local Xamarin.Mac.dll (be careful to take the correct architecture of your project, usually x86 even on 64bit machines)

usually something like

/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/i386/full/Xamarin.Mac.dll.

and you need to actively load the libxammac.dylib

ObjCRuntime.Dlfcn.dlopen("/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/libxammac.dylib", 0);

# Windows

Add Xwt.Wpf NuGet package
