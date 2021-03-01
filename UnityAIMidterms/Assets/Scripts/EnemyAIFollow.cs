using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public Transform goal;
    public float accuracy = 0.01f;
    public float rotationSpeed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;
        // this.transform.LookAt(lookAtGoal);
        this.transform.rotation =
        Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotationSpeed);
        if(Vector3.Distance(transform.position, lookAtGoal)> accuracy){
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
    }
}
