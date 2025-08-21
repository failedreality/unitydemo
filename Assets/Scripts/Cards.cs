public class Cards
{
    public int attack;
    public int defense;
    public int hitPoints;
    public int energyCost;

    public override string ToString()
    {
        return $"Attack: {attack}, Defense: {defense}, Hit Points: {hitPoints}, Energy Cost: {energyCost}";
    }
}