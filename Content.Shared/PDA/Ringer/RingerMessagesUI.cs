using Robust.Shared.Serialization;

namespace Content.Shared.PDA.Ringer;

[Serializable, NetSerializable]
public sealed class RingerPlayRingtoneMessage : BoundUserInterfaceMessage;

[Serializable, NetSerializable]
public sealed class RingerSetRingtoneMessage : BoundUserInterfaceMessage
{
    public Note[] Ringtone { get; }

    public RingerSetRingtoneMessage(Note[] ringTone)
    {
        Ringtone = ringTone;
    }
}
// Aurora's Song - Start
[Serializable, NetSerializable]
public sealed class RingerSetVolumeMessage : BoundUserInterfaceMessage
{
    public float RingerVolume { get; }
    public bool Handled = false;

    public RingerSetVolumeMessage(float volume)
    {
        RingerVolume = volume;
    }
}
// Aurora's Song - End
