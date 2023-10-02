using EIT4Talent.Debugging;

namespace EIT4Talent
{
    public class EIT4TalentConsts
    {
        public const string LocalizationSourceName = "EIT4Talent";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6f07ca48e1904af1a84ff4a9b89f7c26";
    }
}
