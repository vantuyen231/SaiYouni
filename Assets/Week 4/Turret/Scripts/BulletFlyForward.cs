using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlyForward : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
