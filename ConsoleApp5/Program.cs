using AutoFixture;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.Results;
using Riok.Mapperly.Abstractions;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp5;
public class Program 
{
    public static void Main(params string[] args) 
    {
        string mask = string.Empty;
        do
        {
            Console.Clear();
            Console.Write("Inserte una máscara (# letra): ");
            mask = Console.ReadLine() ?? "exit";

            if (mask != "exit")
            {
                string errorCode = GenerateErrorCode("CHEVRON",mask);
                Console.WriteLine(errorCode);
                Console.ReadKey();
            }

        } while (mask != "exit");
    }


}

