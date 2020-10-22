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
using Parcial1aves.Core.Data;
using Parcial1aves.Core.Modelos;

namespace Parcial1aves.Core.Servicios
{
    public class avesServicio
    {
        private avesRepo _AvesRepo;
        public avesServicio()
        {
            _AvesRepo = new avesRepo();
        }
        public List<aves> GetAves()
        {
            return _AvesRepo.GetAves();
        }
        public aves GetAvesById(int id)
        {
            return _AvesRepo.GetAvesById(id);
        }
    }
}