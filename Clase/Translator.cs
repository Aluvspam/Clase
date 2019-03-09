using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Translator
    {
        public string RomanianNumber(int x)
        {
            switch (x)
            {
                case 0:
                    return ("zero");
                case 1:
                    return ("unu");
                case 2:
                    return ("doi");
                case 3:
                    return ("trei");
                case 4:
                    return ("patru");
                case 5:
                    return ("cinci");
                case 6:
                    return ("sase");
                case 7:
                    return ("sapte");
                case 8:
                    return ("opt");
                case 9:
                    return ("noua");
                default:
                    return ("Ai gresit CIFRA baiatu'");
            }
        }

        public string TransformIntToString(int number)
        {
            var dictionary = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" }
            };
            return (dictionary[number]);
        }

        public string DictionarRoEng(string nr)
        {
            Dictionary<string, string> RoEng = new Dictionary<string, string>();
            RoEng.Add("zero", "zero");
            RoEng.Add("unu", "one");
            RoEng.Add("doi", "two");
            RoEng.Add("trei", "three");
            RoEng.Add("patru", "four");
            RoEng.Add("cinci", "five");
            RoEng.Add("sase", "six");
            RoEng.Add("sapte", "seven");
            RoEng.Add("opt", "eight");
            RoEng.Add("noua", "nine");

            string n = "";
            if (!RoEng.ContainsKey(nr.ToLower()))
                n = "Nu exista";
            else
            {
                foreach (var c in RoEng)
                {
                    if (c.Key.Equals(nr.ToLower()))
                    {
                        n = c.Value;
                    }
                }
            }

            return n;
        }
        public string Convert(int num)
        {
            Dictionary<string, int> Ro = new Dictionary<string, int>()
            {{"zero",0 }, {"unu",1 },{"doi",2},{"trei",3 },{"patru",4 }, {"cinci",5 },
            {"sase",6},{"sapte",7 },{"opt",8 },{"noua" ,9} };
            Ro.Add("zece", 10);
            foreach (var item in Ro)
            {
                if (num == item.Value)
                {
                    return (item.Key);
                }
            }
            return "greseala";
            //Console.Write("Introduceti un numar de la zero la zece :");
            //string nr = Console.ReadLine();
            //foreach (var item in Ro)
            //{
            //    if (nr == item.Key)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

        }
    }
}
