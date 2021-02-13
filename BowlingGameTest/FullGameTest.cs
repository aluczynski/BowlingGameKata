using System;
using BowlingGame;
using Xunit;

namespace BowlingGameTest
{
    public class FullGameTest
    {
        private Game game;

        public FullGameTest()
        {
            game = new Game();
        }
        
        [Fact]
        public void TestForAll0()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }
            Assert.Equal(0,game.Score());
        }

        [Fact]
        public void TestForAll1()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }
            Assert.Equal(20,game.Score());
        }

        [Fact]
        public void TestForAllStrike()
        {
            for(int i = 0; i < 12; i++)
            {
                game.Roll(10);
            }
            Assert.Equal(300, game.Score());
        }

        [Fact]
        public void TestOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(2);
            game.Score();
            game.Score();

            Assert.Equal(14,game.Score());
        }

    }
}