//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sandbox_EFCore
{
   public partial class Role
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Role()
      {
         Users = new System.Collections.Generic.HashSet<Sandbox_EFCore.User>();

         Init();
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public long Id { get; set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      /// <summary>
      /// Users
      /// </summary>
      public virtual ICollection<Sandbox_EFCore.User> Users { get; set; }

   }
}
