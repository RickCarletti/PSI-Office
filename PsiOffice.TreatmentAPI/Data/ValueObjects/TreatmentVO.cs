using System.Text.Json.Nodes;

namespace PsiOffice.TreatmentAPI.Data.ValueObjects
{
    public class TreatmentVO
    {
        public long Id { get; set; }
        public string Observation { get; set; }
        public string InitialDemend { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DtCreation { get; set; }
        public JsonNode AdditionalFilds { get; set; }
        public long IdTreatmentType { get; set; }
        public long IdPacient { get; set; }

    }
}