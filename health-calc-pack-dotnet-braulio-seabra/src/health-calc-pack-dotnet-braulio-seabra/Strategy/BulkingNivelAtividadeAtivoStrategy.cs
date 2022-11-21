using System;
using health_calc_pack_dotnet_braulio_seabra.Enums;
using health_calc_pack_dotnet_braulio_seabra.Interfaces;
using health_calc_pack_dotnet_braulio_seabra.Models;
using health_calc_pack_dotnet_braulio_seabra.Strategy.Base;


namespace health_calc_pack_dotnet_braulio_seabra.Strategy
{
    public class BulkingNivelAtividadeAtivoStrategy : MacroNutrienteBase, IMacronutrienteStrategy

    {

        const int PROTEINA = 2;
        const int GORDURA = 2;
        const int CARBOIDRATO = 7;

        public BulkingNivelAtividadeAtivoStrategy(SexoEnum sexo) : base(sexo)

        {

        }
      

        public MacronutrienteModel Calc(double Weight)

        {
          
            var Result = new MacronutrienteModel()

            {
                Proteinas = PROTEINA * (int)Weight * GENDER_MUTIPLIER,
                Carboidratos = CARBOIDRATO * (int)Weight * GENDER_MUTIPLIER,
                Gorduras = GORDURA * (int)Weight * GENDER_MUTIPLIER
            };

            return Result;

        }
    }
}
