 using System;
 using System.Collections;

public class Car
{
    public string Marque { get; private set; }
    public string Model { get; private set; }
    public Colors Color { get; set; }

    public string NomComplet
    {
        get
        {
            return $"{Marque} {Model} {Color}";
        }
    }

    public int AnneeDeFabrication { get; private set; }

    public string Task { get; private set; }

    public bool IsTaskDone { get; private set; }

    public Queue<Tache> CheckList { get; set; }

    public bool IsCheckListOk(){
        foreach(var item in CheckList){
            if(item.IsTaskDone == false){
                Console.WriteLine($"Cette élément {item.Task} n'a pas été effectué ");
                return false;
            }
        }

        return true;
    }
    public void StartEngine(){
        askForCheckList();
        while (IsCheckListOk()== false){
                askForCheckList();
        } 
            Console.WriteLine("Vroum Vroum");
    }

    public virtual void InitCheckList(){
        CheckList = new Queue<Tache>();
        CheckList.Enqueue(new Tache("Possédez vous une clée ?"));
        CheckList.Enqueue(new Tache("Avez vous attacher votre ceinture ?"));
        CheckList.Enqueue(new Tache("Possèdez vous de l'essence dans votre véhicule ?"));
        CheckList.Enqueue(new Tache("Avez vous votre permis sur vous ?"));
    }

    public Car(string marque, string modele, Colors color, int anneeDeFabrication)
    {
        Marque = marque;
        Model = modele;
        Color = color;
        AnneeDeFabrication = anneeDeFabrication;
        InitCheckList();
    }

    public void askForCheckList(){
        foreach(var question in CheckList){
            Console.WriteLine($"Est-ce que tu as fait la tâche suivante : {question.Task} ? (o : oui, n : non)");
            var response = Console.ReadLine();
            if (response == "o"){
                question.IsTaskDone = true;
            }
        }
    }
}