using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class cats
    {
        public string _cName { get; set; }
        public int _jump { get; set; }
        public int _energy { get; set; }
        public string _color { get; set; }


        public cats(String name, int jump, int energy, String color)
        {
            _cName = name;
            _jump = jump;
            _energy = energy;
            _color = color;
        }

    }

}
