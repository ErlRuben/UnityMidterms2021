using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockANDHorde : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject horde;
    public GameObject block;
    public GameObject Done2;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            horde.SetActive(true);
            block.SetActive(true);
            Done2.SetActive(true);
        }

    }
}
