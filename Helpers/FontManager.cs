using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Helpers
{
    public static class FontManager
    {
        private static PrivateFontCollection privateFonts = new PrivateFontCollection();
        private static FontFamily khmerFontFamily;
        private static FontFamily englishFontFamily;

        static FontManager()
        {
            LoadCustomFonts();
        }

        private static void LoadCustomFonts()
        {
            // Load the Khmer font
            string khmerFontPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "AKbalthomKmengKmang.ttf");
            privateFonts.AddFontFile(khmerFontPath);
            khmerFontFamily = privateFonts.Families[0];

            // Load the English font
            string englishFontPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "Lexend.ttf");
            privateFonts.AddFontFile(englishFontPath);
            englishFontFamily = privateFonts.Families[1];
        }

        public static Font GetKhmerFont(float size, FontStyle style = FontStyle.Regular)
        {
            return new Font(khmerFontFamily, size, style);
        }

        public static Font GetEnglishFont(float size, FontStyle style = FontStyle.Regular)
        {
            return new Font(englishFontFamily, size, style);
        }
    }
}
