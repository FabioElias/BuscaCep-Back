using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Back.End.Correios.Repository.Persistence
{
    internal class CorreioSql
    {
        internal const string Create = @"INSERT INTO CORREIOS_ADDRESS (CITY, STREET, DDD, IBGE, COMPLEMENT, SIAFI, GIA, NEIGHBORHOOD, STATE)
                                         VALUES (:City, :Street, :Ddd, :Ibge, :Complement, :Siafi, :Gia, :Neighborhood, :State)";

    }
}
