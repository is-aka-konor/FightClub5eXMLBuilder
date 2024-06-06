// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using FightClub5eXMLBuilder.Core.Models;

var spell = new Spell
{
    Name = "Winging Shot",
    Level = 1,
    Ritual = "NO",
    Time = "1 bonus action",
    Range = "30 feet",
    Components = "None",
    Duration = "Instantaneous",
    Classes = "Fighter (Gunslinger)",
    Texts = new List<string>
    {
        "When you make a firearm attack against a creature, you can expend one grit point to attempt to topple a moving target.  On a hit, the creature suffers normal damage and must make a Strength saving throw or be knocked prone.",
        "",
        "Source: Matthew Mercer - Gunslinger Martial Archetype 1.2 p. 2"
    }
};

var compendium = new Compendium
{
    Version = "5",
    AutoIndent = "NO",
    Spells = new List<Spell> { spell }
};

var serializer = new XmlSerializer(typeof(Compendium));
using (var writer = new StreamWriter("compendium.xml", false))
{
    serializer.Serialize(writer, compendium);
}

Console.WriteLine("Compendium.xml created.");