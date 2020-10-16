using System.Collections.Generic;

namespace ToyBlock
{
    public interface IOrderSummariser
    {
        Dictionary<ShapeEnum, int> CountShapes(Order order);
    }
}