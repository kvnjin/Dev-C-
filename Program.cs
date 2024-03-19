Car bmw = new Car("BMW", "serie5", Colors.Rouge, 2010);
bmw.StartEngine();
Console.WriteLine($"Modèle voiture : {bmw.NomComplet}");


Camion scania = new Camion("Scania", "x500", Colors.Vert, 2000, 500);



Console.WriteLine($"Nouveau modèle de camion :{scania.NomComplet} \n le poids max du camion est de {scania.PoidsMax}");

scania.addColis(new Colis (1, 200, true));
scania.addColis(new Colis (2, 100, true));
scania.addColis(new Colis (3, 50, true));


Console.WriteLine($"Le poids actuelle du camion est de {scania.PoidsActuel}");



