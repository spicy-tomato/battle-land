using Platformer.Core;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    public class PlayerSpawn : Simulation.Event
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var player = model.player;
            player.controlEnabled = false;
            player.Teleport(model.spawnPoint.transform.position);
            model.camera.transform.position = new Vector3(
                model.spawnPoint.transform.position.x,
                model.spawnPoint.transform.position.y,
                -65
            );
            Simulation.Schedule<EnablePlayerInput>(2f);
        }
    }
}
