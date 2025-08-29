
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using core8_ember_oracle.Helpers;

namespace core8_ember_oracle.Entities
{
    
[Table("Products", Schema="C##REY")]
public class Product {

        [Key] // Designates ProductId as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // For identity columns
        public int Id { get; set; }

        [Column("category",TypeName="varchar2(50)")]
        public string Category { get; set; }

        [Column("descriptions", TypeName="varchar2(100)")]
        public string Descriptions { get; set; }

        [Column("qty", TypeName="number(5)")]
        public int Qty { get; set; }

        [Column("unit", TypeName="varchar2(10)")]
        public string Unit { get; set; }

        [Column("costprice",TypeName="decimal(10,2)")]
        public decimal CostPrice { get; set; }

        [Column("sellprice",TypeName="decimal(10,2)")]
        public decimal SellPrice { get; set; }

        [Column("saleprice",TypeName="decimal(10,2)")]
        public decimal SalePrice { get; set; }

        [Column("productpicture",TypeName="varchar2(100)")]
        public string ProductPicture { get; set; }

        [Column("alertstocks",TypeName="number(5)")]
        public int AlertStocks { get; set; }

        [Column("criticalstocks", TypeName="number(5)")]
        public int CriticalStocks { get; set; }

        [Column("createdAt", TypeName="date")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt", TypeName="date")]
        public DateTime UpdatedAt { get; set; }
    }    
}