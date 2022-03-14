using System.Collections;
using System.Collections.Generic;
using Platformer.Core;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Gameplay
{
    public class EnablePlayerInput : Simulation.Event<EnablePlayerInput>
    {
        private PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            model.player.controlEnabled = true;
        }
    }
}
