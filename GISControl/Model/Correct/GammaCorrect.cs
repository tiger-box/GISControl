﻿using System;

namespace GISControl.Model.Correct
{
    class GammaCorrect : ColorCorrect
    {
        protected override byte GetCorrectPixel(byte pixelColor, double value)
        {
            double color = 255.0 * Math.Pow(pixelColor / 255.0, 1.0 / value);

            if (color < 0) color = 0;
            if (color > 255) color = 255;

            return Convert.ToByte(color);
        }
    }
}
