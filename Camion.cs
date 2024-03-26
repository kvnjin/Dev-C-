using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Camion : Car
{
    public int PoidsMax { get; set; }
    public int PoidsActuel
    {
        get
        {
            return GetPoidsActuel();
        }
    }

    public List<Colis> ColisLst { get; set; }

    public void colisList()
    {

        Stack colisList = new Stack(ColisLst);
        if (colisList.Count == 0)
        {
            Console.WriteLine("Il n'y a pas de colis dans votre camion");
        }
        else
        {
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:    {0}", ColisLst.Count);
            Console.Write("\tValues:");
            PrintValues(colisList);
        }
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection){
            Console.Write("    {0}", (obj as Colis)!.Id);
        }
        Console.WriteLine();
    }



    private int GetPoidsActuel()
    {
        int poidsActuel = 0;
        foreach (var colis in ColisLst)
        {
            poidsActuel += colis.Poids;
        }
        return poidsActuel;
    }

    public void addListColis()
    {

    }
    public void addColis(Colis colis)
    {
        var PoidsFutur = PoidsActuel + colis.Poids;
        Console.WriteLine($"Le camion viens d'être chargé de {colis.Id} {colis.Poids} {colis.IsFragile}");

        if (PoidsFutur > PoidsMax)
        {
            Console.WriteLine($"Le poids max du camion a été dépassé");
        }
        else
        {
            ColisLst.Add(colis);
            Console.WriteLine("Le colis a bien était chargé");
        }

    }

    public override void InitCheckList(){
        CheckList = new Queue<Tache>();
        CheckList.Enqueue(new Tache("Possédez vous une clée ?"));
        CheckList.Enqueue(new Tache("Avez vous attacher votre ceinture ?"));
        CheckList.Enqueue(new Tache("Possèdez vous de l'essence dans votre véhicule ?"));
        CheckList.Enqueue(new Tache("Etes vous sobre ?"));
        CheckList.Enqueue(new Tache("Avez vous votre permis camion sur vous ?"));
    }

    public Camion(string marque, string modele, Colors color, int anneeDeFabrication, int poidsMax) : base(marque, modele, color, anneeDeFabrication)
    {
        PoidsMax = poidsMax;
        ColisLst = new List<Colis>();
    }
}