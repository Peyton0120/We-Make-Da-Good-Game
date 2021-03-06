﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master_Run : StateMachineBehaviour
{

    Transform player;
    Rigidbody2D rb;
    public float speed = 2.5f;
    Master master;
    public float attackRnage = 1f;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        master = animator.GetComponent<Master>();
    }

     //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Chases the player
        master.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);

        //Checks if player is far enough away to fire a cross
        if (Vector2.Distance(player.position, rb.position) >= attackRnage) 
        {
            animator.SetTrigger("Attack");
        }
    }

     //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    
}
