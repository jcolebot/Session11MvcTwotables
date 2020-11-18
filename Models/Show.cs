using System;
using System.Collections.Generic;

namespace CartoonDB.Models
{
    public class Show
    {
        public int Id {get;set;}
        public string Network {get;set;}
        public string Name {get;set;}
        public string ArtisticDirector {get;set;}
        public DateTime Start {get;set;}
        public DateTime End {get;set;}
        public string Genre {get;set;}
        public virtual List<Character> Characters {get;set;}
    }
}