using Android.App;
using Android.OS;
using Android.Widget;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using XamarinTraining.Core.ViewModels;

namespace XamarinTraining.Droid.Activities
{
    [Activity]
    public partial class AboutActivity : ActivityBase<AboutViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_about);

            bindings.Add(this.SetBinding(() => ViewModel.AboutTitle, () => EditText.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => EditText.Text, () => TextView.Text));
            bindings.Add(this.SetBinding(() => ViewModel.DataContent, () => DataContent.Text));
            SaveButton.SetCommand(ViewModel.SaveDataCommand);
        }
    }
}