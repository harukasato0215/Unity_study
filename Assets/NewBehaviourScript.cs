using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        /*
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);
        */
        transform.position = playerPos;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            float x = Input.GetAxis("Horizontal");

            Vector3 vec = new Vector3(x * Time.deltaTime * 3f, 0, 0);
            transform.position = transform.position + vec;

            //transform.position.x += x;
        }
        if (Input.GetButton("Vertical"))
        {
            float y = Input.GetAxis("Vertical");
            Vector3 vec = new Vector3(0, y * Time.deltaTime * 3f, 0);
            transform.position = transform.position + vec;

        }

    }
}