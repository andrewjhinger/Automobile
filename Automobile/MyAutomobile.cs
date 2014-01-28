using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automobile
{
    public class MyAutomobile
    {
        private int _topspeed;

        public int Topspeed
        {
            get { return _topspeed; }
            set { _topspeed = value; }
        }
        private double _mpg;

        public double Mpg
        {
            get { return _mpg; }
            set { _mpg = value; }
        }
        private double _tanksize;

        public double Tanksize
        {
            get { return _tanksize; }
            set { _tanksize = value; }
        }
        private double _estdist;

        public double Estdist
        {
            get { return _estdist; }
            set { _estdist = value; }
        }
        private int _numdoors;

        public int Numdoors
        {
            get { return _numdoors; }
            set { _numdoors = value; }
        }
        private bool _sunroof;

        public bool Sunroof
        {
            get { return _sunroof; }
            set { _sunroof = value; }
        }
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
