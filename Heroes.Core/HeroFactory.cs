using System;

namespace Heroes.Core;

public enum HeroType
{
    Warrior, Mage
}

public static class HeroFactory
{
    public static T Create<T>(int health, int damage) where T : HeroBase, new()
    {
        var hero = new T() { Health = health, Damage = damage };
        return hero;
    }
}