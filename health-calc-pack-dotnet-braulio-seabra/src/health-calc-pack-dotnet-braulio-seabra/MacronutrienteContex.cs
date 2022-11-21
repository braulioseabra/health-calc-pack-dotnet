using System;
using health_calc_pack_dotnet_braulio_seabra.Interfaces;
using health_calc_pack_dotnet_braulio_seabra.Models;

namespace health_calc_pack_dotnet_braulio_seabra
{
    public class MacronutrienteContex
    {
        private IMacronutrienteStrategy MacronutrienteStrategy;

        public MacronutrienteContex(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }

        public void SetStrategy(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }

        public MacronutrienteModel Execute(double Weight)

        {
            return MacronutrienteStrategy.Calc(Weight);
        }


       
    }
}

