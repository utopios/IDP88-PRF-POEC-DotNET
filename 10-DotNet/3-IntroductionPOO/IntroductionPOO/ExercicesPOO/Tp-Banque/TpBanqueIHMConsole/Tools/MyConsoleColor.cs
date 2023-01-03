using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueIHMConsole.Tools
{
    internal class MyConsoleColor
    {
        public static void OnDarkCyan(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnDarkCyanInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnCyan(string chaine)

        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnCyanInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnRed(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnRedInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnGrayInput(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void OnGreen(string chaine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(chaine);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
