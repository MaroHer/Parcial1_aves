using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Parcial1aves.Core.Servicios;
using Android.Content;

namespace Parcial1_aves
{
   
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main);
            var avesList = FindViewById<ListView>(Resource.Id.avesView);
            var aveServicio = new avesServicio();
            avesList.Adapter = new aveAdaptador(aveServicio.GetAves());
            avesList.ItemClick += OnAvesClick;
        }

          void OnAvesClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int position = e.Position;

            var intent = new Intent(this, typeof(DetalleActivity));
            intent.PutExtra("ItemPosition", position);
            StartActivity(intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}