using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DatabaseSchemaNamespace;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
using BusinessObjectNamespace;
using Hengam.Forms;

namespace DataGridFiller
{
    public interface IGridValue
    {
        string GetGridValue(ColumnDefinition columnDefinition);
    }

    public class DataGridFiller<T>
    {
        public class DatagridCantSupportException : Exception
        {
            public DatagridCantSupportException()
                : base("Class doesn't support IColumnReader.")
            {

            }
        }

  

        public static void FillDataGrid(DataGridView dataGrid, List<T> list, List<ColumnDefinition> captions)
        {
            //hanieh
            dataGrid.Columns.Clear();

            foreach (ColumnDefinition caption in captions)
            {
                dataGrid.Columns.Add(caption.Name, caption.Caption);
            }

            if (list.Count == 0)
            {
                dataGrid.Rows.Clear();
                return;
            }
            if (!(list[0] is IGridValue))
            {
                throw new DatagridCantSupportException();
            }

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                IGridValue colReader = item as IGridValue;
                int j = dataGrid.Rows.Add();

                DataGridViewRow row = dataGrid.Rows[j];
                row.Tag = item;
                for (int k = 0; k < captions.Count; k++)
                {
                    row.Cells[captions[k].Name].Value = colReader.GetGridValue(captions[k]);
                }
            }
            //foreach (T item in list)
            //{
                
            //}
            if (dataGrid.SelectedRows.Count > 0)
                dataGrid.SelectedRows[0].Selected = false;
        }
    }

}
