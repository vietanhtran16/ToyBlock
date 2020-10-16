namespace ToyBlock
{
    public class Block
    {
        private ColorEnum Color;
        private ShapeEnum Shape;
        public Block(ColorEnum color, ShapeEnum shape)
        {
            this.Color = color;
            this.Shape = shape;
        }

        public ColorEnum GetColor()
        {
            return this.Color;
        }

        public ShapeEnum GetShape()
        {
            return this.Shape;
        }
    }
}