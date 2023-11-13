import PySimpleGUI as sg
import modules.config as cfg

def createCheckBox(section, parameter, label, tooltip):
    return [
        sg.Text(text=label, size=(25,1), tooltip=tooltip),
        sg.Checkbox(key=section + '-' + parameter, text='', default=(cfg.getConfig(section, parameter, 'False') == 'True'), enable_events=True)
    ]

def createTwoCheckBoxes(section1, parameter1, label1, tooltip1, section2, parameter2, label2, tooltip2):
    return [
        sg.Text(text=label1, size=(25,1), tooltip=tooltip1),
        sg.Checkbox(key=section1 + '-' + parameter1, text='', default=(cfg.getConfig(section1, parameter1, 'False') == 'True'), enable_events=True),
        sg.Text(text=label2, size=(25,1), tooltip=tooltip2),
        sg.Checkbox(key=section2 + '-' + parameter2, text='', default=(cfg.getConfig(section2, parameter2, 'False') == 'True'), enable_events=True),
    ]

def createHomeTab():
    return sg.Tab(title='Home', layout=[[]])

def createEnvironmentTab():
    return sg.Tab(title='Environment', layout=[
        [
            sg.Text(text='locale', size=(25,1), tooltip="Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'"),
            sg.Combo(key='environment-locale', values=['en', 'pt-BR', 'it-IT', 'de-DE', 'es-AR'], default_value=cfg.getConfig('environment', 'locale', 'de-DE'), enable_events=True)
        ],
        [
            sg.Text(text='indexTemp', size=(25,1), tooltip='Temporary directory for processing: "default" uses the system temporary folder. Configure it on a folder free of antivirus, system indexing or restoring. Using a SSD disk is highly recommended.'),
            sg.Input(key='environment-indextemp', default_text=cfg.getConfig('environment', 'indextemp', ''), readonly=True, enable_events=True),
            sg.FolderBrowse(button_text='Choose folder ...', target='environment-indextemp')
        ],
        createCheckBox(section='environment', parameter='indextemponssd', label='indexTempOnSSD', tooltip='Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you will have performance problems.'),
        createCheckBox(section='environment', parameter='outputonssd', label='outputOnSSD', tooltip='Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp folder.'),
        [
            sg.Text(text='numThreads', size=(25,1), tooltip='Number of processing threads/workers: "default" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms).'),
            sg.Input(key='environment-numthreads', default_text=cfg.getConfig('environment', 'numthreads', 'default'), enable_events=True)
        ],
        [
            sg.Text(text='hashesDB', size=(25,1), tooltip='Full path for IPED hash database. It is highly recommended to store it on a fast disk,  preferably SSD, and not the same used as "indexTemp", if other disk is available.'),
            sg.Input(key='environment-hashesdb', default_text=cfg.getConfig('environment', 'hashesdb', ''), enable_events=True),
            sg.FileBrowse(button_text='Select file ...', target='environment-hashesdb')
        ],
        [
            sg.Text(text='pluginFolder', size=(25,1), tooltip='Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime.'),
            sg.Input(key='environment-pluginfolder', default_text=cfg.getConfig('environment', 'pluginfolder', ''), enable_events=True),
            sg.FolderBrowse(button_text='Choose folder ...', target='environment-pluginfolder')
        ],
    ])

