using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

namespace PsiOffice.PacientAPI.Data.ValueObjects
{
    public class PacientVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Observation { get; set; }
        public string Forwarding { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Sex { get; set; }
        public string ClinicalHistory { get; set; }
        public string Meds { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DtCreation { get; set; }
        public string BirthPlace { get; set; }
        public JsonNode AdditionalFilds { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string Number { get; set; }
        public long IdCounty { get; set; }
        public long IdState { get; set; }
        public long IdCity { get; set; }
    }
}