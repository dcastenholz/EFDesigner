//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Testing
{
   public partial class Master
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Master()
      {
         Children = new System.Collections.ObjectModel.ObservableCollection<Child>();

         Init();
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      // Persistent navigation properties

      public virtual ICollection<Child> Children { get; set; } 
   }
}

