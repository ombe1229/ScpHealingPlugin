using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace ScpHealingPlugin
{
    public class EventHandlers
    {
        private readonly ScpHealingPlugin _pluginInstance;
        public EventHandlers(ScpHealingPlugin pluginInstance) => this._pluginInstance = pluginInstance;

        internal void OnPlayerDead(DiedEventArgs eventArgs)
        {
            if (eventArgs.Killer.Team != Team.SCP) return;
            Player killer = eventArgs.Killer;
            string killerRole = killer.Role.ToString();
            if (_pluginInstance.Config.HealingAmount.ContainsKey(killerRole))
            {
                killer.Health = killer.Health + _pluginInstance.Config.HealingAmount[killerRole] <= killer.MaxHealth
                    ? _pluginInstance.Config.HealingAmount[killerRole]
                    : killer.MaxHealth;
            }
        }
    }
}