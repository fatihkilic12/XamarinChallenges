using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp
{
  
 class Characterinfo
    {
        public Character Cinfo { get; set; }
        public Characterinfo(Character character = null)
        {
            Cinfo = character;
            
        }
    }
}
