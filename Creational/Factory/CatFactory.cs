namespace Factory
{
    // Define a concrete class that implements the interface 
    class CatFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            return new Cat();
        }
    }
}