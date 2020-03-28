package main

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"log"
	"net/http"
	"os"
	"strings"

	"github.com/boltdb/bolt"
)

//Column struct
type Column struct {
	ColumnName string `json:"columnName"`
	Tip        string `json:"tip"`
	Length     string `json:"length"`
	IsNull     string `json:"IsNull"`
}

//Table struct
type Table struct {
	TableName   string   `json:"tableName"`
	FileName    string   `json:"fileName"`
	RowLength   string   `json:"rowLength"`
	Columns     []Column `json:"Columns"`
	PrimaryKey  []string `json:"primaryKey"`
	UniqueKeys  []string `json:"uniqueKeys"`
	ForeignKeys []string `json:"foreignKeys`
	IndexFiles  []string `json:"indexFiles"`
}

//DataBase struct
type DataBase struct {
	DataBaseName string  `json:"dataBaseName"`
	Tables       []Table `json:"Tables"`
}

func checkIfIndexExists(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	indexName := s[0]
	tableName := s[1]
	dataBaseName := s[2]
	db := readDatabase()

	exists := 0
	indexFinalName := ""
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {
					for k := range db[i].Tables[j].IndexFiles {
						if strings.Contains(db[i].Tables[j].IndexFiles[k], indexName) {
							exists = 1
							indexFinalName = db[i].Tables[j].IndexFiles[k]
						}
					}
				}
			}
		}
	}
	if exists == 1 {
		fmt.Fprintf(w, "%s", indexFinalName)
	} else {
		fmt.Fprint(w, "Indexul nu exista")
	}
}
func getUniqueKeys(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	tableName := s[0]
	dataBaseName := s[1]
	db := readDatabase()
	uniqueKeys := ""
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {
					uniqueKeys = db[i].Tables[j].UniqueKeys[0]
				}
			}
		}
	}
	res := uniqueKeys
	fmt.Fprintf(w, "%s", res)

}
func getForeignKey(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	tableName := s[0]
	dataBaseName := s[1]
	db := readDatabase()
	foreignKeys := ""
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {
					foreignKeys = db[i].Tables[j].ForeignKeys[0]
				}
			}
		}
	}
	res := foreignKeys
	fmt.Fprintf(w, "%s", res)
}
func allIndexName(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	tableName := s[0]
	dataBaseName := s[1]
	db := readDatabase()
	var indexFiles []string
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {
					indexFiles = db[i].Tables[j].IndexFiles
				}
			}
		}
	}
	res := ""
	for i := range indexFiles {
		t := strings.Split(indexFiles[i], ".")
		res = res + t[0] + ";"
	}
	fmt.Println(res)
	fmt.Fprintf(w, "%s", res)

}
func deletedata(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	databasefile := s[0] + ".db"
	tablefile := s[1] + "kv"
	key := s[2]
	db, err := bolt.Open(databasefile, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.Update(func(tx *bolt.Tx) error {
		b := tx.Bucket([]byte(tablefile))
		err := b.Delete([]byte(key))
		fmt.Fprintf(w, "The record was deleted!")
		return err
	})
}
func alldata(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	databasefile := s[0] + ".db"
	tablefile := s[1] + "kv"
	db, err := bolt.Open(databasefile, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.View(func(tx *bolt.Tx) error {
		// Assume bucket exists and has keys
		b := tx.Bucket([]byte(tablefile))

		b.ForEach(func(k, v []byte) error {
			fmt.Printf("key=%s, value=%s\n", k, v)
			fmt.Fprintf(w, "%s#%s;", k, v)
			return nil
		})
		return nil
	})
}
func allforeigndata(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	databasefile := s[0] + ".db"
	table := s[1]
	foreignKeyfile := s[2]
	file := table + "/" + foreignKeyfile
	db, err := bolt.Open(databasefile, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.View(func(tx *bolt.Tx) error {
		// Assume bucket exists and has keys
		b := tx.Bucket([]byte(file))

		b.ForEach(func(k, v []byte) error {
			fmt.Printf("key=%s, value=%s\n", k, v)
			fmt.Fprintf(w, "%s#%s&", k, v)
			return nil
		})
		return nil
	})
}
func alluniquedata(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	databasefile := s[0] + ".db"
	table := s[1]
	uniqueKeyfile := s[2]
	file := table + "/" + uniqueKeyfile
	db, err := bolt.Open(databasefile, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.View(func(tx *bolt.Tx) error {
		// Assume bucket exists and has keys
		b := tx.Bucket([]byte(file))

		b.ForEach(func(k, v []byte) error {
			fmt.Printf("key=%s, value=%s\n", k, v)
			fmt.Fprintf(w, "%s#%s;", k, v)
			return nil
		})
		return nil
	})
}

func insertForeignKeyData(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), "//")
	fileName := s[0]
	fmt.Println(fileName)
	tableName := s[1]
	file := tableName + "/" + fileName
	dataBaseName := s[2]
	data := s[3]
	dbfile := dataBaseName + ".db"
	tryDeleteBucket(dbfile, file)
	createBucket(dataBaseName, file)
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {

					d := strings.Split(data, "&")
					for i := 0; i < len(d)-1; i++ {
						r := strings.Split(d[i], "#")
						key := r[0]
						value := r[1]
						insertInBucket(dbfile, file, key, value)
					}
				}
			}
		}
	}
}
func insertUniqueKeyIndex(w http.ResponseWriter, r *http.Request) {

	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), "//")
	fileName := s[0]
	fmt.Println(fileName)
	tableName := s[1]
	file := tableName + "/" + fileName
	dataBaseName := s[2]
	data := s[3]
	dbfile := dataBaseName + ".db"
	tryDeleteBucket(dbfile, file)
	createBucket(dataBaseName, file)
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {

					d := strings.Split(data, ":")
					for i := 0; i < len(d)-1; i++ {
						r := strings.Split(d[i], ";")
						key := r[0]
						value := r[1]
						insertInBucket(dbfile, file, key, value)
					}
				}
			}
		}
	}
}

