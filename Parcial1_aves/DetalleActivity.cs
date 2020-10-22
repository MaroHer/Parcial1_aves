using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Parcial1aves.Core.Data;

namespace Parcial1_aves
{
    [Activity(Label = "DetalleActivity")]
    public class DetalleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Detalles);
            //Se rescata el dato que le mandamos a travez del nombre que le pusimos al mandarlo "ItemPosition". Si no recibe nada, entonces será -1
            int position = Intent.GetIntExtra("ItemPosition", -1);
            var item = avesRepo._Aves[position];
            
           
            FindViewById<TextView>(Resource.Id.nameTextView).Text = "Nombre: " + item.Name;
            FindViewById<TextView>(Resource.Id.familyTextView).Text = "Familia: " + item.Family.ToString();
            FindViewById<TextView>(Resource.Id.descripcionTextView).Text = "Descripción: " + item.Description.ToString();
            var imag = FindViewById<ImageView>(Resource.Id.aveView);

            Stream stream = Assets.Open(item.ImageUrl);
            Drawable drawable = Drawable.CreateFromStream(stream, null);
            imag.SetImageDrawable(drawable);
            return ;

        }
    }
}