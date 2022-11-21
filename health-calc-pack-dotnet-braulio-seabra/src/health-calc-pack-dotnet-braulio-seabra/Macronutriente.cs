using health_calc_pack_dotnet_braulio_seabra.Enums;
using health_calc_pack_dotnet_braulio_seabra.Interfaces;
using health_calc_pack_dotnet_braulio_seabra.Models;
using health_calc_pack_dotnet_braulio_seabra.Strategy;
using System;

namespace health_calc_pack_dotnet_braulio_seabra
{
    public class Macronutriente : IMacronutriente
    {
       const int MIN_WEIGHT = 35;
     
        public MacronutrienteModel Calc(
             SexoEnum Sexo,
             double Height,
             double Weight,
             NivelAtividadeFisicaEnum nivelAtividadeFisica,
             ObjetivoFisicoEnum objetivoFisico)
        {

            if (!IsValidData(Weight))
            throw new Exception("Invalid Parameters!");

         
            IMacronutrienteStrategy macronutrienteStrategy = new CuttingStrategy(Sexo);

            if (objetivoFisico == ObjetivoFisicoEnum.Cutting)
                macronutrienteStrategy = new CuttingStrategy(Sexo);
            else if (objetivoFisico == ObjetivoFisicoEnum.Bulking)
            {
                if (nivelAtividadeFisica == NivelAtividadeFisicaEnum.BastanteAtivo ||
                    nivelAtividadeFisica == NivelAtividadeFisicaEnum.ExtremamenteAtivo)
                    macronutrienteStrategy = new BulkingNivelAtividadeAtivoStrategy(Sexo);
                else
                    macronutrienteStrategy = new BulkingStrategy(Sexo);
            }
                
            else if (objetivoFisico == ObjetivoFisicoEnum.Maintenance)
                macronutrienteStrategy = new MaintenanceStrategy(Sexo);

            var context = new MacronutrienteContex(macronutrienteStrategy);
            var Result = context.Execute(Weight);

            return Result;
        }

        public bool IsValidData(double Weight)
        {
            if (Weight <= MIN_WEIGHT)

                return false;

            return true;
        }

    }

}

