﻿namespace BoardGameGallery.Models
{
    public class BoardGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ProductNumber { get; set; }
        public double RegPrice { get; set; }
        public double SpecialPrice { get; set; }
        public string ImageName { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string DescriptionHtml { get; set; }
        public string[] Contents { get; set; }
        public Mechanic[] Mechanics { get; set; }
        public Category[] Categories { get; set; }
        public Category[] SubCategories { get; set; }
        public bool Wishlisted { get; set; }
        public bool NewArrival { get; set; }
        public string TitleText
        {
            get
            {
                if (NewArrival)
                {
                    return Title + " (New Arrival)";
                }
                else
                {
                    return Title;
                }
            }
        }
    }
}
