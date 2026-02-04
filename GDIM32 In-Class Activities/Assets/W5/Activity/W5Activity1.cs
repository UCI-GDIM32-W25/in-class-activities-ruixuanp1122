using System.Collections.Generic;
using UnityEngine;

public class W5Activity1 : MonoBehaviour
{
    private void Start()
    {
        List<Item> inventory = new List<Item>()
        {
            new Torch(),
            new ElvenSword(),
            new Axe()
        };

        foreach (Item item in inventory)
        {
            item.Use();
        }
    }
}

public interface IBreakable
{
    void Damage(float damage);
    void Break();
}

public abstract class Item
{
    public abstract void Use();
}

public class Axe : Item, IBreakable
{
    private float _durability = 5.0f;

    public void Damage(float damage)
    {
        _durability -= damage;
        Debug.Log("axe now has " + _durability + " durability remaining");

        if (_durability <= 0)
        {
            Break();
        }
    }

    public void Break()
    {
        Debug.Log("axe is broken!");
    }

    public override void Use()
    {
        Debug.Log("attacking with axe");
        Damage(1.0f);
    }
}

public class ElvenSword : Item
{
    public override void Use()
    {
        Debug.Log("attacking with Elven sword");
    }
}

public class Torch : Item, IBreakable
{
    private float _durability = 1.0f;

    public void Damage(float damage)
    {
        _durability -= damage;
        Debug.Log("torch now has " + _durability + " durability remaining");

        if (_durability <= 0)
        {
            Break();
        }
    }

    public void Break()
    {
        Debug.Log("torch is broken!");
    }

    public override void Use()
    {
        Debug.Log("lighting area with torch");
        Damage(1.0f);
    }
}