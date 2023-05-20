namespace Factory{
    class DogFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            return new Dog();
        }
    }
}