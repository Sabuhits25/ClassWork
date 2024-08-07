using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public object Group { get; internal set; }
    }
}
