using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Model
{
    [System.Serializable]
    public class PlatformerModel
    {
        public Camera camera;
        public PlayerController player;
        public Transform spawnPoint;
    }
}
