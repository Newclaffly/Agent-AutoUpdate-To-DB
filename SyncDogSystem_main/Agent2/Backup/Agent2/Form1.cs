using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Agent2
{
    public partial class Form1 : Form
    {
        string connecting = @"Data Source=172.16.16.1;Initial Catalog=bds_pp_srct;Integrated Security=true;"; //sql connection

        string partnumber;
        string srctcode;
        string dockcode;
        string pack;
        string error;
        string chk;
        string user;
        string ekb;
        string kbid;
        public Form1()
        {
            InitializeComponent();
        }

        private void select_hanheld()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    SqlDataAdapter dtaddAdapter;
                    DataTable dtselect = new DataTable();
                    string select = "SELECT Part_Number,SRCT_Code,Dock_Code,Package,Error_Code,Chk_Type,LogUser,ekb_order_no,Kanban_ID FROM Hanheld";
                    dtaddAdapter = new SqlDataAdapter(select, conn);
                    dtaddAdapter.Fill(dtselect);
                    conn.Close();
                    for (int i = 0; i < dtselect.Rows.Count; i++)
                    {
                        partnumber = dtselect.Rows[i]["Part_number"].ToString();
                        srctcode = dtselect.Rows[i]["SRCT_Code"].ToString();
                        dockcode = dtselect.Rows[i]["Dock_Code"].ToString();
                        pack = dtselect.Rows[i]["Package"].ToString();
                        error = dtselect.Rows[i]["Error_Code"].ToString();
                        chk = dtselect.Rows[i]["Chk_Type"].ToString();
                        user = dtselect.Rows[i]["LogUser"].ToString();
                        //day = dtselect.Rows[i]["LogDate"].ToString();
                        ekb = dtselect.Rows[i]["ekb_order_no"].ToString();
                        kbid = dtselect.Rows[i]["Kanban_ID"].ToString();
                        insert_newtable();

                    }
                    // MessageBox.Show("Clone Succees");
                    delete_log_hanheld();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_newtable()
        {
            string day = DateTime.Now.ToString("dd/mm/yy hh:mm:ss tt");
            using (SqlConnection conn = new SqlConnection(connecting))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT  INTO report_hanheld(Part_Number,SRCT_Code,Dock_Code,Package,Error_Code,Chk_Type,LogUser,LogDate,ekb_order_no,Kanban_ID) VALUES(@partnumber,@srctcode,@dockcode,@pack,@error,@chk,@user,@day,@ekb,@kbid)";
                    cmd.Parameters.AddWithValue("@partnumber", partnumber);
                    cmd.Parameters.AddWithValue("@srctcode", srctcode);
                    cmd.Parameters.AddWithValue("@dockcode", dockcode);
                    cmd.Parameters.AddWithValue("@pack", pack);
                    cmd.Parameters.AddWithValue("@error", error);
                    cmd.Parameters.AddWithValue("@chk", chk);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@ekb", ekb);
                    cmd.Parameters.AddWithValue("@kbid", kbid);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        // MessgeBox.Show(e.Message.ToString(), "Error Message");
                    }
                }
            }
        }

        private void delete_log_hanheld()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    SqlDataAdapter dtaddAdapter;
                    DataTable dtselect = new DataTable();
                    string select = "DELETE FROM Hanheld";
                    dtaddAdapter = new SqlDataAdapter(select, conn);
                    dtaddAdapter.Fill(dtselect);
                    conn.Close();
                    //MessageBox.Show("Delete Succees");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            string hh = DateTime.Now.ToString("hh");
            string mm = DateTime.Now.ToString("mm");
            string ss = DateTime.Now.ToString("ss");
            if (hh == "7" && mm == "30" && ss == "00")
            {
                select_hanheld();
                alert.Text = "ทำการซิงค์ข้อมูล";
                //MessageBox.Show("Complete");
            }
            else
            {
                alert.Text = "ไม่มีการซิงค์ข้อมูล";
            }
        }

        private void clone_Click(object sender, EventArgs e)
        {
            select_hanheld();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/mm/yy hh:mm:ss tt");
        }

       


    }
}
