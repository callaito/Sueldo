// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Sueldo/Salario");
Console.WriteLine();

Double
    pago_hora,
    hora_t;

Console.Write("pago_hora: ");
pago_hora = Convert.ToDouble(Console.ReadLine());

Console.Write("horas_t: ");
hora_t = Convert.ToDouble(Console.ReadLine());

Double

    sueldo_bruto = pago_hora * hora_t,
    afp = sueldo_bruto * 0.0287,
    sfs = sueldo_bruto * 0.0304,
    total_descuento = afp + sfs,
    sueldo_neto = sueldo_bruto - total_descuento;

;



//Imprimir datos en pantalla




Console.WriteLine($"sueldo_bruto: {sueldo_bruto}");
Console.WriteLine($"afp: {afp}");
Console.WriteLine($"sfs: {sfs}");
Console.WriteLine($"total_descuento: {total_descuento}");
Console.WriteLine($"sueldo_neto: {sueldo_neto}");

