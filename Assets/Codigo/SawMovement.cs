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
      
        
        if (saw.position == targets[currentTarget].position)
        {
            currentTarget++;

            if (currentTarget >= targets.Count)
            {
                currentTarget = 0;
            }

        }

        saw.position = Vector2.MoveTowards(saw.position, targets[currentTarget].position, speed * Time.deltaTime);
          
        

    }

}




