﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Compute.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Compute.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SAS Uri for the destination blob is not supported in patch mode:{0}.
        /// </summary>
        public static string AddAzureVhdCommandSASUriNotSupportedInPatchMode {
            get {
                return ResourceManager.GetString("AddAzureVhdCommandSASUriNotSupportedInPatchMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Availability set removal operation.
        /// </summary>
        public static string AvailabilitySetRemovalCaption {
            get {
                return ResourceManager.GetString("AvailabilitySetRemovalCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This cmdlet will remove the specified availability set. Do you want to continue?.
        /// </summary>
        public static string AvailabilitySetRemovalConfirmation {
            get {
                return ResourceManager.GetString("AvailabilitySetRemovalConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apply configuration &apos;{0}&apos;.
        /// </summary>
        public static string AzureVMDscApplyConfigurationAction {
            get {
                return ResourceManager.GetString("AzureVMDscApplyConfigurationAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; already exists. Use the -Force parameter to overwrite it..
        /// </summary>
        public static string AzureVMDscArchiveAlreadyExists {
            get {
                return ResourceManager.GetString("AzureVMDscArchiveAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find configuration data file: {0}.
        /// </summary>
        public static string AzureVMDscCannotFindConfigurationDataFile {
            get {
                return ResourceManager.GetString("AzureVMDscCannotFindConfigurationDataFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The -ConfigurationArchive parameter must no include a path.
        /// </summary>
        public static string AzureVMDscConfigurationDataFileShouldNotIncludePath {
            get {
                return ResourceManager.GetString("AzureVMDscConfigurationDataFileShouldNotIncludePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create Archive.
        /// </summary>
        public static string AzureVMDscCreateArchiveAction {
            get {
                return ResourceManager.GetString("AzureVMDscCreateArchiveAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not find your azure storage credential. Please specify an storage context using the -StorageContext parameter, or set the current storage account using &quot;Set-AzureSubscription&quot;, or set the &quot;AZURE_STORAGE_CONNECTION_STRING&quot; environment variable..
        /// </summary>
        public static string AzureVMDscDefaultStorageCredentialsNotFound {
            get {
                return ResourceManager.GetString("AzureVMDscDefaultStorageCredentialsNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a valid DSC Extension version. Allowed format: N.N where N = [1..9].
        /// </summary>
        public static string AzureVMDscExtensionInvalidVersion {
            get {
                return ResourceManager.GetString("AzureVMDscExtensionInvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration data must be a .psd1 file.
        /// </summary>
        public static string AzureVMDscInvalidConfigurationDataFile {
            get {
                return ResourceManager.GetString("AzureVMDscInvalidConfigurationDataFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the ConfigurationArchive argument is null, then the ConfigurationName, ConfigurationArgument, and ConfigurationDataPath parameters must not be specified .
        /// </summary>
        public static string AzureVMDscNullArchiveNoConfiguragionParameters {
            get {
                return ResourceManager.GetString("AzureVMDscNullArchiveNoConfiguragionParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the ConfigurationArchive argument is null, then the StorageContext, ArchiveContainerName, and ArchiveStorageEndpointSuffix parameters must not be specified.
        /// </summary>
        public static string AzureVMDscNullArchiveNoStorageParameters {
            get {
                return ResourceManager.GetString("AzureVMDscNullArchiveNoStorageParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing configuration script: {0}.
        /// </summary>
        public static string AzureVMDscParsingConfiguration {
            get {
                return ResourceManager.GetString("AzureVMDscParsingConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage Blob &apos;{0}&apos; already exists. Use the -Force parameter to overwrite it..
        /// </summary>
        public static string AzureVMDscStorageBlobAlreadyExists {
            get {
                return ResourceManager.GetString("AzureVMDscStorageBlobAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The storage context must include an storage account..
        /// </summary>
        public static string AzureVMDscStorageContextMustIncludeAccountName {
            get {
                return ResourceManager.GetString("AzureVMDscStorageContextMustIncludeAccountName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upload &apos;{0}&apos;.
        /// </summary>
        public static string AzureVMDscUploadToBlobStorageAction {
            get {
                return ResourceManager.GetString("AzureVMDscUploadToBlobStorageAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot deserialize settings string from DSC extension. Updating your Azure PowerShell SDK to the latest version may solve this problem. Settings string:
        ///{0}.
        /// </summary>
        public static string AzureVMDscWrongSettingsFormat {
            get {
                return ResourceManager.GetString("AzureVMDscWrongSettingsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot specify both Windows and Linux configurations..
        /// </summary>
        public static string BothWindowsAndLinuxConfigurationsSpecified {
            get {
                return ResourceManager.GetString("BothWindowsAndLinuxConfigurationsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Run File has been assigned, and the Custom Script extension will try to use the first specified File Name as the Run File..
        /// </summary>
        public static string CustomScriptExtensionTryToUseTheFirstSpecifiedFileAsRunScript {
            get {
                return ResourceManager.GetString("CustomScriptExtensionTryToUseTheFirstSpecifiedFileAsRunScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data disk, {0}, is not currently assigned for this VM. Use Add-AzureVMDataDisk to add it..
        /// </summary>
        public static string DataDiskNotAssignedForVM {
            get {
                return ResourceManager.GetString("DataDiskNotAssignedForVM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Extension.
        /// </summary>
        public static string DscExtensionRemovalCaption {
            get {
                return ResourceManager.GetString("DscExtensionRemovalCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.
        /// </summary>
        public static string DscExtensionRemovalConfirmation {
            get {
                return ResourceManager.GetString("DscExtensionRemovalConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculating MD5 Hash.
        /// </summary>
        public static string PSSyncOutputEventsCalculatingMD5Hash {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsCalculatingMD5Hash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MD5 hash is being calculated for the file &apos;{0}&apos;..
        /// </summary>
        public static string PSSyncOutputEventsCalculatingMD5HashForFile {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsCalculatingMD5HashForFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying.
        /// </summary>
        public static string PSSyncOutputEventsCopying {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsCopying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating new page blob of size {0}....
        /// </summary>
        public static string PSSyncOutputEventsCreatingNewPageBlob {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsCreatingNewPageBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detecting the empty data blocks in the local file..
        /// </summary>
        public static string PSSyncOutputEventsDetectingActualDataBlocks {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsDetectingActualDataBlocks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detecting the empty data blocks completed..
        /// </summary>
        public static string PSSyncOutputEventsDetectingActualDataBlocksCompleted {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsDetectingActualDataBlocksCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading.
        /// </summary>
        public static string PSSyncOutputEventsDownloading {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsDownloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elapsed time for copy: {0}.
        /// </summary>
        public static string PSSyncOutputEventsElapsedTimeForCopy {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsElapsedTimeForCopy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elapsed time for download: {0}.
        /// </summary>
        public static string PSSyncOutputEventsElapsedTimeForDownload {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsElapsedTimeForDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elapsed time for the operation: {0}.
        /// </summary>
        public static string PSSyncOutputEventsElapsedTimeForOperation {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsElapsedTimeForOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elapsed time for upload: {0}.
        /// </summary>
        public static string PSSyncOutputEventsElapsedTimeForUpload {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsElapsedTimeForUpload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty block detected: {0}.
        /// </summary>
        public static string PSSyncOutputEventsEmptyBlockDetected {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsEmptyBlockDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed.
        /// </summary>
        public static string PSSyncOutputEventsEmptyBlockDetectionCompleted {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsEmptyBlockDetectionCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detecting empty blocks.
        /// </summary>
        public static string PSSyncOutputEventsEmptyBlockDetectionDetecting {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsEmptyBlockDetectionDetecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} days {1:00}:{2:00}:{3:00}.
        /// </summary>
        public static string PSSyncOutputEventsFormatDuration {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsFormatDuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:0.0}% complete; Remaining Time: {1}; Throughput: {2:0.0}Mbps.
        /// </summary>
        public static string PSSyncOutputEventsLogProgress {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsLogProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed.
        /// </summary>
        public static string PSSyncOutputEventsLogProgressCompleteCompleted {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsLogProgressCompleteCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MD5 hash calculation is completed..
        /// </summary>
        public static string PSSyncOutputEventsMD5HashCalculationFinished {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsMD5HashCalculationFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Range of the block is {0}, Length: {1}.
        /// </summary>
        public static string PSSyncOutputEventsPrintBlockRange {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsPrintBlockRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty Block Detection.
        /// </summary>
        public static string PSSyncOutputEventsProgressEmptyBlockDetection {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsProgressEmptyBlockDetection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found existing page blob. Resuming upload....
        /// </summary>
        public static string PSSyncOutputEventsResumingUpload {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsResumingUpload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Network disruption occured, retrying..
        /// </summary>
        public static string PSSyncOutputEventsRetryingAfterANetworkDisruption {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsRetryingAfterANetworkDisruption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upload failed with exceptions:.
        /// </summary>
        public static string PSSyncOutputEventsUploadFailedWithException {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsUploadFailedWithException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading.
        /// </summary>
        public static string PSSyncOutputEventsUploading {
            get {
                return ResourceManager.GetString("PSSyncOutputEventsUploading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; not found..
        /// </summary>
        public static string PublishVMDscExtensionAdditionalContentPathNotExist {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionAdditionalContentPathNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration published to {0}.
        /// </summary>
        public static string PublishVMDscExtensionArchiveUploadedMessage {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionArchiveUploadedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration published to {0}.
        /// </summary>
        public static string PublishVMDscExtensionArchiveUploadedMessage1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionArchiveUploadedMessage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find configuration file: {0}..
        /// </summary>
        public static string PublishVMDscExtensionConfigFileNotFound {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionConfigFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        public static string PublishVMDscExtensionCopyFileVerbose {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCopyFileVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        public static string PublishVMDscExtensionCopyFileVerbose1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCopyFileVerbose1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy the module &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        public static string PublishVMDscExtensionCopyModuleVerbose {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCopyModuleVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy the module &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        public static string PublishVMDscExtensionCopyModuleVerbose1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCopyModuleVerbose1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid configuration file: {0}.
        ///The file needs to be a PowerShell script (.ps1 or .psm1)..
        /// </summary>
        public static string PublishVMDscExtensionCreateArchiveConfigFileInvalidExtension {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCreateArchiveConfigFileInvalidExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid configuration file: {0}.
        ///The file needs to be a PowerShell script (.ps1 or .psm1)..
        /// </summary>
        public static string PublishVMDscExtensionCreateArchiveConfigFileInvalidExtension1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCreateArchiveConfigFileInvalidExtension1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a zip file &apos;{0}&apos; from directory &apos;{1}&apos;..
        /// </summary>
        public static string PublishVMDscExtensionCreateZipVerbose {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionCreateZipVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted &apos;{0}&apos;.
        /// </summary>
        public static string PublishVMDscExtensionDeletedFileMessage {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionDeletedFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted &apos;{0}&apos;.
        /// </summary>
        public static string PublishVMDscExtensionDeletedFileMessage1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionDeletedFileMessage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete &apos;{0}&apos;: {1}.
        /// </summary>
        public static string PublishVMDscExtensionDeleteErrorMessage {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionDeleteErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete &apos;{0}&apos;: {1}.
        /// </summary>
        public static string PublishVMDscExtensionDeleteErrorMessage1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionDeleteErrorMessage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; not found..
        /// </summary>
        public static string PublishVMDscExtensionDirectoryNotExist {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionDirectoryNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get module for DscResource &apos;{0}&apos;. Possible solutions:
        ///1) Specify -ModuleName for Import-DscResource in your configuration.
        ///2) Unblock module that contains resource.
        ///3) Move Import-DscResource inside Node block.
        ///.
        /// </summary>
        public static string PublishVMDscExtensionGetDscResourceFailed {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionGetDscResourceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get module for DscResource &apos;{0}&apos;. Possible solutions:
        ///1) Specify -ModuleName for Import-DscResource in your configuration.
        ///2) Unblock module that contains resource.
        ///3) Move Import-DscResource inside Node block.
        ///.
        /// </summary>
        public static string PublishVMDscExtensionGetDscResourceFailed1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionGetDscResourceFailed1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List of required modules: [{0}]..
        /// </summary>
        public static string PublishVMDscExtensionRequiredModulesVerbose {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionRequiredModulesVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List of required modules: [{0}]..
        /// </summary>
        public static string PublishVMDscExtensionRequiredModulesVerbose1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionRequiredModulesVerbose1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your current PowerShell version {1} is less then required by this cmdlet {0}. Consider download and install latest PowerShell version..
        /// </summary>
        public static string PublishVMDscExtensionRequiredPsVersion {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionRequiredPsVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your current PowerShell version {1} is less then required by this cmdlet {0}. Consider download and install latest PowerShell version..
        /// </summary>
        public static string PublishVMDscExtensionRequiredPsVersion1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionRequiredPsVersion1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration script &apos;{0}&apos; contained parse errors:
        ///{1}.
        /// </summary>
        public static string PublishVMDscExtensionStorageParserErrors {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionStorageParserErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration script &apos;{0}&apos; contained parse errors:
        ///{1}.
        /// </summary>
        public static string PublishVMDscExtensionStorageParserErrors1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionStorageParserErrors1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temp folder &apos;{0}&apos; created..
        /// </summary>
        public static string PublishVMDscExtensionTempFolderVerbose {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionTempFolderVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temp folder &apos;{0}&apos; created..
        /// </summary>
        public static string PublishVMDscExtensionTempFolderVerbose1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionTempFolderVerbose1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid configuration file: {0}.
        ///The file needs to be a PowerShell script (.ps1 or .psm1) or a ZIP archive (.zip)..
        /// </summary>
        public static string PublishVMDscExtensionUploadArchiveConfigFileInvalidExtension {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionUploadArchiveConfigFileInvalidExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid configuration file: {0}.
        ///The file needs to be a PowerShell script (.ps1 or .psm1) or a ZIP archive (.zip)..
        /// </summary>
        public static string PublishVMDscExtensionUploadArchiveConfigFileInvalidExtension1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionUploadArchiveConfigFileInvalidExtension1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration file &apos;{0}&apos; not found..
        /// </summary>
        public static string PublishVMDscExtensionUploadArchiveConfigFileNotExist {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionUploadArchiveConfigFileNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration file &apos;{0}&apos; not found..
        /// </summary>
        public static string PublishVMDscExtensionUploadArchiveConfigFileNotExist1 {
            get {
                return ResourceManager.GetString("PublishVMDscExtensionUploadArchiveConfigFileNotExist1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current subscription has been designated. Use Select-AzureSubscription -Current &lt;subscriptionName&gt; to set the current subscription..
        /// </summary>
        public static string StorageCredentialsFactoryCurrentSubscriptionNotSet {
            get {
                return ResourceManager.GetString("StorageCredentialsFactoryCurrentSubscriptionNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machine extension removal operation.
        /// </summary>
        public static string VirtualMachineExtensionRemovalCaption {
            get {
                return ResourceManager.GetString("VirtualMachineExtensionRemovalCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This cmdlet will remove the specified virtual machine extension. Do you want to continue?.
        /// </summary>
        public static string VirtualMachineExtensionRemovalConfirmation {
            get {
                return ResourceManager.GetString("VirtualMachineExtensionRemovalConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The RDP file cannot be generated because the network interface of the virtual machine does not reference a PublicIP or an InboundNatRule of a public load balancer. .
        /// </summary>
        public static string VirtualMachineNotAssociatedWithPublicIPOrPublicLoadBalancer {
            get {
                return ResourceManager.GetString("VirtualMachineNotAssociatedWithPublicIPOrPublicLoadBalancer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The RDP file cannot be generated because the network interface of the virtual machine does not reference an InboundNatRule of a public load balancer..
        /// </summary>
        public static string VirtualMachineNotAssociatedWithPublicLoadBalancer {
            get {
                return ResourceManager.GetString("VirtualMachineNotAssociatedWithPublicLoadBalancer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The RDP file cannot be generated because the network interface of the virtual machine does not reference a PublicIP or an InboungNatRule of the load balancer..
        /// </summary>
        public static string VirtualMachineReferencesInternalNetworkInterface {
            get {
                return ResourceManager.GetString("VirtualMachineReferencesInternalNetworkInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machine removal operation.
        /// </summary>
        public static string VirtualMachineRemovalCaption {
            get {
                return ResourceManager.GetString("VirtualMachineRemovalCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This cmdlet will remove the specified virtual machine. Do you want to continue?.
        /// </summary>
        public static string VirtualMachineRemovalConfirmation {
            get {
                return ResourceManager.GetString("VirtualMachineRemovalConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual machine stopping operation.
        /// </summary>
        public static string VirtualMachineStoppingCaption {
            get {
                return ResourceManager.GetString("VirtualMachineStoppingCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This cmdlet will stop the specified virtual machine. Do you want to continue?.
        /// </summary>
        public static string VirtualMachineStoppingConfirmation {
            get {
                return ResourceManager.GetString("VirtualMachineStoppingConfirmation", resourceCulture);
            }
        }
    }
}
