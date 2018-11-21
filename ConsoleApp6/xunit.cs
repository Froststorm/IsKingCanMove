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
        [InlineData(1,1,4,4,"NO")]
        [InlineData(1, 1, 2, 1,"YES")]
        [InlineData(1, 1, 1, 1, "YES")]
        [InlineData(1, 1, 3, 7,"NO")]
        [InlineData(1, 1, 3, 3,"NO")]
        [InlineData(1, 1, 8, 3,"NO")]

        void isKingmoving(int x1, int y1, int x2, int y2,string expected)
        {
            
            string actual = kingCheckcs.isKingCanMove(x1,y1,x2,y2);
            Assert.Equal(expected, actual);


        }


    }
}
