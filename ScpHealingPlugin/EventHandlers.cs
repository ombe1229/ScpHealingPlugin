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
                float health = killer.Health;
                killer.Health = health + _pluginInstance.Config.HealingAmount[killerRole] <= killer.MaxHealth
                    ? _pluginInstance.Config.HealingAmount[killerRole]
                    : killer.MaxHealth;
                
                killer.Broadcast(10, FormatHealingMessage(_pluginInstance.Config.HealingAmount[killerRole], health, killer.MaxHealth));
            }
        }

        private string FormatHealingMessage(float amount, float nowHp, float maxHp)
        {
            return _pluginInstance.Config.HealingMessage.Replace("{N}", amount.ToString()).Replace("{NOW}", nowHp.ToString()).Replace("{MAX}", maxHp.ToString());
        }
    }
}