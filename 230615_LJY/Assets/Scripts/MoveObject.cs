using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
   int change = 0;
    
    void Update()
    {   
        float MoveY = this.transform.position.y;
        float MoveX = this.transform.position.x;
        
        if(MoveY >= 2f)
        {
            change =1;
        }
        else if(MoveX >= 2f && MoveY>=2f)
        {
            change =2;
        }else if(MoveY<= -2 && MoveX>= 2){
            change =3;
        }else if (MoveX <=-2 && MoveY<= -2){
            change =4;
        }
        //switch case 문으로 변경
        switch (change){
            case 0:

            break;
            case 1:

            break;
            case 2:

            break;
            case 3:
            break;
            case 4:
            break;
        }

        if(change == 0)
        {
            this.transform.position = this.transform.position + new Vector3(0,2 * Time.deltaTime,0);
        }
        else if(change == 1)
        {
            this.transform.position = this.transform.position + new Vector3(2 * Time.deltaTime,0,0);
        }
        else if(change == 2)
        {
            this.transform.position = this.transform.position + new Vector3(0,-2 * Time.deltaTime,0);
        }
        else if(change == 3)
        {
            this.transform.position = this.transform.position + new Vector3(-2 * Time.deltaTime,0,0);
        }
        
        if(change ==4){
            change = 0;
        }

    }
}
