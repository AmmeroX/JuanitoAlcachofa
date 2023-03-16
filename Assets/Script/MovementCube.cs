using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{
    public float speedBasket = 20;
    public float min = -6, max = 6;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speedBasket);
        
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speedBasket);

        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, min, max);
        transform.position = pos;



    }
}
