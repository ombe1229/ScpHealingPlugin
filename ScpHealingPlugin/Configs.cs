using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ScpHealingPlugin
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("SCP가 인간을 처치할 시 회복할 체력량")]
        public Dictionary<string, int> HealingAmount { get; set; } = new Dictionary<string, int>
        {
            {"Scp106", 75}, {"Scp173", 150}, {"Scp93953", 125}, {"Scp93989", 125}, {"Scp049", 25}, {"Scp0492", 25}, {"Scp096", 20}
        };
    }
}