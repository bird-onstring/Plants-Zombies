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
            ms = camer.ScreenToWorldPoint(ms);//��ȡ������λ��
                                                    //�����λ��
            Vector3 gunPos = this.transform.position;
            float fireangle;//����Ƕ�
                            //�������λ�������λ��֮��ĽǶ�
            Vector2 targetDir = ms - gunPos;
            fireangle = Vector2.Angle(targetDir, Vector3.up);
            if (ms.x > gunPos.x)
            {
                fireangle = -fireangle;
            }
            this.transform.eulerAngles = new Vector3(fireangle,-90,90);
        


    }
}
