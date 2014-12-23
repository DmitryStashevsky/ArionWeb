using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseGenerator.MsAccess
{
    public class TranslationModel
    {
        private Hashtable m_ColumnIndexes;

        public TranslationModel(DataColumnCollection dataColumnCollection)
        {
            m_ColumnIndexes = new Hashtable();
            foreach (DataColumn column in dataColumnCollection)
            {
                m_ColumnIndexes[column.ColumnName] = dataColumnCollection.IndexOf(column);
            }
        }

        public Element TranslateRow(DataRow row)
        {
            Element element = new Element();
            element.Name = (string)TranslateValue(DataTranslate.Name, row);
            element.FailureRate = (float?)TranslateValue(DataTranslate.FailureRate, row);
            element.Specification = (string)TranslateValue(DataTranslate.Specification, row);
            element.FailureRateSwitch = (float?)TranslateValue(DataTranslate.FailureRateSwitch, row);
            element.SubType = (string)TranslateValue(DataTranslate.SubType, row);
            element.ManufacturingTechnology = TranslateValue(DataTranslate.ManufacturingTechnology, row).ToString();
            element.TypeOfHousing = TranslateValue(DataTranslate.TypeOfHousing, row).ToString();
            element.Quantity = (int?)TranslateValue(DataTranslate.Quantity, row);
            //add Temperature properties
            return element;
        }

        private object TranslateValue(string columnKey, DataRow row)
        {
            if (m_ColumnIndexes.ContainsKey(columnKey))
            {
                var value = row[(int)m_ColumnIndexes[columnKey]];
                if (DBNull.Value != value)
                {
                    return row[(int)m_ColumnIndexes[columnKey]];
                }
            }
            return null;
        }
    }
}
