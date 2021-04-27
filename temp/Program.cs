using _domain.Entities;
using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ficha1 = new Ficha
            {
                Nome = Pegar("nome"),
                Idade = int.Parse(Pegar("Idade")),
                Raca = Pegar("Raça"),
                Experiencia = int.Parse(Pegar("Experiencia")),
                Adre = int.Parse(Pegar("Adre")),
                Ataq = int.Parse(Pegar("Ataq")),
                Def = int.Parse(Pegar("Def")),
                Dest = int.Parse(Pegar("Dest")),
                Forc = int.Parse(Pegar("Forc")),
                Inte = int.Parse(Pegar("Inte")),
                Resi = int.Parse(Pegar("Resi")),
                Sabe = int.Parse(Pegar("Sabe")),
                Velo = int.Parse(Pegar("Velo")),
                Vital= int.Parse(Pegar("Vital")),
                Sorte = int.Parse(Pegar("Sorte")),


            };
            Console.WriteLine($"nome: {ficha1.Nome}, idade : {ficha1.Idade}, raça :{ficha1.Raca}, nivel:{ficha1.CalcularNivel()}");
            Console.WriteLine("Adre - " + ficha1.Adre + "--------------------------Vital" + ficha1.Vital);
            Console.WriteLine("Ataq - " + ficha1.Ataq + "---------------------------Sorte" + ficha1.Sorte);
            Console.WriteLine("Def - " + ficha1.Def);
            Console.WriteLine("Dest - " + ficha1.Dest);
            Console.WriteLine("Forc - " + ficha1.Forc);
            Console.WriteLine("Inte - " + ficha1.Inte);
            Console.WriteLine("Resi - " + ficha1.Resi);
            Console.WriteLine("Sabe - " + ficha1.Sabe);
            Console.WriteLine("Velo - " + ficha1.Velo);

        }
        private static string Pegar(string propriedade)
        {
            Console.WriteLine($"digite {propriedade}");
            return Console.ReadLine();
        }
    }
}
