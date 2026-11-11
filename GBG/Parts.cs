using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Quintessential;
using static Quintessential.PartCycleDelegate;

namespace GBG;

internal class Parts
{

    public static Texture BasicIrisLower = Assets.textures.parts.animismus.output_under_iris;
    public static Texture BasicIrisUpper = Assets.textures.parts.animismus.output_above_iris;
    public static Texture BasicQuickInSymb = Assets.textures.parts.projection_glyph.quicksilver_symbol;
    public static Texture BasicMetalUpSymb = Assets.textures.parts.projection_glyph.metal_bowl;
    public static Texture BasicIn1 = Assets.textures.parts.projection_glyph.quicksilver_input;
    public static Texture BasicMetalBowl = Assets.textures.parts.projection_glyph.metal_bowl;
    public static Texture BasicMetalHoleUp = Assets.textures.parts.purification_glyph.lead_symbol;
    
    


    public static PartType Oldjection;
    public static Texture RejectBase = Assets.textures.parts.projection_glyph.@base;
    public static Texture RejectMetalBowlSkin = AssetLoaderHelper.LoadTexture("textures/parts/rejection/input_bowl");
    public static Texture RejectQuickBowlSkin = AssetLoaderHelper.LoadTexture("textures/parts/rejection/output_bowl");
    public static Texture RejectIcon = AssetLoaderHelper.LoadTexture("textures/parts/icons/rejection");
    public static Texture RejectIconHover = AssetLoaderHelper.LoadTexture("textures/parts/icons/rejection_hover");
    public static Texture RejectLeadSymbol = AssetLoaderHelper.LoadTexture("textures/parts/rejection/lead_symbol_down");
    public static Texture RejectQuickSymbol = AssetLoaderHelper.LoadTexture("textures/parts/rejection/quicksilver_symbol");
    public static Texture RejectGloss = AssetLoaderHelper.LoadTexture("textures/parts/rejection/gloss");
    public static Texture RejectGlossMask = AssetLoaderHelper.LoadTexture("textures/parts/rejection/gloss_mask");
    public static Texture RejectOverlay = AssetLoaderHelper.LoadTexture("textures/parts/rejection/output_bowl_overlay");
    public static Texture RejectConectors = Assets.textures.parts.projection_glyph.bond;
    public static HexIndex RejectMetalBowlLoc = new HexIndex(0, 0);
    public static HexIndex RejectQuickBowlLoc = new HexIndex(1, 0);

    public static PartType Oldivision;
    public static Texture DepoBase = AssetLoaderHelper.LoadTexture("textures/parts/deposition/base");
    public static Texture DepoMetalHoleSkin = Assets.textures.parts.projection_glyph.quicksilver_input;
    public static Texture DepoIcon = AssetLoaderHelper.LoadTexture("textures/parts/icons/deposition");
    public static Texture DepoIconHover = AssetLoaderHelper.LoadTexture("textures/parts/icons/deposition_hover");
    public static Texture IrisSymbBigger = AssetLoaderHelper.LoadTexture("textures/parts/deposition/output_symbol_up");
    public static Texture IrisSymbSmaller = AssetLoaderHelper.LoadTexture("textures/parts/deposition/output_symbol_down");
    public static Texture MetalInSymb = AssetLoaderHelper.LoadTexture("textures/parts/deposition/input_symbol");
    public static Texture DepoGloss = AssetLoaderHelper.LoadTexture("textures/parts/deposition/gloss");
    public static Texture DepoGlossMask = AssetLoaderHelper.LoadTexture("textures/parts/deposition/gloss_mask");
    public static Texture DepoConectors = AssetLoaderHelper.LoadTexture("textures/parts/deposition/connectors");
    public static HexIndex InLoc = new HexIndex(0, 0);
    public static HexIndex OutSmallerLoc = new HexIndex(1, 0);
    public static HexIndex OutBiggerLoc = new HexIndex(-1, 0);

    public static PartType LongProjection;
    public static Texture LongBase = AssetLoaderHelper.LoadTexture("textures/parts/deposition/base");
    public static Texture LongQuickInSkin = Assets.textures.parts.projection_glyph.quicksilver_input;
    public static Texture LongIcon = Assets.textures.parts.icons.projection;
    public static Texture LongIconHover = Assets.textures.parts.icons.projection_hover;
    public static Texture LongGloss = AssetLoaderHelper.LoadTexture("textures/parts/deposition/gloss");
    public static Texture LongGlossMask = AssetLoaderHelper.LoadTexture("textures/parts/deposition/gloss_mask");
    public static Texture LongConectors = AssetLoaderHelper.LoadTexture("textures/parts/deposition/connectors");
    public static Texture LongDummySkin = Assets.textures.parts.marker_lighting;
    public static Texture LongDummyDetails = Assets.textures.parts.marker_details;
    public static HexIndex LongInLoc = new HexIndex(-1, 0);
    public static HexIndex LongDummyLoc = new HexIndex(0, 0);
    public static HexIndex LongOutLoc = new HexIndex(1, 0);

