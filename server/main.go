package main

import (
	"fmt"
	"log"
	"net/http"
)

func main() {
	file := checkFile()
	fmt.Println(file)
	m := readDatabase()
	fmt.Println(m)

	http.HandleFunc("/data", createDatabase)
	http.HandleFunc("/deleteDatabase", deleteDatabase)
	http.HandleFunc("/allDatabases", allDatabases)
	http.HandleFunc("/createTable", createTable)
	http.HandleFunc("/allTables", allTables)
	http.HandleFunc("/deleteTable", deleteTable)
	http.HandleFunc("/createIndex", createIndex)
	http.HandleFunc("/allColumns", allColumns)
	http.HandleFunc("/insert", insert)
	http.HandleFunc("/alldata", alldata)
	http.HandleFunc("/deletedata", deletedata)
	http.HandleFunc("/allIndexName", allIndexName)
	http.HandleFunc("/getUniqueKeys", getUniqueKeys)
	http.HandleFunc("/getForeignKey", getForeignKey)
	http.HandleFunc("/checkIfIndexExists", checkIfIndexExists)
	http.HandleFunc("/insertUniqueKeyIndex", insertUniqueKeyIndex)
	http.HandleFunc("/insertForeignKeyData", insertForeignKeyData)
	http.HandleFunc("/alluniquedata", alluniquedata)
	http.HandleFunc("/allforeigndata", allforeigndata)

	fmt.Printf("Starting server for testing...\n")
	if err := http.ListenAndServe(":8080", nil); err != nil {
		log.Fatal(err)
	}
}
