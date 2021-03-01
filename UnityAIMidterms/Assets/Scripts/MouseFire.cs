using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFire : MonoBehaviour
{
    // Start is called before the first frame update]
    public float damage = 10f;
    public float range = 100f;
    public CameraControl fpsCam;
    public ParticleSystem muzzle;
    public GameObject impact;
    public float impactforce = 10f;
    public float firerate = 15f;
    private float nextTimeToFire = 0f;
    public AudioSource fire;
    void Start()
    {    
        
    }

    // Update is called once per frame
    void Update()
    {    
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire){
            nextTimeToFire = Time.time + 1f / firerate;
            Shoot();
        }
    }
    void Shoot(){
        muzzle.Play();
        fire.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null){
                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null){
                hit.rigidbody.AddForce(-hit.normal * impactforce);
            }
            GameObject impactParticle = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactParticle, 2f);
        }
    }
    
}
