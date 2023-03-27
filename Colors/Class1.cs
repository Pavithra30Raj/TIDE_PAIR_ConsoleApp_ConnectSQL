using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    public class Item
    {
        public List<colors> colors { get; set; }
    }
    public class colors
    {
        public string color;
        public string category;
        public string type;
    }

}