using System.Collections.Generic;

namespace ToyBlock
{
    public class Order
    {
        private IEnumerable<Block> Blocks;
        public Order(IEnumerable<Block> blocks)
        {
            this.Blocks = blocks;
        }

        public IEnumerable<Block> GetBlocks()
        {
            return this.Blocks;
        }
    }
}