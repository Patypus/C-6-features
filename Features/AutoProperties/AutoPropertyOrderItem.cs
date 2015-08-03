namespace Features.AutoProperties
{
    public class AutoPropertyOrderItem
    {
        public string Customer { get; } = "unknown";

        public int ItemCode { get; }

        public int Quantity { get; } = -1;

        public AutoPropertyOrderItem(string orderingCustomer = "", int orderItemCode = -1, int quantityOfItem = 0)
        {
            if (!string.IsNullOrEmpty(orderingCustomer))
            {
                //This is the clever bit for the auto property, it automatically has a setter the only constructor can access.
                Customer = orderingCustomer;
            }
            if (orderItemCode >= 0)
            {
                ItemCode = orderItemCode;
            }
            if (quantityOfItem > 0)
            {
                Quantity = quantityOfItem;
            }
        }
        
        /*
        * This is a compile failure are the auto setter is only available to the constructor.
        *
        * public void SetCustomer(string newCustomer)
        * {
        *     Customer = newCustomer;
        * }
        */
    }
}
