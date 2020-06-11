using System.ComponentModel;

namespace supermercado.API.Domain.Models
{
    public enum EUnidadeMedida
    {
        [Description("UN")]
        Unidade = 1,
        [Description("MG")]
        Miligrama = 2,
        [Description("G")]
        Grama = 3,
        [Description("KG")]
        Kilograma = 4,
        [Description("L")]
        Litro = 5
    }
}