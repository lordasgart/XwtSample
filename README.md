# XwtSample

# MacOS

The clue is to add the NuGet packages to Xwt.XamMac

and then

your local Xamarin.Mac.dll

and you need to actively load the libxammac.dylib

ObjCRuntime.Dlfcn.dlopen("/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/libxammac.dylib", 0);
