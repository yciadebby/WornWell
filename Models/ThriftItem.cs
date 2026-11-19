using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace WornWell.Models;

[Table("thrift_items")]
public class ThriftItem : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("title")]
    public string Title { get; set; } = "";

    [Column("category")]
    public string Category { get; set; } = "";

    [Column("size_label")]
    public string SizeLabel { get; set; } = "";

    [Column("condition")]
    public string Condition { get; set; } = "";

    [Column("price")]
    public decimal Price { get; set; }

    [Column("original_price")]
    public decimal? OriginalPrice { get; set; }

    [Column("image_url")]
    public string? ImageUrl { get; set; }

    [Column("status")]
    public string Status { get; set; } = "available";

    [Column("is_favourite")]
    public bool IsFavourite { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}