public class Character
{
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }

    public override string ToString()
    {
        return $"Character [Strength: {Strength}, Agility: {Agility}, Intelligence: {Intelligence}]";
    }
}

public interface ICharacterBuilder
{
    ICharacterBuilder SetStrength(int value);
    ICharacterBuilder SetAgility(int value);
    ICharacterBuilder SetIntelligence(int value);
    Character Build();
}

public class HeroBuilder : ICharacterBuilder
{
    private Character character = new Character();

    public ICharacterBuilder SetStrength(int value)
    {
        character.Strength = value;
        return this;
    }

    public ICharacterBuilder SetAgility(int value)
    {
        character.Agility = value;
        return this;
    }

    public ICharacterBuilder SetIntelligence(int value)
    {
        character.Intelligence = value;
        return this;
    }

    public Character Build()
    {
        return character;
    }
}
