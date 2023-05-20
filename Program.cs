// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Client code that uses the factory method to create objects 
using Factory;

IAnimalFactory dogFactory = new DogFactory();
IAnimalFactory catFactory = new CatFactory();
IAnimalFactory cowFactory = new CowFactory();

//Dogs
var dog1 = dogFactory.CreateAnimal();
dog1.MakeSound();
dog1.Fart();

var dog2 = dogFactory.CreateAnimal();
dog2.MakeSound();

var dog3 = dogFactory.CreateAnimal();
dog3.MakeSound();
dog1.Fart();

//Cats
var cat1 =catFactory.CreateAnimal();
cat1.MakeSound();

var cat2 = catFactory.CreateAnimal();
cat2.MakeSound();

var cat3 = catFactory.CreateAnimal();
cat3.MakeSound();
cat3.Fart();

//Cows
var cow1 = cowFactory.CreateAnimal();
cow1.MakeSound();

var cow2 = cowFactory.CreateAnimal();
cow2.MakeSound();

var cow3 = cowFactory.CreateAnimal();
cow3.MakeSound();
cow3.Fart();