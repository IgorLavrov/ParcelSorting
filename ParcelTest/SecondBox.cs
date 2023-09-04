using ParcelSorting1;
using System.Security.Cryptography.X509Certificates;

namespace ParcelTest
{
    public class SecondBox
    {
        [Fact]
        public void Test1()
        {

                var boxSizes = new List<BoxSize>()
            {
                new BoxSize
            {
                Length = 100,
                Width = 35,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 75

                    },
                    new SortingLineParam
                    {
                        Width = 50
                    },
                    new SortingLineParam
                    {
                        Width = 80
                    },
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 37
                    }
                }
            }
            };

                bool result = Program.FirstParcelLine(boxSizes);

                //Assert
                Assert.True(result);
            }
        }

    }
    
