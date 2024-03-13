const messageListeners = {}

if (window.chrome?.webview) window.chrome.webview.addEventListener("message", event => {
	const message = event.data
	const id = message.Id
	if (messageListeners[id]) {
		for (var listener of messageListeners[id]) {
			listener(message)
		}
	}
});

export function addMessageListener(messageid, listener) {
	if (!messageListeners[messageid]) {
		messageListeners[messageid] = []
	}
	messageListeners[messageid].push(listener)
}

export function exportProfile(messageid) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "ExportProfile"
	})
}

export function showSelectPathDialog(messageid) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "SelectPath"
	})
}

export function showSelectFileDialog(messageid, filter) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "SelectFile",
		FileFilter: filter
	})
}

export function readFile(messageid, path) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "ReadTextFile",
		Path: path
	})
}

export function readFileWithDialog(messageid, filter) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "ReadTextFileDialog",
		Filter: filter
	})
}

export function writeFile(messageid, path, content) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "WriteTextFile",
		Path: path,
		Content: content
	})
}

export function writeFileWithDialog(messageid, filter, content) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "WriteTextFileDialog",
		Filter: filter,
		Content: content
	})
}

export function runProgram(messageid, program, args, workingDirectory) {
	window.chrome?.webview?.postMessage({
		Id: messageid,
		Type: "RunProgram",
		Program: program,
		ProgramArguments: args,
		WorkingDirectory: workingDirectory
	})
}