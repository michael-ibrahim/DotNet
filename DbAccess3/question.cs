//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbAccess3
{
    using System;
    using System.Collections.Generic;
    
    public partial class question
    {
        public int Id { get; set; }
        public Nullable<int> lesson { get; set; }
        public Nullable<int> goal { get; set; }
        public string text { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public Nullable<int> correct { get; set; }
    }
}
