//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestLife.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int QId { get; set; }
        public string Answer1 { get; set; }
        public bool IsCorrect { get; set; }
    
        public virtual Question Question { get; set; }
    }
}