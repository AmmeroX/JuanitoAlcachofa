using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puntaje;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int ptj)
    {
        puntaje += ptj;
    }

     
}
