using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    [SerializeField] private Transform saw;

    [SerializeField] private List<Transform> targets = new List<Transform>();

    [SerializeField] private float speed;

    private int currentTarget;

    private void Start()
    {
        saw.position = targets[0].position;
        currentTarget = 0;
    }

    private void Update()

    {
        if (saw.position == targets[currentTarget].position)
        {
            currentTarget++;
        }  

        if (currentTarget >= targets.Count)
        {
            currentTarget = 0;
        }
        saw.position = Vector2.MoveTowards(saw.position, targets[currentTarget].position, speed * Time.deltaTime);


    }
}


