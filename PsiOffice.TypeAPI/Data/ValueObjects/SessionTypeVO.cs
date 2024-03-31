using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace PsiOffice.TypeAPI.Data.ValueObjects
{
    public class SessionTypeVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public JsonNode BaseAdditionalFilds { get; set; }
    }
}
