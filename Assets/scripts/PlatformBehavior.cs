using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformBehavior : MonoBehaviour
{

    public float speed;
    public bool toRight;

    public GameObject baseIzq, baseDer;
    public GameObject prefab1, prefab2;

    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        
        }


        if (transform.position.x > baseDer.transform.position.x - 1)
        {
            toRight = false;
            Instantiate(prefab1);
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDer.transform.position+ new Vector3 (0,1,0);
        }

        if (transform.position.x < baseIzq.transform.position.x + 1)
        {
            toRight = true;
            Instantiate(prefab2);
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseDer.transform.position + new Vector3(0, 1, 0);
        }

    }
}
