using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PsiOffice.PacientAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiOffice.PacientAPI.Model
{
    [Table("pacient")]
    public class Pacient : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("observation")]
        public string Observation { get; set; }

        [Column("forwarding")]
        public string Forwarding { get; set; }

        [Column("cpf")]
        public string CPF { get; set; }

        [Column("cep")]
        public string CEP { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cellphone")]
        public string Cellphone { get; set; }

        [Column("sex")]
        public string Sex { get; set; }

        [Column("clinical_history")]
        public string ClinicalHistory { get; set; }

        [Column("meds")]
        public string Meds { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("dt_creation")]
        public DateTime DtCreation { get; set; }

        [Column("birth_place")]
        public string BirthPlace { get; set; }

        [Column("additional_fields", TypeName = "json")]
        public string AdditionalFilds { get; set; }

        [Column("street")]
        public string Street { get; set; }

        [Column("complement")]
        public string Complement { get; set; }

        [Column("number")]
        public string Number { get; set; }

        [Column("id_country")]
        public long IdCounty { get; set; }

        [Column("id_state")]
        public long IdState { get; set; }

        [Column("id_city")]
        public long IdCity { get; set; }
    }
}