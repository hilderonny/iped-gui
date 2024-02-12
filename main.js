const { app, BrowserWindow } = require('electron')

// Shell-Kommando ausführen: https://stackoverflow.com/a/55329058
// Electron Tutorial: https://www.electronjs.org/docs/latest/tutorial/tutorial-first-app
// Systemzugriff per preload in Sandbox bringen: https://www.electronjs.org/docs/latest/tutorial/tutorial-preload
// Und über IPC vom HTML auf Systemfunktionen zugreifen: https://www.electronjs.org/docs/latest/tutorial/tutorial-preload#communicating-between-processes
// App-Icon einbauen: https://www.electronforge.io/guides/create-and-add-icons
// Publishing: https://www.electronjs.org/docs/latest/tutorial/tutorial-publishing-updating
// Material 2 in Electron: https://stackoverflow.com/questions/67880117/how-to-use-material-web-components-in-electron
// VueJS und Electron: https://blog.logrocket.com/building-app-electron-vue/ oder https://medium.com/the-devops-corner/building-a-desktop-app-with-electron-and-vue-js-ef2a1bb08e8d

// ABER: Folder Chooser geht hier aber nicht!


const createWindow = () => {
    const win = new BrowserWindow({
        width: 800,
        height: 600,
    })

    win.menuBarVisible = false

    win.loadFile('html/index.html')
}

app.whenReady().then(() => {
    createWindow()

    app.on('activate', () => {
        if (BrowserWindow.getAllWindows().length === 0) {
            createWindow()
        }
    })
})
  
app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit()
    }
})