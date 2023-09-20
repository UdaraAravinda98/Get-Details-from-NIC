using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NICOperations;




namespace NICApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
        }


        NICOperations.Class1 ob1 =new NICOperations.Class1();


        private void Add_KeyUp(object sender, KeyEventArgs e)
        {
            string NICNumber;

            if (e.KeyCode == Keys.Enter && txtIDNumber.Text != "")
            {
                NICNumber = txtIDNumber.Text;

                if (NICNumber.Length == 10 || NICNumber.Length == 12)
                {
                    if (NICNumber.Substring(NICNumber.Length - 1) == "X" || NICNumber.Substring(NICNumber.Length - 1) == "V")
                    {
                        if (NICNumber.Length == 10)
                        {
                            if (NICNumber.Substring(2, 3) == "000" || NICNumber.Substring(2, 3) == "500")
                            {
                                String Msg = "Invalid NIC";
                                MessageBox.Show(Msg);
                            }

                            else
                            {
                                int num = Int32.Parse(NICNumber.Substring(2, 3));
                                txtGender.Text = (ob1.FindGender(num));
                                txtDateOfBirth.Text = ("19" + NICNumber.Substring(0,2) + "." + ob1.DOB(num));
                                txtVote.Text = (ob1.Vote(NICNumber.Substring(9)));
                            }
                        }

                        else
                        {
                            if (NICNumber.Substring(4,3) == "000" || NICNumber.Substring(2, 3) == "500")
                            {

                                String Msg = "Invalid NIC!";
                                MessageBox.Show(Msg);
                            }

                            else
                            {
                                int num = Int32.Parse(NICNumber.Substring(4, 3));
                                txtGender.Text =(ob1.FindGender(num));
                                txtDateOfBirth.Text = (NICNumber.Substring(0,4) + "." + ob1.DOB(num));
                                txtVote.Text = (ob1.Vote(NICNumber.Substring(11)));
                            }
                        }
                    }

                    else
                    {
                        String Msg = "Invalid NIC!";
                        MessageBox.Show(Msg);
                    }
                }

                else
                {
                    String Msg = "Invalid NIC!";
                    MessageBox.Show(Msg);
                }

                    btnNext.Enabled = true;
                    btnNext.Focus();
                     e.Handled=false;
                }

                else
                {
                e.Handled = true;

                }
            }
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtGender.Text = " ";

            txtDateOfBirth.Text = " ";

            txtVote.Text = " ";

           txtIDNumber.Text = " ";

            txtIDNumber.Focus();
            
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
