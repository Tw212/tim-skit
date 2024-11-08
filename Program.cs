// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;
using System.Xml;
using tim_skit;

Bil p = new Bil();
p.setname("volvo");
p.setålder("2020");
p.setmotor("t8");
Console.WriteLine(p.getname());
Console.WriteLine(p.getålder());
Console.WriteLine(p.getmotor());

Bil s = new Bil();
s.setname2("volov");
s.setålder2("1999");
s.setmotor2("2.4");
