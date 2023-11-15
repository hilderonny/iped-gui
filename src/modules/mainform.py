import PySimpleGUI as sg
import modules.win11widgets as w11
from modules.configtab import createConfigTab

def createHomeTab():
    return sg.Tab(title='Home', layout=[
    ])

def createEnvironmentTab():
    return sg.Tab(title='Environment', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                w11.Win11Combo(key='LocalConfig_locale',label='Program language',description="Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'",values=['en', 'pt-BR', 'it-IT', 'de-DE', 'es-AR'],default_value='de-DE'),
                w11.Win11FolderChooser(key='LocalConfig_indexTemp',label='Temporary directory for processing',description='Configure it on a folder free of antivirus, system indexing or restoring. Using a SSD disk is highly recommended.'),
                w11.Win11Checkbox(key='LocalConfig_indexTempOnSSD', label='Temporary directory is on SSD', description='Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you will have performance problems.'),
                w11.Win11Checkbox(key='LocalConfig_outputOnSSD', label='Output directory is on SSD', description='Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp folder.'),
                w11.Win11Input(key='LocalConfig_numThreads',label='Number of processing threads/workers',description='"default" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms).',width=8),
                w11.Win11FileChooser(key='LocalConfig_hashesDB',label='Hash database',description='Full path for IPED hash database. It is highly recommended to store it on a fast disk, preferably SSD, and not the same used as "indexTemp", if other disk is available.'),
                w11.Win11FolderChooser(key='LocalConfig_pluginFolder',label='Plugin folder',description='Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime.'),
            ]),
        ],
    ])

