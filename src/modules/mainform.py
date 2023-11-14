import PySimpleGUI as sg

def Win11Checkbox(key, label, description):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Text(text=description,text_color='#666666',size=(100,None)) ]
                    ]),
                    sg.Push(),
                    sg.Checkbox(text='',key=key,enable_events=True,default=sg.user_settings_get_entry(key, False))
                ]
            ]
        )
    ]

def Win11Combo(key, label, description, values, default_value):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Text(text=description,text_color='#666666',size=(80,None)) ]
                    ]),
                    sg.Push(),
                    sg.Combo(key=key,values=values,enable_events=True,default_value=sg.user_settings_get_entry(key, default_value))
                ]
            ]
        )
    ]

def Win11FileChooser(key, label, description):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Input(key=key,default_text=sg.user_settings_get_entry(key, ''),expand_x=True,readonly=True,enable_events=True)],
                        [ sg.Text(text=description,text_color='#666666',size=(80,None)) ]
                    ]),
                    sg.Push(),
                    sg.FileBrowse(button_text='Select file ...',target=key)
                ]
            ]
        )
    ]

def Win11FolderChooser(key, label, description):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Input(key=key,default_text=sg.user_settings_get_entry(key, ''),expand_x=True,readonly=True,enable_events=True)],
                        [ sg.Text(text=description,text_color='#666666',size=(80,None)) ]
                    ]),
                    sg.Push(),
                    sg.FolderBrowse(button_text='Select folder ...',target=key)
                ]
            ]
        )
    ]

def Win11Input(key, label, description, width=None):
    return [
        sg.Frame(
            title='',
            expand_x=True,
            layout=[
                [
                    sg.Column(layout=[
                        [ sg.Text(text=label,font='bold') ],
                        [ sg.Text(text=description,text_color='#666666',size=(100,None)) ]
                    ]),
                    sg.Push(),
                    sg.Input(key=key,enable_events=True,default_text=sg.user_settings_get_entry(key,''),size=(width,None))
                ]
            ]
        )
    ]

def createHomeTab():
    return sg.Tab(title='Home', layout=[
    ])

def createEnvironmentTab():
    return sg.Tab(title='Environment', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                Win11Combo(key='locale',label='Program language',description="Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'",values=['en', 'pt-BR', 'it-IT', 'de-DE', 'es-AR'],default_value='de-DE'),
                Win11FolderChooser(key='indexTemp',label='Temporary directory for processing',description='Configure it on a folder free of antivirus, system indexing or restoring. Using a SSD disk is highly recommended.'),
                Win11Checkbox(key='indexTempOnSSD', label='Temporary directory is on SSD', description='Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you will have performance problems.'),
                Win11Checkbox(key='outputOnSSD', label='Output directory is on SSD', description='Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp folder.'),
                Win11Input(key='numThreads',label='Number of processing threads/workers',description='"default" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms).',width=8),
                Win11FileChooser(key='hashesDB',label='Hash database',description='Full path for IPED hash database. It is highly recommended to store it on a fast disk, preferably SSD, and not the same used as "indexTemp", if other disk is available.'),
                Win11FolderChooser(key='pluginFolder',label='Plugin folder',description='Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime.'),
            ]),
        ],
    ])

