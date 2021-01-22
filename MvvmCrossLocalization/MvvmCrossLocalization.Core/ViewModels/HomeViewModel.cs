using MvvmCross.Localization;
using MvvmCross.ViewModels;

namespace MvvmCrossLocalization.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel, IMvxLocalizedTextSourceOwner
    {
        public IMvxLanguageBinder LocalizedTextSource =>
            new MvxLanguageBinder("", GetType().Name);
    }
}
