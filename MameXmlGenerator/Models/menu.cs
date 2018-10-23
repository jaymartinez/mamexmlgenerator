namespace HyperspinXmlGenerator.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class menu
    {

        private menuHeader headerField;

        private menuGame[] gameField;

        /// <remarks/>
        public menuHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("game")]
        public menuGame[] game
        {
            get
            {
                return this.gameField;
            }
            set
            {
                this.gameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class menuHeader
    {

        private string listnameField;

        private string lastlistupdateField;

        private string listversionField;

        private string exporterversionField;

        /// <remarks/>
        public string listname
        {
            get
            {
                return this.listnameField;
            }
            set
            {
                this.listnameField = value;
            }
        }

        /// <remarks/>
        public string lastlistupdate
        {
            get
            {
                return this.lastlistupdateField;
            }
            set
            {
                this.lastlistupdateField = value;
            }
        }

        /// <remarks/>
        public string listversion
        {
            get
            {
                return this.listversionField;
            }
            set
            {
                this.listversionField = value;
            }
        }

        /// <remarks/>
        public string exporterversion
        {
            get
            {
                return this.exporterversionField;
            }
            set
            {
                this.exporterversionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class menuGame
    {

        private string descriptionField;

        private object cloneofField;

        private object crcField;

        private string manufacturerField;

        private ushort yearField;

        private string genreField;

        private string ratingField;

        private string enabledField;

        private string nameField;

        private string indexField;

        private string imageField;

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
        public object cloneof
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
        public object crc
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
        public string genre
        {
            get
            {
                return this.genreField;
            }
            set
            {
                this.genreField = value;
            }
        }

        /// <remarks/>
        public string rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        public string enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
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
        public string index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }
    }
}