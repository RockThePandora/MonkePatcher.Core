using System.Collections.Generic;

namespace MonkePatcher.Core.Modding
{
    public class ModConfig
    {
        public List<IMod> Mods { get; set; } = new();
    }
}
