
document.getElementById("selectfilebutton").addEventListener("click", () => {
	window.chrome.webview.postMessage("showselectfiledialog")
})

document.getElementById("selectfolderbutton").addEventListener("click", () => {
	window.chrome.webview.postMessage("showselectfolderdialog")
})

document.getElementById("runbutton").addEventListener("click", () => {
	window.chrome.webview.postMessage("run")
})

window.chrome.webview.addEventListener("message", event => alert(event.data));
