try
{
    DogA dogA = new DogA.Builder()
                    .SetName("복실이")
                    .Build();
    Console.WriteLine(dogA);
    dogA.Speak();
}
catch (IOException ex)
{
    Console.WriteLine($"IO Err: {ex.Message}");
}