using UnityEngine;

namespace Platformer.Mechanics
{
    public class PlayerController : MonoBehaviour
    {
        public bool controlEnabled = true;
        public float currentSpeed = 7;
        public Vector3 velocity;

        private Rigidbody body;
        private new Collider collider;
        private Animator animator;
        private Vector3 targetVelocity;
        private Vector3 move;

        void Awake()
        {
            collider = GetComponent<Collider>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (controlEnabled)
            {
                move.z = Input.GetAxis("Horizontal");
                move.x = Input.GetAxis("Vertical");
            }
            else
            {
                move.x = move.z = 0;
            }

            targetVelocity = Vector3.zero;

            // animator.SetBool("");
            targetVelocity = move * currentSpeed;
        }
        
        public void Bounce(float value)
        {
            velocity.y = value;
        }

        public void Bounce(Vector2 dir)
        {
            velocity.y = dir.y;
            velocity.x = dir.x;
        }

        public void Teleport(Vector3 position)
        {
            body.position = position;
            velocity *= 0;
            body.velocity *= 0;
        }
    }
}
