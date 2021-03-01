using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 50f;
    public GameObject door;
    public GameObject done;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health == 0f){
            door.SetActive(false);
            done.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame

}
