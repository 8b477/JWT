using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Projet.API.REST.Swagger
{
    /// <summary>
    /// Création de notre clef secrete pour notre token.
    /// </summary>
    public class TokenHelper
    {
        private const string SECRET_KEY = "TQvgjeABMPOwCycOqah5EQu5yyVjpmVG";

        public static readonly SymmetricSecurityKey SIGNING_KEY = new
                               SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));
    }
}