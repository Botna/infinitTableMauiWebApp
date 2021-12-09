namespace infinityTableWebApp.Models.Library
{
    public class PixelColor
    {
        /// <summary>
        /// Value for Hue in an HSV color, ranging from 0 to 360
        /// </summary>
        public double Hue { get; set; }

        /// <summary>
        /// Value for Saturation in an HSV color, ranging from 0 to 1
        /// </summary>
        public double Saturation { get; set; }
        /// <summary>
        /// Value for Value in an HSV color, ranging from 0 to 1
        /// </summary>
        public double Value { get; set; }

        public PixelColor(double h, double s, double v)
        {
            Hue = h;
            Saturation = s;
            Value = v;
        }
    }
}
