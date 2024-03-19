public class Car
{
    public string Marque { get; private set; }
    public string Model { get; private set; }
    public Colors Color { get; set; }

    public string NomComplet
    {
        get
        {
            return $"{Marque} {Model}";
        }
    }

    public int AnneeDeFabrication { get; private set; }


    public void StartEngine(){
        Console.WriteLine("Vroum Vroum");
    }

    public Car(string marque, string modele, Colors color, int anneeDeFabrication)
    {
        Marque = marque;
        Model = modele;
        Color = color;
        AnneeDeFabrication = anneeDeFabrication;
    }
}