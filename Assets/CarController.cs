using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    float speedY = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
            Debug.Log(this.startPos);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            float swipeLengthY = endPos.y - this.startPos.y;

            this.speed = swipeLength / 500f;
            this.speedY = swipeLengthY / 500f;
        }
        transform.Translate(this.speed, this.speedY, 0);
        this.speed *= 0.98f;
        this.speedY *= 0.98f;

    }
}