    public static PartType SlowRejection;
    public static Texture SlowBase = Assets.textures.parts.projection_glyph.@base;
    public static Texture SlowMetalInSkin = Assets.textures.parts.rejection_glyph.metal_bowl;
    public static Texture SlowIcon = Assets.textures.parts.icons.rejection;
    public static Texture SlowIconHover = Assets.textures.parts.icons.rejection_hover;
    public static Texture SlowGloss = AssetLoaderHelper.LoadTexture("textures/parts/rejection/gloss");
    public static Texture SlowGlossMask = AssetLoaderHelper.LoadTexture("textures/parts/rejection/gloss_mask");
    public static Texture SlowConectors = Assets.textures.parts.projection_glyph.bond;
    public static HexIndex SlowInLoc = new HexIndex(0, 0);
    public static HexIndex SlowOutLoc = new HexIndex(1, 0);
    
    public static PartType Refinement;
    public static Texture RefBase = AssetLoaderHelper.LoadTexture("textures/parts/refinement/base");
    public static Texture RefLeftInSkin = Assets.textures.parts.projection_glyph.quicksilver_input;
    public static Texture RefRightInSkin = Assets.textures.parts.projection_glyph.quicksilver_input;
    public static Texture RefIcon = Assets.textures.parts.icons.animismus;
    public static Texture RefIconHover = Assets.textures.parts.icons.animismus_hover;
    public static Texture RefGloss = Assets.textures.parts.animismus.gloss;
    public static Texture RefGlossMask = AssetLoaderHelper.LoadTexture("textures/parts/refinement/gloss_mask");
    public static Texture RefConectorsShadows = AssetLoaderHelper.LoadTexture("textures/parts/refinement/connectors_shadows");
    public static Texture RefConectors = AssetLoaderHelper.LoadTexture("textures/parts/refinement/connectors");
    public static HexIndex RefLeftInLoc = new HexIndex(0, 0);
    public static HexIndex RefRightInLoc = new HexIndex(1, 0);
    public static HexIndex RefOutUpperLoc = new HexIndex(0, 1);
    public static HexIndex RefOutLowerLoc = new HexIndex(1, -1);
    public static Texture FakeIris = Assets.textures.parts.purification_glyph.lead_symbol;



    public static Texture Blank = Assets.textures.transparent;

    public static void AddParts()

