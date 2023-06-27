using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Start(){

        for(int i=0; i<10;i++){
            GameObject obj = Instantiate(enemyPrefab,Vector3.zero,Quaternion.identity,this.transform);
            obj.transform.position = new Vector3(Random.Range(-2,2),5+Random.Range(0,3),0);
            Enemy e = new Enemy(Enemy.EnemyType.Basic,100,10,0.5f+i);
            obj.GetComponent<EnemyObject>().SetEnemy(e);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        // 여기서 직접 하지말고 start 에서 만든거 list로 만들어서 불러오기. 안그러면 중복으로 오지게 생겨버림
        //Instantiate(enemyPrefab,Vector3.zero,Quaternion.identity,this.transform);
        //Start();
    }
}
