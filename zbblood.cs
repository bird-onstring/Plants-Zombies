using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zbblood : MonoBehaviour
{
    // Start is called before the first frame update
    public int blood;
    public static int[] a= new int[100];
    public Animator animation;
    public GameObject shanfchu;
    public float Speed;
    public GameObject wanjia;

    private bool jiajiajia=true;

    void Start()
    {
        int i = int.Parse(this.name);
        for (i = int.Parse(this.name); i < 100; i++)
        {
            a[i] = 100;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ms = wanjia.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, ms, Time.deltaTime * Speed);
        if(transform.position.x>wanjia.transform.position.x)
        {
            this.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }else
        {
            this.transform.rotation = Quaternion.Euler(90, 180, 0);
        }

        blood = a[int.Parse(this.name)];
        if (a[int.Parse(this.name)] <0)
        {
            if(jiajiajia)
            {
                biu.killn++;
            }
            jiajiajia = false;
            animation.SetInteger("die",1);
            Debug.Log("die");
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.35f);//运行到这，暂停t秒

        //t秒后，继续运行下面代码
        Destroy(shanfchu);
    }
}
