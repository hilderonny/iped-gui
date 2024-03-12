import * as messages from './messages.mjs'


const CONFIGTYPES = {
	LocalConfig: {
		filepath: "LocalConfig.txt",
		elements: [
			{ name: "locale", type: "stringlist", description: "Defines program localization/language. Currently there are localizations for 'en', 'pt-BR', 'it-IT', 'de-DE' & 'es-AR'", listElements: ["de-DE", "en", "pt-BR", "it-IT", "es-AR" ] },
			{ name: "indexTemp", type: "directory", description: "Temporary directory for processing: \"default\" uses the system temporary folder. Configure it on a folder free of antivirus, system indexing or restoring. "},
			{ name: "indexTempOnSSD", type: "boolean", description: "Enable if indexTemp is on a SSD disk. Optimizations are made that can improve processing speed up to 2x. Do not enable it if indexTemp is NOT on SSD or you "},
			{ name: "outputOnSSD", type: "boolean", description: "Enable if output/case folder is on SSD. If enabled, index is created directly in case folder, not in indexTemp, so you will need less free space in temp "},
			{ name: "numThreads", type: "string", description: "Number of processing threads/workers: \"default\" uses the number of CPU logical cores. If you have memory usage problems, you can decrease it or increase java heap memory (-Xms)."},
			{ name: "hashesDB", type: "file", description: "Full path for IPED hash database. It is highly recommended to store it on a fast disk, preferably SSD, and not the same used as \"indexTemp\", if other disk is available.", fileFilter: "IPED Hash database|iped-hashes.db"},
			// tskJarPath wird hier nicht aufgenommen, da nur für Linux relevant
			{ name: "pluginFolder", type: "directoryrelativetoipedexe", description: "Plugin folder for optional libs not embedded because of license restrictions. They will be dynamically loaded at runtime."}
		]
	},
	IPEDConfig: {
		filepath: "IPEDConfig.txt",
		elements: [
            { name: "enableHash", icon: "#", type: "boolean", description: "Enables file hashes calculation."},
            { name: "enablePhotoDNA", icon: "&#xEB9F", type: "boolean", description: "Enables photoDNA hash calculation. If you have rights to use it (law enforcement that fight against child exploitation) and have received the library, you must put it into plugins folder"},
            { name: "enableHashDBLookup", icon: "#", type: "boolean", description: "Enables hash lookup on IPED database."},
            { name: "enablePhotoDNALookup", icon: "&#xEB9F", type: "boolean", description: "Enables photoDNA lookup on IPED hash database."},
            { name: "enableLedDie", icon: "&#xE716", type: "boolean", description: "Enables nudity detection. For each image it creates attributes \"nudityScore\" (1 to 1000) and \"nudityClass\" (1 to 5) for ranking and/or filtering."},
            { name: "enableYahooNSFWDetection", icon: "&#xE716", type: "boolean", description: "[Experimental] Enables nudity detection using Yahoo OpenNSFW deeplearning algorithm. You may install python and some dependencies to enable it, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#python-modules This is more than 1 order of magnitude slower than LedDie algorithm on the CPU, using a good GPU is highly recommended. It gives higher scores than LedDie algorithm for images/videos with genitals or explicit sex, mainly because of training dataset differences. An attribute nsfw_nudity_score from 0 to 100 will be created."},
            { name: "enableQRCode", icon: "&#xED14", type: "boolean", description: "Enables QRcode detection and decoding"},
            { name: "ignoreDuplicates", icon: "&#xE8C8", type: "boolean", description: "Ignore and exclude duplicated files with same hash from the processing and from the case.  WARNING: This feature is inherently DANGEROUS, as it could exclude from the case duplicated files with different metadata (name, path, dates) like email attachments or files in relevant folders. See #574 and #931."},
            { name: "exportFileProps", icon: "&#xE71D", type: "boolean", description: "Exports the properties of all files in the case to file \"Lista de Arquivos.csv\""},
            { name: "processFileSignatures", icon: "&#xE71D", type: "boolean", description: "Processes the signatures of files"},
            { name: "enableFileParsing", icon: "&#xE773", type: "boolean", description: "Enables parsing of files contents. It's necessary for several functions like containers expansion, detection of encrypted content, metadata indexing, previews generation, etc."},
            { name: "expandContainers", icon: "&#xE773", type: "boolean", description: "Expands containers, like compressed files, e-mail boxes, emails e MS-Office documents. File types to be expanded can be modified in file \"conf/CategoriesToExpand.txt\""},
            { name: "processEmbeddedDisks", icon: "&#xE773", type: "boolean", description: "Process supported disk images (like dd, e01, vhd, vmdk) contained in the main evidence recursively. Splitted images and snapshots are not supported for now."},
            { name: "enableRegexSearch", icon: "&#xF78B", type: "boolean", description: "Searches texts extracted from items by regular expressions like social numbers, emails, URLs, credit cards, money values, etc. New expressions can be configured in file \"conf/RegexConfig.txt\""},
            { name: "enableAutomaticExportFiles", icon: "&#xEE71", type: "boolean", description: "Enables automatic file exporting to case folder based on categories or keywords. If enabled, just the exported files are included in case, others are ignored, and the case becomes datasource independent. Relevant categories and keywords can be configured in CategoriesToExport.txt and KeywordsToExport.txt."},
            { name: "enableLanguageDetect", icon: "&#xF2B7", type: "boolean", description: "Enables detection of more than 70 idioms in document files."},
            { name: "enableNamedEntityRecogniton", icon: "&#xF272", type: "boolean", description: "Feature to recognize named entities: people, organizations or places. StanfordCoreNLP 3.8 language models must be downloaded from https://stanfordnlp.github.io/CoreNLP/history.html and put in plugins folder. This feature is CPU heavy, it can increase processing time by 4x. Advanced settings can be modified in \"conf/NamedEntityRecognitionConfig.txt\" file."},
            { name: "enableGraphGeneration", icon: "&#xF22C", type: "boolean", description: "Feature to create link graphs of communications (calls, messages, emails...) Optionally it can create entities and links based on nearby regex hits (experimental). It could be enabled in conf/GraphConfig.json"},
            { name: "entropyTest", icon: "&#xE727", type: "boolean", description: "Perform test for randomness of binary items and unknown file types. This is used to detect possible encrypted items. Also makes indexing faster and reduces index size, specially when indexing unallocated space. May cause loss of hits surrounded by \"random\" content."},
            { name: "indexFileContents", icon: "&#xE773", type: "boolean", description: "Indexes files contents. If disabled, indexes only the properties of files."},
            { name: "enableIndexToElasticSearch", icon: "&#xE773", type: "boolean", description: "Enables indexing to an ElasticSearch/OpenSearch cluster. You must configure at least host/port options in conf/ElasticSearchConfig.txt"},
            { name: "enableMinIO", icon: "&#xE774", type: "boolean", description: "Enable exporting files to MinIO object storage cluster. You must configure at least host/port options in conf/MinIOConfig.txt"},
            { name: "enableAudioTranscription", icon: "&#xE8D6", type: "boolean", description: "Enable audio transcription. Default implementation uses VOSK transcription [EXPERIMENTAL] on local CPU (slow and medium quality). We include Vosk portable models for 'en' and 'pt-BR', the lang model is taken from 'locale' in LocalConfig.txt You can change it from Vosk to Microsoft Azure or Google Cloud services (faster and better quality). Configure it in conf/AudioTranscriptConfig.txt"},
            { name: "enableCarving", icon: "&#xE773", type: "boolean", description: "Enables carving. \"addUnallocated\" must be enabled to unallocated area be searched. By default carving runs on almost every item in the case. File types to be searched and retrieved can be set in file \"conf/CarvingConfig.txt\""},
            { name: "enableLedCarving", icon: "&#xE773", type: "boolean", description: "Enables carving that retrieves known files from the LED base, based on the beginning (64K) of the file. It's necessary to enable \"addUnallocated\" and to configure \"hashesDB\" (with LED hashes data imported)."},
            { name: "enableKnownMetCarving", icon: "&#xE773", type: "boolean", description: "Enables specific carving of e-Mule \"known.met\" files. \"addUnallocated\" must be enabled."},
            { name: "enableImageThumbs", icon: "&#xEB9F", type: "boolean", description: "Enables the generation of images thumbnails during processing. It can slow down processing, but strongly speeds up image preview in the gallery"},
            { name: "enableImageSimilarity", icon: "&#xEB9F", type: "boolean", description: "Enables the generation of images features during processing, allowing the search for visually similar images. \"enableImageThumbs\" must be enabled."},
            { name: "enableFaceRecognition", icon: "&#xED53", type: "boolean", description: "Enables face recognition feature. You may install python and some dependencies, see https://github.com/sepinf-inc/IPED/wiki/User-Manual#facerecognition Advanced configuration options can be found in conf/FaceRecognitionConfig.txt. If enabled, you can search for faces from the analysis interface, check the options menu."},
            { name: "enableVideoThumbs", icon: "&#xF7EE", type: "boolean", description: "Enables extraction of image frames from video files Extraction settings can be modified in file \"conf/VideoThumbsConfig.txt\""},
            { name: "enableDocThumbs", icon: "&#xE8A5", type: "boolean", description: "[Experimental] Enables thumbnail creation for PDFs and many formats supported by LibreOffice. Advanced configurations can be found at conf/DocThumbsConfig.txt."},
            { name: "enableHTMLReport", icon: "&#xE9F9", type: "boolean", description: "Enables HTML report generation on automatic extractions or from selected items. Generation settings can be modified in file \"conf/HTMLReportConfig.txt\""},
            { name: "enableAudioTranslation", icon: "&#xE8D6", type: "boolean", description: "Enable audio translation via Whisper and Argos Translate. Needs enableHash = true. Configure it in conf/AudioTranslation.txt"},
            { name: "enableTextTranslation", icon: "&#xF2B7", type: "boolean", description: "Enable text translation via Argos Translate. Currently this does not work because it must handle different text sources in a different way. Needs enableHash = true. Configure it in conf/TextTranslation.txt"},
            { name: "enableImageClassification", icon: "&#xEB9F", type: "boolean", description: "Enable image classification. Needs enableHash = true."},
		]
	},
	FileSystemConfig: {
		filepath: "conf/FileSystemConfig.txt",
		elements: [
            { name: "robustImageReading", type: "boolean", description: "Uses auxiliary processes to read file contents in images. If Sleuthkit crashes, only the auxiliary processes are killed and restarted. Increases RAM usage often in about ~500MB per process. Increases up to 3x the processing speed of compressed E01 images, APFS containers or images in network."},
            { name: "numImageReaders", type: "string", description: "Number of auxiliary image reading processes. 'auto' uses 1/4 of the number of logical CPU cores. You can decrease the value if it uses too much RAM. Increasing the value is not efficient, because often IO devices can not handle many reading requests simultaneously."},
            { name: "addUnallocated", type: "boolean", description: "Add and process unallocated areas of images."},
            { name: "addFileSlacks", type: "boolean", description: "Add and process file slacks."},
            { name: "minOrphanSizeToIgnore", type: "string", description: "Ignore orphan files bigger than this value in bytes. Default -1 means disabled. In rare cases, Sleuthkit can recover thousands of large corrupted orphan files pointing to the same disk areas, making the processing not feasible."},
            { name: "unallocatedFragSize", type: "string", description: "Size in bytes of the unallocated space segments. In cases where the carving of videos is important, it may be useful to increase this value to minimize missing items that cross segment boundaries, but processing may take longer if this value is too large."},
            { name: "ignoreHardLinks", type: "boolean", description: "Ignores HFS+ hard links pointing to items already processed. The hard links are added to the case, but their content is not processed (indexed, expanded, carved, etc). Optimizes HFS+ image processing containing millions of hard links (such as Time Machine volumes)."},
            { name: "skipFolderRegex", type: "string", description: "Regex pattern to skip matched folder trees when processing. Just works if processing mounted folders currently. Matched folders are ignored and not included in case."},
		]
	},
	AudioTranslation: {
		filepath: "conf/AudioTranslation.txt",
		elements: [
			{ name: "inputDirectory", icon: "&#xE898", type: "directory", description: "Directory where the task puts the audio files to process."},
			{ name: "outputDirectory", icon: "&#xE896", type: "directory", description: "Directory where the background task puts the results and where the tasks fetches them"},
			{ name: "processVideo", icon: "&#xE714", type: "boolean", description: "Use video processing with caution. It can take very long if you analyze full length cinema movies"},
			{ name: "useForensicTaskBridge", type: "boolean", description: "Use forensic task bridge server instead of local processing"},
			{ name: "forensicTaskBridgeApiUrl", type: "string", description: "URL of the API of the forensic task bridge in the format http://127.0.0.1:30000/api/"},
			{ name: "forensicTaskBridgeShareDirectory", type: "directory", description: "Directory where the task puts the audio files to process when a forensic task bridge server is used"},
		]
	},
	ImageClassification: {
		filepath: "conf/ImageClassification.txt",
		elements: [
			{ name: "inputDirectory", icon: "&#xE898", type: "directory", description: "Directory where the task puts the audio files to process."},
			{ name: "outputDirectory", icon: "&#xE896", type: "directory", description: "Directory where the background task puts the results and where the tasks fetches them"},
			{ name: "useForensicTaskBridge", type: "boolean", description: "Use forensic task bridge server instead of local processing"},
			{ name: "forensicTaskBridgeApiUrl", type: "string", description: "URL of the API of the forensic task bridge in the format http://127.0.0.1:30000/api/"},
			{ name: "forensicTaskBridgeShareDirectory", type: "directory", description: "Directory where the task puts the image files to process when a forensic task bridge server is used"},
		]
	},
}

