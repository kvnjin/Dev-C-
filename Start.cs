using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace firstApp;

class Program
{

    static void Main(string[] args)
    {

        string getNom()
        {

            string? nom;
            string nonNullNom = "";
            bool isNomValide = false;

            do
            {
                Console.WriteLine("Bonjour, quel est votre nom ?");
                nom = Console.ReadLine();
                if (String.IsNullOrEmpty(nom))
                {
                    Console.WriteLine("Le nom est null, merci de fournir votre nom complet");
                }
                else
                {
                    nonNullNom = (string)nom;
                    bool isAllLetters = true;
                    foreach (char c in nonNullNom)
                    {
                        if (!char.IsLetter(c))
                        {
                            isAllLetters = false;
                            break;
                        }
                    }
                    if (isAllLetters)
                    {
                        isNomValide = true;
                    }
                }
            } while (!isNomValide);

            return nonNullNom;
        }

        string getPrenom()
        {

            string? prenom;
            string nonNullPrenom = "";
            bool isPrenomValide = false;

            do
            {
                Console.WriteLine("Bonjour, quel est votre prénom ?");
                prenom = Console.ReadLine();
                if (String.IsNullOrEmpty(prenom))
                {
                    Console.WriteLine("Le prénom est null, merci de fournir votre prénom complet");
                }
                else
                {
                    nonNullPrenom = (string)prenom;
                    bool isAllLetters = true;
                    foreach (char c in nonNullPrenom)
                    {
                        if (!char.IsLetter(c))
                        {
                            isAllLetters = false;
                            break;
                        }
                    }
                    if (isAllLetters)
                    {
                        isPrenomValide = true;
                    }
                }
            } while (!isPrenomValide);

            return nonNullPrenom;
        }

        int getAge()
        {

            string? ageString;
            bool isAgeGood = false;
            int age = 0;

            do
            {
                Console.WriteLine("Quel est votre âge ?");
                ageString = Console.ReadLine();

                if (String.IsNullOrEmpty(ageString))
                {
                    Console.WriteLine("L'âge ne peut pas être nul");
                }
                else
                {

                    try
                    {
                        age = Convert.ToInt32(ageString);
                        if (age > 0 && age <= 99)
                        {
                            isAgeGood = true;
                        }
                        else
                        {
                            Console.WriteLine("Donnez un âge compris entre 0 et 99");
                        }
                    }
                    catch (System.FormatException exception)
                    {
                        Console.WriteLine("Merci de rentrer un âge valide");
                    }
                }
            } while (!isAgeGood);

            return age;
        }

        string nom = getNom();
        string prenom = getPrenom();
        int age = getAge();
        
        Personne untel = new Personne(nom, prenom, age);

        Console.WriteLine($"Bonjour {untel.Nom} {untel.Prenom}");
        Console.WriteLine($"{untel.Nom} {untel.Prenom} a {untel.Age} ans");

        int agePlus10 = age + 10;
        Console.WriteLine($"Dans 10 ans tu auras {agePlus10} ans");
    }
}

class Personne{

    public string Nom { get; }
    public string Prenom { get; }
    public int Age { get; }

    public Personne(string _nom, string _prenom, int _age){
        Nom = _nom;
        Prenom = _prenom;
        Age = _age;
    }
}