def createProcessingTab():
    return sg.Tab(title='Processing', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                w11.Win11Checkbox(key='IPEDConfig_enableHash',label='Create file Hashes',description='Enables file hashes calculation.'),
                w11.Win11Checkbox(key='IPEDConfig_enablePhotoDNA',label='Create PhotoDNA Hashes',description='Enables photoDNA hash calculation. If you have rights to use it (law enforcement that fight against child exploitation) and have received the library, you must put it into plugins folder'),
                w11.Win11Checkbox(key='IPEDConfig_enableHashDBLookup',label='Lookup hashes',description='Enables hash lookup on IPED database.'),
                w11.Win11Checkbox(key='IPEDConfig_enablePhotoDNALookup',label='Lookup PhotoDNA hashes',description='Enables photoDNA lookup on IPED hash database.'),
                w11.Win11Checkbox(key='IPEDConfig_enableLedDie',label='Nudity detection',description='Enables nudity detection. For each image it creates attributes "nudityScore" (1 to 1000) and "nudityClass" (1 to 5) for ranking and/or filtering.'),
                w11.Win11Checkbox(key='IPEDConfig_enableYahooNSFWDetection',label='Nudity detection via Yahoo OpenNSFW',description='[Experimental] Enables nudity detection using Yahoo OpenNSFW deeplearning algorithm. You may install python and some dependencies to enable it, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#python-modules. This is more than 1 order of magnitude slower than LedDie algorithm on the CPU, using a good GPU is highly recommended. It gives higher scores than LedDie algorithm for images/videos with genitals or explicit sex, mainly because of training dataset differences. An attribute nsfw_nudity_score from 0 to 100 will be created.'),
                w11.Win11Checkbox(key='IPEDConfig_enableQRCode',label='QR Code detection',description='Enables QRcode detection and decoding'),
                w11.Win11Checkbox(key='IPEDConfig_ignoreDuplicates',label='Ignore duplicates',description='Ignore and exclude duplicated files with same hash from the processing and from the case. WARNING: This feature is inherently DANGEROUS, as it could exclude from the case duplicated files with different metadata (name, path, dates) like email attachments or files in relevant folders. See #574 and #931.'),
                w11.Win11Checkbox(key='IPEDConfig_exportFileProps',label='Export file properties',description='Exports the properties of all files in the case to file "Lista de Arquivos.csv"'),
                w11.Win11Checkbox(key='IPEDConfig_processFileSignatures',label='Process file signatures',description='Processes the signatures of files'),
                w11.Win11Checkbox(key='IPEDConfig_enableFileParsing',label='Parse file contents',description="Enables parsing of files contents. It's necessary for several functions like containers expansion, detection of encrypted content, metadata indexing, previews generation, etc."),
                w11.Win11Checkbox(key='IPEDConfig_expandContainers',label='Expand containers',description='Expands containers, like compressed files, e-mail boxes, emails e MS-Office documents. File types to be expanded can be modified in file "conf/CategoriesToExpand.txt"'),
                w11.Win11Checkbox(key='IPEDConfig_processEmbeddedDisks',label='Process embedded disks',description='Process supported disk images (like dd, e01, vhd, vmdk) contained in the main evidence recursively. Splitted images and snapshots are not supported for now.'),
                w11.Win11Checkbox(key='IPEDConfig_enableRegexSearch',label='Regular expressions',description='Searches texts extracted from items by regular expressions like social numbers, emails, URLs, credit cards, money values, etc. New expressions can be configured in file "conf/RegexConfig.txt"'),
                w11.Win11Checkbox(key='IPEDConfig_enableAutomaticExportFiles',label='Automatic file export',description='Enables automatic file exporting to case folder based on categories or keywords. If enabled, just the exported files are included in case, others are ignored, and the case becomes datasource independent. Relevant categories and keywords can be configured in CategoriesToExport.txt and KeywordsToExport.txt.'),
                w11.Win11Checkbox(key='IPEDConfig_enableLanguageDetect',label='Language detection',description='Enables detection of more than 70 idioms in document files.'),
                w11.Win11Checkbox(key='IPEDConfig_enableNamedEntityRecogniton',label='Recognize named entities',description='Feature to recognize named entities: people, organizations or places. StanfordCoreNLP 3.8 language models must be downloaded from https://stanfordnlp.github.io/CoreNLP/history.html and put in plugins folder. This feature is CPU heavy, it can increase processing time by 4x. Advanced settings can be modified in "conf/NamedEntityRecognitionConfig.txt" file.'),
                w11.Win11Checkbox(key='IPEDConfig_enableGraphGeneration',label='Generate graphs',description='Feature to create link graphs of communications (calls, messages, emails...) Optionally it can create entities and links based on nearby regex hits (experimental). It could be enabled in conf/GraphConfig.json'),
                w11.Win11Checkbox(key='IPEDConfig_entropyTest',label='Entropy tests',description='Perform test for randomness of binary items and unknown file types. This is used to detect possible encrypted items. Also makes indexing faster and reduces index size, specially when indexing unallocated space. May cause loss of hits surrounded by "random" content.'),
                w11.Win11Checkbox(key='IPEDConfig_indexFileContents',label='Index file contents',description='If disabled, indexes only the properties of files.'),
                w11.Win11Checkbox(key='IPEDConfig_enableIndexToElasticSearch',label='ElasticSearch indexing',description='Enables indexing to an ElasticSearch/OpenSearch cluster. You must configure at least host/port options in conf/ElasticSearchConfig.txt'),
                w11.Win11Checkbox(key='IPEDConfig_enableMinIO',label='MinIO export',description='Enable exporting files to MinIO object storage cluster. You must configure at least host/port options in conf/MinIOConfig.txt'),
                w11.Win11Checkbox(key='IPEDConfig_enableAudioTranscription',label='Audio transcription',description="[Deprecated] Enable audio transcription. Default implementation uses VOSK transcription [EXPERIMENTAL] on local CPU (slow and medium quality). We include Vosk portable models for 'en' and 'pt-BR', the lang model is taken from 'locale' in LocalConfig.txt. You can change it from Vosk to Microsoft Azure or Google Cloud services (faster and better quality). Configure it in conf/AudioTranscriptConfig.txt"),
                w11.Win11Checkbox(key='IPEDConfig_enableCarving',label='Enable carving',description='Enables carving. "addUnallocated" must be enabled to unallocated area be searched. By default carving runs on almost every item in the case. File types to be searched and retrieved can be set in file "conf/CarvingConfig.txt"'),
                w11.Win11Checkbox(key='IPEDConfig_enableLedCarving',label='Carve files known in LED database',description='Enables carving that retrieves known files from the LED base, based on the beginning (64K) of the file. It\'s necessary to enable "addUnallocated" and to configure "hashesDB" (with LED hashes data imported).'),
                w11.Win11Checkbox(key='IPEDConfig_enableKnownMetCarving',label='e-Mule carving',description='Enables specific carving of e-Mule "known.met" files. "addUnallocated" must be enabled.'),
                w11.Win11Checkbox(key='IPEDConfig_enableImageThumbs',label='Image thumbnails',description='Enables the generation of images thumbnails during processing. It can slow down processing, but strongly speeds up image preview in the gallery'),
                w11.Win11Checkbox(key='IPEDConfig_enableImageSimilarity',label='Image similarity',description='Enables the generation of images features during processing, allowing the search for visually similar images. "enableImageThumbs" must be enabled.'),
                w11.Win11Checkbox(key='IPEDConfig_enableFaceRecognition',label='Face recognition',description='Enables face recognition feature. You may install python and some dependencies, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#facerecognition. Advanced configuration options can be found in conf/FaceRecognitionConfig.txt. If enabled, you can search for faces from the analysis interface, check the options menu.'),
                w11.Win11Checkbox(key='IPEDConfig_enableVideoThumbs',label='Video thumbnails',description='Enables extraction of image frames from video files. Extraction settings can be modified in file "conf/VideoThumbsConfig.txt"'),
                w11.Win11Checkbox(key='IPEDConfig_enableDocThumbs',label='Document thumbnails',description='[Experimental] Enables thumbnail creation for PDFs and many formats supported by LibreOffice. Advanced configurations can be found at conf/DocThumbsConfig.txt.'),
                w11.Win11Checkbox(key='IPEDConfig_enableHTMLReport',label='HTML report',description='Enables HTML report generation on automatic extractions or from selected items. Generation settings can be modified in file "conf/HTMLReportConfig.txt"'),
                w11.Win11Checkbox(key='IPEDConfig_enableAudioTranslation',label='Audio translation',description='Transcribes and translates all audio and video files using Faster-Whisper and Argos-Translate'),
                w11.Win11Checkbox(key='IPEDConfig_enableImageClassification',label='Image classification',description='Classifies the content of images into 70 different classes using TensorFlow and Keras.'),
            ]),
        ],
    ])

