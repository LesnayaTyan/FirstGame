using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFiring : MonoBehaviour
{
    public GameObject TankFree_Canon;
    public float range = 100f, force = 15f;
    public ParticleSystem shootEffect;
    public AudioSource Firing;
    public ParticleSystem damageEffect;
    [SerializeField] private GameObject cannonballPrefab = default;
    private Transform cannonEndPoint;
    private float waitUntilNextShot = 0f;

    public GameObject bullet;
    public float shootForce, upwardForce;



    private void Awake()
    {
        // cannonEndPoint = this.transform.Find("TankFree_Tower/TankFree_Canon/point");
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            shoot();
       
    }

    void shoot()
    {
        waitUntilNextShot = 1f;
        Firing.Play();
        shootEffect.Play();

        RaycastHit hit;
        if (Physics.Raycast(TankFree_Canon.transform.position, TankFree_Canon.transform.forward, out hit, range));
        Debug.Log("Object: " + hit.transform.gameObject.name);

        if(hit.transform.gameObject.CompareTag("Box"))
        {
            hit.transform.gameObject.GetComponent<TakeDamage>().takeDamage();
            damageEffect.Play();


            
            
            //if(hit.rigidbody != null)
            // {
            // hit.rigidbody.AddForce(-hit.normal * force);

            //}
        }

        CannonBall cannonball = Instantiate(cannonballPrefab, cannonEndPoint.position, Quaternion.identity)
           .GetComponent <CannonBall>();
        cannonball.Speed = TankFree_Canon.transform.rotation * Vector3.forward;

        
    }

}
