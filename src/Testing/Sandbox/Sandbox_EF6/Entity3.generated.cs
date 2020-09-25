//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v2.1.0.0
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
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

namespace MultiContext.Context2
{
   public partial class Entity3: global::MultiContext.Context2.Base
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Entity3(): base()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Entity3 CreateEntity3Unsafe()
      {
         return new Entity3();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_entity21"></param>
      public Entity3(global::MultiContext.Context2.Entity2 _entity21)
      {
         if (_entity21 == null) throw new ArgumentNullException(nameof(_entity21));
         _entity21.Entity3.Add(this);


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_entity21"></param>
      public static Entity3 Create(global::MultiContext.Context2.Entity2 _entity21)
      {
         return new Entity3(_entity21);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      public string Property1 { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}