func insert(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	s := strings.Split(string(b), ";")
	tableName := s[0]
	dataBaseName := s[1]
	key := s[2]
	var value = ""
	for i := 3; i < len(s)-1; i++ {
		value = value + s[i] + "#"
	}
	dbfile := dataBaseName + ".db"
	db := readDatabase()
	sz := len(value)
	value = value[:sz-1]
	for i := range db {
		if db[i].DataBaseName == dataBaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {
					insertInBucket(dbfile, db[i].Tables[j].FileName, key, value)
				}
			}
		}
	}
	fmt.Println(key)
	fmt.Println(value)
	fmt.Fprintf(w, "The record was added!")

}
func tryDeleteBucket(dbfile string, file string) {
	db, err := bolt.Open(dbfile, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.Update(func(tx *bolt.Tx) error {
		err := tx.DeleteBucket([]byte(file))
		if err != nil {
			fmt.Println("Bucket doesn't exist")
			return nil
		}
		return nil
	})
}
func insertInBucket(dbfile string, tablefile string, key string, value string) {
	db, err := bolt.Open(dbfile, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.Update(func(tx *bolt.Tx) error {
		b := tx.Bucket([]byte(tablefile))
		err := b.Put([]byte(key), []byte(value))
		return err
	})
}
func createIndex(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))

	req := strings.Split(string(b), ";")
	tableName := req[0]
	indexName := req[1]
	databaseName := req[2]
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == databaseName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tableName {
					db[i].Tables[j].IndexFiles = append(db[i].Tables[j].IndexFiles, indexName)
				}
			}
		}
	}

	WriteDatabase(db)

}
func createTable(w http.ResponseWriter, r *http.Request) {
	databaseName := r.Header.Get("dataBaseName")
	fmt.Println(databaseName)
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	var table Table
	err = json.Unmarshal(b, &table)
	if err != nil {
		panic(err)
	}
	fmt.Println(table.TableName)
	fmt.Println(table.Columns[0].ColumnName)
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == databaseName {

			c := len(db[i].Tables)
			fmt.Println(c)
			db[i].Tables = append(db[i].Tables, table)
			n := len(db[i].Tables)
			createBucket(databaseName, db[i].Tables[n-1].FileName)
		}
	}
	WriteDatabase(db)

}
func createDatabase(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}
	fmt.Println(string(b))
	dbName := string(b)

	if checkDatabase(dbName) == true {
		fmt.Println("Database already exists")
		fmt.Fprintf(w, "Database %s already exists.", dbName)
	} else {
		db := readDatabase()
		var newdb DataBase
		newdb.DataBaseName = dbName
		db = append(db, newdb)
		path := dbName + ".db"
		createDatabasefile(path)
		WriteDatabase(db)
		fmt.Println("Databese created")
		fmt.Fprintf(w, "Database %s was created.", dbName)
	}

}
func allDatabases(w http.ResponseWriter, r *http.Request) {
	db := readDatabase()
	c := ""
	for i := range db {
		fmt.Println(i, db[i])
		c = c + db[i].DataBaseName + ";"
	}
	fmt.Println(c)
	fmt.Fprintf(w, c)

}
func allTables(w http.ResponseWriter, r *http.Request) {
	db := readDatabase()
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	fmt.Println(string(b))
	dbName := string(b)

	c := ""
	for i := range db {
		if db[i].DataBaseName == dbName {
			for j := range db[i].Tables {
				c = c + db[i].Tables[j].TableName + ";"
			}
		}
	}
	fmt.Println(c)
	fmt.Fprintf(w, c)
}
func allColumns(w http.ResponseWriter, r *http.Request) {
	db := readDatabase()
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	data := strings.Split(string(b), ";")
	tbName := data[0]
	dbName := data[1]
	c := ""
	for i := range db {
		if db[i].DataBaseName == dbName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tbName {
					for k := range db[i].Tables[j].Columns {
						c = c + db[i].Tables[j].Columns[k].ColumnName + ";"
					}
				}
			}
		}
	}
	fmt.Println(c)
	fmt.Fprintf(w, c)
}
func deleteTable(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	fmt.Println(string(b))
	data := strings.Split(string(b), ";")
	tbName := data[0]
	dbName := data[1]
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == dbName {
			for j := range db[i].Tables {
				if db[i].Tables[j].TableName == tbName {

					deleteBucket(dbName, db[i].Tables[j].FileName)
					db[i].Tables = removeTable(db[i].Tables, j)
					fmt.Fprintf(w, "The Table %s was removed.", tbName)
					fmt.Println(db[i].Tables)
					WriteDatabase(db)
				}
			}
		}
	}
}
func deleteDatabase(w http.ResponseWriter, r *http.Request) {
	b, err := ioutil.ReadAll(r.Body)
	defer r.Body.Close()
	if err != nil {
		http.Error(w, err.Error(), 500)
		return
	}

	fmt.Println(string(b))
	dbName := string(b)

	if checkDatabase(dbName) == true {
		i := databaselocation(dbName)
		db := readDatabase()
		newdb := removeDB(db, i)
		path := dbName + ".db"
		deletedataBasefile(path)
		WriteDatabase(newdb)
		fmt.Println("The database was removed")
		fmt.Fprintf(w, "The database %s was removed.", dbName)

	} else {
		fmt.Println("Databese doesn't exists")
		fmt.Fprintf(w, "Databese %s doesn't exists.", dbName)
	}
}
func removeDB(s []DataBase, i int) []DataBase {
	s[len(s)-1], s[i] = s[i], s[len(s)-1]
	return s[:len(s)-1]
}
func removeTable(s []Table, i int) []Table {
	s[len(s)-1], s[i] = s[i], s[len(s)-1]
	return s[:len(s)-1]
}
func databaselocation(dbName string) int {
	index := -1
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == dbName {
			index = i
		}
	}
	return index

}
func checkDatabase(dbName string) bool {
	ok := false
	db := readDatabase()
	for i := range db {
		if db[i].DataBaseName == dbName {
			ok = true
		}
	}
	return ok

}

