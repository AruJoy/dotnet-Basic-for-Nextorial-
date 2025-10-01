class CAnimal
{
    private string Name { get; set; }
    private int Age { get; set; }
    private CAnimal() { }

    public override string ToString() => $"{Name}, 나이:{Age}";

    public class Builder
    {
        private readonly CAnimal _instance = new();
        public Builder SetName(String name)
        {
            _instance.Name = name;
            return this;
        }

        public Builder SetAge(int age)
        {
            _instance.Age = age;
            return this;
        }

        public CAnimal Build()
        {
            if (string.IsNullOrWhiteSpace(_instance.Name))
                throw new InvalidOperationException("이름은 지어줘야지ㅡㅡ");
            return _instance;
        }
    }
}