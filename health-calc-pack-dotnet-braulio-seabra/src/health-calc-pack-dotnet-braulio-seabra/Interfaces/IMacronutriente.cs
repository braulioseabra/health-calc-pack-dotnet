using health_calc_pack_dotnet_braulio_seabra.Enums;
using health_calc_pack_dotnet_braulio_seabra.Models;

namespace health_calc_pack_dotnet_braulio_seabra.Interfaces
{

    public interface IMacronutriente

    {
        MacronutrienteModel Calc(
            SexoEnum sexo,
            double Height,
            double Weight,
            NivelAtividadeFisicaEnum nivelAtividadeFisica,
            ObjetivoFisicoEnum objetivoFisico);

        bool IsValidData(double Weight);


    }
}

