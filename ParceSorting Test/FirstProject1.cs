using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcelSorting1;


namespace ParcelSorting1_Test
{
    public class FirstProject1
    {
        [Fact]
        public void When_ParcelhasNewDimensions_ThenParcelCanNotFitSortingLine( )
        {
            var boxSizes = new List<BoxSize>()
            {
                new BoxSize
                {
                    Length = 70,
                    Width = 50,
                    SortingLineParams = new List<SortingLineParam>()
                    {
                        new SortingLineParam
                        {
                            Width = 50,
                        },
                        new SortingLineParam
                        {
                            Width = 50,
                        },
                        new SortingLineParam
                        {
                            Width = 100,
                        },
                        new SortingLineParam
                        {
                            Width = 100,
                        }
                    }
                }
            };

            bool isValid = Program.FirstParcelLine(boxSizes);

            //Assert
            Assert.True(isValid);




        }


    }

   
}
