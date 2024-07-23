using ErrorCodeGeneratorCore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorCodeGeneratorCore.src.Services
{
    public class ErrorCodeGenerator : IErrorCodeGenerator
    {
        public string GenerateCode(string mask) 
            => GenerateErrorCode(mask);

        public string GenerateCode(string prefix, string mask)
            => GenerateErrorCode($"{prefix}-{mask}");

        public string GenerateCode(string prefix, string mask, string suffix)
            => GenerateErrorCode($"{prefix}-{mask}-{suffix}");

        private string GenerateErrorCode(string mask)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            foreach (char c in mask)
            {
                if (c == '#')
                {
                    int index = random.Next(0, chars.Length - 1);
                    builder.Append(chars[index]);
                }
                else
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
    }
}
