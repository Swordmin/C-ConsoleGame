using System;

public class Hero
{
    private float health, defaultHealth;
    private float damage, defaultDamage;
    private float agility, defaultAgility;
    private float defense, bodyDefense, hatDefense, legDefense, bootsDefense;
    private float power;

    public Hero(float _health, float _damage, float _power, float _agility, float _defense)
	{

        health = _health;
        defaultHealth = health;
        damage = _damage;
        defaultDamage = damage;
        power = _power;
        agility = _agility;
        defaultAgility = _agility;
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

    public void SetDefense(float _defense)
    {
        defense = _defense;
    }
    public float GetDefense(float _defense)
    {
        return bodyDefense + hatDefense + legDefense + bootsDefense;
    }

    public float GetDefaultHealth()
    {
        return defaultHealth;
    }
    public float GetDefaultDamage()
    {
        return defaultDamage;
    }
    public float GetDefaultAgility()
    {
        return defaultAgility;
    }

    public void SetHatDefense(float _defense) 
    {
        hatDefense = _defense;
    }
    public void SetBodyDefense(float _defense)
    {
        bodyDefense = _defense;
    }
    public void SetLegDefense(float _defense)
    {
        legDefense = _defense;
    }
    public void SetBootsDefense(float _defense)
    {
        bootsDefense = _defense;
    }

    public void Atack() 
    {
        
    }

}
