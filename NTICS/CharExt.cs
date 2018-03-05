using System;
using System.Collections.Generic;
using System.Text;

namespace NTICS.CharExt
{
    public static class CharExt
    {
        public static char UpperKeyToRus(this char value)
        {
            char k = Char.ToUpper(value);
            switch (k)
            {
                case '`': return 'Ё';
                case 'Q': return 'Й';
                case 'W': return 'Ц';
                case 'E': return 'У';
                case 'R': return 'К';
                case 'T': return 'Е';
                case 'Y': return 'Н';
                case 'U': return 'Г';
                case 'I': return 'Ш';
                case 'O': return 'Щ';
                case 'P': return 'З';
                case '{': return 'Х';
                case '}': return 'Ъ';
                case 'ї': return 'Ъ';
                case 'A': return 'Ф';
                case 'S':
                case 'І': return 'Ы';
                case 'D': return 'В';
                case 'F': return 'А';
                case 'G': return 'П';
                case 'H': return 'Р';
                case 'J': return 'О';
                case 'K': return 'Л';
                case 'L': return 'Д';
                case ';': return 'Ж';
                case '\'':
                case 'Є': return 'Э';
                case 'Z': return 'Я';
                case 'X': return 'Ч';
                case 'C': return 'С';
                case 'V': return 'М';
                case 'B': return 'И';
                case 'N': return 'Т';
                case 'M': return 'Ь';
                case ',': return 'Б';
                case '.': return 'Ю';

                default: return k;
            }

        }
    }
}
