using System;
using health_calc_pack_dotnet_braulio_seabra;

namespace health_calc_pack_dotnet_braulio_seabra
{
    public interface IIMC

    {
        double Calc(double Height, double Weight);

        string GetIMCCategory(double IMC);

        bool IsValidData(double Height, double Weight);
       
    }
}

