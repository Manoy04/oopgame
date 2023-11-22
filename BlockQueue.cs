using System;
using System.Windows.Documents;
using System.Windows.Media.Animation;

namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };
        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }

        public Block Queue()
        {
        NextBlock = RandomBlock();
        }
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public Block GetandUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = randomBlock();
            }
            while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
