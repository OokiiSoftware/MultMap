using System.Drawing;

namespace MultMap.Auxiliar
{
    public static class TemaConfig
    {
        public static int Tema = Properties.Settings.Default.Tema;

        private static bool IsTemaDark => Tema == 0;

        public static Color ColorPrimary => IsTemaDark ? Color.WhiteSmoke : Color.Gray;
        public static Color ColorSecundary => IsTemaDark ? Color.WhiteSmoke : Color.DarkGray;
        public static Color ColorPrimaryDark => IsTemaDark ? Color.Gainsboro : Color.DimGray;

        public static Color TextColorPrimary => IsTemaDark ? Color.DimGray : Color.WhiteSmoke;
        public static Color TextColorSecundary => IsTemaDark ? Color.DimGray : Color.White;

        public static Color TextColorAlert => IsTemaDark ? Color.Green : Color.SpringGreen;
        public static Color TextColorAlertErro => IsTemaDark ? Color.Crimson : Color.Pink;
    }
}
