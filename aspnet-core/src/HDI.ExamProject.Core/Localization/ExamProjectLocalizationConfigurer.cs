using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HDI.ExamProject.Localization
{
    public static class ExamProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ExamProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ExamProjectLocalizationConfigurer).GetAssembly(),
                        "HDI.ExamProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
