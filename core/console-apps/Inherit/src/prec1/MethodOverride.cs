class MAnimal
{
    public virtual void speak() => Console.WriteLine("소인은 성대를 잃었소..");
}

class Dog : MAnimal
{
    public override void speak() => Console.WriteLine("월월");
}

class Cat : MAnimal
{
    public override void speak()
    {
        Console.WriteLine("월요일이 두번이라니 이 얼마나 불행한가..");
        base.speak();
    }
}