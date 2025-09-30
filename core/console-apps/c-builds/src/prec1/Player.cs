class Player
{
    public string Name { get; }
    public int Level { get; private set; }

    public Player(string name)
    {
        Name = name;
        Level = 1;
    }

    public void LevelUp() => Level++;
}