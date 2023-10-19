using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForce : MonoBehaviour
{
    public float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move the bullet 
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime, Space.Self);


    }

    // Destory the bullet when it collides with the Bullet Destroyer
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Force collided with Enemy");
            Destroy(gameObject);

        }
    }
}
