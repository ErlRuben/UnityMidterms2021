using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Lose;
    public GameObject Main;
    public GameObject Menus;
    void Start()
    {
        
        // if (Input.GetKey("space")){
        //     Restart();
        // } 
    }
    void Update() {
        
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            Lose.SetActive(true);
            Main.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
        }

    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Menus.SetActive(true);
        // Lose.SetActive(false);
    }
}
