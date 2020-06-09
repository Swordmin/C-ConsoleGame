using System;

public class Item
{
    private string name;
    public enum Type { weapon, clothing, useItem}
    public Type type;

    public virtual void SetName(string _name)
    {
        name = _name;
    }


    public void SetType(Type _type) 
    {
        type = _type;
    }

    

    public virtual void Equip(Hero hero) { }

    public virtual string GetName()
    {
        return name;
    }
}

public class Weapon : Item
{

    Item item = new Item();

    private enum material { coper, gold, iron }
    private material _material;
    private float quality;
    private string qualityName;
    private delegate float Damage(float damage);
   // private float damage => 10 * quality;

    public float GetDamage( float _deffultDaamge) 
    {
        Damage damage = count => count * quality;
        return damage(_deffultDaamge);
    }

    public virtual void Initialization() 
    {
        SetType(Type.weapon);        
        Random random = new Random();
        _material = (material)random.Next(0, Enum.GetValues(typeof(material)).Length);
        switch (_material) 
        {
            case material.coper:
                quality = 1;
                qualityName = "Посредственный";
                break;
            case material.gold:
                quality = 2;
                qualityName = "Неплохой";
                break;
            case material.iron:
                quality = 3;
                qualityName = "Легендарный";
                break;
        }
    }

    public override string GetName()
    {
        return item.GetName();
    }

    public override void SetName(string _name)
    {
        item.SetName(_name);
    }

    public string GetQuality() 
    {
        return qualityName;
    }

}

public class Clothing : Item 
{

    Item item = new Item();

    private enum material { coper, gold, iron }
    private material _material;
    private float quality;
    private string qualityName;
    private delegate float Defense(float defense);

    public virtual void Initialization()
    {
        SetType(Type.clothing);
        Random random = new Random();
        _material = (material)random.Next(0, Enum.GetValues(typeof(material)).Length);
        switch (_material)
        {
            case material.coper:
                quality = 1;
                qualityName = "Посредственный";
                break;
            case material.gold:
                quality = 2;
                qualityName = "Неплохой";
                break;
            case material.iron:
                quality = 3;
                qualityName = "Легендарный";
                break;
        }
    }

    public float GetDefense(float _deffultDefense)
    {
        Defense defense = count => count * quality;
        return defense(_deffultDefense);
    }

    public override string GetName()
    {
        return item.GetName();
    }

    public override void SetName(string _name)
    {
        item.SetName(_name);
    }

    public string GetQuality()
    {
        return qualityName;
    }
}

public class Sword : Weapon
{

    public override void Initialization()
    {
        base.Initialization();
        base.SetName(GetQuality() + " Меч");
    }
    public override void Equip(Hero hero) 
    {
        hero.SetDamage(hero.GetDamage(0) + GetDamage(2));
    }

}
public class Stick : Weapon
{

    public override void Initialization()
    {
        base.Initialization();
        base.SetName(GetQuality() + " Палка");
    }
    public override void Equip(Hero hero)
    {
        hero.SetDamage(hero.GetDefaultDamage() + GetDamage(1));
    }

}

public class Hat : Clothing 
{
    public override void Initialization()
    {
        base.Initialization();
        base.SetName(GetQuality() + " Шлем");
    }
    public override void Equip(Hero hero)
    {
        hero.SetHatDefense(GetDefense(1));
    }
}
public class Bib : Clothing
{
    public override void Initialization()
    {
        base.Initialization();
        base.SetName(GetQuality() + " Нагрудник");
    }
    public override void Equip(Hero hero)
    {
        hero.SetBodyDefense(GetDefense(2));
    }
}
public class Trousers : Clothing
{
    public override void Initialization()
    {
        base.Initialization();
        base.SetName(GetQuality() + " Штаны");
    }
    public override void Equip(Hero hero)
    {
        hero.SetLegDefense(GetDefense(1));
    }
}
public class Boots : Clothing
{
    public override void Initialization()
    {
        base.Initialization();
        base.SetName(GetQuality() + " Ботинки");
    }
    public override void Equip(Hero hero)
    {
        hero.SetBootsDefense(GetDefense(1));
    }
}

