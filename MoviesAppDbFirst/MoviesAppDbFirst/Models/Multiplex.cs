//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesAppDbFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Multiplex
    {
        public int MultiplexId { get; set; }
        public string MultiplexName { get; set; }
        public string Location { get; set; }
        public int Screen { get; set; }
        public Nullable<int> MovieId { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
