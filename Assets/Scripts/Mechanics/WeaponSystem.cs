using Platformer.Gameplay;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class WeaponSystem : MonoBehaviour
    {
        private WeaponConfig currentWeaponConfig = null;
        private Animator animator;
        private AnimatorOverrideController animatorOverrideController;
        private CharacterController character;
        
        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();
            character = GetComponent<CharacterController>();
        }

        private void SetAttackAnimation()
        {
            
        }
    }
}
