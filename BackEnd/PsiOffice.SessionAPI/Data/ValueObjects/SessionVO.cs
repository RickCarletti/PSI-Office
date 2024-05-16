using System.Text.Json.Nodes;

namespace PsiOffice.SessionAPI.Data.ValueObjects
{
    public class SessionVO
    {
        public long Id { get; set; }
        public string Observation { get; set; }
        public DateTime FullDate { get; set; }
        public DateTime DtCreation { get; set; }
        public bool IsRemote { get; set; }
        public string Place { get; set; }
        public JsonNode AdditionalFilds { get; set; }

        public long IdSessionType { get; set; }
        public long IdTreatment { get; set; }
    }
}