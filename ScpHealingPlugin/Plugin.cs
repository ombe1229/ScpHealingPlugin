using PlayerEvents = Exiled.Events.Handlers.Player;
using Features = Exiled.API.Features;
using Log = Exiled.API.Features.Log;

namespace ScpHealingPlugin
{
    public class ScpHealingPlugin : Features.Plugin<Configs>
    {
        private EventHandlers EventHandlers { get; set; }

        private void LoadEvents()
        {
            PlayerEvents.Died += EventHandlers.OnPlayerDead;
        }

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;
            Log.Info("ScpHealingPlugin enabled.");
            EventHandlers = new EventHandlers(this);
            LoadEvents();
        }

        public override void OnDisabled()
        {
            PlayerEvents.Died -= EventHandlers.OnPlayerDead;
        }
    }
}