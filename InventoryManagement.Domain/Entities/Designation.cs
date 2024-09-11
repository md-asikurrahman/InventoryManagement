using InventoryManagement.Domain.BaseEntities;

namespace InventoryManagement.Domain.Entities
{
    public class Designation : BaseEntity
    {
        public string DesignationName {  get; set; }
        public string Description { get; set; }

        IList<Employee> Employees { get; set; } = new List<Employee>(); 
    }
}
