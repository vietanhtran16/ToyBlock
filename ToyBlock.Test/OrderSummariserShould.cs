using System;
using System.Collections.Generic;
using Xunit;

namespace ToyBlock.Test
{
    public class OrderSummariserShould
    {
        [Fact]
        public void ShouldGetEachShapeTotalFromOrders()
        {
            var order = new Order(new List<Block>() { new Block(ColorEnum.Blue, ShapeEnum.Circle) });
            var orderSummariser = new OrderSummariser();

            var result = orderSummariser.CountShapes(order);

            var expected = new Dictionary<ShapeEnum, int>() { { ShapeEnum.Circle, 1 } };
            Assert.Equal(result, expected);
        }
    }
}
