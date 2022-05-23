using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformascript : MonoBehaviour
{
    public float xmovementspeed;
    public float xRightLimit;
    public bool toRight;
    public float xLeftlimit;
    public GameObject prefab1;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(xmovementspeed, 0, 0);
        }

        else
        {
            transform.position -= new Vector3(xmovementspeed, 0, 0);
        }
        if (transform.position.x > xRightLimit) {

            toRight = false;
            Instantiate(prefab1);
        }
        if (transform.position.x < xLeftlimit)
        {
            toRight = true;
            Instantiate(prefab2);
        }
    }
}
