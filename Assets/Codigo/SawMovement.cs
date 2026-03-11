using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    [SerializeField] private Transform saw;

    [SerializeField] private List<Transform> targets = new List<Transform>();

    [SerializeField] private float speed;
    
    [SerializeField] private int currentTarget;
    [SerializeField] private Animator animator;

    public bool isActive;
    

    void Start()

    {
        
        saw.position = targets[currentTarget].position;
       
    }
    private void Update()
    {
        if (isActive == true)
        {
            TurnOn();
            

        }
        else
        {
            TurnOff();
            MovimientoCierra();
        }
    }

           
    public void MovimientoCierra()
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


    public void TurnOn()
    {

        animator.SetBool("isOn", false);
    }

    public void TurnOff()

    {
        animator.SetBool("isOn", true);
    }

}




