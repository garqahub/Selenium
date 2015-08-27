namespace SauceLabs.SeleniumExamples
{
    /// <summary>contains constants used by the tests such as the user name and password for the sauce labs</summary>
    internal static class Constants
    {
        /// <summary>name of the sauce labs account that will be used</summary>
        internal const string SAUCE_LABS_ACCOUNT_NAME = "Schultz";
        /// <summary>account key for the sauce labs account that will be used</summary>
        internal const string SAUCE_LABS_ACCOUNT_KEY = "9836204f-af06-440d-8f07-7ac3d45b3623";

        // NOTE:
        // To change the maximum number of parallel tests edit DegreeOfParallelism in AssemblyInfo.cs

    }
}
