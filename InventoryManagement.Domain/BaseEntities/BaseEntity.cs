

namespace InventoryManagement.Domain.BaseEntities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime UpdatedAt {  get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public string UpdatedByName { get; set;} = string.Empty;
        public bool IsActive { get; set; }

    }
}
