using InventoryManagement.Domain.BaseEntities;

namespace InventoryManagement.Domain.Entities
{
    public class EmployeeType : BaseEntity
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
        IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}
