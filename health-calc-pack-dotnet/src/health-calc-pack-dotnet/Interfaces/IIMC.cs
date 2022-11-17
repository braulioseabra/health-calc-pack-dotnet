using System;
using health_calc_pack_dotnet;

namespace health_calc_pack_dotnet
{
    public interface IIMC

    {
        double Calc(double Height, double Weight);

        string GetIMCCategory(double IMC);

        bool IsValidData(double Height, double Weight);
       
    }
}

