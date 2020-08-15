using Exiled.Events.EventArgs;

namespace ScpHealingPlugin
{
    public class EventHandlers
    {
        private readonly Plugin _pluginInstance;
        public EventHandlers(Plugin pluginInstance) => this._pluginInstance = pluginInstance;


        internal void OnRoundStart()
        {
            Plugin.IsStarted = true;
        }
        
        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            Plugin.IsStarted = false;
        }
        
        internal void OnRoundRestart()
        {
            Plugin.IsStarted = false;
        }
        
        internal void OnKilled(DiedEventArgs ev)
        {
            if (ev.Killer.Team != Team.SCP) return;
            int heal = 0;
            switch (ev.Killer.Role)
            {
                case RoleType.Scp173 :
                    heal = _pluginInstance.Config.Scp173;
                    break;
                case RoleType.Scp096 :
                    heal = _pluginInstance.Config.Scp096;
                    break;
                case RoleType.Scp049 :
                    heal = _pluginInstance.Config.Scp049;
                    break;
                case RoleType.Scp0492 :
                    heal = _pluginInstance.Config.Scp0492;
                    break;
                case RoleType.Scp106 :
                    heal = _pluginInstance.Config.Scp106;
                    break;
                case RoleType.Scp93953 :
                    heal = _pluginInstance.Config.Scp939;
                    break;
                case RoleType.Scp93989 :
                    heal = _pluginInstance.Config.Scp939;
                    break;
            }
            if (ev.Killer.MaxHealth <= ev.Killer.Health + heal) ev.Killer.Health = ev.Killer.MaxHealth;
            else ev.Killer.Health += heal;
            ev.Killer.Broadcast(10,$"인간을 사살하여 체력을 회복했습니다.\n현재 체력:<color=red>{ev.Killer.Health}</color>");
        }
    }
}