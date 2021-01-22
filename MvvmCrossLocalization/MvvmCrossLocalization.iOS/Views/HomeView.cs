using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossLocalization.Core.ViewModels;
using UIKit;

namespace MvvmCrossLocalization.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeView : MvxViewController<HomeViewModel>
    {
        public HomeView()
        {
        }

        public override void ViewDidLoad()
        {
            View.BackgroundColor = UIColor.White;
            base.ViewDidLoad();

            var label = new UILabel { Text = "Hello!" };

            Add(label);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                label.WithSameCenterX(View),
                label.WithSameCenterY(View));

            var set = CreateBindingSet();

            set.Bind(label).ToLocalizationId("Hello");

            set.Apply();
        }
    }
}