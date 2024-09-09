using InventoryManagement.Domain.BaseEntities;


namespace InventoryManagement.Domain.Entities
{
    public class Category : BaseEntity
    {
       public int? ParentCategoryId { get; set; }
       public string CategoryName { get; set; }
       public string CategoryDescription { get; set; } = string.Empty;
       IList<Brand> Brands { get; set; } = new List<Brand>();
    }
}
