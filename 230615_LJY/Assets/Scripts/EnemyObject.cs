using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyObject : MonoBehaviour
{
    
    [SerializeField] private Sprite[] enemyImg;
    [SerializeField] private Slider hpbar;
    Enemy enemy = null;
    

    public void SetEnemy(Enemy e){
        this.enemy = e;

        this.hpbar.maxValue = enemy.HP;
        this.hpbar.value = enemy.HP;
    }

    private void Start()
    {
        SetEnemy(new Enemy(Enemy.EnemyType.Basic,100,10,1.5f));
    }
    
    private void EnemyMove(){
        if(this.transform.position.y <= -2){
            // y 값이 -2보다 작으면 멈춤
        } 
        else{
            this.transform.position -= new Vector3(0,enemy.Speed * Time.deltaTime, 0);
        }

    }

    void Update()
    {
        if(enemy == null) return;
         EnemyMove();
    }
}
