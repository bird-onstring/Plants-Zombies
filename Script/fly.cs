using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public GameObject prefab;//���б���
    public GameObject a;//���б���
    public GameObject plant;//���б���
    public Camera camerrr;
    public float SpeedUp;
    private Vector3 ms;
    public GameObject cameraa;
    public GameObject shanchu;
    public GameObject baozha;
    private bool gooo=true;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        ms = Input.mousePosition;
        ms = camerrr.ScreenToWorldPoint(ms);
    }

    // Update is called once per frame
    void Update()
    {


        //Vector3 mss = new Vector3(ms.x,  ms.y, -0.65f);
        //Vector3 msss = new Vector3(ms.x, ms.y, -0.65f);
        //this.transform.position = Vector3.MoveTowards(this.transform.position, 20*mss, Time.deltaTime * SpeedUp);
        if (gooo)
        {
            transform.position += transform.right * SpeedUp * Time.deltaTime;
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            
            //zbblood.blood = zbblood.blood - 10;
            gooo = false;
            Debug.Log(collision.gameObject.name);
            int i= int.Parse(collision.gameObject.name);
            zbblood.a[i] = zbblood.a[i] - damage;


            cameraa.GetComponent<ShakeCamera>().enabled = true;
            baozha.SetActive(true);
            StartCoroutine(Wait());
            
            // ��ײ�����ˣ�ִ����Ӧ����
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);//���е��⣬��ͣt��

        //t��󣬼��������������
        Destroy(shanchu);
    }

}
