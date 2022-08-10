using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmReminders : Form
    {
        public frmReminders()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReminder.Text.Length > 0)
                {
                    lstReminders.Items.Add(txtReminder.Text);
                    DataSet dst = new DataSet();

                    if (File.Exists("Reminders.xml"))
                    {
                        dst.ReadXml("Reminders.xml");
                        dst.Tables["Reminders"].Rows.Add(txtReminder.Text);
                        dst.WriteXml("Reminders.xml");
                    }
                    else
                    {
                        dst.Tables.Add("Reminders");
                        dst.Tables["Reminders"].Columns.Add("Heading");
                        dst.Tables["Reminders"].Rows.Add(txtReminder.Text);
                        dst.WriteXml("Reminders.xml");
                    }
                    txtReminder.Text = string.Empty;

                    if (btnDelete.Enabled == false)
                        btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void txtReminder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void lstReminders_Click(object sender, EventArgs e)
        {
            txtReminder.Text = lstReminders.SelectedItem.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataSet dst = new DataSet();
            try
            {
                if (lstReminders.SelectedItems.Count > 0)
                {
                    int selectedIndex = lstReminders.SelectedIndex;
                    lstReminders.Items.RemoveAt(lstReminders.SelectedIndex);
                    txtReminder.Text = string.Empty;

                    //update the xml
                    if (File.Exists("Reminders.xml"))
                    {
                        File.Delete("Reminders.xml");
                    }

                    dst.Tables.Add("Reminders");
                    dst.Tables["Reminders"].Columns.Add("Heading");

                    foreach (string s in lstReminders.Items)
                    {
                        dst.Tables["Reminders"].Rows.Add(s);
                    }
                    dst.WriteXml("Reminders.xml");

                    if (lstReminders.Items.Count > 0)
                    {
                        lstReminders.SelectedIndex = selectedIndex - 1;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReminders_Load(object sender, EventArgs e)
        {
            try
            {
                //Read the reminders from xml
                if (File.Exists("Reminders.xml"))
                {
                    DataSet dst = new DataSet();
                    dst.ReadXml("Reminders.xml");

                    if (dst.Tables["Reminders"] != null)
                    {
                        for (int i = 0; i <= dst.Tables["Reminders"].Rows.Count - 1; i++)
                        {
                            lstReminders.Items.Add(dst.Tables["Reminders"].Rows[i][0].ToString());
                        }
                    }
                }

                if (lstReminders.Items.Count > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
