interface IDamageable
{
    void TakeDamage(int damage);
}

abstract class Character: IDamageable
{
    private string Name;
    private int Health;
    protected Character()
    {
        this.Name = "Noname";
        this.Health = 100;
    }
    protected Character(string name, int health)
    {
        this.Name = name;
        this.Health = health;
    }
    public abstract void Attact();
    public void Move()
    {
        Console.WriteLine("Character moved");
    }
    public void TakeDamage(int Damage)
    {
        this.Health -= 1;
    }
}
// абстрактный тк есть абстрактный метод
class Warrior: Character
{
    public override void Attact()
    {
        Console.WriteLine("Warior attacked");
    }
}
class Mage: Character
{
    public override void Attact()
    {
        Console.WriteLine("Mage attacked");
    }
}
//потому что методы оверрайд

class Ward : Character
{
    public override void Attact()
    {
        Console.WriteLine("Ward attacked");
    }
}