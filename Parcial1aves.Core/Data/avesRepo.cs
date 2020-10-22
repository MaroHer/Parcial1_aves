using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Parcial1aves.Core.Modelos;

namespace Parcial1aves.Core.Data
{
    public class avesRepo
    {
        public static List<aves> _Aves;

         static avesRepo()
        {
            var temp = new List<aves>();
            AddAves(temp);
            _Aves = temp.OrderBy(i => i.Name).ToList();
        }

        private static void AddAves(List<aves> aves)
        {
            aves.Add(new aves()
            {
                Id = 1,
                Name = "Cacatúa",
                Family = "Cacatuidae",
                ImageUrl = "images/cacatua.jpg",
                Description = "La familia está distribuida principalmente por Australasia, extendiéndose desde las Filipinas y las islas de Indonesia oriental que pertenecen a la Wallacea hasta Nueva Guinea, Australia y las islas Salomón. Su nombre proviene de la palabra malaya para designar a estas aves: kaka(k)tua, que a su vez, según distintas versiones, puede ser que proceda de kaka, «loro», y tuwah, que es una voz imitativa de su canto; o bien, de kakak, «hermana», y tua, «vieja», significando algo así como «hermana mayor».  "
            });
            aves.Add(new aves()
            {
                Id = 2,
                Name = "Águila arpía",
                Family = "Accipitridae",
                ImageUrl = "images/aguilaarpia.jpg",
                Description = "Es el águila más grande del Hemisferio Occidental y del Hemisferio Austral, y la única especie del género Harpia. Su hábitat es el bosque lluvioso. No se reconocen subespecies. "
            }); aves.Add(new aves()
            {
                Id = 3,
                Name = "Colibrí",
                Family = "	Trochilidae",
                ImageUrl = "images/colibri.jpg",
                Description = "Las especies que forman el género Colibri tienen un tamaño que oscila entre 9,5 y 15 cm, y un peso de 4,8 a 8,5 g. Aunque son aves pequeñas, no son las más pequeñas, dado que estos pertenecen al género Mellisuga. Tienen cola amplia, bifurcada o redondeada. El pico es negro y delgado, relativamente largo y curvado, y tienen una larga lengua en forma tubular. El plumaje de tres de las cuatro especies es principalmente verde o gris claro. "
            });
            aves.Add(new aves()
            {
                Id = 4,
                Name = "Agapornis",
                Family = "Psittaculidae",
                ImageUrl = "images/agaporni.jpg",
                Description = "Agapornis (en griego antiguo: ἀγάπης ὄρνις [agapes ornis], ‘ave de amor’‘tanto el nombre común como el científico se refieren a sus fuertes vínculos de pareja, el macho y la hembra pasan mucho tiempo juntos y con frecuencia se arreglan las plumas el uno al otro o se acurrucan juntos’)?es un género de aves psitaciformes de la familia Psittaculidae, cuyos miembros son nativos de África. Se les conoce vulgarmente como inseparables. "
            });

        }

        public List<aves> GetAves()
        {
            return _Aves;
        }
        public aves GetAvesById(int Id)
        {
            return _Aves.FirstOrDefault(Xamarin => Xamarin.Id == Id);

        }
    }
}