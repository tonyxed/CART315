using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Transform target;
    public float Force;

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                shoot();
            }
        }
        void shoot()
        {
            Vector3 Shoot = (target.position - this.transform.position).normalized;
            GetComponent<Rigidbody>().AddForce(Shoot * Force, ForceMode.Impulse);
        }
}
