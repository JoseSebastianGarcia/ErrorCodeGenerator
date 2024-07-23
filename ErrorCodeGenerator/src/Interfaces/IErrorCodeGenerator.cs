using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorCodeGeneratorCore.src.Interfaces
{
    public interface IErrorCodeGenerator
    {
        /// <summary>
        /// Genera códigos. Si en la máscara hay presente un #, se reemplazará por un caracter aleatorio.
        /// </summary>
        /// <param name="mask"></param>
        /// <returns></returns>
        string GenerateCode(string mask);

        /// <summary>
        /// Genera códigos. Si en la máscara o cualquiera de los miembros hay presente un #, se reemplazará por un caracter aleatorio.
        /// </summary>
        /// <param name="prefix">Prefijo</param>
        /// <param name="mask"></param>
        /// <returns></returns>
        string GenerateCode(string prefix, string mask);

        /// <summary>
        /// Genera códigos. Si en la máscara o cualquiera de los miembros hay presente un #, se reemplazará por un caracter aleatorio.
        /// </summary>
        /// <param name="prefix">Prefijo</param>
        /// <param name="mask"></param>
        /// <param name="suffix">Sufijo</param>
        /// <returns></returns>
        string GenerateCode(string prefix, string mask, string suffix);
    }
}
