public class Person {
    public string Prenom {get; set;}
    public string Nom { get; set;}
    public int Age { get; set;}

    public string NomComplet
    {
        get{
        return $"{Prenom} {Nom}";
    }
    }
    public Person(string prenom, string nom, int age){
        Prenom = prenom;
        Nom = nom;
        Age = age;

    }
}