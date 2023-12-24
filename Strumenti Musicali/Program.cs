// See https://aka.ms/new-console-template for more information
using Strumenti_Musicali;

Console.WriteLine("Hello, World!");
Directory.SetCurrentDirectory("..\\..\\..");


var ganzo = new Spartito("Ganzo", "Do Re Re Sol Fa Fa Mi", 115);
var nomadi = new Spartito("Nomadi", "Re Sol Mi Do Re Fa Fa La", 45);
var setteMila = new Spartito("SetteMila", "La Si Do Do Do La Mi Fa", 34);
var pastaInSaor = new Spartito("PastaInSaor", "Do Do Do Do Do Do Do Do Do", 3);

var playlist1 = new List<Spartito>();
playlist1.Add(nomadi); playlist1.Add(setteMila); playlist1.Add(pastaInSaor);

var playlist2 = new List<Spartito>();
playlist2.Add(ganzo); playlist2.Add(nomadi); playlist2.Add(setteMila); playlist2.Add(pastaInSaor);


var chitarra = new Chitarra("Stratocaster 70\'");
chitarra.Carica();


var tromba = new Tromba("Thormann FH-900J");
tromba.Carica();

Console.WriteLine(chitarra);
chitarra.Suona(0);
chitarra.Suona(1);
chitarra.Suona(2);
chitarra.Salva();

Console.WriteLine(tromba);
tromba.Suona();
tromba.Salva();