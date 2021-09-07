using System.Collections.Generic;
using Mutagen.Bethesda;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
namespace WeaponKeywords.Types
{
    public struct WeaponDB
    {
        //Mod / main keyword
        [SettingName("Mot clé")]
        public List<string> keyword;
        
        //Common names of item (partial match)
        [SettingName("Nom commun")]
        public List<string> commonNames;
        
        //Exclude specific phrases
        [SettingName("Exclure")]
        public List<string> exclude;
        
        //Exlcude specific sources
        [SettingName("Source de l'exclusion")]
        public List<ModKey> excludeSource;
        
        //descriptor when patched
        [SettingName("Description finale")]
        public string outputDescription;
        
        //unused
        [SettingName("Animation")]
        public string animation;
    }
    public struct ExcludesDB
    {
        [SettingName("Nom d'arme")]
        public List<string> phrases;
        
        [SettingName("EDID d'arme")]
        public List<string> weapons;
    }
    public class Database
    {
        [SettingName("Base de donnée")]
        public Dictionary<string, WeaponDB> DB = new();
        
        [SettingName("Inclure")]
        public Dictionary<string, string> includes = new();
        
        [SettingName("Exclusions")]
        public ExcludesDB excludes = new();
        
        [SettingName("Sources")]
        public List<ModKey> sources = new();
    }
}
