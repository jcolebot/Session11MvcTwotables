using System;

namespace CartoonDB.Models
{
    public class Character
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Smell {get;set;}
        public string OriginStory {get;set;}
        public bool Pants {get;set;}
        public DateTime FirstAppearance{get;set;}

        public virtual Show Show {get;set;}
    }
}