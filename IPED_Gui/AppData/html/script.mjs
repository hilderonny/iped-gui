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
	AudioTranslation: {
		filepath: "conf/AudioTranslation.txt",
		elements: [
			{ name: "inputDirectory", type: "directory", description: "Directory where the task puts the audio files to process."},
			{ name: "outputDirectory", type: "directory", description: "Directory where the background task puts the results and where the tasks fetches them"},
			{ name: "processVideo", type: "boolean", description: "Use video processing with caution. It can take very long if you analyze full length cinema movies"},
			{ name: "useForensicTaskBridge", type: "boolean", description: "Use forensic task bridge server instead of loacal processing"},
			{ name: "forensicTaskBridgeApiUrl", type: "string", description: "URL of the API of the forensic task bridge in the format http://127.0.0.1:30000/api/"},
			{ name: "forensicTaskBridgeShareDirectory", type: "directory", description: "Directory where the task puts the audio files to process when a forensic task bridge server is used"},
		]
	},
}

function createSettingsCard(configElement) {
	const settingsCardDiv = document.createElement("div")
	settingsCardDiv.classList.add("settingscard")
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
createContentLayout("AudioTranslation", ".content-audio-translation .generated");


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