using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class PlatformController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                gameObject.transform.Rotate(Input.GetAxis("Mouse Y"), 0f, Input.GetAxis("Mouse X"));
            }
        }
    }
}
