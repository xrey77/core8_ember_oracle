using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core8_ember_oracle.Entities
{
    [Table("Users", Schema="C##REY")]
    public class User {

        [Key] // Designates ProductId as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // For identity columns
        public int Id {get; set;}

        [Column("lastname",TypeName="varchar2(10)")]
        public string LastName {get; set;}

        [Column("firstname",TypeName="varchar2(10)")]
        public string FirstName {get; set;}

        [Column("username",TypeName="varchar2(10)")]
        public string UserName {get; set;}

        [Column("password",TypeName="varchar2(100)")]
        public string Password {get; set;}

        [Column("email",TypeName="varchar2(100)")]
        public string Email { get; set; }

        [Column("mobile",TypeName="varchar2(20)")]
        public string Mobile { get; set; }

        [Column("roles",TypeName="varchar2(10)")]
        public string Roles { get; set; }

        [Column("isactivated",TypeName="number(2)")]
        public int IsActivated {get; set;}

        [Column("isblocked",TypeName="number(2)")]
        public int Isblocked {get; set;}

        [Column("mailtoken",TypeName="number(5)")]
        public int Mailtoken {get; set;}

        [Column("qrcodeurl",TypeName="blob")]
        public string Qrcodeurl {get; set;}

        [Column("profilepic",TypeName="varchar2(4000)")]
        public string Profilepic {get; set;}

        [Column("secretkey",TypeName="varchar2(900)")]
        public string Secretkey {get; set;}

        [Column("createdat",TypeName="date")]
        public DateTime CreatedAt {get; set;}

        [Column("updatedat",TypeName="date")]
        public DateTime UpdatedAt {get; set;}
    }
}