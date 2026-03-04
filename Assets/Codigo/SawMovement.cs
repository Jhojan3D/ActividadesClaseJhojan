using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    [SerializeField] private Transform saw;

    [SerializeField] private List<Transform> targets = new List<Transform>();

    [SerializeField] private float speed;

    [SerializeField] private int currentTarget;
    private float contador = 2;
    bool esperando = false;


    void Start()
    {
        saw.position = targets[currentTarget].position;
    }
    private void Update()
    {
        if (esperando == false)
        {
            if (saw.position == targets[currentTarget].position)
            {
                currentTarget++;

                if (currentTarget >= targets.Count)
                {
                    currentTarget = 0;
                }
            }

            saw.position = Vector2.MoveTowards(saw.position, targets[currentTarget].position, speed * Time.deltaTime);

            if (saw.position == targets[currentTarget].position)
            {
                esperando = true;
            }
        }
        else
        {
            contador -= Time.deltaTime;
            if (contador <= 0)
            {
                esperando = false;
                contador = 2;
            }
        }
           
        

    }

}