def createProcessingTab():
    return sg.Tab(title='Processing', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                Win11Checkbox(key='enableHash',label='Create file Hashes',description='Enables file hashes calculation.'),
                Win11Checkbox(key='enablePhotoDNA',label='Create PhotoDNA Hashes',description='Enables photoDNA hash calculation. If you have rights to use it (law enforcement that fight against child exploitation) and have received the library, you must put it into plugins folder'),
                Win11Checkbox(key='enableHashDBLookup',label='Lookup hashes',description='Enables hash lookup on IPED database.'),
                Win11Checkbox(key='enablePhotoDNALookup',label='Lookup PhotoDNA hashes',description='Enables photoDNA lookup on IPED hash database.'),
                Win11Checkbox(key='enableLedDie',label='Nudity detection',description='Enables nudity detection. For each image it creates attributes "nudityScore" (1 to 1000) and "nudityClass" (1 to 5) for ranking and/or filtering.'),
                Win11Checkbox(key='enableYahooNSFWDetection',label='Nudity detection via Yahoo OpenNSFW',description='[Experimental] Enables nudity detection using Yahoo OpenNSFW deeplearning algorithm. You may install python and some dependencies to enable it, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#python-modules. This is more than 1 order of magnitude slower than LedDie algorithm on the CPU, using a good GPU is highly recommended. It gives higher scores than LedDie algorithm for images/videos with genitals or explicit sex, mainly because of training dataset differences. An attribute nsfw_nudity_score from 0 to 100 will be created.'),
                Win11Checkbox(key='enableQRCode',label='QR Code detection',description='Enables QRcode detection and decoding'),
                Win11Checkbox(key='ignoreDuplicates',label='Ignore duplicates',description='Ignore and exclude duplicated files with same hash from the processing and from the case. WARNING: This feature is inherently DANGEROUS, as it could exclude from the case duplicated files with different metadata (name, path, dates) like email attachments or files in relevant folders. See #574 and #931.'),
                Win11Checkbox(key='exportFileProps',label='Export file properties',description='Exports the properties of all files in the case to file "Lista de Arquivos.csv"'),
                Win11Checkbox(key='processFileSignatures',label='Process file signatures',description='Processes the signatures of files'),
                Win11Checkbox(key='enableFileParsing',label='Parse file contents',description="Enables parsing of files contents. It's necessary for several functions like containers expansion, detection of encrypted content, metadata indexing, previews generation, etc."),
                Win11Checkbox(key='expandContainers',label='Expand containers',description='Expands containers, like compressed files, e-mail boxes, emails e MS-Office documents. File types to be expanded can be modified in file "conf/CategoriesToExpand.txt"'),
                Win11Checkbox(key='processEmbeddedDisks',label='Process embedded disks',description='Process supported disk images (like dd, e01, vhd, vmdk) contained in the main evidence recursively. Splitted images and snapshots are not supported for now.'),
                Win11Checkbox(key='enableRegexSearch',label='Regular expressions',description='Searches texts extracted from items by regular expressions like social numbers, emails, URLs, credit cards, money values, etc. New expressions can be configured in file "conf/RegexConfig.txt"'),
                Win11Checkbox(key='enableAutomaticExportFiles',label='Automatic file export',description='Enables automatic file exporting to case folder based on categories or keywords. If enabled, just the exported files are included in case, others are ignored, and the case becomes datasource independent. Relevant categories and keywords can be configured in CategoriesToExport.txt and KeywordsToExport.txt.'),
                Win11Checkbox(key='enableLanguageDetect',label='Language detection',description='Enables detection of more than 70 idioms in document files.'),
                Win11Checkbox(key='enableNamedEntityRecogniton',label='Recognize named entities',description='Feature to recognize named entities: people, organizations or places. StanfordCoreNLP 3.8 language models must be downloaded from https://stanfordnlp.github.io/CoreNLP/history.html and put in plugins folder. This feature is CPU heavy, it can increase processing time by 4x. Advanced settings can be modified in "conf/NamedEntityRecognitionConfig.txt" file.'),
                Win11Checkbox(key='enableGraphGeneration',label='Generate graphs',description='Feature to create link graphs of communications (calls, messages, emails...) Optionally it can create entities and links based on nearby regex hits (experimental). It could be enabled in conf/GraphConfig.json'),
                Win11Checkbox(key='entropyTest',label='Entropy tests',description='Perform test for randomness of binary items and unknown file types. This is used to detect possible encrypted items. Also makes indexing faster and reduces index size, specially when indexing unallocated space. May cause loss of hits surrounded by "random" content.'),
                Win11Checkbox(key='indexFileContents',label='Index file contents',description='If disabled, indexes only the properties of files.'),
                Win11Checkbox(key='enableIndexToElasticSearch',label='ElasticSearch indexing',description='Enables indexing to an ElasticSearch/OpenSearch cluster. You must configure at least host/port options in conf/ElasticSearchConfig.txt'),
                Win11Checkbox(key='enableMinIO',label='MinIO export',description='Enable exporting files to MinIO object storage cluster. You must configure at least host/port options in conf/MinIOConfig.txt'),
                Win11Checkbox(key='enableAudioTranscription',label='Audio transcription',description="[Deprecated] Enable audio transcription. Default implementation uses VOSK transcription [EXPERIMENTAL] on local CPU (slow and medium quality). We include Vosk portable models for 'en' and 'pt-BR', the lang model is taken from 'locale' in LocalConfig.txt. You can change it from Vosk to Microsoft Azure or Google Cloud services (faster and better quality). Configure it in conf/AudioTranscriptConfig.txt"),
                Win11Checkbox(key='enableCarving',label='Enable carving',description='Enables carving. "addUnallocated" must be enabled to unallocated area be searched. By default carving runs on almost every item in the case. File types to be searched and retrieved can be set in file "conf/CarvingConfig.txt"'),
                Win11Checkbox(key='enableLedCarving',label='Carve files known in LED database',description='Enables carving that retrieves known files from the LED base, based on the beginning (64K) of the file. It\'s necessary to enable "addUnallocated" and to configure "hashesDB" (with LED hashes data imported).'),
                Win11Checkbox(key='enableKnownMetCarving',label='e-Mule carving',description='Enables specific carving of e-Mule "known.met" files. "addUnallocated" must be enabled.'),
                Win11Checkbox(key='enableImageThumbs',label='Image thumbnails',description='Enables the generation of images thumbnails during processing. It can slow down processing, but strongly speeds up image preview in the gallery'),
                Win11Checkbox(key='enableImageSimilarity',label='Image similarity',description='Enables the generation of images features during processing, allowing the search for visually similar images. "enableImageThumbs" must be enabled.'),
                Win11Checkbox(key='enableFaceRecognition',label='Face recognition',description='Enables face recognition feature. You may install python and some dependencies, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#facerecognition. Advanced configuration options can be found in conf/FaceRecognitionConfig.txt. If enabled, you can search for faces from the analysis interface, check the options menu.'),
                Win11Checkbox(key='enableVideoThumbs',label='Video thumbnails',description='Enables extraction of image frames from video files. Extraction settings can be modified in file "conf/VideoThumbsConfig.txt"'),
                Win11Checkbox(key='enableDocThumbs',label='Document thumbnails',description='[Experimental] Enables thumbnail creation for PDFs and many formats supported by LibreOffice. Advanced configurations can be found at conf/DocThumbsConfig.txt.'),
                Win11Checkbox(key='enableHTMLReport',label='HTML report',description='Enables HTML report generation on automatic extractions or from selected items. Generation settings can be modified in file "conf/HTMLReportConfig.txt"'),
                Win11Checkbox(key='enableAudioTranslation',label='Audio translation',description='Transcribes and translates all audio and video files using Faster-Whisper and Argos-Translate'),
                Win11Checkbox(key='enableImageClassification',label='Image classification',description='Classifies the content of images into 70 different classes using TensorFlow and Keras.'),
            ]),
        ],
    ])

