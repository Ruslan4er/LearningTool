//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public int ChapterId { get; set; }
    
        public virtual Chapter Chapter { get; set; }
    }
}
