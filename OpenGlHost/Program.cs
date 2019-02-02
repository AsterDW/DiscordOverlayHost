using System;

namespace OpenGlHost
{
    static class Program
    {
        // default windows size is 768 x 432
        public static int winWidth = 768;
        public static int winHeight = 432;

        // default background color is R:46, G:49, B:54, A:10
        public static int bgColorRed = 46;
        public static int bgColorGreen = 49;
        public static int bgColorBlue = 54;
        public static int bgColorAlpha = 10;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // 190201 peter: add configuration
            if (null != args && 2 == args.Length)
                ChangeDefaultValue(args[0], args[1]);

            OpenGlHost glHost = new OpenGlHost();
            glHost.Run();
        }

        private static void ChangeDefaultValue(string size, string colorRGBA)
        {
            var tmp = size.Split(',');
            bool invalid = false;
            if (2 == tmp.Length)
            {
                if (false == Int32.TryParse(tmp[0], out winWidth))
                    invalid = true;
                if (0 > winWidth)
                    invalid = true;
                if (false == Int32.TryParse(tmp[1], out winHeight))
                    invalid = true;
                if (0 > winHeight)
                    invalid = true;
            }
            else
            {
                invalid = true;
            }

            if (true == invalid)
            {
                winWidth = 768;
                winHeight = 432;
            }


            tmp = colorRGBA.Split(',');
            invalid = false;
            if (4 == tmp.Length)
            {
                if (false == Int32.TryParse(tmp[0], out bgColorRed))
                    invalid = true;
                if (0 > bgColorRed)
                    invalid = true;
                if (false == Int32.TryParse(tmp[1], out bgColorGreen))
                    invalid = true;
                if (0 > bgColorGreen)
                    invalid = true;
                if (false == Int32.TryParse(tmp[2], out bgColorBlue))
                    invalid = true;
                if (0 > bgColorBlue)
                    invalid = true;
                if (false == Int32.TryParse(tmp[3], out bgColorAlpha))
                    invalid = true;
                if (0 > bgColorAlpha)
                    invalid = true;
            }
            else
            {
                invalid = true;
            }

            if (true == invalid)
            {
                // reset to default value
                bgColorRed = 46;
                bgColorGreen = 49;
                bgColorBlue = 54;
                bgColorAlpha = 10;
            }
        }
    }
}
