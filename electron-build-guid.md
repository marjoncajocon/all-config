🚀 Building a Windows EXE App Using Electron 22

Supports Windows Vista, 7, 10, 11

✅ Step 1 — Create Project Folder
mkdir myapp
cd myapp

✅ Step 2 — Install Electron 22

Inside the myapp folder, run:

npm install electron@22 --save-dev


or specify an exact version:

npm install electron@22.0.0 --save-dev

✅ Step 3 — Create main.js

Create a file named main.js:

const { app, BrowserWindow } = require('electron');
const path = require('path');

function createWindow () {
  const win = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      nodeIntegration: true,
      contextIsolation: false
    }
  });

  win.loadFile('index.html');
  // win.webContents.openDevTools(); // Optional
}

app.whenReady().then(createWindow);

app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') app.quit();
});

app.on('activate', () => {
  if (BrowserWindow.getAllWindows().length === 0) createWindow();
});

✅ Step 4 — Update package.json
{
  "name": "myapp",
  "version": "1.0.0",
  "description": "",
  "main": "main.js",
  "scripts": {
    "start": "electron-forge start",
    "package": "electron-forge package",
    "make": "electron-forge make"
  },
  "keywords": [],
  "author": "",
  "license": "ISC",
  "devDependencies": {
    "@electron-forge/cli": "^6.x.x",
    "@electron-forge/maker-deb": "^6.x.x",
    "@electron-forge/maker-rpm": "^6.x.x",
    "@electron-forge/maker-squirrel": "^6.x.x",
    "@electron-forge/maker-zip": "^6.x.x",
    "electron": "^22.3.25"
  },
  "config": {
    "forge": {
      // Additional forge configuration added by import
    }
  }
}

✅ Step 5 — Build the EXE

Install Forge CLI:

npm install --save-dev @electron-forge/cli


Import Forge setup:

npx electron-forge import


Build the Windows EXE:

npm run make


Your .exe will appear in:

/out/make/
