using System;

public class Enemy
{

    private string name;

    private float health;
    private float damage;
    private float agility;

    public Enemy(string _name, float _health, float _damage, float _agility)
	{
        name = _name;
        health = _health;
        damage = _damage;
        agility = _agility;
	}

    public void SetName(string _name)
    {
        name = _name;
    }
    public string GetName(string _name)
    {
        return name;
    }


    public void SetHealth(float _health)
    {
        health = _health;
    }
    public float GetHealth(float _health)
    {
        return health;
    }

    public void SetDamage(float _damage)
    {
        damage = _damage;
    }
    public float GetDamage(float _damage)
    {
        return damage;
    }

    public void SetAgility(float _agility)
    {
        agility = _agility;
    }
    public float GetAgility(float _agility)
    {
        return agility;
    }

    public virtual void Atack(Hero hero) { }
}

public class Skelet : Enemy
{
    public Skelet(string _name, float _health, float _damage, float _agility) : base(_name, _health, _damage, _agility)
    {



    }

    public override void Atack(Hero hero) 
    {
        hero.SetHealth(hero.GetHealth(0) - GetDamage(0));
    }
}

public class Zombie : Enemy
{
    public Zombie (string _name, float _health, float _damage, float _agility) : base(_name, _health, _damage, _agility)
    {



    }

    public override void Atack(Hero hero)
    {
        hero.SetHealth(hero.GetHealth(0) - GetDamage(0));
    }
}

public class Rat : Enemy
{
    public Rat (string _name, float _health, float _damage, float _agility) : base(_name, _health, _damage, _agility)
    {



    }

    public override void Atack(Hero hero)
    {
        hero.SetHealth(hero.GetHealth(0) - GetDamage(0));
    }
}
