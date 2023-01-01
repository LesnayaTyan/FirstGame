using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{

    private float health = 100f;
    public ParticleSystem damageEffect;

    private void Update()
    {
        
    }

    public void takeDamage()
    {
        health -= 100f;
        //damageEffect.Play();


        if (health <= 0)
            Destroy(gameObject);
        
    }

}
