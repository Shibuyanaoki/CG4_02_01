using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprict : MonoBehaviour
{

    public Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = rd.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 moveSpeed = new Vector3(0.1f, 0, 0.1f);
            v.x = moveSpeed.x;
        }
        rd.velocity = v;
    }
}
