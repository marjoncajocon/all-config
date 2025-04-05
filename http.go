/// go lang basic http

package main

import (
	"encoding/json"
	"fmt"
	"log"
	"net/http"
)

func main() {
	fs := http.FileServer(http.Dir("./app/build"))
	http.Handle("/", fs)


	http.HandleFunc("/hellow", func(rw http.ResponseWriter, r *http.Request) {

		fmt.Println(r.Method)
		fmt.Println(r.Body)

		rw.Write([]byte("Hello World"))
	})

	http.HandleFunc("/api/test", func(w http.ResponseWriter, r *http.Request) {

		if r.Method == "POST" {
			
			payload := struct {
				Username string `json:"username"`
				Password string `json:"password"`
			}{};

			json.NewDecoder(r.Body).Decode(&payload)

			fmt.Println(payload)
		}
		
	});

	log.Fatal(http.ListenAndServe(":8000", nil))
}
