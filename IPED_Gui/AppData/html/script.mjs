import * as messages from './messages.mjs'

messages.addMessageListener("selectfiledemo", message => document.getElementById("filename").value = message.Path)
messages.addMessageListener("showfilecontentdemo", message => document.getElementById("filecontent").innerText = message.Content)
messages.addMessageListener("selectfolderdemo", message => document.getElementById("foldername").value = message.Path)
messages.addMessageListener("rundemo", message => {
	console.log(message)
})

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
