using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Model.Weapon
{
    public class Weapon : MonoBehaviour
    {
        public AnimationClip idle;
        public List<AnimationClip> shoot;
        public AnimationClip reload;
        public AnimationClip run;
        public AnimationClip knockDown;
        public AnimationClip die;
    }
}
