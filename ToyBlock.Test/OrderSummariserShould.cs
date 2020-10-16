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
            Assert.Equal(expected, result);
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
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldGroupShapeByColor()
        {
            var order = new Order(new List<Block>() {
                new Block(ColorEnum.Blue, ShapeEnum.Square),
                new Block(ColorEnum.Red, ShapeEnum.Square),
                new Block(ColorEnum.Yellow, ShapeEnum.Square),
                new Block(ColorEnum.Blue, ShapeEnum.Triangle),
                new Block(ColorEnum.Blue, ShapeEnum.Triangle),
                new Block(ColorEnum.Yellow, ShapeEnum.Triangle),
                new Block(ColorEnum.Red, ShapeEnum.Circle),
                new Block(ColorEnum.Yellow, ShapeEnum.Circle),
                new Block(ColorEnum.Yellow, ShapeEnum.Circle),
            });
            var orderSummariser = new OrderSummariser();

            var result = orderSummariser.GroupShapeByColor(order);

            var expected = new Dictionary<Tuple<ShapeEnum, ColorEnum>, int>() {
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Square, ColorEnum.Blue), 1},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Square, ColorEnum.Red), 1},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Square, ColorEnum.Yellow), 1},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Triangle, ColorEnum.Blue), 2},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Triangle, ColorEnum.Red), 0},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Triangle, ColorEnum.Yellow), 1},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Circle, ColorEnum.Blue), 0},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Circle, ColorEnum.Red), 1},
                {new Tuple<ShapeEnum, ColorEnum>(ShapeEnum.Circle, ColorEnum.Yellow), 2},
            };

            Assert.Equal(expected, result);
        }
    }
}
