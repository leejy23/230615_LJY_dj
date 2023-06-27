using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Enemy[] enemyList = new Enemy[10];
    //List<int> listNumber = new List<int>();
    //List<Enemy> e_list = new List<Enemy>();

    void Start()
    {   
        // 로그에 이름,hp 띄우기

        // 리스트 생성방법
        //e_list[0] = new Enemy("name",10);
        
        //e_listAdd(new Enemy("name",100));
        
        
        // 이 두가지가 위에 두가지보다 자주 사용하는 방식임
        //Enemy e = new Enemy("test",1);
        //e_list.Add(e);

        //e_list[0] = e;


        /* 반복문으로 배열에 적 넣기
        for(int i=0; i<enemyList.length;i++)
        {
            enemyList[i] = new Enemy($"ai_{i}",i+10);
        }*/

        // 반복문으로 리스트에 적 넣기
        /*
        for(int i=0; i<enemyList.length;i++)
        {
            e_list[i] = new Enemy("elf",i);
            e.GetEnemyInfo();
            e_list.Add(e);
        }*/
    }

   
}
