// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;
using System.Xml;
using tim_skit;
main();
static void main(){
Bil p = new Bil("volvo", "2007", "2.4");

Console.WriteLine(p.name);
Console.WriteLine(p.ålder);
Console.WriteLine(p.motor);
}


