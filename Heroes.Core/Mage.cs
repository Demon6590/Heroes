namespace Heroes.Core;

public class Mage : HeroBase, IMage
{
    public override void Attack(HeroBase enemy)
    {
        MagicAttack(enemy);
    }

    public void MagicAttack(HeroBase enemy)
    {
        throw new System.NotImplementedException();
    }
}