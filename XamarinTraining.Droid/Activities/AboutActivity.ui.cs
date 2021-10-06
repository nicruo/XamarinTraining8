using Android.Widget;

namespace XamarinTraining.Droid.Activities
{
    public partial class AboutActivity
    {
        private EditText editText;
        public EditText EditText => editText ??= FindViewById<EditText>(Resource.Id.editText);

        private TextView textView;
        public TextView TextView => textView ??= FindViewById<TextView>(Resource.Id.textView);

        private Button saveButton;
        public Button SaveButton => saveButton ??= FindViewById<Button>(Resource.Id.saveButton);

        private TextView dataContent;
        public TextView DataContent => dataContent ??= FindViewById<TextView>(Resource.Id.dataContent);
    }
}