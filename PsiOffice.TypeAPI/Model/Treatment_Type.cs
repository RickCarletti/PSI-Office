using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PsiOffice.TypeAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;

namespace PsiOffice.TypeAPI.Model
{
    [Table("treatment_type")]
    public class TreatmentType : BaseEntity
    {
        [Column("name")]
        [Required]
        public required string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("base_additional_fields", TypeName = "json")]
        public string BaseAdditionalFilds { get; set; }
    }
}