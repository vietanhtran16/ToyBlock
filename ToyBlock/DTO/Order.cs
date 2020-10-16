using System.Collections.Generic;

namespace ToyBlock
{
    public class Order
    {
        private List<Block> Blocks;
        public Order(List<Block> blocks)
        {
            this.Blocks = blocks;
        }

        public List<Block> GetBlocks()
        {
            return this.Blocks;
        }
    }
}