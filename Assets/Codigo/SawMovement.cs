using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    [SerializeField] private Transform saw;

    [SerializeField] private List<Transform> targets = new List<Transform>();

    [SerializeField] private float speed;
    private float originalSpeed;

    [SerializeField] private int currentTarget;
    private int energia = 5;
    private float tiempoDeRecarga = 3f;
    bool recargando = false;

    void Start()

    {
        saw.position = targets[currentTarget].position;
        originalSpeed = speed;
    }
    private void Update()
    {
        if (recargando == false)
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
            if(saw.position == targets[currentTarget].position)
            {
                energia--;
                Debug.Log("Energia: " + energia);

                if(energia <=0)
                {
                    recargando = true;
                }
                if (energia <= 1)
                {
                    speed = 0.5f;
                }
            }

        }
        else
        {
            tiempoDeRecarga -= Time.deltaTime;
            if (tiempoDeRecarga <= 0)
            {
                recargando = false;
                tiempoDeRecarga = 3f;
                energia = 5;
                speed = originalSpeed;
            }
        }

    }

}




