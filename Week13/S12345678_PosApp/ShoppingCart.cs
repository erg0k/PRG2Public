namespace S12345678_PosApp;

public class ShoppingCart
{
    //attributes
    public List<CartItem> ItemList { get; set; } = new List<CartItem>();

    //constructors
    public ShoppingCart() {}

    //methods
    public void AddItem(CartItem addingItem)
    {
        ItemList.Add(addingItem);
    }

    public List<CartItem> GetItemList()
    {
        return ItemList;
    }

    public bool RemoveItem(int inputItemCode /*i have no clue*/)
    {
        foreach (CartItem item in ItemList)
        {
            if (item.Code == inputItemCode.ToString())
            {
                ItemList.Remove(item);
                return true;
            }
        }
        return false;
    }

    public void ClearCart()
    {
        ItemList.Clear();
    }

    public int Size()
    {
        return ItemList.Count();
    }

    public bool IsEmpty()
    {
        int cartSize = Size();
        if (cartSize == 0) return true;
        return false;
    }
}