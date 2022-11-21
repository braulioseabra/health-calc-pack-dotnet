using System;
using health_calc_pack_dotnet_braulio_seabra.Enums;



namespace health_calc_pack_dotnet_braulio_seabra.Strategy.Base
{
    public abstract class MacroNutrienteBase
    {
        public double GENDER_MUTIPLIER;

        public MacroNutrienteBase(SexoEnum Sexo)

        {
            GENDER_MUTIPLIER = (Sexo == SexoEnum.Feninino) ? 0.8 : 1;
        }

    }
}

