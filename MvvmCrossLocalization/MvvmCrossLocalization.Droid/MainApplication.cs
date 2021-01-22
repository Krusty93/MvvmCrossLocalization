using System;

using Android.App;
using Android.Runtime;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossLocalization.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, Core.App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }
    }
}