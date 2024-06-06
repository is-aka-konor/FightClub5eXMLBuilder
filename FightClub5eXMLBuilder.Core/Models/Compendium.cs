using System.Xml.Serialization;

namespace FightClub5eXMLBuilder.Core.Models;

[System.Xml.Serialization.XmlRootAttribute("compendium", Namespace="", IsNullable=false)]
public class Compendium
{
    [XmlAttribute("version")]
    public string Version { get; set; } = string.Empty;

    [XmlAttribute("auto_indent")]
    public string AutoIndent { get; set; } = string.Empty;

    [XmlElement("spell")]
    public List<Spell>? Spells { get; set; }
}