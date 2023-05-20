namespace Factory {
    abstract class Animal
    {
        public abstract void MakeSound();
        public void Fart() => Console.WriteLine("Animal just farted. It stinks!!");
    }
}