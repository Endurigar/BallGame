using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SphereController : MonoBehaviour
    {
        [SerializeField] private int maxSpeed;
        [SerializeField] private Rigidbody rigidbody;

        void FixedUpdate()
        {
            rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, maxSpeed);
        }
    }
}
