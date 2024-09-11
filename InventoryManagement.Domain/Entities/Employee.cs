using InventoryManagement.Domain.BaseEntities;

namespace InventoryManagement.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; } = string.Empty;
        public string OthersContact { get; set; }
        public string NidNo { get; set; }
        public string Email { get; set; }
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }
        public int EmployeeTypeId {  get; set; }
        public EmployeeType EmployeeType { get; set; }
        IList<Address> Addresses { get; set; } = new List<Address>();
    }
}
