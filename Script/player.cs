using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject obj;
    public float x,y;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // ��ȡˮƽ���룬�����󣬻��� -1.0 f ; �����ң����� 1.0 f
        float horizontal = Input.GetAxis("Horizontal");
        // ��ȡ��ֱ���룬�����£����� -1.0 f ; �����ϣ����� 1.0 f
        float vertical = Input.GetAxis("Vertical");

        // ��ȡ����ǰλ��
        Vector3 position = this.transform.position;
        // ����λ��
        position.x = position.x + x * horizontal;
        position.y = position.y + x * vertical;
        position.z = y;
        // ��λ�ø���Ϸ����
        this.transform.position = position;



    }
}
