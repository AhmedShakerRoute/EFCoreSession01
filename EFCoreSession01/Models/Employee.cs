using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession01.Models
{
    // 4 Ways To Map Entity To Table In Database
    // 1. By Convention (Default)
    // 2. By Data Annotations
    // 3. By Fluent API

    //POCO (Plain Old CLR Object) Class

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Identity(1,1) //Auto Increment
        public int EmpId { get; set; } //Primary Key = Id | EmployeeId +  Identity(1,1) 

        [MaxLength(50 , ErrorMessage = "Name is Exceded 50 Char")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name Must Be Between 3 and 50 Char")]
        [Column(TypeName = "varchar")]
        [Required]
        public string? Name { get; set; }//Reference Type + Allow Nulls NVarchar(max) //Optional

        //[Column(TypeName = "decimal(10,2)")]
        [DataType(DataType.Currency)]
        //[Column(TypeName ="money")]
        public decimal Salary { get; set; }//Value Type + Not Allow Nulls Decimal(18,2) //Required

        [NotMapped]
        public int? Age { get; set; } //Value Type + Allow Nulls Int //Optional

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
