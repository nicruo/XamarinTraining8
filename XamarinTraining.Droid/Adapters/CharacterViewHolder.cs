using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace XamarinTraining.Droid.Adapters
{
    public class CharacterViewHolder : RecyclerView.ViewHolder
    {
        public TextView TextView { get; private set; }
        public ImageView ImageView { get; private set; }

        public CharacterViewHolder(View v) : base(v)
        {
            TextView = (TextView)v.FindViewById(Resource.Id.textView);
            ImageView = (ImageView)v.FindViewById(Resource.Id.imageView);
        }
    }
}