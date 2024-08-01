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
            string numbers = "0123456789";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            foreach (char c in mask)
            {
                switch (c) 
                {
                    case '#': 
                        {
                            string mixed = $"{chars}{numbers}";
                            int index = random.Next(0, mixed.Length - 1);
                            builder.Append(mixed[index]);
                            break;
                        }
                    case '$':
                        {
                            int index = random.Next(0, numbers.Length - 1);
                            builder.Append(numbers[index]);
                            break;
                        }
                    case '&':
                        {
                            int index = random.Next(0, chars.Length - 1);
                            builder.Append(chars[index]);
                            break;
                        }
                    default:
                        {
                            builder.Append(c);
                            break;
                        }
                }
            }
            return builder.ToString();
        }
    }
}
