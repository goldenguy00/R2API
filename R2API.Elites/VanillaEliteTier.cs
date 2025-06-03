namespace R2API;

/// <summary>
/// The vanilla elite tiers.
/// Can be casted to an int to index into the EliteAPI.VanillaEliteTiers array.
/// </summary>
public enum VanillaEliteTier
{
    /// <summary>
    /// No Tier. Reserved for spawning non-elites.
    /// </summary>
    None,

    /// <summary>
    /// Tier 1.
    /// Spawns on stages 1 and 2.
    /// </summary>
    Tier1,

    /// <summary>
    /// Tier 1 Honor.
    /// Spawns on stages 1 and 2 with the Honor artifact enabled.
    /// </summary>
    Tier1Honor,

    /// <summary>
    /// Guilded Tier 1 Honor.
    /// Spawns on stage 3 and above with the Honor artifact enabled.
    /// </summary>
    GildedTier1Honor,

    /// <summary>
    /// Guilded Tier 1.
    /// Spawns on stage 3 and above.
    /// </summary>
    GildedTier1,

    /// <summary>
    /// Tier 2.
    /// Spawns after the first loop.
    /// </summary>
    Tier2,

    /// <summary>
    /// Lunar tier. Spawns on the moon only.
    /// </summary>
    Lunar
}
