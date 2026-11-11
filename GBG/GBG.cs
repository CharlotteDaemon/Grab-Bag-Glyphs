using Quintessential;
using System;
namespace GBG;

internal class GrabBagGlyphs : QuintessentialMod
{
    public override string ModId => "grab_bag_glyphs";
    public static GrabBagGlyphs Instance { get; }

    public override void Load()
    {
    GrabBagGlyphs.Instance.Log.Info("GBG: Grab Bag Glyphs Is Here");
        
    }
    

    public override void LoadContent()
    {
        
        // Atoms.AddAtomTypes(); // Add the atoms
        // Util.GlyphLUT.GenerateLUTs(); // This code is commented out.
        MutationsAPI.AddMutations(); // Adds tables and recipes. See MutationsAPI.cs for more
        Parts.AddParts(); // Add parts
        GrabBagGlyphs.Instance.Log.Info("GBG: Retrieved Glyphs From My Bag Successfuly");
    }
    public override void LoadCompatContent() { }
    public override void FinaliseContent() { }

    public override void PostLoad() { }
    public override void Unload()
    {
        GrabBagGlyphs.Instance.Log.Info("GBG: Putting Glyphs Back In The Bag");
    }
}