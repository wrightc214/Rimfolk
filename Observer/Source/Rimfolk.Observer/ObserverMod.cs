using Verse;

namespace Rimfolk.Observer
{
    public sealed class ObserverMod : Mod
    {
        public ObserverMod(ModContentPack content) : base(content)
        {
            Log.Message("[Rimfolk Observer] Startup smoke test: mod initialized.");
        }
    }
}
