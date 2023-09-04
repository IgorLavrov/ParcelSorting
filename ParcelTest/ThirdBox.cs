using ParcelSorting1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTest
{
    public class ThirdBox {
        [Fact]
        public void Test() {


            var boxsize = new List<BoxSize>();
                new BoxSize
            {
                Length = 70,
                Width = 60,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    { Width = 60

                    },
                    new SortingLineParam
                    { Width = 60

                    },
                    new SortingLineParam
                    {
                        Width = 55

                    },
                    new SortingLineParam
                    {
                        Width = 90

                    }




                }
            };

            bool result = Program.FirstParcelLine(boxsize);

            //Assert
            Assert.True(result);
        }


    } }

    