using infinityTableWebApp.Models.Library;

namespace infinityTableWebApp.Globals
{
    public enum Colors
    {
        green,
        red,
        blue,
        yellow,
        orange,
        purple,
        blank
    }
    public static class ColorGenerator
    {
        private static IDictionary<Colors, PixelColor> _colorMapping = new Dictionary<Colors, PixelColor>()
        {
            {Colors.green, new PixelColor(128,1,1) },
            {Colors.red, new PixelColor(0,1,1) },
            {Colors.blue, new PixelColor(255,1,1) },
            {Colors.yellow, new PixelColor(68,1,1) },
            {Colors.orange, new PixelColor(35,1,1) },
            {Colors.purple, new PixelColor(296,1,1) },
            {Colors.blank, new PixelColor(0,0,0) },

        };
        public static PixelColor ConvertToHSVPixelColor(string color)
        {
            Colors colorEnum;
            if (Enum.TryParse(color.ToLowerInvariant(), out colorEnum))
            {
                return _colorMapping[colorEnum];
            }
            return _colorMapping[Colors.blank];
        }

        
    }
}
