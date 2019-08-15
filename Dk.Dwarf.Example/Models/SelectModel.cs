using Dk.Dwarf.Example.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dk.Dwarf.Example.Models
{
    public class SelectModel<T>
    {
        public bool Selected { get; set; }
        public T Obj { get; }
        public SelectModel(T obj)
        {
            Obj = obj;
        }
    }
}
