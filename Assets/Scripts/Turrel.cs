using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrel : MonoBehaviour
{
    
    public Transform Tower;
    public Transform Cannon;
    public float TowerSpeed = 10f;
    public float CannonSpeed = 10f;
    float TowerAngle;
    float CannonAngle;

    /* 
    public GameObject TankFree_Canon;
    public float range = 100f, force = 15f;
    public ParticleSystem shootEffect;
    public AudioSource Firing;
    [SerializeField] private GameObject cannonBallPrefab = default;
    private Transform cannonEndPoint;
    */
    private void Awake()
    {
       // cannonEndPoint = this.transform.Find("TankFree_Tower/TankFree_Canon/point");
    }
    //

    private void Update()
    {
        RotateTower();
        RotateCannon();
        //
       // if (Input.GetButtonDown("Fire1"))
        //    shoot();
    }

    void RotateTower()
    {
        TowerAngle += Input.GetAxis("Mouse X") * TowerSpeed - Time.deltaTime;
        TowerAngle = Mathf.Clamp(TowerAngle, -70, 70);
        Tower.localRotation = Quaternion.AngleAxis(TowerAngle, Vector3.up); //rotate only Y
        

    }

    void RotateCannon()
    {
        CannonAngle += Input.GetAxis("Mouse Y") * CannonSpeed - Time.deltaTime;
        CannonAngle = Mathf.Clamp(TowerAngle, -10f, 10);
        Cannon.localRotation = Quaternion.AngleAxis(CannonAngle, Vector3.right); //rotate only Y
    }
    /*
    void shoot()
    {
        Firing.Play();
        shootEffect.Play();
        RaycastHit hit;
        if (Physics.Raycast(TankFree_Canon.transform.position, TankFree_Canon.transform.forward, out hit, range)) ;
        Debug.Log("Object: " + hit.transform.gameObject.name);

        if (hit.transform.gameObject.CompareTag("Box"))
        {
            hit.transform.gameObject.GetComponent<TakeDamage>().takeDamage();

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);

            }
        }

        //CannonBall cannonBall = Instantiate(cannonBallPrefab, cannonEndPoint.position, Quaternion.identity)
       // .GetComponent<CannonBall>();
       // cannonBall.Speed = Tower.transform.rotation * Vector3.forward * 2;
    }
    */
}








