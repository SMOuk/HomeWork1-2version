using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cats
    {
        private string _name = "NoName";
        private int _age;
        private int _health;

        public Cats()
        {
            _health = 5;
        }

        public string CurrentColor
        {
            get {
                if (_health < 5)
                {
                    return CatColor.SickColor;
                }
                else
                {
                    return CatColor.HealthyColor;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == "NoName")
                {
                    _name = value;
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age == 0)
                {
                    _age = value;
                }
            }

        }

        public void Feed()
        {
            _health = _health ++ >= 10 ? 10 : _health ++;
        }

        public void Punish()
        {
            _health = _health -- < 0 ? 0 : _health --;
        }

    }
}
