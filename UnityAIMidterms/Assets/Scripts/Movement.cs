using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update]
    Animator animator;
    public AudioSource walk;

    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Update() {
        Walk();
    }
    // Update is called once per frame
    void Walk()
    {
        float movez = Input.GetAxis("Vertical");

        if(Input.GetKeyDown("w")){
            animator.SetBool("Is Walking", true);
            walk.Play();
        }
        else if(Input.GetKeyUp("w")){
            animator.SetBool("Is Walking", false);
            walk.Play();
        }
        else if(Input.GetKeyDown("s")){
            animator.SetBool("Is Back", true);
            walk.Play();
        }
        else if(Input.GetKeyUp("s")){
            animator.SetBool("Is Back", false);
            walk.Play();
        }
        else if(Input.GetKeyDown("a")){
            animator.SetBool("Is Left", true);
            walk.Play();
        }
        else if(Input.GetKeyUp("a")){
            animator.SetBool("Is Left", false);
            walk.Play();
        }
        else if(Input.GetKeyDown("d")){
            animator.SetBool("Is Right", true);
            walk.Play();
        }
        else if(Input.GetKeyUp("d")){
            animator.SetBool("Is Right", false);
            walk.Play();
        }
    }
}
