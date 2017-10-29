﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace whitodo_csharp
{
    public class SettingsPDU
    {
        public int id;
        public double outerWidth;
        public double innerWidth;
        public double innerHeight;
        public double outerTransparency;
        public double innerTransparency;
        public Brush outerBrush;
        public Brush innerBrush;
        public Brush brush1;
        public Brush brush2;
        public Brush brush3;
        public Brush brush4;
        public Brush brush5;
        public Brush brush6;

        public SettingsPDU(double ow, double iw, double ih, double ot, double it, Brush ob, Brush ib,
            Brush b1, Brush b2, Brush b3, Brush b4, Brush b5, Brush b6)
        {
            outerWidth = ow;
            innerWidth = iw;
            innerHeight = ih;
            outerTransparency = ot;
            innerTransparency = it;
            outerBrush = ob;
            innerBrush = ib;
            brush1 = b1;
            brush2 = b2;
            brush3 = b3;
            brush4 = b4;
            brush5 = b5;
            brush6 = b6;
            //MessageBox.Show(innerWidth.ToString());
        }
    }
}