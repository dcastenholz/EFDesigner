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
   public partial class AllPropertyTypesRequired
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected AllPropertyTypesRequired()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_binaryattr"></param>
      /// <param name="_booleanattr"></param>
      /// <param name="_byteattr"></param>
      /// <param name="_datetimeattr"></param>
      /// <param name="_datetimeoffsetattr"></param>
      /// <param name="_decimalattr"></param>
      /// <param name="_doubleattr"></param>
      /// <param name="_guidattr"></param>
      /// <param name="_int16attr"></param>
      /// <param name="_int32attr"></param>
      /// <param name="_int64attr"></param>
      /// <param name="_singleattr"></param>
      /// <param name="_timeattr"></param>
      /// <param name="_string"></param>
      public AllPropertyTypesRequired(byte[] _binaryattr, bool _booleanattr, byte _byteattr, DateTime _datetimeattr, DateTimeOffset _datetimeoffsetattr, decimal _decimalattr, double _doubleattr, Guid _guidattr, short _int16attr, int _int32attr, long _int64attr, Single _singleattr, TimeSpan _timeattr, string _string)
      {
         BinaryAttr = _binaryattr;
         BooleanAttr = _booleanattr;
         ByteAttr = _byteattr;
         DateTimeAttr = _datetimeattr;
         DateTimeOffsetAttr = _datetimeoffsetattr;
         DecimalAttr = _decimalattr;
         DoubleAttr = _doubleattr;
         GuidAttr = _guidattr;
         Int16Attr = _int16attr;
         Int32Attr = _int32attr;
         Int64Attr = _int64attr;
         SingleAttr = _singleattr;
         TimeAttr = _timeattr;
         if (string.IsNullOrEmpty(_string)) throw new ArgumentNullException(nameof(_string));
         String = _string;
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_binaryattr"></param>
      /// <param name="_booleanattr"></param>
      /// <param name="_byteattr"></param>
      /// <param name="_datetimeattr"></param>
      /// <param name="_datetimeoffsetattr"></param>
      /// <param name="_decimalattr"></param>
      /// <param name="_doubleattr"></param>
      /// <param name="_guidattr"></param>
      /// <param name="_int16attr"></param>
      /// <param name="_int32attr"></param>
      /// <param name="_int64attr"></param>
      /// <param name="_singleattr"></param>
      /// <param name="_timeattr"></param>
      /// <param name="_string"></param>
      public static AllPropertyTypesRequired Create(byte[] _binaryattr, bool _booleanattr, byte _byteattr, DateTime _datetimeattr, DateTimeOffset _datetimeoffsetattr, decimal _decimalattr, double _doubleattr, Guid _guidattr, short _int16attr, int _int32attr, long _int64attr, Single _singleattr, TimeSpan _timeattr, string _string)
      {
         return new AllPropertyTypesRequired(_binaryattr, _booleanattr, _byteattr, _datetimeattr, _datetimeoffsetattr, _decimalattr, _doubleattr, _guidattr, _int16attr, _int32attr, _int64attr, _singleattr, _timeattr, _string);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public byte[] BinaryAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public bool BooleanAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public byte ByteAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public DateTime DateTimeAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public DateTimeOffset DateTimeOffsetAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public decimal DecimalAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public double DoubleAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public Guid GuidAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public short Int16Attr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public int Int32Attr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public long Int64Attr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public Single SingleAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public TimeSpan TimeAttr { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string String { get; set; }

   }
}

