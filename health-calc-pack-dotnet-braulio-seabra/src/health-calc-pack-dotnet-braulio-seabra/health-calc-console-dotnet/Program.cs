using health_calc_pack_dotnet_braulio_seabra;

Console.WriteLine("Entre com a sua altura e o seu peso para calcular o seu IMC!");

Console.Write("Altura: ");
var Height = Console.ReadLine();

Console.Write("Peso: ");
var Weight = Console.ReadLine();

IMC objIMC = new IMC();

double Result = objIMC.Calc(double.Parse(Height), double.Parse(Weight));

string Category = objIMC.GetIMCCategory(Result);


Console.WriteLine(" O resultado do seu IMC foi: " + Category);

Console.ReadKey();