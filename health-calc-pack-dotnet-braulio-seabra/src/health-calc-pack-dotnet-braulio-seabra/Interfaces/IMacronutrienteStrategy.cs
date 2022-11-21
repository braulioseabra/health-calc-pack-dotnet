using health_calc_pack_dotnet_braulio_seabra.Enums;
using health_calc_pack_dotnet_braulio_seabra.Models;

namespace health_calc_pack_dotnet_braulio_seabra.Interfaces
{
    public interface IMacronutrienteStrategy
    {
        MacronutrienteModel Calc(double Weight);            
    }
}

