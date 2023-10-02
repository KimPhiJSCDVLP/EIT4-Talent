using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EIT4Talent.Localization
{
    public static class EIT4TalentLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EIT4TalentConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EIT4TalentLocalizationConfigurer).GetAssembly(),
                        "EIT4Talent.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
