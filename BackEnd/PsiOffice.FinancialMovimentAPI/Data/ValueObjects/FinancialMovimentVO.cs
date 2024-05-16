using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

namespace PsiOffice.FinancialMovimentAPI.Data.ValueObjects
{
    public class FinancialMovimentVO
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime DtCreation { get; set; }
        public DateTime DtPayment { get; set; }
        public bool IsExpense { get; set; }
        public decimal BaseValue { get; set; }
        public decimal Discounts { get; set; }
        public decimal Additions { get; set; }
        public decimal FullValue { get; set; }
    }
}