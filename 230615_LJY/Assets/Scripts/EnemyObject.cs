using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyObject : MonoBehaviour
{
    
    [SerializeField] private Sprite[] enemyImg;
    [SerializeField] private Slider hpbar;
    Enemy enemy = null;
    float time = 0f;

    public void SetEnemy(Enemy e){
        this.enemy = e;

        this.hpbar.maxValue = enemy.HP;
        this.hpbar.value = enemy.HP;
    }

    private void Start()
    {
        //SetEnemy(new Enemy(Enemy.EnemyType.Basic,100,10,1.5f));
    }
    
    private void EnemyMove(){
        if(this.transform.position.y <= -5f)
        {   
            time += Time.deltaTime;
            if(time>=1f)
            {
                time = 0f;
                if(enemy.Hit(1)==false)
                {
                    Destroy(this.gameObject);
                }
            }
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
