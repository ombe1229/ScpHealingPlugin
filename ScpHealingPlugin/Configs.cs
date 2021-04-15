using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ScpHealingPlugin
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("SCP가 인간을 처치할 시 회복할 체력량")]
        public Dictionary<string, float> HealingAmount { get; private set; } = new Dictionary<string, float>
        {
            {"Scp106", 75}, {"Scp173", 150}, {"Scp93953", 125}, {"Scp93989", 125}, {"Scp049", 25}, {"Scp0492", 25}, {"Scp096", 20}
        };

        [Description("체력 회복 후 상단에 띄울 메세지")]
        public string HealingMessage { get; private set; } = "인간을 처치하여 <color=red>HP</color>가 <color=red>{N}</color>만큼 회복되었습니다.\n현재 <color=red>HP</color>: {NOW}/{MAX}";
    }
}