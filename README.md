# Error code generator core
Es una librería codeada 100% en C#, nos facilita mecanismos para la generacion de códigos alfanuméricos de error o de lo que querramos, con el plus de agregar prefijos y sufijos.

## Máscara normal
```csharp
string GenerateCode(string mask); // ###-#-### -> AN5-G-B42
```

## Máscara con prefijo
```csharp
string GenerateCode(string prefix, string mask); //WARN,#####-######-# -> WARN-610MN-0PLO15-1
```

## Máscara con prefijo y sufijo
```csharp
string GenerateCode(string prefix, string mask, string suffix); //WARN,#####-######-#,NET -> WARN-LBC078-W1GFH3-9-NET
```

Los tres argumentos admiten el caracter # para la generación de alfanuméricos [A-Z0-9]

# Inyección de dependencias
```csharp
IServiceCollection services = new ServiceCollection();
services.AddErrorCodeGenerator();

var provider = services.BuildServiceProvider();

var generator = provider.GetRequiredService<IErrorCodeGenerator>();
generator.GenerateCode("#-###-##"); //R-6H5-Q2, 1-AS2-3B
```

## Features Version 1.0.1
```
  # Generará letras y números
  $ Generará únicamente números
  & Generará únicamente letras
```

<a href="https://www.buymeacoffee.com/josesebastiangarcia" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>
