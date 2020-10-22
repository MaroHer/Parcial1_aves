using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Parcial1aves.Core.Modelos;
using Stream = System.IO.Stream;

namespace Parcial1_aves
{
    public class aveAdaptador : BaseAdapter<aves>
    {
        public  List<aves> aves;
        public aveAdaptador(List<aves> aves)
        {
            this.aves = aves;
        }
        public override aves this[int position]
        {
            get
            {
                return aves[position];
            }
        }
        public override int Count
        {
            get
            {
                return aves.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.avesRow, parent, false);

            var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
            var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
            var Family = view.FindViewById<TextView>(Resource.Id.familyTextView);

            Stream stream = parent.Context.Assets.Open(aves[position].ImageUrl);
            Drawable drawable = Drawable.CreateFromStream(stream, null);
            photo.SetImageDrawable(drawable);

            name.Text = aves[position].Name;
            Family.Text = aves[position].Family;

            return view;

        }
    }
}