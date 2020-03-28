using Newtonsoft.Json;
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
    
    public partial class FormTable : Form
    {
        public static List<Column> columns = new List<Column>();
        public static int rowLg = 0;  
        public static string dataBaseName;
        public static List<string> columnsNames = new List<string>();

        public FormTable(string DataBaseName)
        {
            dataBaseName = DataBaseName;
            InitializeComponent();
        }
        private void addColumnBtn_Click(object sender, EventArgs e)
        {
            Column column = new Column(clName.Text, TypeCb.Text, clLength.Text, cbIsNull.Text);
            columnsNames.Add(clName.Text);
            if (clLength.Text != string.Empty)
            {
                int parsedValue;
                if (!int.TryParse(clLength.Text, out parsedValue))
                {
                    MessageBox.Show("Column Length is a number only field");
                    return;
                }
                else
                {
                    rowLg = rowLg + Int32.Parse(clLength.Text);
                }

            }
            if (clName.Text == string.Empty)
            {
                MessageBox.Show("Please name the column");
                return;
            }
            if (TypeCb.Text == string.Empty)
            {
                MessageBox.Show("Please choose the column type");
                return;
            }
            if (cbIsNull.Text == string.Empty)
            {
                MessageBox.Show("Please choose if the column is null or not");
                return;
            }
            columns.Add(column);

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = clName.Text;

            dataGridView1.Rows[n].Cells[1].Value = TypeCb.Text;

            dataGridView1.Rows[n].Cells[2].Value = clLength.Text;

            dataGridView1.Rows[n].Cells[3].Value = cbIsNull.Text;
             
            clName.Text = string.Empty;
            TypeCb.Text = string.Empty;
            clLength.Text = string.Empty;
            cbIsNull.Text = string.Empty;
        }

        private void btnAddTableOK_Click(object sender, EventArgs e)
        {
            if (TableName.Text == string.Empty)
            {
                MessageBox.Show("Please name the table");
                return;
            }
            string file = TableName.Text + "kv";
            List<string> PrimaryKey = new List<string>();
            if (cbPrimaryKey.Text != "")
            {
                PrimaryKey.Add(cbPrimaryKey.Text);
            }

            List<string> UniqueKeys = new List<string>();


            if (cbUniqueKey.Text != "") {

                UniqueKeys.Add(cbUniqueKey.Text);
            }
            List<string> ForeignKeys = new List<string>();


            if (cbForeignKey.Text != "")
            {

                ForeignKeys.Add(cbForeignKey.Text);
            }

            List<Column> ceva = columns;
            List<string> IndexFiles = new List<string>();

            Table table = new Table(TableName.Text, file, rowLg.ToString(), columns, PrimaryKey, UniqueKeys, ForeignKeys, IndexFiles);
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/createTable");
            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers["dataBaseName"] = dataBaseName;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(table);


                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            columns.Clear();
            this.Close();
        }

        private void btnCnAddTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            foreach (var cl in columnsNames)
            {
                cbForeignKey.Items.Add(cl);
                cbPrimaryKey.Items.Add(cl);
                cbUniqueKey.Items.Add(cl);
            }
            columnsNames.Clear();
        }
    }
    public class Column
    {
        public string ColumnName { get; set; }
        public string Tip { get; set; }
        public string Length { get; set; }
        public string IsNull { get; set; }
        public Column(string name, string tip, string length, string isNull)
        {
            ColumnName = name;
            Tip = tip;
            Length = length;
            IsNull = isNull;
        }
        //Other properties, methods, events...
    }
    public class Table
    {
        public string TableName { get; set; }
        public string FileName { get; set; }
        public string RowLength { get; set; }
        public List<Column> Columns { get; set; }
        public List<string> PrimaryKey { get; set; }
        public List<string> UniqueKeys { get; set; }
        public List<string> ForeignKeys { get; set; }
        public List<string> IndexFiles { get; set; }

        public Table(string name, string file, string row, List<Column> columns, List<string> primaryKey, List<string> uniqueKeys,List<string> foreignKeys,List<string>indexFiles)
        {
            TableName = name;
            FileName = file;
            RowLength = row;
            Columns = columns;
            PrimaryKey = primaryKey;
            UniqueKeys = uniqueKeys;
            ForeignKeys = foreignKeys;
            IndexFiles = indexFiles;
        }

    }

}
