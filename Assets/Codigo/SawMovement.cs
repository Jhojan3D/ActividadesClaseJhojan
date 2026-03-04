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
    private int direction = 1;  


    void Start()
    {
        saw.position = targets[currentTarget].position;
    }
    private void Update()
    {
      
            if (saw.position == targets[currentTarget].position)
            {
                currentTarget += direction;
                

            if (currentTarget >= targets.Count -1)
                {
                    direction = -1;
                }
                if (currentTarget <= 0)
                {
                    direction = 1;
            }
        }

            saw.position = Vector2.MoveTowards(saw.position, targets[currentTarget].position, speed * Time.deltaTime);

        
        }
   
           
        

    }




