
namespace HyperspinXmlGenerator.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class mame
    {

        private mameMachine[] machineField;

        private string buildField;

        private string debugField;

        private byte mameconfigField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("machine")]
        public mameMachine[] machine
        {
            get
            {
                return this.machineField;
            }
            set
            {
                this.machineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string build
        {
            get
            {
                return this.buildField;
            }
            set
            {
                this.buildField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string debug
        {
            get
            {
                return this.debugField;
            }
            set
            {
                this.debugField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte mameconfig
        {
            get
            {
                return this.mameconfigField;
            }
            set
            {
                this.mameconfigField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachine
    {

        private string descriptionField;

        private ushort yearField;

        private string manufacturerField;

        private mameMachineRom[] romField;

        private mameMachineDevice_ref[] device_refField;

        private mameMachineSample[] sampleField;

        private mameMachineChip[] chipField;

        private mameMachineDisplay displayField;

        private mameMachineSound soundField;

        private mameMachineInput inputField;

        private mameMachineDipswitch[] dipswitchField;

        private mameMachinePort[] portField;

        private mameMachineDriver driverField;

        private string nameField;

        private string sourcefileField;

        private string sampleofField;

        private bool sampleofFieldSpecified;

        private string cloneofField;

        private string romofField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ushort year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public string manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rom")]
        public mameMachineRom[] rom
        {
            get
            {
                return this.romField;
            }
            set
            {
                this.romField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("device_ref")]
        public mameMachineDevice_ref[] device_ref
        {
            get
            {
                return this.device_refField;
            }
            set
            {
                this.device_refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sample")]
        public mameMachineSample[] sample
        {
            get
            {
                return this.sampleField;
            }
            set
            {
                this.sampleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("chip")]
        public mameMachineChip[] chip
        {
            get
            {
                return this.chipField;
            }
            set
            {
                this.chipField = value;
            }
        }

        /// <remarks/>
        public mameMachineDisplay display
        {
            get
            {
                return this.displayField;
            }
            set
            {
                this.displayField = value;
            }
        }

        /// <remarks/>
        public mameMachineSound sound
        {
            get
            {
                return this.soundField;
            }
            set
            {
                this.soundField = value;
            }
        }

        /// <remarks/>
        public mameMachineInput input
        {
            get
            {
                return this.inputField;
            }
            set
            {
                this.inputField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dipswitch")]
        public mameMachineDipswitch[] dipswitch
        {
            get
            {
                return this.dipswitchField;
            }
            set
            {
                this.dipswitchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("port")]
        public mameMachinePort[] port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        public mameMachineDriver driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string sourcefile
        {
            get
            {
                return this.sourcefileField;
            }
            set
            {
                this.sourcefileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string sampleof
        {
            get
            {
                return this.sampleofField;
            }
            set
            {
                this.sampleofField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sampleofSpecified
        {
            get
            {
                return this.sampleofFieldSpecified;
            }
            set
            {
                this.sampleofFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string cloneof
        {
            get
            {
                return this.cloneofField;
            }
            set
            {
                this.cloneofField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string romof
        {
            get
            {
                return this.romofField;
            }
            set
            {
                this.romofField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineRom
    {

        private string nameField;

        private ushort sizeField;

        private string crcField;

        private string sha1Field;

        private string regionField;

        private string offsetField;

        private string statusField;

        private string mergeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crc
        {
            get
            {
                return this.crcField;
            }
            set
            {
                this.crcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string sha1
        {
            get
            {
                return this.sha1Field;
            }
            set
            {
                this.sha1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string merge
        {
            get
            {
                return this.mergeField;
            }
            set
            {
                this.mergeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineDevice_ref
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineSample
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineChip
    {

        private string typeField;

        private string tagField;

        private string nameField;

        private uint clockField;

        private bool clockFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public uint clock
        {
            get
            {
                return this.clockField;
            }
            set
            {
                this.clockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clockSpecified
        {
            get
            {
                return this.clockFieldSpecified;
            }
            set
            {
                this.clockFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineDisplay
    {

        private string tagField;

        private string typeField;

        private ushort rotateField;

        private ushort widthField;

        private byte heightField;

        private decimal refreshField;

        private uint pixclockField;

        private ushort htotalField;

        private byte hbendField;

        private ushort hbstartField;

        private ushort vtotalField;

        private byte vbendField;

        private ushort vbstartField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort rotate
        {
            get
            {
                return this.rotateField;
            }
            set
            {
                this.rotateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal refresh
        {
            get
            {
                return this.refreshField;
            }
            set
            {
                this.refreshField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public uint pixclock
        {
            get
            {
                return this.pixclockField;
            }
            set
            {
                this.pixclockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort htotal
        {
            get
            {
                return this.htotalField;
            }
            set
            {
                this.htotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte hbend
        {
            get
            {
                return this.hbendField;
            }
            set
            {
                this.hbendField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort hbstart
        {
            get
            {
                return this.hbstartField;
            }
            set
            {
                this.hbstartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort vtotal
        {
            get
            {
                return this.vtotalField;
            }
            set
            {
                this.vtotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte vbend
        {
            get
            {
                return this.vbendField;
            }
            set
            {
                this.vbendField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort vbstart
        {
            get
            {
                return this.vbstartField;
            }
            set
            {
                this.vbstartField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineSound
    {

        private byte channelsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte channels
        {
            get
            {
                return this.channelsField;
            }
            set
            {
                this.channelsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineInput
    {

        private mameMachineInputControl controlField;

        private byte playersField;

        private byte buttonsField;

        private byte coinsField;

        private string serviceField;

        /// <remarks/>
        public mameMachineInputControl control
        {
            get
            {
                return this.controlField;
            }
            set
            {
                this.controlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte players
        {
            get
            {
                return this.playersField;
            }
            set
            {
                this.playersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte buttons
        {
            get
            {
                return this.buttonsField;
            }
            set
            {
                this.buttonsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte coins
        {
            get
            {
                return this.coinsField;
            }
            set
            {
                this.coinsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineInputControl
    {

        private string typeField;

        private byte waysField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte ways
        {
            get
            {
                return this.waysField;
            }
            set
            {
                this.waysField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineDipswitch
    {

        private mameMachineDipswitchDipvalue[] dipvalueField;

        private string nameField;

        private string tagField;

        private byte maskField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dipvalue")]
        public mameMachineDipswitchDipvalue[] dipvalue
        {
            get
            {
                return this.dipvalueField;
            }
            set
            {
                this.dipvalueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte mask
        {
            get
            {
                return this.maskField;
            }
            set
            {
                this.maskField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineDipswitchDipvalue
    {

        private string nameField;

        private byte valueField;

        private string defaultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string @default
        {
            get
            {
                return this.defaultField;
            }
            set
            {
                this.defaultField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachinePort
    {

        private string tagField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class mameMachineDriver
    {

        private string statusField;

        private string emulationField;

        private string colorField;

        private string soundField;

        private string graphicField;

        private string savestateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string emulation
        {
            get
            {
                return this.emulationField;
            }
            set
            {
                this.emulationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string sound
        {
            get
            {
                return this.soundField;
            }
            set
            {
                this.soundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string graphic
        {
            get
            {
                return this.graphicField;
            }
            set
            {
                this.graphicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string savestate
        {
            get
            {
                return this.savestateField;
            }
            set
            {
                this.savestateField = value;
            }
        }
    }
}
