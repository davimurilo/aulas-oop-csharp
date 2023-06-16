using ConsoleAppOOP.Aula3.Entidades;



NotaFiscal notaFiscal = new NotaFiscal();


Console.WriteLine(notaFiscal.Limite2);

notaFiscal.Numero = 10;

Console.WriteLine(notaFiscal.Limite2);

Console.WriteLine($"Tipo de Nota:{notaFiscal.TipoDocumento}");
Console.WriteLine($"Numero de Nota:{notaFiscal.Numero}");
Console.WriteLine($"Serie de Nota:{notaFiscal.Serie}");

notaFiscal.Serie = "002";

Console.WriteLine($"Serie de Nota:{notaFiscal.Serie}");

Console.WriteLine(notaFiscal.Limite2);

Console.ReadKey();
