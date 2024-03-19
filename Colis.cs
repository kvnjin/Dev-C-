public class Colis{
    public int Id { get; private set; }
    public int Poids { get; private set; }
    public bool IsFragile { get; private set; }

    public Colis(int id, int poids, bool isFragile){
        Id = id; 
        Poids = poids;
        IsFragile = isFragile;
    }
}