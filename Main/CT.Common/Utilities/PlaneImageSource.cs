﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CT.Common.Utilities
{
    /// <summary>
    /// A static class representing bitmap images for the CT app
    /// </summary>
    public static class PlaneImageSource
    {
        public static BitmapImage PlaneLeft
        {
            get
            {
                return new BitmapImage(new Uri(@"C:\Users\matsll\Documents\Visual Studio 2015\Projects\ControlTower_MVVM\Main\CT.UI\Images\planeleft.png"));
            }
        }

        public static BitmapImage PlaneDown
        {
            get
            {
                return new BitmapImage(new Uri(@"C:\Users\matsll\Documents\Visual Studio 2015\Projects\ControlTower_MVVM\Main\CT.UI\Images\planedown.png"));
            }
        }

        public static BitmapImage NoPlane
        {
            get
            {
                return new BitmapImage();
            }
        }
    }
}
