using System.Collections;
using System.Collections.Generic;
using Platformer.Model.Weapon;
using UnityEngine;

namespace Platformer.Gameplay
{
    public class WeaponConfig : ScriptableObject
    {
        public Dictionary<string, Weapon> weaponsList;
    }
}
