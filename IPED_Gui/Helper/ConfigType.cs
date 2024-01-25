using IPED_Gui_WinForms.Properties;

namespace IPED_Gui_WinForms.Helper
{
    public class ConfigType
    {

        public static void WriteAllToDisk(string profilePath)
        {
            IPEDConfig.WriteToDisk(profilePath);
            FileSystemConfig.WriteToDisk(profilePath);
        }

        public static readonly ConfigType IPEDConfig = new("IPEDConfig.txt", new ConfigElement[] {
            new("enableHash", "IPEDConfigEnableHash", typeof(bool), "Enables file hashes calculation."),
            new("enablePhotoDNA", "IPEDConfigEnablePhotoDNA", typeof(bool), "Enables photoDNA hash calculation. If you have rights to use it (law enforcement that fight against child exploitation) and have received the library, you must put it into plugins folder"),
            new("enableHashDBLookup", "IPEDConfigEnableHashDBLookup", typeof(bool), "Enables hash lookup on IPED database."),
            new("enablePhotoDNALookup", "IPEDConfigEnablePhotoDNALookup", typeof(bool), "Enables photoDNA lookup on IPED hash database."),
            new("enableLedDie", "IPEDConfigEnableLedDie", typeof(bool), "Enables nudity detection. For each image it creates attributes \"nudityScore\" (1 to 1000) and \"nudityClass\" (1 to 5) for ranking and/or filtering."),
            new("enableYahooNSFWDetection", "IPEDConfigEenableYahooNSFWDetection", typeof(bool), "[Experimental] Enables nudity detection using Yahoo OpenNSFW deeplearning algorithm. You may install python and some dependencies to enable it, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#python-modules This is more than 1 order of magnitude slower than LedDie algorithm on the CPU, using a good GPU is highly recommended. It gives higher scores than LedDie algorithm for images/videos with genitals or explicit sex, mainly because of training dataset differences. An attribute nsfw_nudity_score from 0 to 100 will be created."),
            new("enableQRCode", "IPEDConfigEnableQRCode", typeof(bool), "Enables QRcode detection and decoding"),
            new("ignoreDuplicates", "IPEDConfigIgnoreDuplicates", typeof(bool), "Ignore and exclude duplicated files with same hash from the processing and from the case.  WARNING: This feature is inherently DANGEROUS, as it could exclude from the case duplicated files with different metadata (name, path, dates) like email attachments or files in relevant folders. See #574 and #931."),
            new("exportFileProps", "IPEDConfigExportFileProps", typeof(bool), "Exports the properties of all files in the case to file \"Lista de Arquivos.csv\""),
            new("processFileSignatures", "IPEDConfigProcessFileSignatures", typeof(bool), "Processes the signatures of files"),
            new("enableFileParsing", "IPEDConfigEnableFileParsing", typeof(bool), "Enables parsing of files contents. It's necessary for several functions like containers expansion, detection of encrypted content, metadata indexing, previews generation, etc."),
            new("expandContainers", "IPEDConfigExpandContainers", typeof(bool), "Expands containers, like compressed files, e-mail boxes, emails e MS-Office documents. File types to be expanded can be modified in file \"conf/CategoriesToExpand.txt\""),
            new("processEmbeddedDisks", "IPEDConfigProcessEmbeddedDisks", typeof(bool), "Process supported disk images (like dd, e01, vhd, vmdk) contained in the main evidence recursively. Splitted images and snapshots are not supported for now."),
            new("enableRegexSearch", "IPEDConfigEnableRegexSearch", typeof(bool), "Searches texts extracted from items by regular expressions like social numbers, emails, URLs, credit cards, money values, etc. New expressions can be configured in file \"conf/RegexConfig.txt\""),
            new("enableAutomaticExportFiles", "IPEDConfigEnableAutomaticExportFiles", typeof(bool), "Enables automatic file exporting to case folder based on categories or keywords. If enabled, just the exported files are included in case, others are ignored, and the case becomes datasource independent. Relevant categories and keywords can be configured in CategoriesToExport.txt and KeywordsToExport.txt."),
            new("enableLanguageDetect", "IPEDConfigEnableLanguageDetect", typeof(bool), "Enables detection of more than 70 idioms in document files."),
            new("enableNamedEntityRecogniton", "IPEDConfigEnableNamedEntityRecogniton", typeof(bool), "Feature to recognize named entities: people, organizations or places. StanfordCoreNLP 3.8 language models must be downloaded from https://stanfordnlp.github.io/CoreNLP/history.html and put in plugins folder. This feature is CPU heavy, it can increase processing time by 4x. Advanced settings can be modified in \"conf/NamedEntityRecognitionConfig.txt\" file."),
            new("enableGraphGeneration", "IPEDConfigEnableGraphGeneration", typeof(bool), "Feature to create link graphs of communications (calls, messages, emails...) Optionally it can create entities and links based on nearby regex hits (experimental). It could be enabled in conf/GraphConfig.json"),
            new("entropyTest", "IPEDConfigEntropyTest", typeof(bool), "Perform test for randomness of binary items and unknown file types. This is used to detect possible encrypted items. Also makes indexing faster and reduces index size, specially when indexing unallocated space. May cause loss of hits surrounded by \"random\" content."),
            new("indexFileContents", "IPEDConfigIndexFileContents", typeof(bool), "Indexes files contents. If disabled, indexes only the properties of files."),
            new("enableIndexToElasticSearch", "IPEDConfigEnableIndexToElasticSearch", typeof(bool), "Enables indexing to an ElasticSearch/OpenSearch cluster. You must configure at least host/port options in conf/ElasticSearchConfig.txt"),
            new("enableMinIO", "IPEDConfigEnableMinIO", typeof(bool), "Enable exporting files to MinIO object storage cluster. You must configure at least host/port options in conf/MinIOConfig.txt"),
            new("enableAudioTranscription", "IPEDConfigEnableAudioTranscription", typeof(bool), "Enable audio transcription. Default implementation uses VOSK transcription [EXPERIMENTAL] on local CPU (slow and medium quality). We include Vosk portable models for 'en' and 'pt-BR', the lang model is taken from 'locale' in LocalConfig.txt You can change it from Vosk to Microsoft Azure or Google Cloud services (faster and better quality). Configure it in conf/AudioTranscriptConfig.txt"),
            new("enableCarving", "IPEDConfigEnableCarving", typeof(bool), "Enables carving. \"addUnallocated\" must be enabled to unallocated area be searched. By default carving runs on almost every item in the case. File types to be searched and retrieved can be set in file \"conf/CarvingConfig.txt\""),
            new("enableLedCarving", "IPEDConfigEnableLedCarving", typeof(bool), "Enables carving that retrieves known files from the LED base, based on the beginning (64K) of the file. It's necessary to enable \"addUnallocated\" and to configure \"hashesDB\" (with LED hashes data imported)."),
            new("enableKnownMetCarving", "IPEDConfigEnableKnownMetCarving", typeof(bool), "Enables specific carving of e-Mule \"known.met\" files. \"addUnallocated\" must be enabled."),
            new("enableImageThumbs", "IPEDConfigEnableImageThumbs", typeof(bool), "Enables the generation of images thumbnails during processing. It can slow down processing, but strongly speeds up image preview in the gallery"),
            new("enableImageSimilarity", "IPEDConfigEnableImageSimilarity", typeof(bool), "Enables the generation of images features during processing, allowing the search for visually similar images. \"enableImageThumbs\" must be enabled."),
            new("enableFaceRecognition", "IPEDConfigEnableFaceRecognition", typeof(bool), "Enables face recognition feature. You may install python and some dependencies, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#facerecognition Advanced configuration options can be found in conf/FaceRecognitionConfig.txt. If enabled, you can search for faces from the analysis interface, check the options menu."),
            new("enableVideoThumbs", "IPEDConfigEnableVideoThumbs", typeof(bool), "Enables extraction of image frames from video files Extraction settings can be modified in file \"conf/VideoThumbsConfig.txt\""),
            new("enableDocThumbs", "IPEDConfigEnableDocThumbs", typeof(bool), "[Experimental] Enables thumbnail creation for PDFs and many formats supported by LibreOffice. Advanced configurations can be found at conf/DocThumbsConfig.txt."),
            new("enableHTMLReport", "IPEDConfigEnableHTMLReport", typeof(bool), "Enables HTML report generation on automatic extractions or from selected items. Generation settings can be modified in file \"conf/HTMLReportConfig.txt\""),
            new("enableAudioTranslation", "IPEDConfigEnableAudioTranslation", typeof(bool), "Enable audio translation via Whisper and Argos Translate. Needs enableHash = true. Configure it in conf/AudioTranslation.txt"),
            new("enableTextTranslation", "IPEDConfigEnableTextTranslation", typeof(bool), "Enable text translation via Argos Translate. Currently this does not work because it must handle different text sources in a different way. Needs enableHash = true. Configure it in conf/TextTranslation.txt"),
            new("enableImageClassification", "IPEDConfigEnableImageClassification", typeof(bool), "Enable image classification. Needs enableHash = true.")
        });

