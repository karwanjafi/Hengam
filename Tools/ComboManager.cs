using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HengamWidgets;
using ComboManager;


namespace Hengam.ComboManager
{


    //public interface IComboFillable
    //{
    //    /// <summary>
    //    /// Dont change this name. Or update it in ComboFiller's FillCombo Method.
    //    /// </summary>
    //    string ComboText { get; }
    //    string ComboDescription { get; }

    //}



    public class ComboFiller<T>
    {
        public class ComboCantSupportException : Exception
        {
            public ComboCantSupportException()
                : base("Class doesn't support IComboFillable.")
            {

            }
        }

        public static void FillCombo(ComboBox comboBox, List<T> fillWith)
        {
            if (fillWith == null || fillWith.Count == 0)
                return;

            //comboBox.SelectedValueChanged += new EventHandler(SetTooltip);
            if (fillWith[0] is IComboFillable)
            {
                comboBox.Items.Clear();
                comboBox.DisplayMember = "ComboText";
                foreach (T item in fillWith)
                {
                    IComboFillable fillable = item as IComboFillable;
                    int i = comboBox.Items.Add(fillable);
                }
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        /// <summary>
        /// Fills a CoolComboBox with fillWith list.
        /// </summary>
        /// <param name="comboBox">the comboBox to fill.</param>
        /// <param name="fillWith">the list to fill comboBox with.</param>
        public static void FillCombo(CoolComboBox comboBox, List<T> fillWith)
        {
            if (fillWith == null || fillWith.Count == 0)
                return;

            //comboBox.SelectedValueChanged += new EventHandler(SetTooltip);
            if (fillWith[0] is IComboFillable)
            {
                comboBox.Items.Clear();
                comboBox.DisplayMember = "ComboText";
                foreach (T item in fillWith)
                {
                    IComboFillable fillable = item as IComboFillable;
                    int i = comboBox.Items.Add(fillable);
                }
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        public static void FillList(ListBox listBox, List<T> fillWith)
        {
            if (fillWith == null || fillWith.Count == 0)
                return;

            //listBox.SelectedValueChanged += new EventHandler(SetTooltip);
            if (fillWith[0] is IComboFillable)
            {
                listBox.Items.Clear();
                listBox.DisplayMember = "ComboText";
                foreach (T item in fillWith)
                {
                    IComboFillable fillable = item as IComboFillable;
                    int i = listBox.Items.Add(fillable);
                }
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        public static void Add(ListBox listBox, T fillWith)
        {
            if (fillWith == null)
                return;

            //listBox.SelectedValueChanged += new EventHandler(SetTooltip);
            if (fillWith is IComboFillable)
            {
                listBox.DisplayMember = "ComboText";
                IComboFillable fillable = fillWith as IComboFillable;
                int i = listBox.Items.Add(fillable);
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        public static void Add(ComboBox comboBox, T fillWith)
        {
            if (fillWith == null)
                return;

            //comboBox.SelectedValueChanged += new EventHandler(SetTooltip);
            if (fillWith is IComboFillable)
            {
                comboBox.DisplayMember = "ComboText";
                IComboFillable fillable = fillWith as IComboFillable;
                int i = comboBox.Items.Add(fillable);
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        /// <summary>
        /// Gets selected item from ComboBox.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public static T GetFromCombo(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
                return default(T);

            if (comboBox.SelectedItem is T)
            {
                return (T)comboBox.SelectedItem;
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        /// <summary>
        /// Sets selected item in comboBox to setTo item.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="setTo"></param>
        public static void SetCombo(ComboBox comboBox, T setTo)
        {
            if (comboBox.Items.Count == 0)
                return;

            if (comboBox.Items[0] is T)
            {
                foreach (object item in comboBox.Items)
                {
                    //if (((T)item as IComboFillable<T>).ComboText == (setTo as IComboFillable<T>).ComboText)
                    if (((T)item).Equals(setTo))
                    {
                        comboBox.SelectedItem = item;
                        return;
                    }
                }
                comboBox.SelectedItem = null;
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }


        /// <summary>
        /// Gets selected item from ComboBox.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public static T GetFromCombo(CoolComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
                return default(T);

            if (comboBox.SelectedItem is T)
            {
                return (T)comboBox.SelectedItem;
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }

        /// <summary>
        /// Sets selected item in comboBox to setTo item.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="setTo"></param>
        public static void SetCombo(CoolComboBox comboBox, T setTo)
        {
            if (comboBox.Items.Count == 0)
                return;

            if (comboBox.Items[0] is T)
            {
                foreach (object item in comboBox.Items)
                {
                    //if (((T)item as IComboFillable<T>).ComboText == (setTo as IComboFillable<T>).ComboText)
                    Type tt = typeof(T);
                    if (((T)item).Equals(setTo))
                    {
                        comboBox.SelectedItem = item;
                        return;
                    }
                }
                comboBox.SelectedItem = null;
            }
            else
            {
                throw new ComboCantSupportException();
            }
        }
        //private static void SetTooltip(object sender, EventArgs e)
        //{
        //    // Sender is ComboBox.


        //    CoolComboBox comboBox = sender as CoolComboBox;
        //    if(comboBox.SelectedItem == null ) return;

        //    IComboFillable fillable = (comboBox.SelectedItem) as IComboFillable;
        //    comboBox.SetToolTip(fillable.ComboDescription);


        //}
    }



}
