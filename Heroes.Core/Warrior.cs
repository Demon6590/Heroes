namespace Heroes.Core;

public class Warrior : HeroBase, IWarrior
{
    public override void Attack(HeroBase enemy)
    {
        PhysicalAttack(enemy);
    }

    public void PhysicalAttack(HeroBase enemy)
    {
        throw new System.NotImplementedException();
    }
}