using Robust.Shared.Configuration;

namespace Content.Server._AS;

[CVarDefs]
public sealed class AuroraCVars
{
    /// <summary>
    /// How long it takes a deathrattle implant to switch from triage mode to emergency broadcast mode
    /// </summary>
    public static readonly CVarDef<int> DeathTimerEmergencyMessage =
        CVarDef.Create(
            "death_timer_emergency_message.time",
            (10),
            CVar.SERVERONLY,
            "How long a deathrattle implant takes to start broadcasting on emergency channels, in minutes"
        );
    /// <summary>
    /// How often station staff wages are paid.
    /// </summary>
    public static readonly CVarDef<int> StationPayDelay =
        CVarDef.Create(
            "station_pay.delay",
            3600,
            CVar.SERVERONLY,
            "how often station staff wages are paid"
        );

    /// <summary>
    /// How long until suit sensors for dead players are automatically toggled on, following their death.
    /// </summary>
    public static readonly CVarDef<int> SuitSensorDeathActivationDelay =
        CVarDef.Create(
            "suit_sensors.death_activation_delay",
            600,
            CVar.SERVERONLY,
            "how long before dead player's suit sensors are toggled, in seconds"
        );

    public static readonly CVarDef<int> TickLimiterPowerSystem =
        CVarDef.Create(
            "tick_limiter.power_system",
            1,
            CVar.SERVERONLY,
            "power system will be updated once every N ticks"
        );

    public static readonly CVarDef<int> TickLimiterNpcSystem =
        CVarDef.Create(
            "tick_limiter.npc_system",
            1,
            CVar.SERVERONLY,
            "npc system will be updated once every N ticks"
        );

    public static readonly CVarDef<int> TickLimiterAtmosSystem =
        CVarDef.Create(
            "tick_limiter.atmos_system",
            1,
            CVar.SERVERONLY,
            "atmospherics system will be updated once every N ticks"
        );

    public static readonly CVarDef<int> TickLimiterPathfindingSystem =
        CVarDef.Create(
            "tick_limiter.pathfinding_system",
            1,
            CVar.SERVERONLY,
            "pathfinding system will be updated once every N ticks"
        );
}