    {
        Oldjection = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.double_glow,
            strokeTexture = Assets.textures.select.double_stroke,
            iconTexture = RejectIcon,
            iconHoverTexture = RejectIconHover,
            glyphHexes = new HexIndex[] { RejectMetalBowlLoc, RejectQuickBowlLoc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("oldjection"))
        };
        GrabBagGlyphs.Instance.AddPartType(Oldjection, "oldjection", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(RejectBase, Vector2.Zero, new Vector2(42f, 48f), 0f);
            renderer.RenderRotating(RejectMetalBowlSkin, RejectMetalBowlLoc, Vector2.Zero);
            renderer.RenderRotating(RejectQuickBowlSkin, RejectQuickBowlLoc, Vector2.Zero);
            renderer.RenderBase(RejectConectors, new Vector2(-32f, 11f));

            renderer.RenderUpright(RejectLeadSymbol, RejectMetalBowlLoc, Vector2.Zero);
            renderer.RenderUpright(RejectOverlay, RejectQuickBowlLoc, Vector2.Zero);
            renderer.RenderUpright(RejectQuickSymbol, RejectQuickBowlLoc, Vector2.Zero);
            renderer.RenderGloss(RejectGloss, RejectGlossMask, new Vector2(42f, 48f));
        });
        SlowRejection = new()
        {
            cost = 10,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.double_glow,
            strokeTexture = Assets.textures.select.double_stroke,
            iconTexture = SlowIcon,
            iconHoverTexture = SlowIconHover,
            glyphHexes = new HexIndex[] { SlowInLoc, SlowOutLoc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("slowrejection"))
        };
        GrabBagGlyphs.Instance.AddPartType(SlowRejection, "slowrejection", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(SlowBase, Vector2.Zero, new Vector2(42f, 48f), 0f);
            renderer.RenderRotating(SlowMetalInSkin, SlowInLoc, Vector2.Zero);

            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);

            renderer.RenderUpright(RejectOverlay, SlowOutLoc, Vector2.Zero);
            renderer.RenderIris(intermState, SlowOutLoc, time, pss.isProcessing ? pss.processingAtoms[0] : null);
            renderer.RenderBase(RejectConectors, new Vector2(-32f, 11f));

            renderer.RenderUpright(RejectLeadSymbol, SlowInLoc, Vector2.Zero);
            renderer.RenderUpright(RejectQuickSymbol, SlowOutLoc, Vector2.Zero);
            renderer.RenderGloss(RejectGloss, RejectGlossMask, new Vector2(42f, 48f));
        });
        Oldivision = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.division_glow,
            strokeTexture = Assets.textures.select.division_stroke,
            iconTexture = DepoIcon,
            iconHoverTexture = DepoIconHover,
            glyphHexes = new HexIndex[] { OutSmallerLoc, InLoc, OutBiggerLoc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("oldivision"))
        };
        GrabBagGlyphs.Instance.AddPartType(Oldivision, "oldivision", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(DepoBase, Vector2.Zero, new Vector2(123f, 48f), 0f);
            renderer.RenderRotating(DepoMetalHoleSkin, InLoc, Vector2.Zero);

            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);

            renderer.RenderIris(intermState, OutBiggerLoc, time, pss.isProcessing? pss.processingAtoms[0] : null);
            renderer.RenderIris(intermState, OutSmallerLoc, time, pss.isProcessing? pss.processingAtoms[1] : null);
            renderer.RenderBase(DepoConectors, DepoConectors.GetHalfSizeRounded(), 0f);

            if (!(pss.isProcessing && time >= 1 / 32))
            {
                renderer.RenderUpright(IrisSymbSmaller, OutSmallerLoc, Vector2.Zero);
                renderer.RenderUpright(IrisSymbBigger, OutBiggerLoc, Vector2.Zero);

            }

            renderer.RenderUpright(MetalInSymb, InLoc, Vector2.Zero);
            renderer.RenderGloss(DepoGloss, DepoGlossMask, new Vector2(123f, 48f));
        });
        LongProjection = new()
        {
            cost = 35,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.division_glow,
            strokeTexture = Assets.textures.select.division_stroke,
            iconTexture = LongIcon,
            iconHoverTexture = LongIconHover,
            glyphHexes = new HexIndex[] { LongInLoc, LongDummyLoc, LongOutLoc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("lojection"))
        };
        GrabBagGlyphs.Instance.AddPartType(LongProjection, "lojection", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(DepoBase, Vector2.Zero, new Vector2(123f, 48f), 0f);
            
            renderer.RenderRotating(BasicIn1, LongInLoc, Vector2.Zero);
            renderer.RenderRotating(LongDummySkin, LongDummyLoc, Vector2.Zero);
            renderer.RenderRotating(BasicMetalBowl, LongOutLoc, Vector2.Zero);
            
            renderer.RenderBase(DepoConectors, DepoConectors.GetHalfSizeRounded(), 0f);

            renderer.RenderUpright(LongDummyDetails, LongDummyLoc, Vector2.Zero);
            renderer.RenderUpright(BasicQuickInSymb, LongInLoc, Vector2.Zero);
            renderer.RenderUpright(BasicMetalUpSymb, LongOutLoc, Vector2.Zero);

            renderer.RenderGloss(LongGloss, LongGlossMask, new Vector2(123f, 48f));
        });
        Refinement = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.diamond_glow,
            strokeTexture = Assets.textures.select.diamond_stroke,
            iconTexture = RefIcon,
            iconHoverTexture = RefIconHover,
            glyphHexes = new HexIndex[] { RefLeftInLoc, RefRightInLoc, RefOutUpperLoc, RefOutLowerLoc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("refinement"))
        };
        GrabBagGlyphs.Instance.AddPartType(Refinement, "refinement", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(RefBase, RefBase.GetHalfSizeRounded(), 0f);
            renderer.RenderBase(RefConectorsShadows, RefConectorsShadows.GetHalfSizeRounded(), 0f);
            renderer.RenderBase(RefConectors, RefConectors.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(RefLeftInSkin, RefLeftInLoc, Vector2.Zero);
            renderer.RenderRotating(RefRightInSkin, RefRightInLoc, Vector2.Zero);

            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            
            
            renderer.RenderIris(intermState, RefOutUpperLoc, time, BasicIrisLower, Assets.textures.parts.iris_full_division_high, BasicIrisUpper, pss.isProcessing ? pss.processingAtoms[0] : null);
            renderer.RenderIris(intermState, RefOutLowerLoc, time, BasicIrisLower, Assets.textures.parts.iris_full_division_low, BasicIrisUpper, (pss.isProcessing && pss.processingAtoms.Length == 2) ? pss.processingAtoms[1] : null);
             
            

            
            renderer.RenderGloss(RefGloss, RefGlossMask, RefGlossMask.GetHalfSizeRounded());
            
            renderer.RenderUpright(BasicMetalHoleUp, RefLeftInLoc, Vector2.Zero);
            renderer.RenderUpright(BasicMetalHoleUp, RefRightInLoc, Vector2.Zero);
        });

        QApi.AddPartTypeToPanel(Oldjection, false);
        QApi.AddPartTypeToPanel(Oldivision, false);
        QApi.AddPartTypeToPanel(LongProjection, false);
        QApi.AddPartTypeToPanel(SlowRejection, false);
        QApi.AddPartTypeToPanel(Refinement, false);

        GrabBagGlyphs.Instance.AddPuzzlePermission("oldjection");
        GrabBagGlyphs.Instance.AddPuzzlePermission("oldivision");
        GrabBagGlyphs.Instance.AddPuzzlePermission("lojection");
        GrabBagGlyphs.Instance.AddPuzzlePermission("slowrejection");
        GrabBagGlyphs.Instance.AddPuzzlePermission("refinement");
        
        QApi.BindGlyphCycle(Oldjection, new(PartCycleExecutionType.Normal, OldjectionCycle));
        QApi.BindGlyphCycle(Oldivision, new(PartCycleExecutionType.Normal, OldivisionCycle));
        QApi.BindGlyphCycle(LongProjection, new(PartCycleExecutionType.Normal, LongCycle));
        QApi.BindGlyphCycle(SlowRejection, new(PartCycleExecutionType.Normal, SlowCycle));
        QApi.BindGlyphCycle(Refinement, new(PartCycleExecutionType.Normal, RefCycle));
        
        var RejectionRecipe = GlyphRecipe.Recipes["om:rejection"]["om:rejection"].Predicate;
        var DivisionRecipe = GlyphRecipe.Recipes["om:division"]["om:division"].Predicate;
        var PurificationRecipe = GlyphRecipe.Recipes["om:purification"]["om:purification"].Predicate;
        
        GrabBagGlyphs.Instance.AddRecipe(new(RejectionRecipe), Oldjection.Id, Oldjection.Id);
        GrabBagGlyphs.Instance.AddRecipe(new(RejectionRecipe), SlowRejection.Id, SlowRejection.Id);
        GrabBagGlyphs.Instance.AddRecipe(new(DivisionRecipe), Oldivision.Id, Oldivision.Id);
        GrabBagGlyphs.Instance.AddRecipe(new(PurificationRecipe), Refinement.Id, Refinement.Id);
        GrabBagGlyphs.Instance.AddRecipe(new(MutationsAPI.BasicLongProjection), LongProjection.Id, LongProjection.Id);
    }
    public static bool OldjectionCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe CurrRecipe, bool first)
    {
        
        if (!(CurrRecipe.Predicate.InvokeAndClear(sim, part)))
        {
            return false;
        }

        AtomReference MetalSubject = (AtomReference)sim.RecipeInputs[new(0, 0)];
        AtomType MetalAfter = (AtomType)sim.RecipeOutputs[new(0, 0)];
        AtomType QuickOut = (AtomType)sim.RecipeOutputs[new(1, 0)];

        MetalSubject.molecule.ReplaceAtom(MetalAfter, MetalSubject.pos);
        Atom spawned = sim.SpawnAtomRelative(QuickOut, part, new(1, 0));
        spawned.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, spawned.atomType, Assets.textures.atoms.rejection_effect_metal, 30f);
        MetalSubject.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, MetalSubject.atomType, Assets.textures.atoms.rejection_effect_quicksilver, 30f);
        SolutionEditorBase SEB = sim.solutionEditor;
        SEB.glyphEffects.Add(new GlyphEffect(SEB, EffectTimescaleType.RealTime, HexGrid.standardGrid.ToPixelCoords(part.GlobalPosFromLocal(RejectQuickBowlLoc), new Vector2(80f, 0f)), Assets.textures.parts.disposal_flash, 30f, Vector2.Zero, 0));

        Volume.PlaySound(Assets.sounds.glyph_projection, SEB.GetVolumeMultiplier());

        return true;
    }
    public static bool SlowCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe CurrRecipe, bool first)
    {
        if (!(pss.isProcessing))
        {
            if (!first || !(CurrRecipe.Predicate.InvokeAndClear(sim, part)))
            {
                return false;
            }

            AtomReference MetalSubject = (AtomReference)sim.RecipeInputs[new(0, 0)];
            AtomType MetalAfter = (AtomType)sim.RecipeOutputs[new(0, 0)];
            AtomType QuickOut = (AtomType)sim.RecipeOutputs[new(1, 0)];

            MetalSubject.molecule.ReplaceAtom(MetalAfter, MetalSubject.pos);
            MetalSubject.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, MetalSubject.atomType, Assets.textures.atoms.rejection_effect_quicksilver, 30f);

            pss.isProcessing = true;
            pss.processingAtoms = new AtomType[] { QuickOut };
            sim.SpawnColliderRelative(part, SlowOutLoc);

            SolutionEditorBase SEB = sim.solutionEditor;

            Volume.PlaySound(Assets.sounds.glyph_projection, SEB.GetVolumeMultiplier());

            return true;
        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, SlowOutLoc);

            return true;
        }

        return false;
    }
    public static bool OldivisionCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe CurrRecipe, bool first)
    {
        if (!(pss.isProcessing))
        {
            if (!(first && CurrRecipe.Predicate.InvokeAndClear(sim, part)))
            {
                return false;
            }

            AtomType MetalBigger = (AtomType)sim.RecipeOutputs[new(-1, 0)];
            AtomReference MetalSubject = (AtomReference)sim.RecipeInputs[new(0, 0)];
            AtomType MetalSmaller = (AtomType)sim.RecipeOutputs[new(1, 0)];

            MetalSubject.molecule.RemoveAtom(MetalSubject.pos);
            sim.solutionEditor.DrawFallingAtom(MetalSubject);

            pss.isProcessing = true;
            pss.processingAtoms = new AtomType[] { MetalBigger, MetalSmaller };

            sim.SpawnColliderRelative(part, OutBiggerLoc); // Colliders for rising atoms
            sim.SpawnColliderRelative(part, OutSmallerLoc);

            SolutionEditorBase SEB = sim.solutionEditor;
            Volume.PlaySound(Assets.sounds.glyph_purification, SEB.GetVolumeMultiplier());


            return true;
        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, OutBiggerLoc);
            sim.SpawnAtomRelative(pss.processingAtoms[1], part, OutSmallerLoc);

            return true;
        }




        return false;
    }
    public static bool LongCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe CurrRecipe, bool first)
    {
        
        if (!(CurrRecipe.Predicate.InvokeAndClear(sim, part)))
        {
            return false;
        }

        AtomReference MetalBefore = (AtomReference)sim.RecipeInputs[new(1, 0)];
        AtomReference QuickIn = (AtomReference)sim.RecipeInputs[new(-1, 0)];
        AtomType MetalAfter = (AtomType)sim.RecipeOutputs[new(-1, 0)];

        MetalBefore.molecule.ReplaceAtom(MetalAfter, MetalBefore.pos);

        QuickIn.molecule.RemoveAtom(QuickIn.pos);
        sim.solutionEditor.DrawFallingAtom(QuickIn);

        MetalBefore.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, MetalBefore.atomType, Assets.textures.atoms.rejection_effect_quicksilver, 30f);
        SolutionEditorBase SEB = sim.solutionEditor;

        Volume.PlaySound(Assets.sounds.glyph_projection, SEB.GetVolumeMultiplier());

        return true;
    }

    public static bool RefCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe CurrRecipe, bool first)
    {
        if (!(pss.isProcessing))
        {
            if (!(first && CurrRecipe.Predicate.InvokeAndClear(sim, part)))
            {
                return false;
            }

            AtomReference MetalIn1 = (AtomReference)sim.RecipeInputs[new(0, 0)];
            AtomReference MetalIn2 = (AtomReference)sim.RecipeInputs[new(1, 0)];
            AtomType MetalOut1 = (AtomType)sim.RecipeOutputs[new(0, 1)];

            MutationsAPI.AttributesFromMetal(MetalIn1.atomType, out _, out int size);
            if (size > 1)
            {
                
                MutationsAPI.MetalFromAttributes(false, size - 1, out AtomType MetalOut2);
                pss.isProcessing = true;
                pss.processingAtoms = new AtomType[] { MetalOut1, MetalOut2 };
                sim.SpawnColliderRelative(part, RefOutLowerLoc);
            }
            else
            {
                pss.isProcessing = true;
                pss.processingAtoms = new AtomType[] { MetalOut1 };

            }
            MetalIn1.molecule.RemoveAtom(MetalIn1.pos);
            MetalIn2.molecule.RemoveAtom(MetalIn2.pos);
            sim.solutionEditor.DrawFallingAtom(MetalIn1);
            sim.solutionEditor.DrawFallingAtom(MetalIn2);
            sim.SpawnColliderRelative(part, RefOutUpperLoc); // Colliders for rising atoms

            SolutionEditorBase SEB = sim.solutionEditor;

            Volume.PlaySound(Assets.sounds.glyph_purification, SEB.GetVolumeMultiplier());
            Volume.PlaySound(Assets.sounds.glyph_animismus, SEB.GetVolumeMultiplier());
            return true;
        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, RefOutUpperLoc);
            if (pss.processingAtoms.Length == 2)
            {
                sim.SpawnAtomRelative(pss.processingAtoms[1], part, RefOutLowerLoc);

            }

            return true;
        }
        return false;
    }

    /*
        Coronation = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.double_glow,
            strokeTexture = Assets.textures.select.double_stroke,
            iconTexture = CoroIcon,
            iconHoverTexture = CoroIconHover,
            glyphHexes = new HexIndex[] { CoroBowl, CoroHole },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("coronation"))
        };
        GrabBagGlyphs.Instance.AddPartType(Coronation, "coronation", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(CoroBase, Vector2.Zero, new Vector2(42f, 48f), 0f);
            renderer.RenderRotating(CoroBowlSkin, CoroBowl, Vector2.Zero);
            renderer.RenderRotating(CoroHoleSkin, CoroHole, Vector2.Zero);
            renderer.RenderUpright(GenericMetalBowl, CoroBowl, Vector2.Zero);
            renderer.RenderUpright(GenericQuixIn, CoroHole, Vector2.Zero);
        });
        Royalty = new()
        {
            cost = 40,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.double_glow,
            strokeTexture = Assets.textures.select.double_stroke,
            iconTexture = RoyalIcon,
            iconHoverTexture = RoyalIconHover,
            glyphHexes = new HexIndex[] { RoyalBowlI, RoyalBowlO },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("royalty"))
        };
        GrabBagGlyphs.Instance.AddPartType(Royalty, "royalty", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(RoyalBase, Vector2.Zero, new Vector2(42f, 48f), 0f);
            renderer.RenderRotating(RoyalBowlISkin, RoyalBowlI, Vector2.Zero);
            renderer.RenderUpright(RoyalBowlIOverlaySkin, RoyalBowlI, Vector2.Zero);
            renderer.RenderUpright(RoyalBowlISymbol, RoyalBowlI, Vector2.Zero);
            renderer.RenderRotating(RoyalHoleOSkin, RoyalBowlO, Vector2.Zero);
            renderer.RenderUpright(RoyalBowlOSymbol, RoyalBowlO, Vector2.Zero);
        });
        Divergence = new()
        {
            cost = 30,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.triple_glow,
            strokeTexture = Assets.textures.select.triple_stroke,
            iconTexture = DiverIcon,
            iconHoverTexture = DiverIconHover,
            glyphHexes = new HexIndex[] { DiverInLoc, DiverOut1Loc, DiverOut2Loc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("divergence"))
        };
        GrabBagGlyphs.Instance.AddPartType(Divergence, "divergence", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(DiverBase, Vector2.Zero, DiverBase.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(DiverInHole, DiverInLoc, Vector2.Zero);
            renderer.RenderUpright(GenericMetalIn, DiverInLoc, Vector2.Zero);
            renderer.RenderUpright(DiverOut1, DiverOut1Loc, Vector2.Zero);
            renderer.RenderUpright(DiverOut2, DiverOut2Loc, Vector2.Zero);
            renderer.RenderBase(DiverConnectors, Vector2.Zero, DiverConnectors.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(DiverOut2Ring, DiverOut2Loc, Vector2.Zero);
            renderer.RenderRotating(DiverOut1Ring, DiverOut1Loc, Vector2.Zero);
        });
        Insurrection = new()
        {
            cost = 50,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.diamond_glow,
            strokeTexture = Assets.textures.select.diamond_stroke,
            iconTexture = InsurIcon,
            iconHoverTexture = InsurIconHover,
            glyphHexes = new HexIndex[] { InsurIn1Loc, InsurIn2Loc, InsurOut1Loc, InsurOut2Loc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("insurrection"))
        };
        GrabBagGlyphs.Instance.AddPartType(Insurrection, "insurrection", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(InsurBase, Vector2.Zero, InsurBase.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(InsurInput, InsurIn1Loc, Vector2.Zero);
            renderer.RenderRotating(InsurInput, InsurIn2Loc, Vector2.Zero);
            renderer.RenderUpright(InsurOutLowerer, InsurOut1Loc, Vector2.Zero);
            renderer.RenderUpright(InsurOutLowerer, InsurOut2Loc, Vector2.Zero);
            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            renderer.RenderBase(InsurConnectors, Vector2.Zero, InsurConnectors.GetHalfSizeRounded(), 0f);
            renderer.RenderBase(InsurConnectors, Vector2.Zero, InsurConnectorsShadow.GetHalfSizeRounded(), 0f);
            renderer.RenderIris(intermState, InsurOut1Loc, time, InsurOutLower, Assets.textures.parts.iris_full_division_low, InsurOutUpper, pss.wasActivated ? pss.processingAtoms[0] : null);
            renderer.RenderIris(intermState, InsurOut2Loc, time, InsurOutLower, Assets.textures.parts.iris_full_division_high, InsurOutUpper, pss.wasActivated ? pss.processingAtoms[1] : null);
            renderer.RenderUpright(GenericMetalIn, InsurIn1Loc, Vector2.Zero);
            renderer.RenderUpright(GenericMetalIn, InsurIn2Loc, Vector2.Zero);
            // renderer.RenderUpright(DiverOut1Ring, InsurOut1Loc, Vector2.Zero);
            // renderer.RenderUpright(DiverOut1Ring, InsurOut2Loc, Vector2.Zero);
        });
        Promotion = new()
        {
            cost = 50,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.proliferation_glow,
            strokeTexture = Assets.textures.select.proliferation_stroke,
            iconTexture = ProIcon,
            iconHoverTexture = ProIconHover,
            glyphHexes = new HexIndex[] { ProBloodInLoc, ProMetalBowlLoc, ProBloodExcessLoc},
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(GrabBagGlyphs.Instance.GetIdentifier("promotion"))
        };
        GrabBagGlyphs.Instance.AddPartType(Promotion, "promotion", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(ProBase, Vector2.Zero, ProBase.GetHalfSizeRounded(), 0f);
            renderer.RenderBase(ProBase2, Vector2.Zero, ProBase2.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(ProInputRing, ProBloodInLoc, Vector2.Zero);
            renderer.RenderRotating(ProBowl, ProMetalBowlLoc, Vector2.Zero);
            renderer.RenderUpright(ProMetals, ProMetalBowlLoc, Vector2.Zero);
            renderer.RenderUpright(GenericQuixIn, ProBloodInLoc, Vector2.Zero);
            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            renderer.RenderIris(intermState, ProBloodExcessLoc, time, Blank, Assets.textures.parts.iris_full, ProInputRing, pss.isProcessing ? pss.processingAtoms[0] : null);
        });

    }

    public static bool CoronationCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if ((!sim.FindAtomRelative(part, CoroBowl).GetOrDefault(out AtomReference CoroA)) || // Check to see if atoms are present
            (!sim.FindAtomRelative(part, CoroHole).GetOrDefault(out AtomReference CoroB)))
        {
            return false;
        }
        if (CoroB.isHeldByArm || CoroB.inMultiAtomMolecule) // make sure the hole input atom isn't held or in a molecule
        {
            return false;
        }
        foreach (var recipe in MutationsAPI.coronationTransmutations) // choose transmutation based off recipe
        {
            if (recipe.input == CoroA.atomType && recipe.host == CoroB.atomType) // if transmutation is proper, execute it
            {
                CoroB.molecule.RemoveAtom(CoroB.pos);
                CoroA.molecule.ReplaceAtom(recipe.output, CoroA.pos);
                CoroA.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, CoroA.atomType, Assets.textures.atoms.projection_effect, 30f);

                return true;
            }
        }
        return false;
    }
    public static bool RoyalCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if (!sim.FindAtomRelative(part, RoyalBowlI).GetOrDefault(out AtomReference RoyalA)) // check for input
        {
            return false;
        }
        if (sim.FindAtomRelative(part, RoyalBowlO).GetOrDefault(out AtomReference RoyalB)) // check for something blocking the output
        {
            return false;
        }
        MutationsAPI.AttributesFromMetal(RoyalA.atomType, out bool isQuix, out int _);
        foreach (var recipe in MutationsAPI.royaltyTransmutations) // choose transmutation based off recipe
        {
            if (recipe.input == RoyalA.atomType) // if transmutation is proper, execute it
            {
                RoyalA.molecule.ReplaceAtom(recipe.output1, RoyalA.pos);
                Atom spawned = sim.SpawnAtomRelative(recipe.output2, part, RoyalBowlO);



                spawned.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, spawned.atomType, Assets.textures.atoms.rejection_effect_metal, 30f);
                RoyalA.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, RoyalA.atomType, Assets.textures.atoms.rejection_effect_quicksilver, 30f);
                return true;
            }
        }
        return false;
    }
    public static bool DiverCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if ((!sim.FindAtomRelative(part, DiverInLoc).GetOrDefault(out AtomReference Subject))) // CHECK FOR INPUT oops caps
        {
            return false;
        }
        if (((Subject.isHeldByArm || // Make sure input isn't grabbed or in a molecule and that there aren't any atoms in the way of the output
              Subject.inMultiAtomMolecule)) ||
            (sim.FindAtomRelative(part, DiverOut1Loc).GetOrDefault(out AtomReference _) ||
             sim.FindAtomRelative(part, DiverOut2Loc).GetOrDefault(out AtomReference _)))
        {
            return false;
        }
        foreach (var recipe in MutationsAPI.divergenceTransmutations) // choose transmutation based off recipe
        {
            if (recipe.input == Subject.atomType) // if transmutation is proper, execute it
            {
                Subject.molecule.RemoveAtom(Subject.pos);
                sim.solutionEditor.DrawFallingAtom(Subject);
                sim.SpawnAtomRelative(recipe.output1, part, DiverOut1Loc);
                sim.SpawnAtomRelative(recipe.output2, part, DiverOut2Loc);

                return true;
            }
        }
        return false;
    }
    public static bool InsurCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if (!pss.isProcessing)
        {
            if (first)
            {
                if ((!sim.FindAtomRelative(part, InsurIn1Loc).GetOrDefault(out AtomReference Subject1)) || // Make sure input atoms exist
                (!sim.FindAtomRelative(part, InsurIn2Loc).GetOrDefault(out AtomReference Subject2)))
                {
                    return false;
                }
                if (!(MutationsAPI.AttributesFromMetal(Subject1.atomType, out bool isQuix1, out int metalSize1)) || // grab atoms 1 & 2 data
                    !(MutationsAPI.AttributesFromMetal(Subject2.atomType, out bool isQuix2, out int metalSize2)))
                {
                    return false;
                }
                if ((Subject1.isHeldByArm || Subject1.inMultiAtomMolecule) || // Check if atom 1 is a singlet 
                    (Subject2.isHeldByArm || Subject2.inMultiAtomMolecule) || // Check if atom 2 is a singlet
                    (isQuix1 == isQuix2 || metalSize1 == metalSize2))         // Check to make sure atoms aren't the same size or type
                {
                    return false;
                }
                if (sim.FindAtomRelative(part, InsurOut1Loc).GetOrDefault(out AtomReference _) || // make sure outputs are clear
                    sim.FindAtomRelative(part, InsurOut2Loc).GetOrDefault(out AtomReference _))
                {
                    return false;
                }

                bool temp = isQuix1; // swap quicknesses
                isQuix1 = isQuix2;
                isQuix2 = temp;
                AtomType Output1;
                AtomType Output2;
                if (isQuix1)
                {
                    MutationsAPI.MetalFromAttributes(isQuix1, metalSize1, out Output1); // get output atoms from our modified attributes
                    MutationsAPI.MetalFromAttributes(isQuix2, metalSize2, out Output2);
                }
                else
                {
                    MutationsAPI.MetalFromAttributes(isQuix1, metalSize1, out Output2); // get output atoms from our modified attributes 
                    MutationsAPI.MetalFromAttributes(isQuix2, metalSize2, out Output1); // but flipped because quix on bottom
                }

                Subject1.molecule.RemoveAtom(Subject1.pos); // Kill inputs
                Subject2.molecule.RemoveAtom(Subject2.pos);

                sim.solutionEditor.DrawFallingAtom(Subject1); // draw falling atoms
                sim.solutionEditor.DrawFallingAtom(Subject2);

                pss.processingAtoms = new AtomType[] { Output1, Output2 }; // send out outputs pt1
                pss.isProcessing = true;

                sim.SpawnColliderRelative(part, InsurOut1Loc); // Colliders for rising atoms
                sim.SpawnColliderRelative(part, InsurOut2Loc);


                return true;
            }

        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, InsurOut1Loc); // send out outputs pt2
            sim.SpawnAtomRelative(pss.processingAtoms[1], part, InsurOut2Loc);
            return true;
        }
        return false;
    }
    public static bool ProCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if (!pss.isProcessing)
        {
            if (first)
            {
                if ((!sim.FindAtomRelative(part, ProBloodInLoc).GetOrDefault(out AtomReference BloodIn)) || // Make sure input atoms exist
                (!sim.FindAtomRelative(part, ProMetalBowlLoc).GetOrDefault(out AtomReference MetalIn)))
                {
                    return false;
                }
                if (BloodIn.isHeldByArm || BloodIn.inMultiAtomMolecule) // Check to make sure blood input isn't held or in a molecule
                {
                    return false;
                }
                if (sim.FindAtomRelative(part, ProBloodExcessLoc).GetOrDefault(out AtomReference IDC)) // Make sure output isn't covered
                {
                    return false;
                }
                if (!(MutationsAPI.AttributesFromMetal(BloodIn.atomType, out bool isQuix1, out int metalSize1)) || // grab atoms 1 & 2 data
                    !(MutationsAPI.AttributesFromMetal(MetalIn.atomType, out bool isQuix2, out int metalSize2)))
                {
                    return false;
                }
                if (!isQuix1 || isQuix2 || // make sure atoms are the proper metal type and that the blood is big enough to do anything
                    metalSize1 < metalSize2) 
                {
                    return false;

                }
                while (metalSize1 >= metalSize2)
                {
                    metalSize1 -= metalSize2;
                    metalSize2 <<= 1;
                }

                AtomType Output1;
                AtomType Output2;

                if (metalSize2 > 32)
                {
                    metalSize1 = 32;
                    metalSize2 = 32;
                    Logger.Log("Hey, you tried to project gold you idiot. Stop doing that. Here, take your Quickgold back");
                }
                if (metalSize1 != 0)
                {
                    MutationsAPI.MetalFromAttributes(isQuix1, metalSize1, out Output1);
                    sim.SpawnColliderRelative(part, ProBloodExcessLoc); // Colliders for rising atoms
                    pss.processingAtoms = new AtomType[] { Output1 }; // send out outputs pt1
                    pss.isProcessing = true;

                }
                MutationsAPI.MetalFromAttributes(isQuix2, metalSize2, out Output2);

                BloodIn.molecule.RemoveAtom(BloodIn.pos); // Kill inputs
                sim.solutionEditor.DrawFallingAtom(BloodIn); // draw falling atoms
                MetalIn.molecule.ReplaceAtom(Output2, MetalIn.pos);

                MetalIn.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, MetalIn.atomType, Assets.textures.atoms.projection_effect, 30f);


                return true;
            }

        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, ProBloodExcessLoc); // send out outputs pt2
            return true;
        }
        return false;
    */
}
