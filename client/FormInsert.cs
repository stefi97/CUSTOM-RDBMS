using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Client
{
    public partial class FormInsert : Form
    {
        private int A = 1;
        private int B = 1;
        public string DataBaseName;
        public string TableName;

        public FormInsert(string table, string database)
        {
            TableName = table;
            DataBaseName = database;
            InitializeComponent();
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
        }

        private void showColumnsBtn_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create("http://localhost:8080/allColumns");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var data = TableName + ";" + DataBaseName;
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            var columns = result.Split(';').ToList();
            columns.RemoveAt(columns.Count - 1);
            foreach (var col in columns)
            {
                addNewLabel(col);
                addNewText(col);
            }

            showColumnsBtn.Visible = false;
        }

        public Label addNewLabel(string columnName)
        {
            var abc = new Label();
            Controls.Add(abc);
            abc.Top = B * 28;
            abc.Left = 50;
            abc.Text = columnName;
            B = B + 1;
            return abc;
        }

        public TextBox addNewText(string columnName)
        {
            var text = new TextBox();
            Controls.Add(text);
            text.Top = A * 28;
            text.Left = 150;
            text.Text = "";
            text.Name = columnName;
            A = A + 1;
            return text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            var message = TableName + ";" + DataBaseName + ";";
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                message += textBox.Text + ";";
            }
            var httpWebRequest = (HttpWebRequest) WebRequest.Create("http://localhost:8080/insert");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(message);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
            var result = "";
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            MessageBox.Show(result);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void getForeignKeyId (string tablename, string databaseName){

        }
        
    }
}