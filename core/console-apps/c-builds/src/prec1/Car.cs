// using System;

class Car
{
    public string Model { get; set; } = "몰?루";
    public int Speed { get; private set; }

    public void Accelerate(int amount)
    {
        Speed += amount;
        Console.WriteLine("부릉부릉");
    }
}