using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CSharpTest_HalaiYaroslav
{
    static class LINQer
    {
        public static DataTable GetTable(DataTable dataTable, List<DataColumn> colNamesToGroup, List<DataColumn> colNamesToSum)
        {
            /*There must be a code that make an Expressions Tree which will build in cycles 
             * which iterating through the colNamesToGrop and colNamesToSum. Than execute
             * the query and build DataTable by CreateDataTable method. (I have no time to learn Expresions Trees untill deadline.)
             */
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method takes an iteratable list of any type
        /// </summary>
        /// <typeparam name="T">Type of list parameters</typeparam>
        /// <param name="list">List of elements which will be insearted to datatable</param>
        /// <returns>DataTable representation of some object</returns>
        static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
