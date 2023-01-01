using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    //
    public Vector3 Speed { get; set; }

     private void FixedUpdate()
    {
        this.transform.position += this.transform.position + Speed * Time.deltaTime;
       this.Speed += Vector3.down * Time.deltaTime;
    }

    public ParticleSystem ExplosionParticles;
    public float MaxDamage;
    public float ExplosionForce = 500f;
    public float MaxLifeTime = 2f;
    public float ExplosionRadius = 5f;


    private void Start()
    {
        Destroy(gameObject, MaxLifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
      /*  Collider[] colliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
        for (int i = 0; i < colliders.Length; i++)
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();

        if (!targetRigidbody)
            continue;
        targetRigidbody.AddExplosionDamage(ExplosionForce, transform.position, ExplosionRadius);

        float damage = CalculateDamage(targetRigidbody.position);
    }

    private void CalculateDamage(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;
        float explosionDistance = explosionToTarget.magnitude;
        float relativeDistance = (ExplosionRadius - explosionDistance) / ExplosionRadius;*/
    }
      
}
