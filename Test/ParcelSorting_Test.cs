using ParcelSorting1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [Fact]
    public class ParcelSorting_Test
    {

        public void When_ParcelHasNewDimensions_ThenParcelCanNotFirSorting()
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

            bool result = Program.FirstParcelLine(boxSizes);

            //Assert
            Assert.True(result);
        }
    }
