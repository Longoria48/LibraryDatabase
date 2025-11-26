using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LibraryDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Presets on load
            rbBook.Checked = true;
            rbFair.Checked = true;
            rbYes.Checked = true;
            InterfaceManager();
        }
        //Update Labels & tb shown to user
        private void InterfaceManager()
        {
            if (rbBook.Checked)
            { 
                lbSlot1.Hide(); tbSlot1.Hide();
                lbSlot2.Hide(); tbSlot2.Hide(); 
                lbSlot3.Hide(); tbSlot3.Hide();

                lbCover.Show(); rbPaperback.Show(); rbHardCover.Show();
            }
            else if (rbEbook.Checked)
            {
                lbSlot1.Text = "Audio Length:"; 
                lbSlot2.Text = "Narrator Name:";
                lbSlot1.Show(); lbSlot2.Show(); lbSlot3.Hide();
                tbSlot1.Show(); tbSlot2.Show(); tbSlot3.Hide();
                lbCover.Hide(); rbPaperback.Hide(); rbHardCover.Hide();
            }
            else if (rbMag.Checked)
            {
                lbSlot1.Text = "Publisher:";
                lbSlot2.Text = "Issue Number:";
                lbSlot3.Text = "Issue Month:";
                lbSlot1.Show(); lbSlot2.Show(); lbSlot3.Show();
                tbSlot1.Show(); tbSlot2.Show(); tbSlot3.Show();
                lbCover.Hide(); rbPaperback.Hide(); rbHardCover.Hide();
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            InterfaceManager();
        }

        private Book CreateBook()
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string genre = tbGenre.Text;
            //If its not available its checked out
            //bool rb = true when NO is selected
            bool available = rbNo.Checked;
            //True = Good; False = Fair;
            bool condition = rbGood.Checked;

            //Type Options
            if (rbBook.Checked)
            {
                bool? isHardCover = null;

                if (rbPaperback.Checked)
                {
                    isHardCover = false; 
                }
            else if (rbHardCover.Checked)
            { 
                    isHardCover = true; 
            }

                return new Book(title, author, genre, condition, available, isHardCover);
            }
            else if (rbEbook.Checked)
            {
                if(!int.TryParse(tbSlot1.Text, out int audioLength))
                {
                    ListboxAlerts.Items.Add("Please enter a valid number for audio length.");
                    throw new Exception("Invalid audio length");
                }
                string narratorName = tbSlot2.Text.Trim();

                return new EBook(title, author, genre, condition, available, audioLength, narratorName);
            }
            else //Magazine
            {
                string publisher = tbSlot1.Text.Trim();
                if(!int.TryParse(tbSlot2.Text, out int issueNumber))
                {
                    ListboxAlerts.Items.Add("Please enter a valid number for issue number. Digits only");
                    throw new Exception("Invalid issue number");
                }
                string issueMonth = tbSlot3.Text.Trim();

                return new Magazine(title, publisher, issueNumber, issueMonth, condition, available);
            }
        }

        private void SaveMaterialToDB(Book material)
        {
            string connectionString = @"Data Source=KELCOS_OMNIBOOK\LONGORIAFA25; Initial Catalog=LibraryDB; User ID=LibraryAdmin; Password = Library1!; TrustServerCertificate=True";

            SqlConnection currConnection = null;
            SqlCommand myQuery= null;

            try
            {
                currConnection = new SqlConnection(connectionString);
                currConnection.Open();

                string sql = @"
                    INSERT INTO Materials
                    (Title, Author, Genre, GoodCondition, IsCheckedOut, Type,
                    AudioLength, NarratorName, IssueNumber, MonthIssue, Publisher, IsHardCover)
                    VALUES
                    (@Title, @Author, @Genre, @GoodCondition, @IsCheckedOut, @Type,
                    @AudioLength, @NarratorName, @IssueNumber, @MonthIssue, @Publisher, @IsHardCover);";

                myQuery = new SqlCommand(sql, currConnection);

                //Add Basic book values
                myQuery.Parameters.AddWithValue("@Title", material.Title);
                myQuery.Parameters.AddWithValue("@Author", material.Author);
                myQuery.Parameters.AddWithValue("@Genre", material.Genre);
                myQuery.Parameters.AddWithValue("@GoodCondition", material.GoodCondition);
                myQuery.Parameters.AddWithValue("@IsCheckedOut", material.IsCheckedOut);
                myQuery.Parameters.AddWithValue("@IsHardCover", material.IsHardCover);


                //Determine subtype
                string type = "Book";
                int? audioLength = null;
                string narratorName = null;
                int? issueNumber = null;
                string monthIssue = null;
                string publisher = null;

                if (material is EBook ebook)
                {
                    type = "EBook";
                    audioLength = ebook.AudioLength;
                    narratorName = ebook.NarratorName;
                }
                else if (material is Magazine mag)
                {
                    type = "Magazine";
                    issueNumber = mag.IssueNumber;
                    monthIssue = mag.MonthIssue;
                    publisher = mag.Publisher;
                }

                myQuery.Parameters.AddWithValue("@Type", type);
                myQuery.Parameters.AddWithValue("@AudioLength", (object)audioLength ?? DBNull.Value);
                myQuery.Parameters.AddWithValue("@NarratorName", (object)narratorName ?? DBNull.Value);
                myQuery.Parameters.AddWithValue("@IssueNumber", (object)issueNumber ?? DBNull.Value);
                myQuery.Parameters.AddWithValue("@MonthIssue", (object)monthIssue ?? DBNull.Value);
                myQuery.Parameters.AddWithValue("@Publisher", (object)publisher ?? DBNull.Value);

                myQuery.ExecuteNonQuery();
            }
            finally
            {
                if(myQuery != null)
                {
                    myQuery.Dispose();
                }

                if(currConnection != null && currConnection.State == ConnectionState.Open)
                {
                    currConnection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = CreateBook();

                //Save to Database
                SaveMaterialToDB(newBook);

                    ListboxAlerts.Items.Add($"Created {newBook.GetType().Name}:");
                    ListboxAlerts.Items.Add($"Title: {newBook.Title}");
                    ListboxAlerts.Items.Add($"Author: {newBook.Author}");
                    ListboxAlerts.Items.Add($"Genre: {newBook.Genre}");
            }
            catch(Exception ex)
            {
                ListboxAlerts.Items.Add("Could not save material. Please check the input values.");
                ListboxAlerts.Items.Add("Error: " + ex.Message);
            }

        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            //Close app
            try
            {
                ListboxAlerts.Items.Clear();
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
