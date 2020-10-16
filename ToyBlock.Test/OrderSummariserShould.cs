using System;
using System.Collections.Generic;
using Xunit;

namespace ToyBlock.Test
{
    public class OrderSummariserShould
    {
        [Fact]
        public void ShouldCountShapesOfSingleShapeOrder()
        {
            var order = new Order(new List<Block>() { new Block(ColorEnum.Blue, ShapeEnum.Circle) });
            var orderSummariser = new OrderSummariser();

            var result = orderSummariser.CountShapes(order);

            var expected = new Dictionary<ShapeEnum, int>() {
                { ShapeEnum.Circle, 1 },
                { ShapeEnum.Square, 0 },
                { ShapeEnum.Triangle, 0 }
            };
            Assert.Equal(result, expected);
        }

        [Fact]
        public void ShouldCountShapesOfManyShapesOrder()
        {
            var order = new Order(new List<Block>() {
                new Block(ColorEnum.Blue, ShapeEnum.Circle),
                new Block(ColorEnum.Red, ShapeEnum.Circle),
                new Block(ColorEnum.Red, ShapeEnum.Triangle),
                new Block(ColorEnum.Yellow, ShapeEnum.Square),
            });
            var orderSummariser = new OrderSummariser();

            var result = orderSummariser.CountShapes(order);

            var expected = new Dictionary<ShapeEnum, int>() {
                { ShapeEnum.Circle, 2 },
                { ShapeEnum.Square, 1 },
                { ShapeEnum.Triangle, 1 }
            };
            Assert.Equal(result, expected);
        }
    }
}
