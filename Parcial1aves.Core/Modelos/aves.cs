using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Parcial1aves.Core.Modelos
{
   public class aves
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Family { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name + " " + Family;
        }
    }
}