def createTaskTab():
    return sg.Tab(title='Tasks', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.SkipCommitedTask',label='Skip already commited files',description='Task to ignore already commited files into index. Commited containers without all their subitems commited are not ignored to be processed again. Redefines ids and parentIds of incomming items to be equal of commited items if they have same trackID.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.IgnoreHardLinkTask',label='Ignore hard links',description='Labels hard links so that they are ignored while hashing in HashTask'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.TempFileTask',label='Create temporary files',description='Task for generating temporary files for items before processing. If indexTemp is on an SSD disk and the image is compressed (e01), it can considerably increase performance as items are no longer decompressed multiple times by libewf, which is not thread safe and synchronizes concurrent decompressions, underutilizing multiprocessing machines.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.HashTask',label='Calculate hashes',description='Task for calculating and manipulating hashes.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.SignatureTask',label='Analyze signatures',description='Signature analysis using Apache Tika library.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.SetTypeTask',label='Media type detection',description='Sets the type (correct extension) of items based on their recognized mediaType.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.SetCategoryTask',label='Define item category',description='Class that carries the mapping of mimeTypes to Application Category. Additionally, it uses JavaScript rules to define categories based on item properties. It is also responsible for defining the item category.'),
                w11.Win11Checkbox(key='TaskInstaller_RefineCategoryTask.js',label='Refine item category',description='Task of Category Specialization based on item properties. Uses javascript language to allow flexibility in definitions.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.HashDBLookupTask',label='Hash DB Lookup',description='Checks whether an item is contained in the hash database and marks it as to be ignored in further processing.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.DuplicateTask',label='Handle duplicates',description='Duplicate files check task. Ignores the configured case file.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.transcript.AudioTranscriptTask',label='Audio transcription',description='Performs transcription of audio files. Please use Audio translation instead.'),
                w11.Win11Checkbox(key='TaskInstaller_AudioTranslateTask.py',label='Audio translation',description='Transcribes media files (audio and video), detects the spoken language and translates the text into english and german.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.video.VideoThumbTask',label='Generate video thumbnails',description='Image generation task with thumbnails (thumbs) of scenes extracted from video files.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.ParsingTask',label='Parse for text',description='Parsing task for some types of files. Stores the extracted text, if small, for reuse during indexing, so the file is not decoded again. Parsing is executed in another thread, making it possible to monitor and recover from hangs, etc. Parsing is performed in the following cases: - Container type items, for extraction of subitems. - Carving items to ignore corrupted if indexing is disabled. - Categories that may contain encrypted items, so that they can be added to the specific category. Parsing of other items is performed during indexing, so large items do not have their extracted text stored in memory, which could cause boom.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.QRCodeTask',label='QR Code detection',description='Detect QR codes in images and extract their textual content.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.regex.RegexTask',label='Regular expressions',description='Searches the extracted text of items for content matching regular expressions'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.LanguageDetectTask',label='Language detection',description='Determines the main language of texts in items'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.NamedEntityTask',label='Named entities',description='Detect named entities in item texts'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.ExportFileTask',label='Export files',description='Responsible for extracting subitems from containers. It also exports active items in cases of automatic data extraction or in cases of extracting selected items after analysis.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.EmbeddedDiskProcessTask',label='Process embedded disks',description='Process content of images (RAW, EWF, EWF2, VMDK) recursively.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.MakePreviewTask',label='Make preview',description='Creates HTML previews of supported file types like SQLite databases, WhatsApp chats of Firefox history.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.ImageThumbTask',label='Image Thumbnails',description='Create thumbnails of images'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.die.DIETask',label='Explicit image detection',description='Detects explicit images by rating the nudity score'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.similarity.ImageSimilarityTask',label='Image similarity',description='Extract features of images for later similarity comparison'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.PhotoDNATask',label='Photo DNA calculation',description='Calculates PhotoDNA features for images'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.PhotoDNALookup',label='Photo DNA Lookup',description='Lookup for previously calculated PhotoDNA features in PhotoDNA hash database'),
                w11.Win11Checkbox(key='TaskInstaller_NSFWNudityDetectTask.py',label='NSFW Nudity detection',description='Nudity detection based on yahoo open_nsfw algorithm.'),
                w11.Win11Checkbox(key='TaskInstaller_ImageClassificationTask.py',label='Image classification',description='Classifies images into 70 classes based on Tensorflow and Keras'),
                w11.Win11Checkbox(key='TaskInstaller_FaceRecognitionTask.py',label='Face recognition',description='Detects and identifies faces in images. The faces can afterwards be compared to each other to find images with similar faces.'),
                w11.Win11Checkbox(key='TaskInstaller_SearchHardwareWallets.py',label='Search for hardware wallets',description='Looks for clues about crypto hardwares wallets. Searches the system registry and the setupapi.dev.[0-9_]log file. The ID\'s for the wallets come from Interpol (https://github.com/INTERPOL-Innovation-Centre/HardwareWallets_DF_List).'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.carver.LedCarveTask',label='LED carving',description='Carve files known in LED database'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.carver.CarverTask',label='Data carving',description='Task responsible for Data Carving. It uses the aho-corasick algorithm, which generates a state machine from the patterns to be searched. Thus, the algorithm is independent of the number of signatures searched, being proportional to the volume of input data and the number of patterns discovered.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.carver.KnownMetCarveTask',label='e-Mule carving',description='Specific task for carving e-Mule known.met files.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.FragmentLargeBinaryTask',label='Fragment large binaries',description='Breaks large binary files (indexed by strings) into smaller pieces to be indexed.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.EntropyTask',label='Compression entropy',description='Calculates the compression ratio of compressed files'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.MinIOTask',label='MinIO export',description='Task to export files to MinIO object storage service.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.index.ElasticSearchIndexTask',label='ElasticSearch indexing',description='Performs indexing to ElasticSearch/OpenSearch clusters.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.index.IndexTask',label='Index items',description='Item indexing task. Indexes only properties if content indexing is disabled. Reuses the text of items if it was extracted by previous tasks. Indexes large items by dividing them into fragments, as the indexing lib consumes a lot of memory with large documents.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.graph.GraphTask',label='Generate graph',description='Generate links graphs of communication and nearby regex hits'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.ExportCSVTask',label='Export CSV overview',description='Responsible for generating CSV file with the properties of the processed items.'),
                w11.Win11Checkbox(key='TaskInstaller_iped.engine.task.HTMLReportTask',label='HTML report',description='Report generation task in HTML format for selected items, generated when the processing input is an ".IPED" file. Must be active on first generation to make the templates available in further exports.'),
            ]),
        ]
    ])

def createmainform(version):
    layout = [
        [
            sg.TabGroup(expand_x=True, expand_y=True, layout=[
                [
                    createHomeTab(),
                    createEnvironmentTab(),
                    createProcessingTab(),
                    createTaskTab(),
                    createConfigTab(),
                ]
            ])
        ],
    ]
    window = sg.Window(title="IPED GUI - " + version, layout=layout, size=(1000,700), resizable=True, element_justification="center", finalize=True)
    return window