try
{
    var fox = new Fox();
    fox.Say();

    var animal = new MAnimal();
    animal.speak();

    var dog = new Dog();
    dog.speak();

    var cat = new Cat();
    cat.speak();
    CAnimal cAnimal = new CAnimal.Builder()
                        .SetName("바다거북이")
                        .SetAge(104)
                        .Build();

    Console.WriteLine(cAnimal.ToString());
    Console.WriteLine(cAnimal);
}
catch (IOException ex)
{
    Console.WriteLine($"IO Err: {ex.Message}");
}