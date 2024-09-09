using InventoryManagement.Domain.BaseEntities;

namespace InventoryManagement.Domain.Entities
{
    public class AddressType : BaseEntity
    {
        public string TypeName {get;set;}
        IList<Address> AddressList {get;set;} = new List<Address>();
    }
}
