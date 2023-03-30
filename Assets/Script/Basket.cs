using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public float iceActualTime;
    public float iceTotalTime;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Fruit"))
        {
            ColectFruit(other);



        }

        if (other.CompareTag("Ice"))
        {

            gameObject.SendMessage("Slow");
            ColectFruit(other);
        }








    }

    public void ColectFruit(Collider other)
    {
        FruitInfo fi = other.GetComponent<FruitInfo>();
        GameManager.instance.AddScore(fi.scoreToAdd);
        Destroy(other.gameObject);



    }

    private void Update()

    {
        if (iceActualTime < iceTotalTime)
        {

            iceActualTime += 1 * Time.deltaTime;

            if (iceActualTime >= iceTotalTime)
            {

                gameObject.SendMessage("ResetVelocity");


            }


        }






    }
}    

      



