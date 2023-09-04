using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelSorting1
{
     
        public class BoxSize
        {
            public int Length { get; set; }
            public int Width { get; set; }
            public List<SortingLineParam> SortingLineParams { get; set; }
             = new List<SortingLineParam>();
        }
    
}
