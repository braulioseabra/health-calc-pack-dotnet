using System;
using health_calc_pack_dotnet.Enums;



namespace health_calc_pack_dotnet.Strategy.Base
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