def createTaskTab():
    return sg.Tab(title='Tasks', layout=[
        [
            sg.Column(expand_x=True,expand_y=True,scrollable=True,vertical_scroll_only=True,layout=[
                Win11Checkbox(key='iped.engine.task.SkipCommitedTask',label='Skip already commited files',description='Task to ignore already commited files into index. Commited containers without all their subitems commited are not ignored to be processed again. Redefines ids and parentIds of incomming items to be equal of commited items if they have same trackID.'),
                Win11Checkbox(key='iped.engine.task.IgnoreHardLinkTask',label='Ignore hard links',description='Labels hard links so that they are ignored while hashing in HashTask'),
                Win11Checkbox(key='iped.engine.task.TempFileTask',label='Create temporary files',description='Task for generating temporary files for items before processing. If indexTemp is on an SSD disk and the image is compressed (e01), it can considerably increase performance as items are no longer decompressed multiple times by libewf, which is not thread safe and synchronizes concurrent decompressions, underutilizing multiprocessing machines.'),
                Win11Checkbox(key='iped.engine.task.HashTask',label='Calculate hashes',description='Task for calculating and manipulating hashes.'),
                Win11Checkbox(key='iped.engine.task.SignatureTask',label='Analyze signatures',description='Signature analysis using Apache Tika library.'),
                Win11Checkbox(key='iped.engine.task.SetTypeTask',label='Media type detection',description='Sets the type (correct extension) of items based on their recognized mediaType.'),
                Win11Checkbox(key='iped.engine.task.SetCategoryTask',label='Define item category',description='Class that carries the mapping of mimeTypes to Application Category. Additionally, it uses JavaScript rules to define categories based on item properties. It is also responsible for defining the item category.'),
                Win11Checkbox(key='RefineCategoryTask.js',label='Refine item category',description='Task of Category Specialization based on item properties. Uses javascript language to allow flexibility in definitions.'),
                Win11Checkbox(key='iped.engine.task.HashDBLookupTask',label='Hash DB Lookup',description='Checks whether an item is contained in the hash database and marks it as to be ignored in further processing.'),
                Win11Checkbox(key='iped.engine.task.DuplicateTask',label='Handle duplicates',description='Duplicate files check task. Ignores the configured case file.'),
                Win11Checkbox(key='iped.engine.task.transcript.AudioTranscriptTask',label='Audio transcription',description='Performs transcription of audio files. Please use Audio translation instead.'),
                Win11Checkbox(key='AudioTranslateTask.py',label='Audio translation',description='Transcribes media files (audio and video), detects the spoken language and translates the text into english and german.'),
                Win11Checkbox(key='iped.engine.task.video.VideoThumbTask',label='Generate video thumbnails',description='Image generation task with thumbnails (thumbs) of scenes extracted from video files.'),
                Win11Checkbox(key='iped.engine.task.ParsingTask',label='Parse for text',description='Parsing task for some types of files. Stores the extracted text, if small, for reuse during indexing, so the file is not decoded again. Parsing is executed in another thread, making it possible to monitor and recover from hangs, etc. Parsing is performed in the following cases: - Container type items, for extraction of subitems. - Carving items to ignore corrupted if indexing is disabled. - Categories that may contain encrypted items, so that they can be added to the specific category. Parsing of other items is performed during indexing, so large items do not have their extracted text stored in memory, which could cause boom.'),
                Win11Checkbox(key='iped.engine.task.QRCodeTask',label='QR Code detection',description='Detect QR codes in images and extract their textual content.'),
                Win11Checkbox(key='iped.engine.task.regex.RegexTask',label='Regular expressions',description='Searches the extracted text of items for content matching regular expressions'),
                Win11Checkbox(key='iped.engine.task.LanguageDetectTask',label='Language detection',description='Determines the main language of texts in items'),
                Win11Checkbox(key='iped.engine.task.NamedEntityTask',label='Named entities',description='Detect named entities in item texts'),
                Win11Checkbox(key='iped.engine.task.ExportFileTask',label='Export files',description='Responsible for extracting subitems from containers. It also exports active items in cases of automatic data extraction or in cases of extracting selected items after analysis.'),
                Win11Checkbox(key='iped.engine.task.EmbeddedDiskProcessTask',label='Process embedded disks',description='Process content of images (RAW, EWF, EWF2, VMDK) recursively.'),
                Win11Checkbox(key='iped.engine.task.MakePreviewTask',label='Make preview',description='Creates HTML previews of supported file types like SQLite databases, WhatsApp chats of Firefox history.'),
                Win11Checkbox(key='iped.engine.task.ImageThumbTask',label='Image Thumbnails',description='Create thumbnails of images'),
                Win11Checkbox(key='iped.engine.task.die.DIETask',label='Explicit image detection',description='Detects explicit images by rating the nudity score'),
                Win11Checkbox(key='iped.engine.task.similarity.ImageSimilarityTask',label='Image similarity',description='Extract features of images for later similarity comparison'),
                Win11Checkbox(key='iped.engine.task.PhotoDNATask',label='Photo DNA calculation',description='Calculates PhotoDNA features for images'),
                Win11Checkbox(key='iped.engine.task.PhotoDNALookup',label='Photo DNA Lookup',description='Lookup for previously calculated PhotoDNA features in PhotoDNA hash database'),
                Win11Checkbox(key='NSFWNudityDetectTask.py',label='NSFW Nudity detection',description='Nudity detection based on yahoo open_nsfw algorithm.'),
                Win11Checkbox(key='ImageClassificationTask.py',label='Image classification',description='Classifies images into 70 classes based on Tensorflow and Keras'),
                Win11Checkbox(key='FaceRecognitionTask.py',label='Face recognition',description='Detects and identifies faces in images. The faces can afterwards be compared to each other to find images with similar faces.'),
                Win11Checkbox(key='SearchHardwareWallets.py',label='Search for hardware wallets',description='Looks for clues about crypto hardwares wallets. Searches the system registry and the setupapi.dev.[0-9_]log file. The ID\'s for the wallets come from Interpol (https://github.com/INTERPOL-Innovation-Centre/HardwareWallets_DF_List).'),
                Win11Checkbox(key='iped.engine.task.carver.LedCarveTask',label='LED carving',description='Carve files known in LED database'),
                Win11Checkbox(key='iped.engine.task.carver.CarverTask',label='Data carving',description='Task responsible for Data Carving. It uses the aho-corasick algorithm, which generates a state machine from the patterns to be searched. Thus, the algorithm is independent of the number of signatures searched, being proportional to the volume of input data and the number of patterns discovered.'),
                Win11Checkbox(key='iped.engine.task.carver.KnownMetCarveTask',label='e-Mule carving',description='Specific task for carving e-Mule known.met files.'),
                Win11Checkbox(key='iped.engine.task.FragmentLargeBinaryTask',label='Fragment large binaries',description='Breaks large binary files (indexed by strings) into smaller pieces to be indexed.'),
                Win11Checkbox(key='iped.engine.task.EntropyTask',label='Compression entropy',description='Calculates the compression ratio of compressed files'),
                Win11Checkbox(key='iped.engine.task.MinIOTask',label='MinIO export',description='Task to export files to MinIO object storage service.'),
                Win11Checkbox(key='iped.engine.task.index.ElasticSearchIndexTask',label='ElasticSearch indexing',description='Performs indexing to ElasticSearch/OpenSearch clusters.'),
                Win11Checkbox(key='iped.engine.task.index.IndexTask',label='Index items',description='Item indexing task. Indexes only properties if content indexing is disabled. Reuses the text of items if it was extracted by previous tasks. Indexes large items by dividing them into fragments, as the indexing lib consumes a lot of memory with large documents.'),
                Win11Checkbox(key='iped.engine.graph.GraphTask',label='Generate graph',description='Generate links graphs of communication and nearby regex hits'),
                Win11Checkbox(key='iped.engine.task.ExportCSVTask',label='Export CSV overview',description='Responsible for generating CSV file with the properties of the processed items.'),
                Win11Checkbox(key='iped.engine.task.HTMLReportTask',label='HTML report',description='Report generation task in HTML format for selected items, generated when the processing input is an ".IPED" file. Must be active on first generation to make the templates available in further exports.'),
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
                    createTaskTab()
                ]
            ])
        ],
    ]
    window = sg.Window(title="Transkription und Übersetzung - " + version, layout=layout, size=(1000,700), resizable=True, element_justification="center", finalize=True)
    return window