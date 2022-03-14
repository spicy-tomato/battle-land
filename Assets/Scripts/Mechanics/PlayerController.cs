using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class PlayerController : MonoBehaviour
    {
        public new Collider collider;
        public bool controlEnabled = true;
        public Vector3 velocity;
        private Rigidbody body;

        void Awake()
        {
            collider = GetComponent<Collider>();
        }

        public void Teleport(Vector3 position)
        {
            body.position = position;
            velocity *= 0;
            body.velocity *= 0;
        }
    }
}
