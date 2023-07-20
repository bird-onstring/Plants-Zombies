using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cmmm;
    public GameObject player;
    private float x, y,rotationSpeed=0.5f;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 mousePosition = cmmm.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log(cmmm.ScreenToWorldPoint(Input.mousePosition));
        //    Debug.Log(cmmm.ScreenToWorldPoint(player.transform.position));
        //    Vector3 baby = new Vector3(cmmm.ScreenToWorldPoint(Input.mousePosition).x, cmmm.ScreenToWorldPoint(Input.mousePosition).y, -0.65f);
        //}

        //player.transform.rotation.x;
        //player.transform.LookAt(baby);



    }
}
