//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Minutes { get; set; }
        public int Match { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Distance { get; set; }
        public int TeamsId { get; set; }
    
        public virtual Team Team { get; set; }
    }
}
