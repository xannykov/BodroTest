using System;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BodroTest
{
    internal class FontLoader
    {
        private static FontFamily customFontFamily;

        static FontLoader()
        {
            LoadCustomFont();
        }

        private static void LoadCustomFont()
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.Floripa;

            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);

            customFontFamily = privateFontCollection.Families[0];
        }

        public static Font GetFont(float size)
        {
            return new Font(customFontFamily, size);
        }
    }
}
