using System.Text.Json.Serialization;

namespace CrudPessoaFisicaApi.Domain.Entities
{
    public class EntityBase
    {
        public int? Id { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
