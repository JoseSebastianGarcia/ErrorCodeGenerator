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