//WriteDatabase scrie in json file
func WriteDatabase(db []DataBase) string {
	newFile, err := os.Create("data.json")
	if err != nil {
		log.Fatal(err)
	}
	log.Println(newFile)
	newFile.Close()
	f, err := os.OpenFile("data.json", os.O_APPEND|os.O_WRONLY, 0644)
	// if we os.Open returns an error then handle it
	if err != nil {
		fmt.Println(err)
	}
	b, err := json.Marshal(db)
	if err != nil {
		fmt.Println(err)
	}
	_, err = f.Write(b)
	f.Close()
	return "The database was created"
}

func readDatabase() []DataBase {
	jsonFile, err := os.Open("data.json")
	// if we os.Open returns an error then handle it
	if err != nil {
		fmt.Println(err)
	}
	fmt.Println("Successfully Opened data.json")
	byteValue, _ := ioutil.ReadAll(jsonFile)
	var data []DataBase
	json.Unmarshal(byteValue, &data)
	jsonFile.Close()
	return data
}

func checkFile() string {
	var raspuns string
	if _, err := os.Stat("data.json"); os.IsNotExist(err) {
		raspuns = "File does not exist"
		f, err := os.Create("data.json")
		if err != nil {
			panic(err)
		}
		defer f.Close()
	} else {
		raspuns = "File exist"
	}
	return raspuns
}
func createDatabasefile(databaseFileName string) {
	db, err := bolt.Open(databaseFileName, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	db.Close()
}
func deletedataBasefile(databaseFileName string) {
	// delete file
	path := databaseFileName
	var err = os.Remove(path)
	if isError(err) {
		return
	}

	fmt.Println("==> done deleting file")
}

func isError(err error) bool {
	if err != nil {
		fmt.Println(err.Error())
	}

	return (err != nil)
}
func createBucket(databaseName string, fileTable string) {
	path := databaseName + ".db"
	db, err := bolt.Open(path, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.Update(func(tx *bolt.Tx) error {
		b, err := tx.CreateBucket([]byte(fileTable))
		if err != nil {
			return fmt.Errorf("create bucket: %s", err)
		}

		fmt.Println(b)
		return nil
	})
}
func deleteBucket(databaseName string, fileTable string) {
	path := databaseName + ".db"
	db, err := bolt.Open(path, 0600, nil)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()
	db.Update(func(tx *bolt.Tx) error {
		err := tx.DeleteBucket([]byte(fileTable))

		if err != nil {
			log.Fatal(err)
		}
		return err
	})
}