def createProcessingTab():
    return sg.Tab(title='Processing', layout=[
        createTwoCheckBoxes(section1='processing', parameter1='enablehash', label1='enableHash', tooltip1='Enables file hashes calculation.', section2='processing', parameter2='enablephotodna', label2='enablePhotoDNA', tooltip2='Enables photoDNA hash calculation. If you have rights to use it (law enforcement that fight against child exploitation) and have received the library, you must put it into plugins folder'),
        createTwoCheckBoxes(section1='processing', parameter1='enablehashdblookup', label1='enableHashDBLookup', tooltip1='Enables hash lookup on IPED database.', section2='processing', parameter2='enablephotodnalookup', label2='enablePhotoDNALookup', tooltip2='Enables photoDNA lookup on IPED hash database.'),
        createTwoCheckBoxes(section1='processing', parameter1='enableleddie', label1='enableLedDie', tooltip1='Enables nudity detection. For each image it creates attributes "nudityScore" (1 to 1000) and "nudityClass" (1 to 5) for ranking and/or filtering.', section2='processing', parameter2='enableyahoonsfwdetection', label2='enableYahooNSFWDetection', tooltip2='[Experimental] Enables nudity detection using Yahoo OpenNSFW deeplearning algorithm. You may install python and some dependencies to enable it, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#python-modules This is more than 1 order of magnitude slower than LedDie algorithm on the CPU, using a good GPU is highly recommended. It gives higher scores than LedDie algorithm for images/videos with genitals or explicit sex, mainly because of training dataset differences. An attribute nsfw_nudity_score from 0 to 100 will be created.'),
        createTwoCheckBoxes(section1='processing', parameter1='enableqrcode', label1='enableQRCode', tooltip1='Enables QRcode detection and decoding', section2='processing', parameter2='ignoreduplicates', label2='ignoreDuplicates', tooltip2='Ignore and exclude duplicated files with same hash from the processing and from the case. WARNING: This feature is inherently DANGEROUS, as it could exclude from the case duplicated files with different metadata (name, path, dates) like email attachments or files in relevant folders. See #574 and #931.'),
        createTwoCheckBoxes(section1='processing', parameter1='exportfileprops', label1='exportFileProps', tooltip1='Exports the properties of all files in the case to file "Lista de Arquivos.csv"', section2='processing', parameter2='processfilesignatures', label2='processFileSignatures', tooltip2='Processes the signatures of files'),
        createTwoCheckBoxes(section1='processing', parameter1='enablefileparsing', label1='enableFileParsing', tooltip1="Enables parsing of files contents. It's necessary for several functions like containers expansion, detection of encrypted content, metadata indexing, previews generation, etc.", section2='processing', parameter2='expandcontainers', label2='expandContainers', tooltip2='Expands containers, like compressed files, e-mail boxes, emails e MS-Office documents. File types to be expanded can be modified in file "conf/CategoriesToExpand.txt"'),
        createTwoCheckBoxes(section1='processing', parameter1='processembeddeddisks', label1='processEmbeddedDisks', tooltip1='Process supported disk images (like dd, e01, vhd, vmdk) contained in the main evidence recursively. Splitted images and snapshots are not supported for now.', section2='processing', parameter2='enableregexsearch', label2='enableRegexSearch', tooltip2='Searches texts extracted from items by regular expressions like social numbers, emails, URLs, credit cards, money values, etc. New expressions can be configured in file "conf/RegexConfig.txt"'),
        createTwoCheckBoxes(section1='processing', parameter1='enableautomaticexportfiles', label1='enableAutomaticExportFiles', tooltip1='Enables automatic file exporting to case folder based on categories or keywords. If enabled, just the exported files are included in case, others are ignored, and the case becomes datasource independent. Relevant categories and keywords can be configured in CategoriesToExport.txt and KeywordsToExport.txt.', section2='processing', parameter2='enablelanguagedetect', label2='enableLanguageDetect', tooltip2='Enables detection of more than 70 idioms in document files.'),
        createTwoCheckBoxes(section1='processing', parameter1='enablenamedentityrecogniton', label1='enableNamedEntityRecogniton', tooltip1='Feature to recognize named entities: people, organizations or places. StanfordCoreNLP 3.8 language models must be downloaded from https://stanfordnlp.github.io/CoreNLP/history.html and put in plugins folder. This feature is CPU heavy, it can increase processing time by 4x. Advanced settings can be modified in "conf/NamedEntityRecognitionConfig.txt" file.', section2='processing', parameter2='enablegraphgeneration', label2='enableGraphGeneration', tooltip2='Feature to create link graphs of communications (calls, messages, emails...) Optionally it can create entities and links based on nearby regex hits (experimental). It could be enabled in conf/GraphConfig.json'),
        createTwoCheckBoxes(section1='processing', parameter1='entropytest', label1='entropyTest', tooltip1='Perform test for randomness of binary items and unknown file types. This is used to detect possible encrypted items. Also makes indexing faster and reduces index size, specially when indexing unallocated space. May cause loss of hits surrounded by "random" content.', section2='processing', parameter2='indexfilecontents', label2='indexFileContents', tooltip2='Indexes files contents. If disabled, indexes only the properties of files.'),
        createTwoCheckBoxes(section1='processing', parameter1='enableindextoelasticsearch', label1='enableIndexToElasticSearch', tooltip1='Enables indexing to an ElasticSearch/OpenSearch cluster. You must configure at least host/port options in conf/ElasticSearchConfig.txt', section2='processing', parameter2='enableminio', label2='enableMinIO', tooltip2='Enable exporting files to MinIO object storage cluster. You must configure at least host/port options in conf/MinIOConfig.txt'),
        createTwoCheckBoxes(section1='processing', parameter1='enableaudiotranscription', label1='enableAudioTranscription', tooltip1="Enable audio transcription. Default implementation uses VOSK transcription [EXPERIMENTAL] on local CPU (slow and medium quality). We include Vosk portable models for 'en' and 'pt-BR', the lang model is taken from 'locale' in LocalConfig.txt. You can change it from Vosk to Microsoft Azure or Google Cloud services (faster and better quality). Configure it in conf/AudioTranscriptConfig.txt", section2='processing', parameter2='enablecarving', label2='enableCarving', tooltip2='Enables carving. "addUnallocated" must be enabled to unallocated area be searched. By default carving runs on almost every item in the case. File types to be searched and retrieved can be set in file "conf/CarvingConfig.txt"'),
        createTwoCheckBoxes(section1='processing', parameter1='enableledcarving', label1='enableLedCarving', tooltip1='Enables carving that retrieves known files from the LED base, based on the beginning (64K) of the file. It\'s necessary to enable "addUnallocated" and to configure "hashesDB" (with LED hashes data imported).', section2='processing', parameter2='enableknownmetcarving', label2='enableKnownMetCarving', tooltip2='Enables specific carving of e-Mule "known.met" files. "addUnallocated" must be enabled.'),
        createTwoCheckBoxes(section1='processing', parameter1='enableimagethumbs', label1='enableImageThumbs', tooltip1='Enables the generation of images thumbnails during processing. It can slow down processing, but strongly speeds up image preview in the gallery', section2='processing', parameter2='enableimagesimilarity', label2='enableImageSimilarity', tooltip2='Enables the generation of images features during processing, allowing the search for visually similar images. "enableImageThumbs" must be enabled.'),
        createTwoCheckBoxes(section1='processing', parameter1='enablefacerecognition', label1='enableFaceRecognition', tooltip1='Enables face recognition feature. You may install python and some dependencies, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#facerecognition. Advanced configuration options can be found in conf/FaceRecognitionConfig.txt. If enabled, you can search for faces from the analysis interface, check the options menu.', section2='processing', parameter2='enablevideothumbs', label2='enableVideoThumbs', tooltip2='Enables extraction of image frames from video files. Extraction settings can be modified in file "conf/VideoThumbsConfig.txt"'),
        createTwoCheckBoxes(section1='processing', parameter1='enabledocthumbs', label1='enableDocThumbs', tooltip1='[Experimental] Enables thumbnail creation for PDFs and many formats supported by LibreOffice. Advanced configurations can be found at conf/DocThumbsConfig.txt.', section2='processing', parameter2='enablehtmlreport', label2='enableHTMLReport', tooltip2='Enables HTML report generation on automatic extractions or from selected items. Generation settings can be modified in file "conf/HTMLReportConfig.txt"'),
        createTwoCheckBoxes(section1='processing', parameter1='enableaudiotranslation', label1='enableAudioTranslation', tooltip1='', section2='processing', parameter2='enableimageclassification', label2='enableImageClassification', tooltip2=''),
    ])

def createTaskTab():
    return sg.Tab(title='Tasks', layout=[
        [
            sg.Text('Tasks')
        ]
    ])

def createmainform(version):
    layout = [
        [
            sg.TabGroup(expand_x=True, expand_y=True, layout=[
                [
                    #createHomeTab(),
                    createEnvironmentTab(),
                    createProcessingTab(),
                    createTaskTab()
                ]
            ])
        ],
    ]
    window = sg.Window(title="Transkription und Übersetzung - " + version, layout=layout, size=(1000,700), resizable=True, element_justification="center", finalize=True)
    return window