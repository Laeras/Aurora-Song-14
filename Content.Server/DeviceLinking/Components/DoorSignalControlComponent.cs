using Content.Shared.DeviceLinking;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.DeviceLinking.Components
{
    [RegisterComponent]
    public sealed partial class DoorSignalControlComponent : Component
    {
        [DataField("openPort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
        public string OpenPort = "Open";

        [DataField("closePort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
        public string ClosePort = "Close";

        [DataField("togglePort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
        public string TogglePort = "Toggle";

        [DataField("boltPort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
        public string InBolt = "DoorBolt";

        [DataField("onOpenPort", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutOpen = "DoorStatus";
        // Aurora's Song - Start
        [DataField("whenOpen", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutOpened = "DoorStatusOpened";

        [DataField("whenClosed", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutClosed = "DoorStatusClosed";

        [DataField("whenOpening", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutOpening = "DoorStatusOpening";

        [DataField("whenClosing", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutClosing = "DoorStatusClosing";

        [DataField("whenBolted", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutBolted = "DoorStatusBolted";
        // These 5 instead are for momentary invocations!
        [DataField("onOpen", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutInvokeOpened = "DoorStatusOnOpened";

        [DataField("onClosed", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutInvokeClosed = "DoorStatusOnClosed";

        [DataField("onOpening", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutInvokeOpening = "DoorStatusOnOpening";

        [DataField("onClosing", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutInvokeClosing = "DoorStatusOnClosing";

        [DataField("onBolted", customTypeSerializer: typeof(PrototypeIdSerializer<SourcePortPrototype>))]
        public string OutInvokeBolted = "DoorStatusOnBolted";
        // Aurora's Song - End
    }
}
