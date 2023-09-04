using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Sources;

namespace ParcelSorting1
{
    public class Program
    {
        static void Main(string[] args)
        { 

            FirstParcelLine(boxSizes);

        }

         public static bool FirstParcelLine(List<BoxSize> boxSizes)
        {  
            bool parcelFits=false;

             foreach(BoxSize box in boxSizes)
            {
                Console.WriteLine("New sorting Line starts");
                var halfBoxLength=box.Length/2;
                var halfBoxDiagonalNotSqrt= Math.Pow(halfBoxLength, 2) + Math.Pow(box.Width, 2);
                var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSqrt);

                var LineWidth = 0;
               
                foreach(SortingLineParam sortingLine in box.SortingLineParams)
                {

                    var cornerDiagonal = Math.Sqrt((sortingLine.Width * sortingLine.Width) + (LineWidth * LineWidth));

                    if (sortingLine.Width >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0}and fits", sortingLine.Width);
                        return true;
                    }
                    else if ( sortingLine.Width<= halfParcelDiagonal && LineWidth>=halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0}and fits", sortingLine.Width);
                        return true;
                    }
                    else if ( sortingLine.Width >= cornerDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and fits", sortingLine.Width);
                        return true;
                    }
                   
                    LineWidth = sortingLine.Width;                               

                }

                Console.WriteLine("\n");

            }

           return parcelFits;
        }


        public static readonly List<BoxSize> boxSizes = new List<BoxSize>()
        {

            new BoxSize
            {
                Length = 120,
                Width = 60,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 100

                    },
                    new SortingLineParam
                    {
                        Width = 75
                    }
                }
            },
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
            },
            new BoxSize
            {
                Length = 70,
                Width = 60,
                SortingLineParams = new List<SortingLineParam> {
                    new SortingLineParam
                    { Width = 60

                    },
                    new SortingLineParam
                    { Width = 60

                    },
                    new SortingLineParam
                    { Width = 55

                    }, new SortingLineParam
                    { Width = 90

                    }



                }


            }
        };
        }

    


       public  class SortingLineParam
        {
            public int Width { get; set; }
        }

    }