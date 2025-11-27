BUILDING application USING electron 22 (Last Version Support in windows 7)
---

```markdown
# 🚀 Building a Windows EXE App Using Electron 22

Supports Windows Vista, 7, 10, 11

---

## Prerequisites
- Node.js installed
- Basic knowledge of command line

---

## Step-by-Step Guide

### ✅ Step 1 — Create Project Folder
```bash
mkdir myapp
cd myapp
```

### ✅ Step 2 — Install Electron 22
Inside the `myapp` folder, run:
```bash
npm install electron@22 --save-dev
```
Or specify an exact version:
```bash
npm install electron@22.0.0 --save-dev
```

### ✅ Step 3 — Create `main.js`
Create a file named `main.js` with the following content:
```javascript
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
```

### ✅ Step 4 — Update `package.json`
Replace or add the following in your `package.json`:
```json
{
  "name": "myapp",
  "version": "1.0.0",
  "main": "main.js",
  "scripts": {
    "start": "electron-forge start",
    "package": "electron-forge package",
    "make": "electron-forge make"
  },
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
      // Additional forge configuration
    }
  }
}
```

### ✅ Step 5 — Build the EXE

1. Install Forge CLI:
```bash
npm install --save-dev @electron-forge/cli
```

2. Import Forge setup:
```bash
npx electron-forge import
```

3. Build the Windows executable:
```bash
npm run make
```

Your `.exe` file will be available in:
```
/out/make/
```

---

## Additional Notes
- Ensure `index.html` exists in your project directory.
- Customize `main.js` and `package.json` as needed for your app.
- use latest nodejs because it does not affect elecctron 22 and does not affect version support

---

## License
[123]
```

---
