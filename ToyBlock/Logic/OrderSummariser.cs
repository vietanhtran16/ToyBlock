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

        public Dictionary<Tuple<ShapeEnum, ColorEnum>, int> GroupShapeByColor(Order order)
        {
            var summary = new Dictionary<Tuple<ShapeEnum, ColorEnum>, int>();
            foreach (ShapeEnum shape in Enum.GetValues(typeof(ShapeEnum)))
            {
                foreach (ColorEnum color in Enum.GetValues(typeof(ColorEnum)))
                {
                    summary.Add(new Tuple<ShapeEnum, ColorEnum>(shape, color), order.GetBlocks().FindAll(block => block.GetShape() == shape && block.GetColor() == color).Count);
                }
            }
            return summary;
        }
    }
}