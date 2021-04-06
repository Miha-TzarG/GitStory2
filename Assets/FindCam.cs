using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCam : MonoBehaviour
{ Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

      //  Vector2 point = Camera.ViewportToScreenPoint(new Vector2(1f, 1f));
      //  point.x = 0.2f;
      //  point.y = -0.44f;

       // transform.position = new Vector2(point.x,point.y);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = Camera.ViewportToWorldPoint(new Vector3(.9f, .5f, .5f));
        // Vector2 point = Camera.ViewportToScreenPoint(new Vector2(.5f, .5f));
        transform.position = new Vector3( point.x, point.y / 2, point.z / 2);
    }
}
