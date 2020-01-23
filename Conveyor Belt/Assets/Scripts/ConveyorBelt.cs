using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public AudioSource objectCollision;
    public GameObject belt;
    public Transform endpoint;
    public float speed;


    void Start()
    {
        objectCollision = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        objectCollision.Play();
    }
    

    void OnTriggerStay2D(Collider2D other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
    }
}
