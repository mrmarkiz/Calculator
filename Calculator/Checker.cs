using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Checker
    {
        public static char[] operations = { '+', '-', '*', '/' };

        public static bool CanAddSymbol(string equalation, char symbol)
        {
            //не вийти за межі лейбла
            if (equalation.Length >= 21)
                return false;
            //якщо хочуть написати символ і останній написаний символ операція
            if (IsOperation(symbol) && IsOperation(equalation.Last()))
                return false;
            string[] numbers = equalation.Split(operations);
            //якщо в останньому числі вже є крапка
            if (symbol == ',' && numbers.Last().Contains(','))
                return false;
            //якщо останній символ 0 і хочуть написати ще якесь число
            if (numbers.Last() == "0" && !IsOperation(symbol) && symbol != ',')
                return false;
            return true;
        }

        private static bool IsOperation(char symbol) => operations.Contains(symbol);
    }
}