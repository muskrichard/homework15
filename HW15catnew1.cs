namespace HW15
{
    class HW15catnew
    {
        public string _cName { get; set; }
        public int _jump { get; set; }
        public int _energy { get; set; }
        public string _color { get; set; }


        public HW15catnew(string name, int jump, int energy, string color)
        {
            _cName = name;
            _jump = jump;
            _energy = energy;
            _color = color;
        }

    }

}
