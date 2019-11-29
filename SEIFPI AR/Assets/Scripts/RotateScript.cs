using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    // variable to control object rotate
    public bool canRotate;

    // Start is called before the first frame update
    void Start()
    {
        canRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canRotate)
        {
            transform.Rotate(0.0f, 30f * Time.deltaTime, 0.0f);
        }
    }
}
