using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private new string name;
    private string job;
    private int hp;
    private int atk;

    public string Name
    {
        get { return this.name; }
    }

    public string Job
    {
        get { return this.job; }
        set { job = value; }
    }

    public int HP
    {
        get { return this.hp; }
        set { hp = value; }
    }

    public int ATK
    {
        get { return this.atk; }
        set { atk = value; }
    }

    public Character(string name, string job, int hp, int atk)
    {
        this.name = name;
        this.job = job;
        this.hp = hp;
        this.atk = atk;
}

    public void GetInfo()
    {
        Debug.Log("Name: " + this.name+ " Job: " + this.job+ " HP: " + this.hp+ " ATK: " + this.atk);
    }
}
