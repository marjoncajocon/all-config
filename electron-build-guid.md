# using electron 22 to build exe app, this support windows vista, 7, 10, 11

*step 1: 
	create project folder myapp and navigate to myapp
*step 2:
	in myapp folder
        - npm install electron@22 --save-dev
        or
        - npm install electron@22.0.0 --save-dev

*step 3:
      - create a file main.js
      ```
const { app, BrowserWindow } = require('electron');
const path = require('path');

function createWindow () {
  // Create the browser window.
  const win = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      // This is necessary for Electron 22/Node integration setup
      nodeIntegration: true,
      contextIsolation: false
    }
  });

  // Load the index.html file.
  win.loadFile('index.html');

  // Open the DevTools (optional).
  // win.webContents.openDevTools();
}

// When the app is ready, create the window.
app.whenReady().then(createWindow);

// Quit the app when all windows are closed (except on macOS).
app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') {
    app.quit();
  }
});

app.on('activate', () => {
  // On macOS, re-create a window when the dock icon is clicked.
  if (BrowserWindow.getAllWindows().length === 0) {
    createWindow();
  }
});
      ```
