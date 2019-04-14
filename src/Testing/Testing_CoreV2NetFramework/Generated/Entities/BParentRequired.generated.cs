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
using System.Runtime.CompilerServices;

namespace Testing
{
   public partial class BParentRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BParentRequired()
      {
         BChildCollection = new System.Collections.Generic.HashSet<Testing.BChild>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="bchildrequired"></param>
      public BParentRequired(Testing.BChild bchildrequired)
      {
         if (bchildrequired == null) throw new ArgumentNullException(nameof(bchildrequired));
         this.BChildRequired = bchildrequired;

         this.BChildCollection = new System.Collections.Generic.HashSet<Testing.BChild>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="bchildrequired"></param>
      public static BParentRequired Create(Testing.BChild bchildrequired)
      {
         return new BParentRequired(bchildrequired);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; private set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      public virtual Testing.BChild BChildOptional { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual Testing.BChild BChildRequired { get; set; }

      public virtual ICollection<Testing.BChild> BChildCollection { get; private set; }

   }
}

