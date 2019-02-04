using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WebApiBank.Models
{
    public partial class Account
    {
        public Account()
        {
            Transaction = new HashSet<Transaction>();
        }

        [Key]
        [StringLength(20)]
        public string IBAN { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public long BankId { get; set; }
        public long CustomerId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Balance { get; set; }

        [IgnoreDataMember]
        [ForeignKey("BankId")]
        [InverseProperty("Account")]
        public virtual Bank Bank { get; set; }
        [IgnoreDataMember]
        [ForeignKey("CustomerId")]
        [InverseProperty("Account")]
        public virtual Customer Customer { get; set; }
        [IgnoreDataMember]
        [InverseProperty("IBANNavigation")]
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}