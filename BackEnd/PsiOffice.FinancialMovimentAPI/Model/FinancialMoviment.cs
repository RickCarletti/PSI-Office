using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PsiOffice.FinancialMovimentAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiOffice.FinancialMovimentAPI.Model
{
    [Table("financial_moviment")]
    public class FinancialMoviment : BaseEntity
    {
        [Column("description")]
        public string Description { get; set; }

        [Column("dt_creation")]
        public DateTime DtCreation { get; set; }

        [Column("dt_payment")]
        public DateTime DtPayment { get; set; }

        [Column("is_expense")]
        public bool IsExpense { get; set; }

        [Column("base_value")]
        public decimal BaseValue { get; set; }

        [Column("discounts")]
        public decimal Discounts { get; set; }

        [Column("additions")]
        public decimal Additions { get; set; }

        [Column("full_value")]
        public decimal FullValue { get; set; }
    }
}