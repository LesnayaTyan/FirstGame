using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YelTankMove : MonoBehaviour
{
    
    public float speed = 5f;
    public float speedAttitude = 2f;
    public float rotateSpeed = 50f;
    private Rigidbody rb;

    private void Start()
    {
        Cursor.visible = false;
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
       

        // this.transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        float horMove = Input.GetAxis("Horizontal");
        float vertMove = Input.GetAxis("Vertical");

        if (horMove > 0)
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        else if (horMove < 0)
            transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);

        Vector3 direction = new Vector3(0, 0, vertMove);

        rb.MovePosition(transform.position + transform.TransformDirection(direction * speed * Time.deltaTime));
    }
}
