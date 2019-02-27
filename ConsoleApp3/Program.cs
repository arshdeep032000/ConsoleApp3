using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        var orderProcessor = new orderProcessor();
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);
            }
}
public class orderProcessor
{
    private readonly ShippingCalculator_ShippingCalculator;
                public orderProcessor()
    {
        _ShippingCalculator = new ShippingCalculator();
    }
    public void Process(Order order)
    {
        if (order.IsShipped)
            throw new InvalidOperationException("this order is already processed");
        order.Shipment = new Shipment
        {
            Cost = _shippingCalculator.CalculateShipping(Order),
            ShippingDate = DateTime.Today.AddDays(1);
    }
}
        }
 public class ShippingCalculator
{
    public float CalculateShipping(Orderorder)
    {
        if (order.TotalPrice < 30f) return order.TotalPrice * 0.1f;
        return0;
    }
}  
        
        
    

