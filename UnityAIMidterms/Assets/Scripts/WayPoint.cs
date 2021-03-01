using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] waypoints;
    public float speed = 1.0f;
    public float accuracy = 1.0f;
    public float rotationSpeed = 0.04f;
    int currentWP = 0;
    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(waypoints.Length == 0) return;
        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x, this.transform.position.y, waypoints[currentWP].transform.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotationSpeed);

        if(direction.magnitude < accuracy){
            currentWP++;
            if(currentWP >= waypoints.Length){
                currentWP = 0;
            }
        }
        this.transform.Translate(0,0,speed * Time.deltaTime);
        }
    
}
