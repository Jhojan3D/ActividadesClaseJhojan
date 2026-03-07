using System.Collections.Generic;
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
            TurnOff();
        }
      else
        {
            TurnOn();
        }

        
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
    private void TurnOn()
    {

        animator.SetBool("isOn", true);
    }

    private void TurnOff()

    {
        animator.SetBool("isOn", false);
    }

}




