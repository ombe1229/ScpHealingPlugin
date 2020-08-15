using Exiled.API.Interfaces;

namespace ScpHealingPlugin
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public int Scp106 { get; set; } = 75;
        public int Scp173 { get; set; } = 150;
        public int Scp939 { get; set; } = 125;
        public int Scp049 { get; set; } = 25;
        public int Scp0492 { get; set; } = 25;
        public int Scp096 { get; set; } = 0;
    }
}