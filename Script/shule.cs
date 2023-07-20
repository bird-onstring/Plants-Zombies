using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shule : MonoBehaviour
{
    public GameObject shuletxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Peashooter_1")
        {
            Debug.Log("shule");
            shuletxt.SetActive(true);
        }
    }
}
