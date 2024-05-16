using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PsiOffice.SessionAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiOffice.SessionAPI.Model
{
    [Table("session")]
    public class Session : BaseEntity
    {
        [Column("observation")]
        public string Observation { get; set; }

        [Column("full_date")]
        public DateTime FullDate { get; set; }

        [Column("dt_creation")]
        public DateTime DtCreation { get; set; }

        [Column("is_remote")]
        public bool IsRemote { get; set; }

        [Column("place")]
        public string Place { get; set; }

        [Column("additional_fields", TypeName = "json")]
        public string AdditionalFilds { get; set; }

        [Column("id_session_type")]
        public long IdSessionType { get; set; }

        [Column("id_treatment")]
        public long IdTreatment { get; set; }
    }
}