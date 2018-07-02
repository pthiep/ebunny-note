using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ebunny_note
{
    public class MainWindowLayoutModel
    {

    }

    public class GridLengthHelper
    {
        public static GridLength Zero { get; } = new GridLength(0);
        public static GridLength Star { get; } = new GridLength(0.5, GridUnitType.Star);

        public static GridLength Auto
        {
            get => GridLength.Auto;
        }
        public static GridLength WindowSeparator { get; } = new GridLength(12);

        public static GridLength FromDouble(double size)
        {
            return new GridLength(size);
        }
        public static GridLength FromInt(double size)
        {
            return new GridLength(size);
        }

        /// <summary>
        /// Converts a GridLength to an Int Value checking for
        /// IsAbsolute and if not returning -1
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Int value or Int.MinValue if not absolute</returns>
        public static int ParseInt(GridLength value)
        {
            if (value.IsAbsolute)
                return Convert.ToInt32(value.Value);

            return int.MinValue;
        }


        public static bool TryParseInt(GridLength value, out int intValue)
        {
            intValue = -1;
            if (!value.IsAbsolute)
                return false;

            intValue = Convert.ToInt32(value.Value);
            return true;
        }
    }
}
