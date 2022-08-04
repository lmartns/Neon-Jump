using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{

    private int auxDirection;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (auxDirection != 0)
        {
            transform.Translate(speed * Time.deltaTime * auxDirection, 0, 0);
        }

    }

    public void TouchHorizontal(int direction)
    {

        auxDirection = direction;

    }

}
