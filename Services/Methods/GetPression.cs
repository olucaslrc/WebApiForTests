using System;

namespace Air_BOT.Services.Methods
{
    public class GetPression
    {
        public string GetPressionMetar(string Metar)
        {
            string result = string.Empty;

            var Pression = Metar.Substring(Metar.IndexOf("/"));

            result = $"{Pression.Substring(Pression.IndexOf("Q")).Substring(1, 4)} hPa";

            return $"QNH: {result}";
        }
    }
}