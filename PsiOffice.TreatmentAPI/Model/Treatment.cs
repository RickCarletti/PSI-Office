using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PsiOffice.TreatmentAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiOffice.TreatmentAPI.Model
{
    [Table("treatment")]
    public class Treatment : BaseEntity
    {
        [Column("observation")]
        public string Observation { get; set; }

        [Column("initial_demend")]
        public string InitialDemend { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Column("dt_creation")]
        public DateTime DtCreation { get; set; }

        [Column("additional_fields", TypeName = "json")]
        public string AdditionalFilds { get; set; }

        [Column("id_treatment_type")]
        public long IdTreatmentType { get; set; }

        [Column("id_pacient")]
        public long IdPacient { get; set; }
    }
}