namespace DDD_Library.Models;

public interface IItemsModel<TItemsModel>
    where TItemsModel : class
{
    IReadOnlyList<TItemsModel> Items { get; set; } 
}