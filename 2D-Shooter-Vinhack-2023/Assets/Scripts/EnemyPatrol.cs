using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPoint;

    public float movespeed, waitAtpoints;
    private float waitCounter;

    public float jumpforce;
    public Rigidbody2D theRB;
    // Start is called before the first frame update
    void Start()
    {
        waitCounter = waitAtpoints;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x - patrolPoints[currentPoint].position.x) > .2f)
        {
            if(transform.position.x < patrolPoints[currentPoint].position.x){
                theRB.velocity = new Vector2(movespeed, theRB.velocity.y);

            }
             else
        {
            theRB.velocity = new Vector2(-movespeed,theRB.velocity.y);
        }
            
        }
       
    }
}
