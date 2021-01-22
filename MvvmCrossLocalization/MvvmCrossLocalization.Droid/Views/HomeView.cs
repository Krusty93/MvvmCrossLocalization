using Android.App;
using Android.OS;
using AndroidX.AppCompat.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCrossLocalization.Core.ViewModels;

namespace MvvmCrossLocalization.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    public class HomeView : MvxActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.home_view);

            var textView = FindViewById<AppCompatTextView>(Resource.Id.txtHello);

            var set = CreateBindingSet();

            set.Bind(textView).ToLocalizationId("Hello");

            set.Apply();
        }
    }
}