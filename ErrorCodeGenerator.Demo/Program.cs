using ErrorCodeGeneratorCore.src.Dependency_Injection;
using ErrorCodeGeneratorCore.src.Interfaces;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();
services.AddErrorCodeGenerator();

var provider = services.BuildServiceProvider();

var generator = provider.GetRequiredService<IErrorCodeGenerator>();


Console.WriteLine("Only mask");
Console.WriteLine("#####-##########");
Console.WriteLine(generator.GenerateCode("#####-##########"));
Console.WriteLine();

Console.WriteLine("Prefix and mask");
Console.WriteLine("SHOE ##########");
Console.WriteLine(generator.GenerateCode("SHOE", "##########"));
Console.WriteLine();

Console.WriteLine("Prefix, mask and suffix");
Console.WriteLine("HAMSTER ########## PIC");
Console.WriteLine(generator.GenerateCode("HAMSTER", "##########", "PIC"));
Console.WriteLine();

Console.WriteLine("Mixed component");
Console.WriteLine("NA-### ###-#-### P-#");
Console.WriteLine(generator.GenerateCode("NA-###", "###-#-###", "P-#"));
Console.WriteLine();

Console.ReadKey();