function createSettingsCard(configElement) {
	const settingsCardDiv = document.createElement("div")
	settingsCardDiv.classList.add("settingscard")
	if (configElement.icon) {
		const iconDiv = document.createElement("div")
		iconDiv.classList.add("icon")
		iconDiv.innerHTML = configElement.icon
		settingsCardDiv.appendChild(iconDiv)
	}
	const textDiv = document.createElement("div")
	textDiv.classList.add("text")
	settingsCardDiv.appendChild(textDiv)
	const titleDiv = document.createElement("div")
	titleDiv.classList.add("title")
	titleDiv.innerHTML = configElement.name
	textDiv.appendChild(titleDiv)
	const descriptionDiv = document.createElement("div")
	descriptionDiv.classList.add("description")
	textDiv.appendChild(descriptionDiv)
	const actionDiv = document.createElement("div")
	actionDiv.classList.add("action")
	settingsCardDiv.appendChild(actionDiv)
	let descriptionTextDiv, valueDiv, button
	switch (configElement.type) {
		case "stringlist":
			descriptionDiv.innerHTML = configElement.description
			const selectBox = document.createElement("select")
			for (const entry of configElement.listElements) {
				const option = document.createElement("option")
				option.innerHTML = entry
				selectBox.appendChild(option)
			}
			actionDiv.appendChild(selectBox)
			break
		case "directory":
			descriptionTextDiv = document.createElement("div")
			descriptionTextDiv.innerHTML = configElement.description
			descriptionTextDiv.classList.add("description")
			textDiv.appendChild(descriptionTextDiv)
			valueDiv = document.createElement("div")
			valueDiv.classList.add("value")
			textDiv.appendChild(valueDiv)
			button = document.createElement("button")
			button.innerHTML = "Auswählen ..."
			actionDiv.appendChild(button)
			break
		case "boolean":
			descriptionDiv.innerHTML = configElement.description
			const toggleInput = document.createElement("input")
			toggleInput.type = "checkbox"
			toggleInput.classList.add("toggle")
			actionDiv.appendChild(toggleInput)
			break
		case "string":
			descriptionDiv.innerHTML = configElement.description
			const textInput = document.createElement("input")
			actionDiv.appendChild(textInput)
			break
		case "file":
			descriptionTextDiv = document.createElement("div")
			descriptionTextDiv.innerHTML = configElement.description
			descriptionTextDiv.classList.add("description")
			textDiv.appendChild(descriptionTextDiv)
			valueDiv = document.createElement("div")
			valueDiv.classList.add("value")
			textDiv.appendChild(valueDiv)
			button = document.createElement("button")
			button.innerHTML = "Auswählen ..."
			actionDiv.appendChild(button)
			break
		case "directoryrelativetoipedexe":
			descriptionTextDiv = document.createElement("div")
			descriptionTextDiv.innerHTML = configElement.description
			descriptionTextDiv.classList.add("description")
			textDiv.appendChild(descriptionTextDiv)
			valueDiv = document.createElement("div")
			valueDiv.classList.add("value")
			textDiv.appendChild(valueDiv)
			button = document.createElement("button")
			button.innerHTML = "Auswählen ..."
			actionDiv.appendChild(button)
			break
	}
	return settingsCardDiv
}

