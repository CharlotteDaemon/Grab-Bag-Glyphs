using Quintessential;
using System;
using System.Collections.Generic;
using System.Text;
using static Quintessential.Internal.LegacyPuzzleModel;

namespace GBG;


internal static class MutationsAPI
{
    public static bool BasicLongProjection(Sim sim, Part part)
    {
        if (!sim.GetAtomReference(part, new HexIndex(1, 0), false, out var projected) ||
            !AtomTag.AtomTags["om:$successor_proj"].HasAtom(projected, out var result) ||
            !sim.GetAtomReference(part, new HexIndex(-1, 0), false, out var consumed) ||
            consumed.isHeldByArm || consumed.inMultiAtomMolecule || consumed.atomType != AtomTypes.quicksilver) return false;

        sim.RecipeInputs.Add(new HexIndex(1, 0), projected);
        sim.RecipeInputs.Add(new HexIndex(-1, 0), consumed);
        sim.RecipeOutputs.Add(new HexIndex(-1, 0), AtomTypes.GetByID(result.Value));
        return true;
    }


    //public struct CoronationRecipe
    //{
    //    public CoronationRecipe(AtomType input, AtomType host, AtomType output)
    //    {
    //        this.input = input;
    //        this.host = host;
    //        this.output = output;
    //    }

    //    public bool IsMatch(AtomType input, AtomType host)
    //    {
    //        return this.input == input && this.host == host;
    //    }

    //    public AtomType input;
    //    public AtomType host;
    //    public AtomType output;
    //}

    public struct MetalData
    {
        public AtomType MetalAtom;
        public bool IsQuix;
        public int MetalSize;
        public MetalData(AtomType metalAtom, bool isQuix, int metalSize)
        {
            MetalAtom = metalAtom;
            IsQuix = isQuix;
            MetalSize = metalSize;
        }
    }
    public static List<MetalData> metalChart = new();

    public static void AddMutations()
    {
        var QSilver = AtomTypes.quicksilver;
        var Gold = AtomTypes.gold;
        var Silver = AtomTypes.silver;
        var Copper = AtomTypes.copper;
        var Iron = AtomTypes.iron;
        var Tin = AtomTypes.tin;
        var Lead = AtomTypes.lead;

        /*** Metallicity Chart ***/
        /* Atoms.<AtomName>, true if this is meant to be a quicksilver-like, metallicity */
        metalChart.Add(new MetalData(Gold, false, 6));
        metalChart.Add(new MetalData(Silver, false, 5));
        metalChart.Add(new MetalData(Copper, false, 4));
        metalChart.Add(new MetalData(Iron, false, 3));
        metalChart.Add(new MetalData(Tin, false, 2));
        metalChart.Add(new MetalData(Lead, false, 1));
        metalChart.Add(new MetalData(QSilver, true, 1));
    }
    public static bool MetalFromAttributes(bool isQuix, int metalSize, out AtomType metalAtom)
    {
        metalAtom = default;

        foreach (var entry in metalChart)
        {
            if (entry.IsQuix == isQuix && entry.MetalSize == metalSize)
            {
                metalAtom = entry.MetalAtom;
                return true;
            }

        }
        return false;
    }

    public static bool AttributesFromMetal(AtomType metalAtom, out bool isQuix, out int metalSize)
    {
        isQuix = false;
        metalSize = 0;

        foreach (var entry in metalChart)
        {
            if (entry.MetalAtom == metalAtom)
            {
                metalSize = entry.MetalSize;
                isQuix = entry.IsQuix;
                return true;
            }

        }
        return false;
    }
    //public static List<CoronationRecipe> coronationTransmutations = new();
    //public static List<RoyaltyRecipe> royaltyTransmutations = new();
    //public static List<DivergenceRecipe> divergenceTransmutations = new();

    //public static void AddTransmutations()
    //{


    //    /*** Coronation ***/
    //    /* Hole Atom, Bowl Atom, Result */
    //    coronationTransmutations.Add(new(QCopper, QCopper, QSilver));
    //    coronationTransmutations.Add(new(QIron, QIron, QCopper));
    //    coronationTransmutations.Add(new(QTin, QTin, QIron));
    //    coronationTransmutations.Add(new(QLead, QLead, QTin));
    //    /*** Royalty ***/
    //    /* Bowl Atom, Bowl Atom Result, Other Bowl New Atom Result */
    //    royaltyTransmutations.Add(new(Gold, Silver, QSilver));
    //    royaltyTransmutations.Add(new(Silver, Copper, QCopper));
    //    royaltyTransmutations.Add(new(Copper, Iron, QIron));
    //    royaltyTransmutations.Add(new(Iron, Tin, QTin));
    //    royaltyTransmutations.Add(new(Tin, Lead, QLead));

    //    /* Bowl Atom, Bowl Atom Result, Other Bowl New Atom Result */
    //    royaltyTransmutations.Add(new(QGold, QSilver, QSilver));
    //    royaltyTransmutations.Add(new(QSilver, QCopper, QCopper));
    //    royaltyTransmutations.Add(new(QCopper, QIron, QIron));
    //    royaltyTransmutations.Add(new(QIron, QTin, QTin));
    //    royaltyTransmutations.Add(new(QTin, QLead, QLead));
    //    /*** Divergence ***/
    //    /* Hole Atom, Left Atom Out, Right Atom Out (Usually same at Left Atom) */
    //    divergenceTransmutations.Add(new(Gold, Silver, Silver));
    //    divergenceTransmutations.Add(new(Silver, Copper, Copper));
    //    divergenceTransmutations.Add(new(Copper, Iron, Iron));
    //    divergenceTransmutations.Add(new(Iron, Tin, Tin));
    //    divergenceTransmutations.Add(new(Tin, Lead, Lead));
    //    
    //    /*** End ***/

    //}

}

