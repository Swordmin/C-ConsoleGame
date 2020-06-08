using System;

public class Item
{
    private static string name;

    public void SetName(string _name)
    {
        name = _name;
    }

    public string GetName()
    {
        return name;
    }

}

public class Weapon : Item
{
    private enum material { coper = 1, gold = 2, iron = 3 }
    private material _material;
    private float quality;
    private static string qualityName;
    private float damage => 10 * quality;

    public virtual void Initialization() 
    {
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

    public string GetQualityName() 
    {
        return qualityName;
    }
}

public class Sword : Weapon
{
    Weapon weapon = new Weapon();

    public override void Initialization()
    {
        base.Initialization();
        weapon.SetName("Меч");
        weapon.SetName(weapon.GetQualityName() + " " + weapon.GetName());
    }

}
