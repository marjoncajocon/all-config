func fileUploadHandler(w http.ResponseWriter, r *http.Request) {
    // Limit file size to 10MB. This line saves you from those accidental 100MB uploads!
    r.ParseMultipartForm(10 << 20)

    // Retrieve the file from form data
    file, handler, err := r.FormFile("myFile")
    if err != nil {
        http.Error(w, "Error retrieving the file", http.StatusBadRequest)
        return
    }
    defer file.Close()

    fmt.Fprintf(w, "Uploaded File: %s\n", handler.Filename)
    fmt.Fprintf(w, "File Size: %d\n", handler.Size)
    fmt.Fprintf(w, "MIME Header: %v\n", handler.Header)

    // Now let’s save it locally
    dst, err := createFile(handler.Filename)
    if err != nil {
        http.Error(w, "Error saving the file", http.StatusInternalServerError)
        return
    }
    defer dst.Close()

    // Copy the uploaded file to the destination file
    if _, err := dst.ReadFrom(file); err != nil {
        http.Error(w, "Error saving the file", http.StatusInternalServerError)
    }
}
