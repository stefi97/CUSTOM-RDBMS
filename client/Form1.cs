using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addDatabase_Click(object sender, EventArgs e)
        {
            panelDeletedb.Visible = false;
            panelAdddb.Visible = true;
            dbTextName.Text = "";
            DatabasesPanel.Visible = false;
        }

        private void btnDbOk_Click(object sender, EventArgs e)
        {
            string dbName = dbTextName.Text;
            if (String.IsNullOrEmpty(dbTextName.Text))
            {
                MessageBox.Show("Please name the database you want to create!");

            }
            else
            {

                createDatabase(dbName);
                panelAdddb.Visible = false;
            }
        }

        public void createDatabase(string dbN)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/data");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
               // string json = "{\"user\":\"test\"," +
               //  "\"password\":\"bla\"}";
                string dbName = dbN;
                streamWriter.Write(dbName);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            MessageBox.Show(result);
        }
        
        private void btnDbCn_Click(object sender, EventArgs e)
        {
            panelAdddb.Visible = false;
        }

        private void btnDeletedb_Click(object sender, EventArgs e)
        {
            panelDeletedb.Visible = true;
            panelAdddb.Visible = false;
            DatabasesPanel.Visible = false;
            panelDataSelectedColumns.Visible = false;
            panelAlldataWithKey.Visible = false;
            panelData.Visible = false;
            txtDeletedb.Text = "";
        }

        private void btnDeletedbOk_Click(object sender, EventArgs e)
        {
            string dbName = txtDeletedb.Text;
            if(String.IsNullOrEmpty(txtDeletedb.Text))
            {
                MessageBox.Show("Please name the database you want to delete!");

            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this database?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteDatabase(dbName);
                }
                else if (dialogResult == DialogResult.No)
                {
                    dialogResult = System.Windows.Forms.DialogResult.No;
                }
                panelDeletedb.Visible = false;
            }
            

        }
        private void deleteDatabase(string dbn)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/deleteDatabase");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string dbName = dbn;
                streamWriter.Write(dbName);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            MessageBox.Show(result);
        }
        
        
        private void btnDeletedbCn_Click(object sender, EventArgs e)
        {
            panelDeletedb.Visible = false;
        }
        

        public void DatabasesBtn_Click(object sender, EventArgs e)
        {
            panelDeletedb.Visible = false;
            panelAdddb.Visible = false;
            DatabasesPanel.Visible = true;
            dataBasesTreeView.Nodes.Clear();
            getDatabases();
            foreach (TreeNode RootNode in dataBasesTreeView.Nodes)
            {
    
                foreach (TreeNode ChildNode in RootNode.Nodes)
                {
                    ChildNode.ContextMenuStrip = contextMenuTable;
                }
            }
        }

        private void getDatabases()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/allDatabases");
            httpWebRequest.ContentType = "application/json";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            List<string> dbList = result.Split(';').ToList();
            dbList.RemoveAt(dbList.Count - 1);



            for (int i = 0; i < dbList.Count; i++)
            {

                dataBasesTreeView.Nodes.Add(new TreeNode() { Text = dbList[i] });
                List <string> tbList = getTables(dbList[i]);
                foreach (var table in tbList)
                {
                    dataBasesTreeView.Nodes[i].Nodes.Add(table);
                }
            }

        }
        private List<string> getTables(string dataBaseName)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/allTables");
            httpWebRequest.ContentType = "application/json";

            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string dbName = dataBaseName;
                streamWriter.Write(dbName);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            List<string> tbList = result.Split(';').ToList();
            tbList.RemoveAt(tbList.Count - 1);
            return tbList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addTableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTable f = new FormTable(dataBasesTreeView.SelectedNode.Text);
            f.Show();
            DatabasesBtn_Click(null, null);
        }

        private void dropTableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string deleteTableName = dataBasesTreeView.SelectedNode.Text;
            string databaseName = dataBasesTreeView.SelectedNode.Parent.Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Table?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteTable(deleteTableName,databaseName);
                DatabasesBtn_Click(null, null);
                
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = System.Windows.Forms.DialogResult.No;
            }
        }
        private void DeleteTable(string TableName,string databaseName)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/deleteTable");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string data = TableName + ";"+databaseName ;
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            MessageBox.Show(result);
        }

        private void createIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = true;
            panelData.Visible = false;
            panelDataSelectedColumns.Visible = false;
            panelAlldataWithKey.Visible = false;
            tableNameIndex.Text = dataBasesTreeView.SelectedNode.Text;
            IndexDatabaseName.Text = dataBasesTreeView.SelectedNode.Parent.Text;
            List<string> columns  = getAllColumns(dataBasesTreeView.SelectedNode.Text,dataBasesTreeView.SelectedNode.Parent.Text);
            foreach (var column in columns)
            {
                cbColumns.Items.Add(column);
            }
            
            
            
        }
        private void createIndex(string TableName, string IndexName, string databaseName)
        {
            
            string send = TableName + ";" + IndexName+ ";" +databaseName;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/createIndex");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            MessageBox.Show("The index was created");
            panelIndex.Visible = false;
            indexColumnText.Text = "";
            cbColumns.Text = "";
        }
        private List<string> getAllColumns(string TableName,string DataBaseName)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/allColumns");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string data = TableName + ";" + DataBaseName; 
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            List<string> columns = result.Split(';').ToList();
            columns.RemoveAt(columns.Count - 1);
            return columns;
        } 
        private void btnOkIndex_Click(object sender, EventArgs e)
        {
            string indexName = indexColumnText.Text;
            createIndex(tableNameIndex.Text, indexName, IndexDatabaseName.Text);
            panelIndex.Visible = false;
        }

        private void btnCancelIndex_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = false;
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelIndex.Visible = false;
            FormInsert f = new FormInsert(dataBasesTreeView.SelectedNode.Text,dataBasesTreeView.SelectedNode.Parent.Text);
            f.Show();
        }
        

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = false;
            
            panelDataSelectedColumns.Visible = false;
            panelAlldataWithKey.Visible = false;
            btnUniqueData.Visible = false;
            btnUniqueIndex.Visible = true;
            try
            {
                tbUnique.Text = getUniqueKey(dataBasesTreeView.SelectedNode.Text,
                dataBasesTreeView.SelectedNode.Parent.Text);
                tbForeign.Text = getForeignKey(dataBasesTreeView.SelectedNode.Text,
                dataBasesTreeView.SelectedNode.Parent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            DataTable dt = new DataTable();
            List<string> columns = getAllColumns(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text);
            foreach (var column in columns)
            {
                dt.Columns.Add(column);
                
            }

            dataGridView1.DataSource = dt;

            panelData.Visible = true;
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);

            if (data == "")
            {
                MessageBox.Show("The table data is empty!");
                panelData.Visible = false;
                return;
                
            }

            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');

            foreach (var r in rows)
            {
                string[] rowsdata = r.Split('#');

                DataRow row = dataTable.NewRow();
                int i = 0;
                foreach (var d in rowsdata)
                {
                    row[i] = d;
                    i++;
                }
                dataTable.Rows.Add(row);
                dataTable.AcceptChanges();
            }
        }

        private string getUniqueKey(string tableName, string dataBaseName)
        {
            string send = tableName + ";" + dataBaseName;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/getUniqueKeys");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
        private string getForeignKey(string tableName, string dataBaseName)
        {
            string send = tableName + ";" + dataBaseName;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/getForeignKey");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
        private string getData(string dataBaseName, string TableName)
        {
            string send = dataBaseName +";"+TableName ;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/alldata");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            keyText.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (keyText.Text == string.Empty)
            {
                MessageBox.Show("Please select the record you want to delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text, keyText.Text);
                    keyText.Text = string.Empty;
                    viewToolStripMenuItem_Click(null, null);

                }
                else if (dialogResult == DialogResult.No)
                {
                    dialogResult = System.Windows.Forms.DialogResult.No;
                }
            }
        }
        private void deleteData(string dataBase,string table,string key)
        {
            string send = dataBase + ";" + table + ";" + key;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/deletedata");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            MessageBox.Show(result);
        }

        private void panelData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelViewData_Click(object sender, EventArgs e)
        {
            panelData.Visible = false;
        }

        private void viewIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> columns = getAllColumns(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text);
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);
            FormIndex f = new FormIndex(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text,columns,data);
            f.Show();
        }

        private void btnUniqueIndex_Click(object sender, EventArgs e)
        {
            btnUniqueIndex.Visible = false;
            btnUniqueData.Visible = true;
            
            string indexName = tbUnique.Text + ".ind";
            string allIndex = getAllIndex(dataBasesTreeView.SelectedNode.Text,dataBasesTreeView.SelectedNode.Parent.Text);
            List<string> indList = allIndex.Split(';').ToList();
            indList.RemoveAt(indList.Count - 1);
            bool ok = false;
            foreach (var k in indList)
            {
                string check = k + ".ind";
                if (check == indexName)
                {
                    ok = true;
                }
            }
            if(ok ==false)
            {
                createIndex(dataBasesTreeView.SelectedNode.Text, indexName, dataBasesTreeView.SelectedNode.Parent.Text);
            }
            string value = "";
            string key = "";
            string send = "";
            int i = 0;
            int index = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.HeaderText == tbUnique.Text)
                {
                    index = i;
                }

                i++;
            }

            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                value = dataGridView1.Rows[j].Cells[0].Value.ToString();
                key = dataGridView1.Rows[j].Cells[index].Value.ToString();
                send =send + key + ";" + value + ":";
            }
            insertUniqueKeyIndex(indexName,dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text, send);
        }

        private string getAllIndex(string tableName, string dataBaseName)
        {
            string send = tableName + ";" + dataBaseName;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/allIndexName");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        private void btnUniqueData_Click(object sender, EventArgs e)
        {
            string file = tbUnique.Text + ".ind";
            string data = getUniquedata(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text,
                file);

            DataTable dt = new DataTable();
            dt.Columns.Add("KEY");
            dt.Columns.Add("VALUE");

            dataGridView1.DataSource = dt;
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');

            foreach (var r in rows)
            {
                string[] rowsdata = r.Split('#');

                DataRow row = dataTable.NewRow();
                int i = 0;
                foreach (var d in rowsdata)
                {
                    row[i] = d;
                    i++;
                }
                dataTable.Rows.Add(row);
                dataTable.AcceptChanges();
            }
        }

        private void insertUniqueKeyIndex(string fileName, string tableName, string dataBaseName, string data)
        {
            string send = fileName + "//" + tableName + "//" + dataBaseName + "//" + data;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/insertUniqueKeyIndex");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
        }

        private string getUniquedata(string dataBaseName, string TableName, string file)
        {
            string send = dataBaseName + ";" + TableName+";"+file;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/alluniquedata");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        private void ForeignKeyIndexData_Click(object sender, EventArgs e)
        {
            //Check if the index exists
            string indexName = tbForeign.Text;
            string tableName = dataBasesTreeView.SelectedNode.Text;
            string dataBaseName = dataBasesTreeView.SelectedNode.Parent.Text;
            string exists = checkIfIndexExists(indexName, tableName, dataBaseName);

            if (exists== "Indexul nu exista")
            {
                MessageBox.Show("Please create the index first");
            }
            else
            {
                ShowForeignKeyData(exists, tableName, dataBaseName);
                ForeignKeyIndexData.Visible = false;
            }
            
            
        }
        private void ShowForeignKeyData(string indexName, string tableName, string dataBaseName)
        {
            List<ForeignData> data = new List<ForeignData>();
            string send = "";
            int i = 0;
            int index = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.HeaderText == tbForeign.Text)
                {
                    index = i;
                }

                i++;
            }

            List<string> keys = new List<string>(); 
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                keys.Add(dataGridView1.Rows[j].Cells[index].Value.ToString());
            }
            List<string> disKeys = keys.Distinct().ToList();
            
            foreach (var l in disKeys)
            {
                ForeignData c = new ForeignData(l, "");
                data.Add(c);
            }
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                foreach( var k in disKeys)
                {
                    if (dataGridView1.Rows[j].Cells[index].Value.ToString() == k) {

                        foreach (var d in data)
                        {
                            if (k == d.Key)
                            {
                                d.Data = d.Data + dataGridView1.Rows[j].Cells[0].Value.ToString()+";";
                            }
                        }
                    }
                }
            }
            
            foreach (var s in data)
            {
                string t = s.Key;
                string v = s.Data;

                send = send + t + "#" + v + "&";
            }
            insertForeignKeyData(indexName, tableName, dataBaseName, send);
            string foreigndata = viewForeignData(dataBaseName, tableName, indexName);
            DataTable dt = new DataTable();
            dt.Columns.Add("KEY");
            dt.Columns.Add("VALUE");

            dataGridView1.DataSource = dt;
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            foreigndata = foreigndata.Remove(foreigndata.Length - 1);
            string[] rows = foreigndata.Split('&');

            foreach (var r in rows)
            {
                string[] rowsdata = r.Split('#');

                DataRow row = dataTable.NewRow();
                int q = 0;
                foreach (var d in rowsdata)
                {
                    row[q] = d;
                    q++;
                }
                dataTable.Rows.Add(row);
                dataTable.AcceptChanges();
            }
            
        }
        private string viewForeignData(string database, string tableName, string indexName)
        {
            string send = database + ";" + tableName + ";" + indexName;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/allforeigndata");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
        private void insertForeignKeyData(string indexName, string tableName, string dataBaseName,string send)
        {
            string data = indexName + "//" + tableName + "//" + dataBaseName + "//" + send;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/insertForeignKeyData");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
        }

        public string checkIfIndexExists( string indexName, string tableName, string dataBaseName)
        {
            string send = indexName + ";" + tableName + ";" + dataBaseName + ";";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/checkIfIndexExists");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(send);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }
        public class ForeignData
        {
            public string Key { get; set; }
            public string Data { get; set; }
            public ForeignData(string key, string data)
            {
                Key = key;
                Data = data;
            }
            //Other properties, methods, events...
        }

        private void selectAllWithSpeccificKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbKeys.Items.Clear();
            panelAlldataWithKey.Visible = true;
            panelDataSelectedColumns.Visible = false;
            panelData.Visible = false;
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);
            if (data == "")
            {
                MessageBox.Show("The table data is empty!");
                panelData.Visible = false;
                return;

            }
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');
            List<string> keys1 = new List<string>();

            foreach (var r in rows)
            {
                string[] col = r.Split('#');
                keys1.Add(col[0]);

            }
            foreach(var key in keys1)
            {
                cbKeys.Items.Add(key);
            }
            

        }

        private void btnShowDataKey_Click(object sender, EventArgs e)
        {
            dataGridViewwithKey.Visible = true;
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);
            if (data == "")
            {
                MessageBox.Show("The table data is empty!");
                panelData.Visible = false;
                return;

            }
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');
            List<string> d = new List<string>();
            foreach (var r in rows)
            {
                string[] col = r.Split('#');
                if (col[0] == cbKeys.Text)
                {
                    for (int i=1;i<col.Length;i++) {
                        d.Add(col[i]);
                    }
                }
            }
            
            DataTable dt = new DataTable();
            List<string> columns = getAllColumns(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text);
            
            for (int j = 1; j < columns.Count(); j++)
            {
                dt.Columns.Add(columns[j]);
            }
            dataGridViewwithKey.DataSource = dt;
            DataTable dataTable = (DataTable)dataGridViewwithKey.DataSource;
            DataRow row = dataTable.NewRow();
            int k = 0;
            foreach (var c in d)
            {
                row[k] = c;
                k++;
            }
            dataTable.Rows.Add(row);
            dataTable.AcceptChanges();
        }

        private void selectTheColumnsWithSpecifiedKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            dataGridViewSelectedColumns.Visible=true;
            if (cbKey2.Text == "")
            {
                MessageBox.Show("Please select a key");
                return;
            }
            if (col.Count==0)
            {
                MessageBox.Show("Please add columns");
                return;
            }
            DataTable dt = new DataTable();
            foreach(var c in col)
            {
                dt.Columns.Add(c);
            }
            dataGridViewSelectedColumns.DataSource = dt;
            DataTable dataTable = (DataTable)dataGridViewSelectedColumns.DataSource;
            List<string> columns = getAllColumns(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text);
            List<int> indexes = new List<int>();
           
            foreach(var p in col)
            {
                for(int i = 0; i < columns.Count; i++)
                {
                    if (p == columns[i])
                    {
                        indexes.Add(i);
                    }
                }
            }
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);
            if (data == "")
            {
                MessageBox.Show("The table data is empty!");
                panelData.Visible = false;
                return;

            }
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');
            List<string> d = new List<string>();
            foreach (var r in rows)
            {
                string[] col = r.Split('#');
                if (col[0] == cbKey2.Text)
                {
                    for (int i = 0; i < col.Length; i++)
                    {
                        d.Add(col[i]);
                    }
                }
            }
            DataRow row = dataTable.NewRow();
            int k = 0;
            
            foreach (var j in indexes)
            {
                for (int i = 0; i < d.Count; i++)
                {
                    if (i == j)
                    {
                        row[k] = d[i];
                        k++;
                    }
                }
            }
            dataTable.Rows.Add(row);
            dataTable.AcceptChanges();
            col.Clear();
            cbKey2.Text = "";
        }

        private void showTheSelectedColumnsWithSpecifiedKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbKey2.Items.Clear();
            cbColumns2.Items.Clear();
            panelDataSelectedColumns.Visible = true;
            panelData.Visible = false;
            panelAlldataWithKey.Visible = false;
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);
            if (data == "")
            {
                MessageBox.Show("The table data is empty!");
                panelData.Visible = false;
                return;

            }
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');
            List<string> keys = new List<string>();

            foreach (var r in rows)
            {
                string[] col = r.Split('#');
                keys.Add(col[0]);

            }
            foreach (var key in keys)
            {
                cbKey2.Items.Add(key);
            }
            List<string> columns = getAllColumns(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text);

            foreach(var col in columns)
            {
                cbColumns2.Items.Add(col);
            }
        }
        private static List<string> col = new List<string>();
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (cbColumns2.Text == "")
            {
                MessageBox.Show("Please select a column");
                return;
            }
            if (!col.Contains(cbColumns2.Text)) {
                col.Add(cbColumns2.Text);
                cbColumns2.Text = "";
            }
            else
            {
                MessageBox.Show("the column is already selected");
            }
        }

        private void btnColumnsData_Click(object sender, EventArgs e)
        {
            dataGridViewSelectedColumns.Visible = true;

            if (col.Count == 0)
            {
                MessageBox.Show("Please add columns");
                return;
            }
            DataTable dt = new DataTable();
            foreach (var c in col)
            {
                dt.Columns.Add(c);
            }
            dataGridViewSelectedColumns.DataSource = dt;
            DataTable dataTable = (DataTable)dataGridViewSelectedColumns.DataSource;
            List<string> columns = getAllColumns(dataBasesTreeView.SelectedNode.Text, dataBasesTreeView.SelectedNode.Parent.Text);
            List<int> indexes = new List<int>();

            foreach (var p in col)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    if (p == columns[i])
                    {
                        indexes.Add(i);
                    }
                }
            }
            string data = getData(dataBasesTreeView.SelectedNode.Parent.Text, dataBasesTreeView.SelectedNode.Text);
            if (data == "")
            {
                MessageBox.Show("The table data is empty!");
                panelData.Visible = false;
                return;

            }
            data = data.Remove(data.Length - 1);
            string[] rows = data.Split(';');
            
            foreach (var r in rows)
            {
                string[] rowsdata = r.Split('#');
                
                DataRow row = dataTable.NewRow();
                int k = 0;

                foreach (var j in indexes)
                {
                    for (int i = 0; i < rowsdata.Length; i++)
                    {
                        if (i == j)
                        {
                            row[k] = rowsdata[i];
                            k++;
                        }
                    }
                }
                dataTable.Rows.Add(row);
                dataTable.AcceptChanges();
            }
            col.Clear();
        }
    }
}
