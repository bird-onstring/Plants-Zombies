using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class biu2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;//公有变量
    public GameObject a;//公有变量
    public GameObject plant;//公有变量
    public Camera camerrr;
    public float SpeedUp;
    // Start is called before the first frame update

    public GameObject Cube_Prefab;//Cube预制体

    public static int jishuqi = 0;
    public Text text1;
    public GameObject shuaguaidian1;
    public GameObject shuaguaidian2;
    public GameObject shuaguaidian3;
    public GameObject shuaguaidian4;
    public GameObject shuaguaidian5;
    public GameObject shuaguaidian6;

    public bool ui = true, iu = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 ms = Input.mousePosition;
            ms = camerrr.ScreenToWorldPoint(ms);

            Instantiate(prefab, transform).transform.position = new Vector3(plant.transform.position.x, plant.transform.position.y, plant.transform.position.z - 0.3f);//方式一

            //prefab.transform.position = Vector3.MoveTowards(transform.position, ms, Time.deltaTime * SpeedUp);
        }

        if (jishuqi > 20)
        {
            ui = false;
        }


        if (ui && iu)
        {

            Debug.Log("开始");
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        iu = false;
        yield return new WaitForSeconds(0.35f);//运行到这，暂停t秒

        //t秒后，继续运行下面代码
        int a = Random.Range(0, 10);
        Debug.Log(a);

        if (a == 0)
        {
            Debug.Log("生成");
            jishuqi++;
            Instantiate(Cube_Prefab).name = jishuqi.ToString();
            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian1.transform.position.x, shuaguaidian1.transform.position.y, shuaguaidian1.transform.position.z - 0.3f);
            gg.GetComponent<zbblood>().enabled = true;
            iu = true;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {

            jishuqi++;

            Instantiate(Cube_Prefab).name = jishuqi.ToString();

            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian6.transform.position.x, shuaguaidian6.transform.position.y, shuaguaidian6.transform.position.z - 0.3f);
        }
        if (a == 1)
        {

            jishuqi++;

            Instantiate(Cube_Prefab).name = jishuqi.ToString();

            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian2.transform.position.x, shuaguaidian2.transform.position.y, shuaguaidian2.transform.position.z - 0.3f);
            gg.GetComponent<zbblood>().enabled = true;
            iu = true;
        }
        if (a == 2)
        {



            jishuqi++;

            Instantiate(Cube_Prefab).name = jishuqi.ToString();

            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian3.transform.position.x, shuaguaidian3.transform.position.y, shuaguaidian3.transform.position.z - 0.3f);
            gg.GetComponent<zbblood>().enabled = true;
            iu = true;
        }
        if (a == 3)
        {




            jishuqi++;

            Instantiate(Cube_Prefab).name = jishuqi.ToString();

            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian4.transform.position.x, shuaguaidian4.transform.position.y, shuaguaidian4.transform.position.z - 0.3f);
            gg.GetComponent<zbblood>().enabled = true;
            iu = true;
        }
        if (a == 4)
        {




            jishuqi++;

            Instantiate(Cube_Prefab).name = jishuqi.ToString();

            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian5.transform.position.x, shuaguaidian5.transform.position.y, shuaguaidian5.transform.position.z - 0.3f);
            gg.GetComponent<zbblood>().enabled = true;
            iu = true;
        }
        if (a == 5)
        {




            jishuqi++;

            Instantiate(Cube_Prefab).name = jishuqi.ToString();

            var gg = GameObject.Find(jishuqi.ToString());
            gg.transform.position = new Vector3(shuaguaidian6.transform.position.x, shuaguaidian6.transform.position.y, shuaguaidian6.transform.position.z - 0.3f);
            gg.GetComponent<zbblood>().enabled = true;
            iu = true;
        }
        if (a > 5)
        {
            iu = true;
        }

    }


}
