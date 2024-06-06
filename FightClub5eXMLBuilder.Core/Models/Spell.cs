using System;
using System.Xml.Serialization;

[XmlRoot("spell")]
public record Spell
{
    [XmlElement("name")]
    public string Name { get; init; }

    [XmlElement("level")]
    public int Level { get; init; }

    [XmlElement("school")]
    public string School { get; init; }

    [XmlElement("time")]
    public string Time { get; init; }

    [XmlElement("range")]
    public string Range { get; init; }

    [XmlElement("components")]
    public string Components { get; init; }

    [XmlElement("duration")]
    public string Duration { get; init; }

    [XmlElement("roll")]
    public string Roll { get; init; }
    
    [XmlElement("ritual")]
    public string Ritual { get; set; }

    [XmlElement("classes")]
    public string Classes { get; set; }

    [XmlElement("text")]
    public List<string> Texts { get; set; }
}