function createContentLayout(configTypeName, selector) {
	const configType = CONFIGTYPES[configTypeName]
	const targetDiv = document.querySelector(selector)
	for (const element of configType.elements) {
		const settingsCard = createSettingsCard(element)
		targetDiv.appendChild(settingsCard)
	}
}

createContentLayout("LocalConfig", ".content-local-config");
createContentLayout("IPEDConfig", ".content-features");
createContentLayout("FileSystemConfig", ".content-file-system-config");
createContentLayout("AudioTranslation", ".content-audio-translation .generated");
createContentLayout("ImageClassification", ".content-image-classification .generated");


messages.addMessageListener("selectfiledemo", message => document.getElementById("filename").value = message.Path)
messages.addMessageListener("showfilecontentdemo", message => document.getElementById("filecontent").innerText = message.Content)
messages.addMessageListener("selectfolderdemo", message => document.getElementById("foldername").value = message.Path)
messages.addMessageListener("rundemo", message => {
	console.log(message)
})

/*
document.getElementById("selectfilebutton").addEventListener("click", () => {
	messages.showSelectFileDialog("selectfiledemo", "Text|*.txt")
})

document.getElementById("showfilecontentbutton").addEventListener("click", () => {
	messages.readFileWithDialog("showfilecontentdemo", "Text|*.txt")
})

document.getElementById("selectfolderbutton").addEventListener("click", () => {
	messages.showSelectPathDialog("selectfolderdemo")
})

document.getElementById("runbutton").addEventListener("click", () => {
	const program = document.getElementById("program").value
	messages.runProgram("rundemo", program)
})
*/