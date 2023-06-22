using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
   public string name;
   public int hp;

    public Enemy(string name, int hp){
        this.name = name;
        this.hp = hp;
        
    }
    

   
    public void GetEnemyInfo(){
        Debug.Log($"name : {this.name} hp : {this.hp}");
        //Debug.Log("name : "+this.name+" hp : "+this.hp);
    }
}
