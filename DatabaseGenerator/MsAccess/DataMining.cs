using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseGenerator.MsAccess
{
    public class DataMining
    {
        string m_ConnectionString;

        public DataMining(string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/lib.MDB")
        {
            m_ConnectionString = connectionString;
        }

        public void Mining(string tableName)
        {
            using (var accessConnection = new OleDbConnection(m_ConnectionString))
            {
                accessConnection.Open();
                string accessSelect = string.Format("SELECT * FROM [{0}]", tableName);
                OleDbCommand accessCommand = new OleDbCommand(accessSelect, accessConnection);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(accessCommand);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, tableName);

                DataColumnCollection dataColumnCollection = dataSet.Tables[tableName].Columns;
                TranslationModel translationModel = new TranslationModel(dataColumnCollection);

                DataRowCollection dataRowCollection = dataSet.Tables[tableName].Rows;
                foreach (DataRow dataRow in dataRowCollection)
                {
                    var sss = translationModel.TranslateRow(dataRow);
                }
            }
        }
    }
}
