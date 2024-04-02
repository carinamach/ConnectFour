using ConnectFour;
using System.Numerics;
using Xunit.Sdk;

namespace ConnectFourXunit
{
    public class ConnectFourXunitTest
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            var gameState = new GameState();

            var result  = gameState.CheckForWin();

            Assert.Equal(GameState.WinState.No_Winner, result);
        }
        [Fact]
        public void CheckForWin_TieGame()
        {
            //arrange
            var gameState = new GameState();

            gameState.TheBoard = new List<int>
            {
                1,2,1,2,1,2,1,
                1,2,1,2,1,2,1,
                2,1,2,1,2,1,2,
                2,1,2,1,2,1,2,
                1,2,1,2,1,2,1,
                1,2,1,2,1,2,1,
            };

            //act
            var result = gameState.CheckForWin();

            //assert
            Assert.Equal(GameState.WinState.Tie, result);

        }
    }
}