using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
   public string namee;
   public int hp;

    public Enemy(string namee, int hp){
        this.namee = namee;
        this.hp = hp;
        
    }
    

   
    public void GetEnemyInfo(){
        Debug.Log($"name : {this.namee} hp : {this.hp}");
        //Debug.Log("name : "+this.name+" hp : "+this.hp);
    }
}
