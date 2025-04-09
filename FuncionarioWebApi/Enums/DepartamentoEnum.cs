using System.Text.Json.Serialization;

namespace FuncionarioWebApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //converte os numero para o que está escrito nas enums
    public enum DepartamentoEnum
    {
        Rh,
        Compras,
        Financeiro,
        Zeladoria,
        Produção,
        Almoraxarifado
    }
}
