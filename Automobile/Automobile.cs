using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Automobile : Form
    {
        private MyAutomobile _myAutomobile;

        public Automobile()
        {
            _myAutomobile = new MyAutomobile();
            _myAutomobile.Topspeed = 100;
            _myAutomobile.Mpg = 45;
            _myAutomobile.Tanksize = 15;
            _myAutomobile.Estdist = _myAutomobile.Mpg * _myAutomobile.Estdist;
            _myAutomobile.Numdoors = 2;
            _myAutomobile.Sunroof = true;
            _myAutomobile.Color = "Blue";
            InitializeComponent();
            Console.WriteLine("Top speed: {0}\nMpg: {1}\nTanksize: {2}\nEstdist: {3}\nNumdoors: {4}\nSunroof: {5}\nColor: {6}", _myAutomobile.Topspeed, _myAutomobile.Mpg, _myAutomobile.Tanksize, _myAutomobile.Estdist, _myAutomobile.Numdoors, _myAutomobile.Sunroof, _myAutomobile.Color);

        }
    }
}
