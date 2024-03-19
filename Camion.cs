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

    private int GetPoidsActuel()
    {
        int poidsActuel = 0;
        foreach (var colis in ColisLst)
        {
            poidsActuel += colis.Poids;
        }
        return poidsActuel;
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

    public Camion(string marque, string modele, Colors color, int anneeDeFabrication, int poidsMax) : base(marque, modele, color, anneeDeFabrication)
    {
        PoidsMax = poidsMax;
        ColisLst = new List<Colis>();
    }
}