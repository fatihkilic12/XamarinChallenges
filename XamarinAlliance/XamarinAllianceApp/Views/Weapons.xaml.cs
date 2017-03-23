using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Weapons : ContentPage
    {
        Weapon guns;
        private ICollection<Weapon> weapons;

        public Weapons(ICollection<Weapon> weapons)
        {
            this.weapons = weapons;
            
        }

        public Weapons(Weapon weap)
        {
            BindingContext = guns = weap;
            InitializeComponent();
            
        }
    }
}
