using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the text you want to translate to morsecode one letter at a time.");
            string plainText = Console.ReadLine();
            char[] chars = plainText.ToCharArray();
            string morseText = "";

            for(int i = 0; i < plainText.Length; i++)
            {
                switch (char.ToLower(chars[i]))
                {
                    case 'a':
                        morseText += "·- ";
                        break;

                    case 'b':
                        morseText += "-··· ";
                        break;

                    case 'c':
                        morseText += "-·-· ";
                        break;

                    case 'd':
                        morseText+= "—·· ";
                        break;

                    case 'e':
                        morseText += "· ";
                        break;

                    case 'f':
                        morseText += "··—· ";
                        break;

                    case 'g':
                        morseText += "—-· ";
                        break;

                    case 'h':
                        morseText += "···· ";
                        break;

                    case 'i':
                        morseText += "·· ";
                        break;

                    case 'j':
                        morseText += "·——— ";
                        break;

                    case 'k':
                        morseText += "-·— ";
                        break;

                    case 'l':
                        morseText += "·—·· ";
                        break;

                    case 'm':
                        morseText += "-- ";
                        break;

                    case 'n':
                        morseText += "-· ";
                        break;

                    case 'o':
                        morseText += "--- ";
                        break;

                    case 'p':
                        morseText += "·--· ";
                        break;

                    case 'q':
                        morseText += "--·- ";
                        break;

                    case 'r':
                        morseText += "·-· ";
                        break;

                    case 's':
                        morseText += "··· ";
                        break;

                    case 't':
                        morseText += "- ";
                        break;

                    case 'u':
                        morseText += "··- ";
                        break;

                    case 'v':
                        morseText += "···- ";
                        break;

                    case 'w':
                        morseText += "·-- ";
                        break;

                    case 'x':
                        morseText += "-··- ";
                        break;

                    case 'y':
                        morseText += "-·-- ";
                        break;

                    case 'z':
                        morseText += "--·· ";
                        break;

                    case 'æ':
                    case 'ä':
                    case 'ą':
                        morseText += "--·· ";
                        break;

                    case 'ø':
                    case 'ó':
                    case 'ö':
                        morseText += "---· ";
                        break;

                    case 'å':
                    case 'à':
                        morseText += "·--·- ";
                        break;

                    case '1':
                        morseText += "·---- ";
                        break;

                    case '2':
                        morseText += "··--- ";
                        break;

                    case '3':
                        morseText += "···-- ";
                        break;

                    case '4':
                        morseText += "····- ";
                        break;

                    case '5':
                        morseText += "····· ";
                        break;

                    case '6':
                        morseText += "-···· ";
                        break;

                    case '7':
                        morseText += "--··· ";
                        break;

                    case '8':
                        morseText += "---·· ";
                        break;

                    case '9':
                        morseText += "----· ";
                        break;

                    case '0':
                        morseText += "----- ";
                        break;

                    case '.':
                        morseText += "·-·-·- ";
                        break;

                    case ',':
                        morseText += "--··-- ";
                        break;

                    case ':':
                        morseText += "---··· ";
                        break;

                    case '?':
                        morseText += "··--·· ";
                        break;

                    case '\'':
                        morseText += "·----· ";
                        break;

                    case '-':
                        morseText += "-····- ";
                        break;

                    case '/':
                        morseText += "-··-· ";
                        break;

                    case '(':
                        morseText += "-·--· ";
                        break;

                    case ')':
                        morseText += "-·--·- ";
                        break;

                    case '"':
                        morseText += "·-··-· ";
                        break;

                    case '×':
                        morseText += "-··- ";
                        break;

                    case '@':
                        morseText += "·--·-· ";
                        break;

                    case ' ':
                        morseText += "   ";
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine("Morse code: " + morseText);
            Console.ReadLine();
        }
    }
}
