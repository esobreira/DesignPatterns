namespace Factory
{
    class CowFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            return new Cow();
        }
    }
}