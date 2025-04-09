using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace FuncionarioWebApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //converte os numero para o que está escrito nas enums
    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite

    }
}
