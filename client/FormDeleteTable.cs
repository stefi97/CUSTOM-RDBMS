using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormDeleteTable : Form
    {
        public static string dataBaseName;
        public FormDeleteTable(string db)
        {
            dataBaseName = db;
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string deleteTableName = TableTree.SelectedNode.Text;
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Table?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteTable(deleteTableName);
            }
            else if (dialogResult == DialogResult.No)
            {
                dialogResult = System.Windows.Forms.DialogResult.No;
            }
           
        }
        private void DeleteTable(string TableName)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/deleteTable");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string table = TableName;
                streamWriter.Write(table);
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
        private void TablesBtn_Click(object sender, EventArgs e)
        {
            TableTree.Nodes.Clear();
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

            List<string> listStrLineElements = result.Split(';').ToList();
            listStrLineElements.RemoveAt(listStrLineElements.Count - 1);

            for (int i = 0; i < listStrLineElements.Count; i++)
            {

                TableTree.Nodes.Add(new TreeNode() { Text = listStrLineElements[i] });
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = true;
            tableNameIndex.Text = TableTree.SelectedNode.Text;
        }

        private void btnOkIndex_Click(object sender, EventArgs e)
        {
            string tableName = tableNameIndex.Text;
            string indexName = indexColumnText.Text;

            string send = tableName + ";" + indexName;
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
        }

        private void btnCancelIndex_Click(object sender, EventArgs e)
        {
            panelIndex.Visible = false;
            indexColumnText.Text = "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
