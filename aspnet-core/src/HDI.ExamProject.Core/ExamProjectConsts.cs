using HDI.ExamProject.Debugging;

namespace HDI.ExamProject
{
    public class ExamProjectConsts
    {
        public const string LocalizationSourceName = "ExamProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7be124626393471ab95ee49998e52884";
    }
}
