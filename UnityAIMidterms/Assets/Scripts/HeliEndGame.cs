using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HeliEndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Done3;
    public GameObject WinPanel;
    public GameObject MainDisable;

    // Update is called once per frame
    void Start() {
        Cursor.visible = true;
    }
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            Done3.SetActive(true);
            WinPanel.SetActive(true);
            MainDisable.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
        }

    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Menus.SetActive(true);
        // Lose.SetActive(false);
    }
}
