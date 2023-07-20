using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lllokkk : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Vector3 ms = Input.mousePosition;
            ms = camer.ScreenToWorldPoint(ms);//获取鼠标相对位置
                                                    //对象的位置
            Vector3 gunPos = this.transform.position;
            float fireangle;//发射角度
                            //计算鼠标位置与对象位置之间的角度
            Vector2 targetDir = ms - gunPos;
            fireangle = Vector2.Angle(targetDir, Vector3.up);
            if (ms.x > gunPos.x)
            {
                fireangle = -fireangle;
            }
            this.transform.eulerAngles = new Vector3(fireangle,-90,90);
        


    }
}