        public static readonly ConfigType FileSystemConfig = new("conf/FileSystemConfig.txt", new ConfigElement[] {
            new("robustImageReading", "FileSystemConfigRobustImageReading", typeof(bool), "Uses auxiliary processes to read file contents in images. If Sleuthkit crashes, only the auxiliary processes are killed and restarted. Increases RAM usage often in about ~500MB per process. Increases up to 3x the processing speed of compressed E01 images, APFS containers or images in network."),
            new("numImageReaders", "FileSystemConfigNumImageReaders", typeof(string), "Number of auxiliary image reading processes. 'auto' uses 1/4 of the number of logical CPU cores. You can decrease the value if it uses too much RAM. Increasing the value is not efficient, because often IO devices can not handle many reading requests simultaneously."),
            new("addUnallocated", "FileSystemConfigAddUnallocated", typeof(bool), "Add and process unallocated areas of images."),
            new("addFileSlacks", "FileSystemConfigAddFileSlacks", typeof(bool), "Add and process file slacks."),
            new("minOrphanSizeToIgnore", "FileSystemConfigMinOrphanSizeToIgnore", typeof(string), "Ignore orphan files bigger than this value in bytes. Default -1 means disabled. In rare cases, Sleuthkit can recover thousands of large corrupted orphan files pointing to the same disk areas, making the processing not feasible."),
            new("unallocatedFragSize", "FileSystemConfigUnallocatedFragSize", typeof(string), "Size in bytes of the unallocated space segments. In cases where the carving of videos is important, it may be useful to increase this value to minimize missing items that cross segment boundaries, but processing may take longer if this value is too large."),
            new("ignoreHardLinks", "FileSystemConfigIgnoreHardLinks", typeof(bool), "Ignores HFS+ hard links pointing to items already processed. The hard links are added to the case, but their content is not processed (indexed, expanded, carved, etc). Optimizes HFS+ image processing containing millions of hard links (such as Time Machine volumes)."),
            new("skipFolderRegex", "FileSystemConfigSkipFolderRegex", typeof(string), "Regex pattern to skip matched folder trees when processing. Just works if processing mounted folders currently. Matched folders are ignored and not included in case.")
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
                if (configElement.ElementType == typeof(bool))
                {
                    line += (bool)Settings.Default[configElement.SettingsName] ? "true" : "false";
                }
                else
                {
                    line += Settings.Default[configElement.SettingsName].ToString();
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
        public readonly Type ElementType;
        public readonly string Description;

        public ConfigElement(string elementName, string settingsName, Type elementType, string description)
        {
            ElementName = elementName;
            SettingsName = settingsName;
            ElementType = elementType;
            Description = description;
        }
    }
}
