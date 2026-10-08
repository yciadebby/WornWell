using System;

namespace WornWell.Models
{
    public enum ItemCondition
    {
        Fair,
        Good,
        Excellent
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Size { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ItemCondition Condition { get; set; } = ItemCondition.Good;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
