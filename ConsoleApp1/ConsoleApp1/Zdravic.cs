using System;

namespace ConsoleApp1
{
    class Zdravic
    {
        private string _text;
        private string _dodatek;
        private string _jmeno;
        // takto se běžně tvoří soukromý string

        public Zdravic()
        {

        }

        public Zdravic(string text, string jmeno, string dodatek)
        {
            _text = text;
            _dodatek = dodatek;
            _jmeno = jmeno;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }

        public void SetJmeno(string jmeno)
        {
            _jmeno = jmeno;
        }

        public string GetJmeno()
        {
            return _jmeno;
        }

        public void SetDodatek(string dodatek)
        {
            _dodatek = dodatek;
        }

        public string GetDodatek()
        {
            return _dodatek;
        }

        public void Pozdrav()   // Pozdrav je metoda

        {
            Console.WriteLine("{0} {1} {2}", _text, _jmeno, _dodatek);      // dané čísla určují pořadí proměnných za ním (1. text pak 2. jmeno

        }
    }
}
