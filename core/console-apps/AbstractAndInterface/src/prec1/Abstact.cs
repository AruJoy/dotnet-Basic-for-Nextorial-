abstract class AnimalA
{
    protected string Name { get; set; }

    public override string ToString() => $"이름: {Name}";
    public void Eat()
    {
        if (string.IsNullOrWhiteSpace(Name)) throw new InvalidDataException("이름이 없어 말을 못함");
        Console.WriteLine($"{Name} is eating");
    }
    public abstract void Speak();
}

class DogA : AnimalA
{
    public class Builder
    {
        private readonly DogA _instance = new DogA();
        public Builder SetName(string name)
        {
            _instance.Name = name;
            return this;
        }
        public DogA Build()
        {
            if (string.IsNullOrWhiteSpace(_instance.Name)) throw new InvalidDataException("이름은 지어줘야지 ㅡㅡ");
            return _instance;
        }
    }
    public override void Speak() => Console.WriteLine("아.. 개어렵네");
}

