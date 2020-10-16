using System;
using System.Collections.Generic;

namespace ToyBlock
{
    public class OrderSummariser : IOrderSummariser
    {
        public Dictionary<ShapeEnum, int> CountShapes(Order order)
        {
            var summary = new Dictionary<ShapeEnum, int>();
            foreach (ShapeEnum shape in Enum.GetValues(typeof(ShapeEnum)))
            {
                summary.Add(shape, order.GetBlocks().FindAll(block => block.GetShape() == shape).Count);
            }
            return summary;
        }
    }
}