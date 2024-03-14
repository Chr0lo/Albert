using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceAbMove : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float minSpeed = 1f;
    public float maxSpeed = 3f;

    private int currentPointIndex;
    private Transform currentPatrolPoint;
    private float currentSpeed;
    private bool isMovingForward = true;

    void Start()
    {
        // Set random speed
        currentSpeed = Random.Range(minSpeed, maxSpeed);

        // Choose random starting point
        currentPointIndex = Random.Range(0, patrolPoints.Length);
        currentPatrolPoint = patrolPoints[currentPointIndex];
    }

    void Update()
    {
        // Move towards the current patrol point
        transform.position = Vector2.MoveTowards(transform.position, currentPatrolPoint.position, currentSpeed * Time.deltaTime);

        // Check if reached patrol point
        if (Vector2.Distance(transform.position, currentPatrolPoint.position) < 0.1f)
        {
            // Choose next patrol point randomly
            ChooseNextPatrolPoint();
        }
    }

    void ChooseNextPatrolPoint()
    {
        // Choose next patrol point randomly
        int randomIndex = currentPointIndex;
        while (randomIndex == currentPointIndex)
        {
            randomIndex = Random.Range(0, patrolPoints.Length);
        }

        currentPointIndex = randomIndex;
        currentPatrolPoint = patrolPoints[currentPointIndex];

        // Reverse direction randomly
        if (Random.value < 0.5f)
        {
            isMovingForward = !isMovingForward;
        }

        // Set random speed
        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }
}
