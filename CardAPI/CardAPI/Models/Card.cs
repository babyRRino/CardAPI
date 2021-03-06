﻿using System.ComponentModel.DataAnnotations;

namespace CardAPI.Models
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }
        public string ImageRef { get; set; }
        public string Text { get; set; }
        public int Military1 { get; set; }
        public int Military2 { get; set; }
        public int Happiness1 { get; set; }
        public int Happiness2 { get; set; }
        public int Economy1 { get; set; }
        public int Economy2 { get; set; }
        public int Relations1 { get; set; }
        public int Relations2 { get; set; }
        public int CharacterID { get; set; }
    }
}
