using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Helper
{
    public class ConfigType
    {

        public static void WriteAllToDisk(string profilePath)
        {
            LocalConfig.WriteToDisk(profilePath);
            IPEDConfig.WriteToDisk(profilePath);
            FileSystemConfig.WriteToDisk(profilePath);
            AudioTranslation.WriteToDisk(profilePath);
            ImageClassification.WriteToDisk(profilePath);
        }

        public static readonly ConfigType LocalConfig = new("LocalConfig.txt", new ConfigElement[] {
            new("locale", "LocalConfigLocale", ConfigElementType.StringList, "Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'", listElements: new List<string>{ "de-DE", "en", "pt-BR", "it-IT", "es-AR" }),
            new("indexTemp", "LocalConfigIndexTemp", ConfigElementType.Directory, "Temporary directory for processing: \"default\" uses the system temporary folder. Configure it on a folder free of antivirus, system indexing or restoring. "),
            new("indexTempOnSSD", "LocalConfigIndexTempOnSSD", ConfigElementType.Boolean, "Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you "),
            new("outputOnSSD", "LocalConfigOutputOnSSD", ConfigElementType.Boolean, "Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp "),
            new("numThreads", "LocalConfigNumThreads", ConfigElementType.String, "Number of processing threads/workers: \"default\" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms)."),
            new("hashesDB", "LocalConfigHashesDB", ConfigElementType.File, "Full path for IPED hash database. It is highly recommended to store it on a fast disk, preferably SSD, and not the same used as \"indexTemp\", if other disk is available.", filter: "IPED Hash database|iped-hashes.db"),
            // tskJarPath wird hier nicht aufgenommen, da nur für Linux relevant
            new("pluginFolder", "LocalConfigPluginFolder", ConfigElementType.DirectoryRelativeToIpedExe, "Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime.")
        });

        public static readonly ConfigType IPEDConfig = new("IPEDConfig.txt", new ConfigElement[] {
            new("enableHash", "IPEDConfigEnableHash", ConfigElementType.Boolean, "Enables file hashes calculation."),
            new("enablePhotoDNA", "IPEDConfigEnablePhotoDNA", ConfigElementType.Boolean, "Enables photoDNA hash calculation. If you have rights to use it (law enforcement that fight against child exploitation) and have received the library, you must put it into plugins folder"),
            new("enableHashDBLookup", "IPEDConfigEnableHashDBLookup", ConfigElementType.Boolean, "Enables hash lookup on IPED database."),
            new("enablePhotoDNALookup", "IPEDConfigEnablePhotoDNALookup", ConfigElementType.Boolean, "Enables photoDNA lookup on IPED hash database."),
            new("enableLedDie", "IPEDConfigEnableLedDie", ConfigElementType.Boolean, "Enables nudity detection. For each image it creates attributes \"nudityScore\" (1 to 1000) and \"nudityClass\" (1 to 5) for ranking and/or filtering."),
            new("enableYahooNSFWDetection", "IPEDConfigEenableYahooNSFWDetection", ConfigElementType.Boolean, "[Experimental] Enables nudity detection using Yahoo OpenNSFW deeplearning algorithm. You may install python and some dependencies to enable it, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#python-modules This is more than 1 order of magnitude slower than LedDie algorithm on the CPU, using a good GPU is highly recommended. It gives higher scores than LedDie algorithm for images/videos with genitals or explicit sex, mainly because of training dataset differences. An attribute nsfw_nudity_score from 0 to 100 will be created."),
            new("enableQRCode", "IPEDConfigEnableQRCode", ConfigElementType.Boolean, "Enables QRcode detection and decoding"),
            new("ignoreDuplicates", "IPEDConfigIgnoreDuplicates", ConfigElementType.Boolean, "Ignore and exclude duplicated files with same hash from the processing and from the case.  WARNING: This feature is inherently DANGEROUS, as it could exclude from the case duplicated files with different metadata (name, path, dates) like email attachments or files in relevant folders. See #574 and #931."),
            new("exportFileProps", "IPEDConfigExportFileProps", ConfigElementType.Boolean, "Exports the properties of all files in the case to file \"Lista de Arquivos.csv\""),
            new("processFileSignatures", "IPEDConfigProcessFileSignatures", ConfigElementType.Boolean, "Processes the signatures of files"),
            new("enableFileParsing", "IPEDConfigEnableFileParsing", ConfigElementType.Boolean, "Enables parsing of files contents. It's necessary for several functions like containers expansion, detection of encrypted content, metadata indexing, previews generation, etc."),
            new("expandContainers", "IPEDConfigExpandContainers", ConfigElementType.Boolean, "Expands containers, like compressed files, e-mail boxes, emails e MS-Office documents. File types to be expanded can be modified in file \"conf/CategoriesToExpand.txt\""),
            new("processEmbeddedDisks", "IPEDConfigProcessEmbeddedDisks", ConfigElementType.Boolean, "Process supported disk images (like dd, e01, vhd, vmdk) contained in the main evidence recursively. Splitted images and snapshots are not supported for now."),
            new("enableRegexSearch", "IPEDConfigEnableRegexSearch", ConfigElementType.Boolean, "Searches texts extracted from items by regular expressions like social numbers, emails, URLs, credit cards, money values, etc. New expressions can be configured in file \"conf/RegexConfig.txt\""),
            new("enableAutomaticExportFiles", "IPEDConfigEnableAutomaticExportFiles", ConfigElementType.Boolean, "Enables automatic file exporting to case folder based on categories or keywords. If enabled, just the exported files are included in case, others are ignored, and the case becomes datasource independent. Relevant categories and keywords can be configured in CategoriesToExport.txt and KeywordsToExport.txt."),
            new("enableLanguageDetect", "IPEDConfigEnableLanguageDetect", ConfigElementType.Boolean, "Enables detection of more than 70 idioms in document files."),
            new("enableNamedEntityRecogniton", "IPEDConfigEnableNamedEntityRecogniton", ConfigElementType.Boolean, "Feature to recognize named entities: people, organizations or places. StanfordCoreNLP 3.8 language models must be downloaded from https://stanfordnlp.github.io/CoreNLP/history.html and put in plugins folder. This feature is CPU heavy, it can increase processing time by 4x. Advanced settings can be modified in \"conf/NamedEntityRecognitionConfig.txt\" file."),
            new("enableGraphGeneration", "IPEDConfigEnableGraphGeneration", ConfigElementType.Boolean, "Feature to create link graphs of communications (calls, messages, emails...) Optionally it can create entities and links based on nearby regex hits (experimental). It could be enabled in conf/GraphConfig.json"),
            new("entropyTest", "IPEDConfigEntropyTest", ConfigElementType.Boolean, "Perform test for randomness of binary items and unknown file types. This is used to detect possible encrypted items. Also makes indexing faster and reduces index size, specially when indexing unallocated space. May cause loss of hits surrounded by \"random\" content."),
            new("indexFileContents", "IPEDConfigIndexFileContents", ConfigElementType.Boolean, "Indexes files contents. If disabled, indexes only the properties of files."),
            new("enableIndexToElasticSearch", "IPEDConfigEnableIndexToElasticSearch", ConfigElementType.Boolean, "Enables indexing to an ElasticSearch/OpenSearch cluster. You must configure at least host/port options in conf/ElasticSearchConfig.txt"),
            new("enableMinIO", "IPEDConfigEnableMinIO", ConfigElementType.Boolean, "Enable exporting files to MinIO object storage cluster. You must configure at least host/port options in conf/MinIOConfig.txt"),
            new("enableAudioTranscription", "IPEDConfigEnableAudioTranscription", ConfigElementType.Boolean, "Enable audio transcription. Default implementation uses VOSK transcription [EXPERIMENTAL] on local CPU (slow and medium quality). We include Vosk portable models for 'en' and 'pt-BR', the lang model is taken from 'locale' in LocalConfig.txt You can change it from Vosk to Microsoft Azure or Google Cloud services (faster and better quality). Configure it in conf/AudioTranscriptConfig.txt"),
            new("enableCarving", "IPEDConfigEnableCarving", ConfigElementType.Boolean, "Enables carving. \"addUnallocated\" must be enabled to unallocated area be searched. By default carving runs on almost every item in the case. File types to be searched and retrieved can be set in file \"conf/CarvingConfig.txt\""),
            new("enableLedCarving", "IPEDConfigEnableLedCarving", ConfigElementType.Boolean, "Enables carving that retrieves known files from the LED base, based on the beginning (64K) of the file. It's necessary to enable \"addUnallocated\" and to configure \"hashesDB\" (with LED hashes data imported)."),
            new("enableKnownMetCarving", "IPEDConfigEnableKnownMetCarving", ConfigElementType.Boolean, "Enables specific carving of e-Mule \"known.met\" files. \"addUnallocated\" must be enabled."),
            new("enableImageThumbs", "IPEDConfigEnableImageThumbs", ConfigElementType.Boolean, "Enables the generation of images thumbnails during processing. It can slow down processing, but strongly speeds up image preview in the gallery"),
            new("enableImageSimilarity", "IPEDConfigEnableImageSimilarity", ConfigElementType.Boolean, "Enables the generation of images features during processing, allowing the search for visually similar images. \"enableImageThumbs\" must be enabled."),
            new("enableFaceRecognition", "IPEDConfigEnableFaceRecognition", ConfigElementType.Boolean, "Enables face recognition feature. You may install python and some dependencies, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#facerecognition Advanced configuration options can be found in conf/FaceRecognitionConfig.txt. If enabled, you can search for faces from the analysis interface, check the options menu."),
            new("enableVideoThumbs", "IPEDConfigEnableVideoThumbs", ConfigElementType.Boolean, "Enables extraction of image frames from video files Extraction settings can be modified in file \"conf/VideoThumbsConfig.txt\""),
            new("enableDocThumbs", "IPEDConfigEnableDocThumbs", ConfigElementType.Boolean, "[Experimental] Enables thumbnail creation for PDFs and many formats supported by LibreOffice. Advanced configurations can be found at conf/DocThumbsConfig.txt."),
            new("enableHTMLReport", "IPEDConfigEnableHTMLReport", ConfigElementType.Boolean, "Enables HTML report generation on automatic extractions or from selected items. Generation settings can be modified in file \"conf/HTMLReportConfig.txt\""),
            new("enableAudioTranslation", "IPEDConfigEnableAudioTranslation", ConfigElementType.Boolean, "Enable audio translation via Whisper and Argos Translate. Needs enableHash = true. Configure it in conf/AudioTranslation.txt"),
            new("enableTextTranslation", "IPEDConfigEnableTextTranslation", ConfigElementType.Boolean, "Enable text translation via Argos Translate. Currently this does not work because it must handle different text sources in a different way. Needs enableHash = true. Configure it in conf/TextTranslation.txt"),
            new("enableImageClassification", "IPEDConfigEnableImageClassification", ConfigElementType.Boolean, "Enable image classification. Needs enableHash = true.")
        });

        public static readonly ConfigType FileSystemConfig = new("conf/FileSystemConfig.txt", new ConfigElement[] {
            new("robustImageReading", "FileSystemConfigRobustImageReading", ConfigElementType.Boolean, "Uses auxiliary processes to read file contents in images. If Sleuthkit crashes, only the auxiliary processes are killed and restarted. Increases RAM usage often in about ~500MB per process. Increases up to 3x the processing speed of compressed E01 images, APFS containers or images in network."),
            new("numImageReaders", "FileSystemConfigNumImageReaders", ConfigElementType.String, "Number of auxiliary image reading processes. 'auto' uses 1/4 of the number of logical CPU cores. You can decrease the value if it uses too much RAM. Increasing the value is not efficient, because often IO devices can not handle many reading requests simultaneously."),
            new("addUnallocated", "FileSystemConfigAddUnallocated", ConfigElementType.Boolean, "Add and process unallocated areas of images."),
            new("addFileSlacks", "FileSystemConfigAddFileSlacks", ConfigElementType.Boolean, "Add and process file slacks."),
            new("minOrphanSizeToIgnore", "FileSystemConfigMinOrphanSizeToIgnore", ConfigElementType.String, "Ignore orphan files bigger than this value in bytes. Default -1 means disabled. In rare cases, Sleuthkit can recover thousands of large corrupted orphan files pointing to the same disk areas, making the processing not feasible."),
            new("unallocatedFragSize", "FileSystemConfigUnallocatedFragSize", ConfigElementType.String, "Size in bytes of the unallocated space segments. In cases where the carving of videos is important, it may be useful to increase this value to minimize missing items that cross segment boundaries, but processing may take longer if this value is too large."),
            new("ignoreHardLinks", "FileSystemConfigIgnoreHardLinks", ConfigElementType.Boolean, "Ignores HFS+ hard links pointing to items already processed. The hard links are added to the case, but their content is not processed (indexed, expanded, carved, etc). Optimizes HFS+ image processing containing millions of hard links (such as Time Machine volumes)."),
            new("skipFolderRegex", "FileSystemConfigSkipFolderRegex", ConfigElementType.String, "Regex pattern to skip matched folder trees when processing. Just works if processing mounted folders currently. Matched folders are ignored and not included in case.")
        });

        public static readonly ConfigType AudioTranslation = new("conf/AudioTranslation.txt", new ConfigElement[] {
            new("processVideo", "AudioTranslationProcessVideo", ConfigElementType.Boolean, "Use video processing with caution. It can take very long if you analyze full length cinema movies"),
            new("taskBridgeUrl", "AudioTranslationTaskBridgeUrl", ConfigElementType.String, "URL of the task bridge in the format http://127.0.0.1:42000/"),
        });

        public static readonly ConfigType ImageClassification = new("conf/ImageClassification.txt", new ConfigElement[] {
            new("taskBridgeUrl", "ImageClassificationTaskBridgeUrl", ConfigElementType.String, "URL of the task bridge in the format http://127.0.0.1:42000/"),
        });

        public readonly string FilePath;
        public readonly ConfigElement[] ConfigElements;

        public ConfigType(string filePath, ConfigElement[] configElements)
        {
            FilePath = filePath;
            ConfigElements = configElements;
        }

        private void WriteToDisk(string profilePath)
        {
            var lines = new List<string>();
            foreach (var configElement in ConfigElements)
            {
                lines.Add("# " + configElement.Description);
                var line = configElement.ElementName + " = ";
                var setting = Settings.Default[configElement.SettingsName];
                if (configElement.ElementType == ConfigElementType.Boolean)
                {
                    line += (bool)setting ? "true" : "false";
                }
                else if (configElement.ElementType == ConfigElementType.File || configElement.ElementType == ConfigElementType.Directory)
                {
                    line += (setting.ToString() ?? "").Replace("\\", "/");
                }
                else if (configElement.ElementType == ConfigElementType.DirectoryRelativeToIpedExe)
                {
                    line += Path.GetRelativePath(Path.GetDirectoryName(Settings.Default.SettingsIpedExePath) ?? "", setting.ToString() ?? "").Replace("\\", "/");
                }
                else
                {
                    line += setting.ToString();
                }
                lines.Add(line);
                lines.Add("");
            }
            File.WriteAllText(Path.Join(profilePath, FilePath), string.Join("\n", lines));
        }

    }

    public class ConfigElement
    {
        public readonly string ElementName;
        public readonly string SettingsName;
        public readonly ConfigElementType ElementType;
        public readonly string Description;
        public readonly string Filter;
        public readonly List<string> ListElements;

        public ConfigElement(string elementName, string settingsName, ConfigElementType elementType, string description, string filter, List<string> listElements)
        {
            ElementName = elementName;
            SettingsName = settingsName;
            ElementType = elementType;
            Description = description;
            Filter = filter;
            ListElements = listElements;
        }

        public ConfigElement(string elementName, string settingsName, ConfigElementType elementType, string description, List<string> listElements) : this(elementName, settingsName, elementType, description, "", listElements) { }

        public ConfigElement(string elementName, string settingsName, ConfigElementType elementType, string description, string filter) : this(elementName, settingsName, elementType, description, filter, new List<string>()) { }

        public ConfigElement(string elementName, string settingsName, ConfigElementType elementType, string description) : this(elementName, settingsName, elementType, description, "", new List<string>()) { }
    }

    public enum ConfigElementType
    {
        String,
        Number,
        Boolean,
        Directory,
        DirectoryRelativeToIpedExe,
        File,
        StringList
    }
}
