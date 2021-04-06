using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotate : MonoBehaviour
{
    public float speed;
    public bool lightBool;
    public bool snowBool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lightBool)
        {
            transform.Rotate(0, 1 * speed * Time.deltaTime, 0);
        }
        if (snowBool)
        {
            transform.Rotate(0, 0, 1 * speed * Time.deltaTime);
        }

    }
}
