using System;

public class Hero
{

    private float health;
    private float damage;
    private float power;
    private float agility;
    private float defense;

    public Hero(float _health, float _damage, float _power, float _ability, float _defense)
	{

        health = _health;
        damage = _damage;
        power = _power;
        agility = _ability;
        defense = _defense;
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

    public void SetPower(float _power)
    {
        power = _power;
    }
    public float GetPower(float _power)
    {
        return power;
    }

    public void SetAgility(float _agility)
    {
        agility = _agility;
    }
    public float GetAgility(float _agility)
    {
        return agility;
    }

    public void Atack() 
    {
        
    }

}
