using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectOnBelt : MonoBehaviour
{
    public float speed;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position += transform.forward * speed * Time.deltaTime;
    }
}
