using Lab_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_4.Utilities
{
    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public Dictionary<string, Videogames> dictionary = new Dictionary<string, Videogames>();

        public List<Videogames> DictionaryToList()
        {
            List<Videogames> temp = dictionary.Values.ToList();
            return temp;
        }
    }
}