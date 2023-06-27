using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyObject : MonoBehaviour
{
    
    [SerializeField] private Sprite[] enemyImg;
    Enemy enemy;
    

    public void SetEnemy(Enemy e){
        this.enemy = e;
    }
    
    public void EnemyMove(){
        if(this.transform.position.y <= -2){

        } 
        else{
            this.transform.position -= new Vector3(0,3 * Time.deltaTime, 0);
        }

    }

    void Update()
    {
         EnemyMove();
    }
}
