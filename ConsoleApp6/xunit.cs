using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ConsoleApp6
{
    public class Xunit
    {
        [Theory]
        [InlineData(5, 5, 4, 3, "YES")]
        [InlineData(5, 5, 3, 4, "YES")]
        [InlineData(5, 5, 7, 4, "YES")]
        [InlineData(1, 1, 7, 4, "NO")]
        [InlineData(1, 1, 3, 3, "NO")]
        [InlineData(1, 1, 2, 8, "NO")]

        void isKingmoving(int x1, int y1, int x2, int y2, string expected)
        {

            var actual = kingCheckcs.isKingCanMove(x1, y1, x2, y2);
            Assert.Equal(expected, actual);


        }


    }
}
