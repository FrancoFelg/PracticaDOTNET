//Console.WriteLine("Hola puto");
using ConsoleApp1.Entities;

/////Clase 1

Human human1 = new Human();
Human human2 = new Human("Carlos", "Caserios", 48, 180);

//Console.WriteLine(human2.GetHeight());
//Console.WriteLine("Altura 1 "+human1.GetHeight());
//Console.WriteLine("Altura 2 "+human1.GetHeight());
//Console.WriteLine("Altura 1 " + human1.Height);
//Console.WriteLine("Altura 2 " + human1.Height);

/////Clase 1
/////Clase 2
PetType petType1 = new PetType();
petType1.Id = 1;
petType1.Type = "Canino";

PetType petType2 = new PetType();
petType2.Id = 2;
petType2.Type = "Felino";

Pet pet1 = new Pet();
pet1.Name = "FyruLays";
pet1.Type = petType1;
pet1.Owner = human2;

Pet pet2 = new Pet();
pet2.Name = "Figaro";
pet2.Type = petType2;
pet2.Owner = human2;

List<Pet> petsList = new List<Pet>();
petsList.Add(pet1);
petsList.Add(pet2);
human2.Pets = petsList;

//Console.WriteLine(human2.Name);
human1.Name = "cambiado bobo";
foreach (Pet item in human2.Pets)
{
    Console.WriteLine("Mascota ID   = " + item.Id);
    Console.WriteLine("Mascota Name = " + item.Name);
    item.Owner = human1;
    Console.WriteLine("Mascota Owner= " + item.Owner.Name);

    //Console.WriteLine("Mascota Owner= " + );
    Console.WriteLine();
}



var arr = human2.Pets.ToArray();
for (int i = 0; i < human2.Pets.Count; i++)
{
    Console.WriteLine(arr[i].Name);
    Console.WriteLine(arr[i].Owner.Name);
}


Nationalities nationality1 = new Nationalities();
nationality1.Id = 1;
nationality1.Nationality = "Argentina";

Nationalities nationality2 = new Nationalities();
nationality2.Id = 2;
nationality2.Nationality = "Francia";//jaja tan segundos

Nationalities nationality3 = new Nationalities();
nationality3.Id = 3;
nationality3.Nationality = "Italiana";

Humans_Nationalities humans_Nationalities1 = new Humans_Nationalities();
humans_Nationalities1.Id = 1;
humans_Nationalities1.Human = human2;
humans_Nationalities1.Nationality = nationality1;

Humans_Nationalities humans_Nationalities2 = new Humans_Nationalities();
humans_Nationalities2.Id = 2;
humans_Nationalities2.Human = human2;
humans_Nationalities2.Nationality = nationality3;

List<Humans_Nationalities> nationalities1 = new List<Humans_Nationalities>();
nationalities1.Add(humans_Nationalities1);
nationalities1.Add(humans_Nationalities2);

human2.Nationalities = nationalities1;
nationality1.Humans = nationalities1;
nationality3.Humans = nationalities1;

Console.WriteLine(human2.Pets.ToArray());

/////Clase 2

