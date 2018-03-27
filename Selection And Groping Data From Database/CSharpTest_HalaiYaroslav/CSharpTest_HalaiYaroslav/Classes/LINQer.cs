using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CSharpTest_HalaiYaroslav
{
    static class LINQer
    {
        #region Old Version        
        public static DataTable GetTable(DataSet dataSet, string colName1)
        {
            var query = from orgInfoRow in dataSet.Tables[0].AsEnumerable()
                        group orgInfoRow by orgInfoRow[colName1] into grp
                        select new
                        {
                            ColumnName1 = grp.Key,
                            Quantity = grp.Sum(q => q.Field<Int32>("Quantity")),
                            Sum = grp.Sum(s => s.Field<Decimal>("Sum"))
                        };

            DataTable newDataTable = CreateDataTable(query);
            newDataTable.Columns[0].ColumnName = colName1;

            return newDataTable;
        }

        public static DataTable GetTable(DataSet dataSet, string colName1, string colName2)
        {
            var query = from orgInfoRow in dataSet.Tables[0].AsEnumerable()
                        group orgInfoRow by new
                        {
                            colName1 = orgInfoRow[colName1],
                            colName2 = orgInfoRow[colName2]
                        } into grp
                        select new
                        {
                            ColumnName1 = grp.Key.colName1,
                            ColumnName2 = grp.Key.colName2,
                            Quantity = grp.Sum(q => q.Field<Int32>("Quantity")),
                            Sum = grp.Sum(s => s.Field<Decimal>("Sum"))
                        };

            DataTable newDataTable = CreateDataTable(query);
            newDataTable.Columns[0].ColumnName = colName1;
            newDataTable.Columns[1].ColumnName = colName2;

            return newDataTable;
        }
        
        public static DataTable GetTable(DataSet dataSet, string colName1, string colName2, string colName3)
        {
            var query = from orgInfoRow in dataSet.Tables[0].AsEnumerable()
                        group orgInfoRow by new
                        {
                            colName1 = orgInfoRow[colName1],
                            colName2 = orgInfoRow[colName2],
                            colName3 = orgInfoRow[colName3]
                        } into grp
                        select new
                        {
                            ColumnName1 = grp.Key.colName1,
                            ColumnName2 = grp.Key.colName2,
                            ColumnName3 = grp.Key.colName3,
                            Quantity = grp.Sum(q => q.Field<Int32>("Quantity")),
                            Sum = grp.Sum(s => s.Field<Decimal>("Sum"))
                        };

            DataTable newDataTable = CreateDataTable(query);
            newDataTable.Columns[0].ColumnName = colName1;
            newDataTable.Columns[1].ColumnName = colName2;
            newDataTable.Columns[3].ColumnName = colName3;

            return newDataTable;
        }

        public static DataTable GetTable(DataSet dataSet, string colName1, string colName2, string colName3, string colName4)
        {
            var query = from orgInfoRow in dataSet.Tables[0].AsEnumerable()
                        group orgInfoRow by new
                        {
                            colName1 = orgInfoRow[colName1],
                            colName2 = orgInfoRow[colName2],
                            colName3 = orgInfoRow[colName3],
                            colName4 = orgInfoRow[colName4]
                        } into grp
                        select new
                        {
                            ColumnName1 = grp.Key.colName1,
                            ColumnName2 = grp.Key.colName2,
                            ColumnName3 = grp.Key.colName3,
                            ColumnName4 = grp.Key.colName4,
                            Quantity = grp.Sum(q => q.Field<Int32>("Quantity")),
                            Sum = grp.Sum(s => s.Field<Decimal>("Sum"))
                        };

            DataTable newDataTable = CreateDataTable(query);
            newDataTable.Columns[0].ColumnName = colName1;
            newDataTable.Columns[1].ColumnName = colName2;
            newDataTable.Columns[3].ColumnName = colName3;
            newDataTable.Columns[4].ColumnName = colName4;

            return newDataTable;
        }

        public static DataTable GetTable(DataSet dataSet, string colName1, string colName2, string colName3, string colName4, string colName5)
        {
            var query = from orgInfoRow in dataSet.Tables[0].AsEnumerable()
                        group orgInfoRow by new
                        {
                            colName1 = orgInfoRow[colName1],
                            colName2 = orgInfoRow[colName2],
                            colName3 = orgInfoRow[colName3],
                            colName4 = orgInfoRow[colName4],
                            colName5 = orgInfoRow[colName5]
                        } into grp
                        select new
                        {
                            ColumnName1 = grp.Key.colName1,
                            ColumnName2 = grp.Key.colName2,
                            ColumnName3 = grp.Key.colName3,
                            ColumnName4 = grp.Key.colName4,
                            ColumnName5 = grp.Key.colName5,
                            Quantity = grp.Sum(q => q.Field<Int32>("Quantity")),
                            Sum = grp.Sum(s => s.Field<Decimal>("Sum"))
                        };

            DataTable newDataTable = CreateDataTable(query);
            newDataTable.Columns[0].ColumnName = colName1;
            newDataTable.Columns[1].ColumnName = colName2;
            newDataTable.Columns[3].ColumnName = colName3;
            newDataTable.Columns[4].ColumnName = colName4;
            newDataTable.Columns[5].ColumnName = colName5;

            return newDataTable;
        }
        #endregion

        public static DataTable GetTable(DataTable dataTable, List<DataColumn> colNamesToGroup, List<DataColumn> colNamesToSum)
        {
            /*There must be a code that make a Expressions Tree which will build in cycles 
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
