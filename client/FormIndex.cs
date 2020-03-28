using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormIndex : Form
    {
        public string DataBaseName;
        public string TableName;
        public string Data;
        public List<string> Columns;
        public FormIndex(string table, string database, List<string>columns, string data)
        {
            TableName = table;
            DataBaseName = database;
            Data = data;
            Columns = columns;
            InitializeComponent();

        }

        private void btnShowIndex_Click(object sender, EventArgs e)
        {
            IndexTreeView.Visible = true;
            List<string> indexes = getAllIndexNames(TableName,DataBaseName);
            for (int i = 0; i < indexes.Count; i++)
            {

                IndexTreeView.Nodes.Add(new TreeNode() { Text = indexes[i] });
                
            }
        }

        private List<string> getAllIndexNames(string tbName, string dbName)
        {
            var message = tbName + ";" + dbName;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/allIndexName");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(message);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            List<string> indexes = result.Split(';').ToList();
            indexes.RemoveAt(indexes.Count - 1);
            return indexes;
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic data = new ExpandoObject();
           
            Data = Data.Remove(Data.Length - 1);
            string[] rows = Data.Split(';');
            string[] dataValue = rows[0].Split('#');

            int i = 0;
            foreach (var c in Columns)
            {
                AddProperty(data, c, dataValue[i]);
                i++;
            }


            
        }
        public static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
                expandoDict[propertyName] = propertyValue;
            else
                expandoDict.Add(propertyName, propertyValue);
        }
    }
}
