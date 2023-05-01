
using Catalog.Entities;

namespace Catalog.Repositories
{
  public interface InterfaceItemsRepository
  {
    Item GetItem(Guid id);
    IEnumerable<Item> GetItems();
  }
}