using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GTSAPP
{
    public partial class Form1 : Form
    {
        string conString = "Data Source=ERAY\\SQLEXPRESS;Initial Catalog=GTS;Integrated Security=True;TrustServerCertificate=True;"; //CHANGE THIS CONNECTION STRING ACCORDING TO YOUR SQL SERVER

        public Form1()
        {
            InitializeComponent();
            LoadSubjectList();
            LoadLanguageList();
        }

        private void addp_Click(object sender, EventArgs e) //ADD PERSON
        {
            if (string.IsNullOrEmpty(personFName.Text) || string.IsNullOrEmpty(personLName.Text))
            {
                MessageBox.Show("Name and Surname cannot be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @ID";
                SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, con);
                checkIdCmd.Parameters.AddWithValue("@ID", userId.Text);
                int idCount = (int)checkIdCmd.ExecuteScalar();

                if (idCount > 0)
                {
                    MessageBox.Show("A person with this ID already exists.");
                    return;
                }

                string checkNameSurnameQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_FNAME = @Name AND PERSON_LNAME = @Surname";
                SqlCommand checkNameSurnameCmd = new SqlCommand(checkNameSurnameQuery, con);
                checkNameSurnameCmd.Parameters.AddWithValue("@Name", personFName.Text);
                checkNameSurnameCmd.Parameters.AddWithValue("@Surname", personLName.Text);
                int nameSurnameCount = (int)checkNameSurnameCmd.ExecuteScalar();

                if (nameSurnameCount > 0)
                {
                    MessageBox.Show("A person with this Name, and Surname already exists.");
                    return;
                }

                string insertQuery = "INSERT INTO PERSON (PERSON_ID, PERSON_FNAME, PERSON_LNAME) VALUES (@ID, @Name, @Surname)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@ID", userId.Text);
                insertCmd.Parameters.AddWithValue("@Name", personFName.Text);
                insertCmd.Parameters.AddWithValue("@Surname", personLName.Text);
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Person added successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the person.");
                }

                con.Close();
            }
        }

        private void listp_Click(object sender, EventArgs e) //LIST PERSON
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT PERSON_ID AS [PERSON ID], PERSON_FNAME AS NAME, PERSON_LNAME AS SURNAME FROM PERSON WHERE 1=1";
                if (!string.IsNullOrEmpty(userId.Text))
                {
                    query += " AND PERSON_ID = @ID";
                }
                if (!string.IsNullOrEmpty(personFName.Text))
                {
                    query += " AND PERSON_FNAME LIKE @Name";
                }
                if (!string.IsNullOrEmpty(personLName.Text))
                {
                    query += " AND PERSON_LNAME LIKE @Surname";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                if (!string.IsNullOrEmpty(userId.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@ID", userId.Text);
                }
                if (!string.IsNullOrEmpty(personFName.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Name", "%" + personFName.Text + "%");
                }
                if (!string.IsNullOrEmpty(personLName.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Surname", "%" + personLName.Text + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void updatep_Click(object sender, EventArgs e) //UPDATE PERSON
        {
            if (string.IsNullOrEmpty(userId.Text) || string.IsNullOrEmpty(personFName.Text) || string.IsNullOrEmpty(personLName.Text))
            {
                MessageBox.Show("ID, Name, and Surname cannot be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @ID";
                SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, con);
                checkIdCmd.Parameters.AddWithValue("@ID", userId.Text);
                int idCount = (int)checkIdCmd.ExecuteScalar();

                if (idCount == 0)
                {
                    MessageBox.Show("No person found with the provided ID.");
                    return;
                }

                string updateQuery = "UPDATE PERSON SET PERSON_FNAME = @Name, PERSON_LNAME = @Surname WHERE PERSON_ID = @ID";
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.Parameters.AddWithValue("@ID", userId.Text);
                updateCmd.Parameters.AddWithValue("@Name", personFName.Text);
                updateCmd.Parameters.AddWithValue("@Surname", personLName.Text);
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Person updated successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the person.");
                }

                con.Close();
            }
        }
        private void deletep_Click(object sender, EventArgs e) //DELETE PERSON
        {
            if (string.IsNullOrEmpty(userId.Text) || string.IsNullOrEmpty(personFName.Text) || string.IsNullOrEmpty(personLName.Text))
            {
                MessageBox.Show("Please fill in all fields (ID, Name, Surname) to delete a person.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkThesisQuery = "SELECT COUNT(*) FROM THESIS WHERE AUTHOR_ID = @ID";
                SqlCommand checkThesisCmd = new SqlCommand(checkThesisQuery, con);
                checkThesisCmd.Parameters.AddWithValue("@ID", userId.Text);
                int thesisCount = (int)checkThesisCmd.ExecuteScalar();

                if (thesisCount > 0)
                {
                    MessageBox.Show("This person is author of a thesis and cannot be deleted.");
                    return;
                }

                string checkSupervisorQuery = "SELECT COUNT(*) FROM SUPERVISOR WHERE SUPERVISOR_ID = @ID OR COSUPERVISOR_ID = @ID";
                SqlCommand checkSupervisorCmd = new SqlCommand(checkSupervisorQuery, con);
                checkSupervisorCmd.Parameters.AddWithValue("@ID", userId.Text);
                int supervisorCount = (int)checkSupervisorCmd.ExecuteScalar();

                if (supervisorCount > 0)
                {
                    MessageBox.Show("This person is supervises a thesis and cannot be deleted.");
                    return;
                }

                con.Close();
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this person?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "DELETE FROM PERSON WHERE PERSON_ID = @ID AND PERSON_FNAME = @Name AND PERSON_LNAME = @Surname";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", userId.Text);
                    cmd.Parameters.AddWithValue("@Name", personFName.Text);
                    cmd.Parameters.AddWithValue("@Surname", personLName.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Person deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No person found with the provided details.");
                    }
                }
            }
        }

        private void adduniv_Click(object sender, EventArgs e) //ADD UNIVERSITY
        {
            if (string.IsNullOrEmpty(uniName.Text))
            {
                MessageBox.Show("University name cannot be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkUniversityQuery = "SELECT COUNT(*) FROM UNIVERSITY WHERE UNIVERSITY_NAME = @UniversityName";
                SqlCommand checkUniversityCmd = new SqlCommand(checkUniversityQuery, con);
                checkUniversityCmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                int universityCount = (int)checkUniversityCmd.ExecuteScalar();

                if (universityCount > 0)
                {
                    MessageBox.Show("A university with this name already exists.");
                    return;
                }

                string insertQuery = "INSERT INTO UNIVERSITY (UNIVERSITY_NAME) VALUES (@UniversityName)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("University added successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the university.");
                }

                con.Close();
            }
        }

        private void listuniv_Click(object sender, EventArgs e) //LIST UNIVERSITY
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT UNIVERSITY_NAME AS UNIVERSITY FROM UNIVERSITY WHERE 1=1";
                if (!string.IsNullOrEmpty(uniName.Text))
                {
                    query += " AND UNIVERSITY_NAME LIKE @UniversityName";
                }
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                if (!string.IsNullOrEmpty(uniName.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@UniversityName", "%" + uniName.Text + "%");
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
        private void deleteuni_Click(object sender, EventArgs e) //DELETE UNIVERSITY
        {
            if (string.IsNullOrEmpty(uniName.Text))
            {
                MessageBox.Show("Please fill in the university name to delete the university.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkInstituteQuery = "SELECT COUNT(*) FROM INSTITUTE WHERE UNIVERSITY_NAME = @UniversityName";
                SqlCommand checkInstituteCmd = new SqlCommand(checkInstituteQuery, con);
                checkInstituteCmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                int instituteCount = (int)checkInstituteCmd.ExecuteScalar();

                if (instituteCount > 0)
                {
                    MessageBox.Show("This university is linked to an institute and cannot be deleted.");
                    return;
                }

                con.Close();
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this university?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "DELETE FROM UNIVERSITY WHERE UNIVERSITY_NAME = @UniversityName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UniversityName", uniName.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("University deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No university found with the provided name.");
                    }
                }
            }
        }

        private void linkinst_Click(object sender, EventArgs e) //LINK INSTITUTE
        {
            if (string.IsNullOrEmpty(uniName.Text) || string.IsNullOrEmpty(instName.Text))
            {
                MessageBox.Show("University and Institute name cannot be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkUniversityQuery = "SELECT COUNT(*) FROM UNIVERSITY WHERE UNIVERSITY_NAME = @UniversityName";
                SqlCommand checkUniversityCmd = new SqlCommand(checkUniversityQuery, con);
                checkUniversityCmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                int universityCount = (int)checkUniversityCmd.ExecuteScalar();

                if (universityCount == 0)
                {
                    MessageBox.Show("The selected university does not exist.");
                    return;
                }

                string checkInstituteQuery = "SELECT COUNT(*) FROM INSTITUTE WHERE INSTITUTE_NAME = @InstituteName";
                SqlCommand checkInstituteCmd = new SqlCommand(checkInstituteQuery, con);
                checkInstituteCmd.Parameters.AddWithValue("@InstituteName", instName.Text);
                int instituteCount = (int)checkInstituteCmd.ExecuteScalar();

                if (instituteCount > 0)
                {
                    MessageBox.Show("This institute already belongs to a university.");
                    return;
                }

                string insertQuery = "INSERT INTO INSTITUTE (INSTITUTE_NAME, UNIVERSITY_NAME) VALUES (@InstituteName, @UniversityName)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                insertCmd.Parameters.AddWithValue("@InstituteName", instName.Text);
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Institute linked to university successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while linking the institute to the university.");
                }

                con.Close();
            }
        }
        private void listinst_Click(object sender, EventArgs e) //LIST INSTITUTE
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT UNIVERSITY_NAME AS UNIVERSITY, INSTITUTE_NAME AS INSTITUTE FROM INSTITUTE WHERE 1=1";

                if (!string.IsNullOrEmpty(instName.Text))
                {
                    query += " AND INSTITUTE_NAME LIKE @InstituteName";
                }
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                if (!string.IsNullOrEmpty(instName.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@InstituteName", "%" + instName.Text + "%");
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
        private void deleteinst_Click(object sender, EventArgs e) //DELETE INSTITUTE
        {
            if (string.IsNullOrEmpty(uniName.Text) || string.IsNullOrEmpty(instName.Text))
            {
                MessageBox.Show("Please fill in the university and institute name to delete the institute.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkThesisQuery = "SELECT COUNT(*) FROM THESIS WHERE UNIVERSITY_NAME = @UniversityName AND INSTITUTE_NAME = @InstituteName";
                SqlCommand checkThesisCmd = new SqlCommand(checkThesisQuery, con);
                checkThesisCmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                checkThesisCmd.Parameters.AddWithValue("@InstituteName", instName.Text);
                int thesisCount = (int)checkThesisCmd.ExecuteScalar();

                if (thesisCount > 0)
                {
                    MessageBox.Show("This institute is linked to a thesis and cannot be deleted.");
                    return;
                }

                con.Close();
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this institute?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "DELETE FROM INSTITUTE WHERE UNIVERSITY_NAME = @UniversityName AND INSTITUTE_NAME = @InstituteName";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UniversityName", uniName.Text);
                    cmd.Parameters.AddWithValue("@InstituteName", instName.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Institute deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No institute found with the provided name.");
                    }
                }
            }
        }
        private void updateinst_Click(object sender, EventArgs e) //UPDATE INSTITUTE
        {
            using (InputBoxForm inputBox = new InputBoxForm())
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    string oldInstituteName = inputBox.OldInstituteName;
                    string newInstituteName = inputBox.NewInstituteName;

                    if (string.IsNullOrEmpty(oldInstituteName) || string.IsNullOrEmpty(newInstituteName))
                    {
                        MessageBox.Show("Both old and new institute names must be provided.");
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();

                        string checkInstituteQuery = "SELECT COUNT(*) FROM INSTITUTE WHERE INSTITUTE_NAME = @OldInstituteName";
                        SqlCommand checkInstituteCmd = new SqlCommand(checkInstituteQuery, con);
                        checkInstituteCmd.Parameters.AddWithValue("@OldInstituteName", oldInstituteName);
                        int instituteCount = (int)checkInstituteCmd.ExecuteScalar();

                        if (instituteCount == 0)
                        {
                            MessageBox.Show("The specified old institute name does not exist.");
                            return;
                        }

                        string checkNewInstituteQuery = "SELECT COUNT(*) FROM INSTITUTE WHERE INSTITUTE_NAME = @NewInstituteName";
                        SqlCommand checkNewInstituteCmd = new SqlCommand(checkNewInstituteQuery, con);
                        checkNewInstituteCmd.Parameters.AddWithValue("@NewInstituteName", newInstituteName);
                        int newInstituteCount = (int)checkNewInstituteCmd.ExecuteScalar();

                        if (newInstituteCount > 0)
                        {
                            MessageBox.Show("The specified new institute name already exists.");
                            return;
                        }

                        string dropConstraintsQuery = @"
                    ALTER TABLE THESIS NOCHECK CONSTRAINT ALL;
                    ALTER TABLE INSTITUTE NOCHECK CONSTRAINT ALL;";
                        SqlCommand dropConstraintsCmd = new SqlCommand(dropConstraintsQuery, con);
                        dropConstraintsCmd.ExecuteNonQuery();

                        string updateInstituteQuery = "UPDATE INSTITUTE SET INSTITUTE_NAME = @NewInstituteName WHERE INSTITUTE_NAME = @OldInstituteName";
                        SqlCommand updateInstituteCmd = new SqlCommand(updateInstituteQuery, con);
                        updateInstituteCmd.Parameters.AddWithValue("@OldInstituteName", oldInstituteName);
                        updateInstituteCmd.Parameters.AddWithValue("@NewInstituteName", newInstituteName);
                        int instituteRowsAffected = updateInstituteCmd.ExecuteNonQuery();

                        string updateThesisQuery = "UPDATE THESIS SET INSTITUTE_NAME = @NewInstituteName WHERE INSTITUTE_NAME = @OldInstituteName";
                        SqlCommand updateThesisCmd = new SqlCommand(updateThesisQuery, con);
                        updateThesisCmd.Parameters.AddWithValue("@OldInstituteName", oldInstituteName);
                        updateThesisCmd.Parameters.AddWithValue("@NewInstituteName", newInstituteName);
                        int thesisRowsAffected = updateThesisCmd.ExecuteNonQuery();

                        string addConstraintsQuery = @"
                    ALTER TABLE THESIS CHECK CONSTRAINT ALL;
                    ALTER TABLE INSTITUTE CHECK CONSTRAINT ALL;";
                        SqlCommand addConstraintsCmd = new SqlCommand(addConstraintsQuery, con);
                        addConstraintsCmd.ExecuteNonQuery();

                        if (instituteRowsAffected > 0 && thesisRowsAffected > 0)
                        {
                            MessageBox.Show("Institute name updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while updating the institute name.");
                        }

                        con.Close();
                    }
                }
            }
        }


        private void addkeyw_Click(object sender, EventArgs e) //ADD KEYWORD
        {
            if (string.IsNullOrEmpty(this.thesisNo.Text) || string.IsNullOrEmpty(keyword.Text))
            {
                MessageBox.Show("Thesis number and keyword cannot be empty.");
                return;
            }

            if (!int.TryParse(this.thesisNo.Text, out int thesisNo))
            {
                MessageBox.Show("Thesis number must be numeric.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkThesisQuery = "SELECT COUNT(*) FROM THESIS WHERE THESIS_NO = @ThesisNo";
                SqlCommand checkThesisCmd = new SqlCommand(checkThesisQuery, con);
                checkThesisCmd.Parameters.AddWithValue("@ThesisNo", thesisNo);
                int thesisCount = (int)checkThesisCmd.ExecuteScalar();

                if (thesisCount == 0)
                {
                    MessageBox.Show("The specified thesis number does not exist.");
                    return;
                }

                string checkKeywordQuery = "SELECT COUNT(*) FROM THESIS_KEYWORD WHERE THESIS_NO = @ThesisNo AND KEYWORD = @Keyword";
                SqlCommand checkKeywordCmd = new SqlCommand(checkKeywordQuery, con);
                checkKeywordCmd.Parameters.AddWithValue("@ThesisNo", thesisNo);
                checkKeywordCmd.Parameters.AddWithValue("@Keyword", keyword.Text);
                int keywordCount = (int)checkKeywordCmd.ExecuteScalar();

                if (keywordCount > 0)
                {
                    MessageBox.Show("The specified keyword already exists for this thesis number.");
                    return;
                }

                string insertQuery = "INSERT INTO THESIS_KEYWORD (THESIS_NO, KEYWORD) VALUES (@ThesisNo, @Keyword)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@ThesisNo", thesisNo);
                insertCmd.Parameters.AddWithValue("@Keyword", keyword.Text);
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Keyword added to thesis successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the keyword to the thesis.");
                }

                con.Close();
            }
        }

        private void deleteKeyword_Click(object sender, EventArgs e) //DELETE KEYWORD
        {
            if (string.IsNullOrEmpty(this.thesisNo.Text) || string.IsNullOrEmpty(keyword.Text))
            {
                MessageBox.Show("Thesis number and keyword cannot be empty.");
                return;
            }

            if (!int.TryParse(this.thesisNo.Text, out int thesisNo))
            {
                MessageBox.Show("Thesis number must be numeric.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkKeywordQuery = "SELECT COUNT(*) FROM THESIS_KEYWORD WHERE THESIS_NO = @ThesisNo AND KEYWORD = @Keyword";
                SqlCommand checkKeywordCmd = new SqlCommand(checkKeywordQuery, con);
                checkKeywordCmd.Parameters.AddWithValue("@ThesisNo", thesisNo);
                checkKeywordCmd.Parameters.AddWithValue("@Keyword", keyword.Text);
                int keywordCount = (int)checkKeywordCmd.ExecuteScalar();

                if (keywordCount == 0)
                {
                    MessageBox.Show("The specified keyword does not exist for this thesis number.");
                    return;
                }

                string deleteQuery = "DELETE FROM THESIS_KEYWORD WHERE THESIS_NO = @ThesisNo AND KEYWORD = @Keyword";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                deleteCmd.Parameters.AddWithValue("@ThesisNo", thesisNo);
                deleteCmd.Parameters.AddWithValue("@Keyword", keyword.Text);
                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Keyword deleted from thesis successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the keyword from the thesis.");
                }

                con.Close();
            }
        }



        private void LoadSubjectList() //LOAD SUBJECT LIST FUNCTION
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT TOPIC_NAME FROM SUBJECT_TOPIC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                subjectL.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    subjectL.Items.Add(row["TOPIC_NAME"].ToString());
                }
            }
        }
        private void LoadLanguageList() //LOAD LANGUAGE LIST FUNCTION
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT LANG_NAME FROM LANG";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                selectLang.DataSource = dt;
                selectLang.DisplayMember = "LANG_NAME";
                selectLang.ValueMember = "LANG_NAME";
            }
        }
        private void addThesis_Click(object sender, EventArgs e) //ADD THESIS
        {
            if (string.IsNullOrEmpty(thesisNo.Text) || string.IsNullOrEmpty(title.Text) || string.IsNullOrEmpty(abstrac.Text) ||
    string.IsNullOrEmpty(authorId.Text) || string.IsNullOrEmpty(year.Text) || string.IsNullOrEmpty(uniNameT.Text) ||
    string.IsNullOrEmpty(instNameT.Text) || string.IsNullOrEmpty(pages.Text) || subjectL.CheckedItems.Count == 0 ||
    selectLang.SelectedItem == null || (!rad1.Checked && !rad2.Checked && !rad3.Checked && !rad4.Checked))
            {
                MessageBox.Show("All fields except Co-Supervisor ID must be filled, and at least one subject must be selected.");
                return;
            }

            if (!int.TryParse(thesisNo.Text, out int thesisNoValue) || !int.TryParse(year.Text, out int yearValue) || !int.TryParse(pages.Text, out int pagesValue))
            {
                MessageBox.Show("Thesis number, year and pages must be numbers.");
                return;
            }

            string type = rad1.Checked ? "Master" : rad2.Checked ? "Doctorate" : rad3.Checked ? "Specialization in Medicine" : "Proficiency in Art";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkThesisNoQuery = "SELECT COUNT(*) FROM THESIS WHERE THESIS_NO = @ThesisNo";
                SqlCommand checkThesisNoCmd = new SqlCommand(checkThesisNoQuery, con);
                checkThesisNoCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                int thesisNoCount = (int)checkThesisNoCmd.ExecuteScalar();

                if (thesisNoCount > 0)
                {
                    MessageBox.Show("A thesis with this number already exists.");
                    return;
                }

                string checkAuthorIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @AuthorId";
                SqlCommand checkAuthorIdCmd = new SqlCommand(checkAuthorIdQuery, con);
                checkAuthorIdCmd.Parameters.AddWithValue("@AuthorId", authorId.Text);
                int authorIdCount = (int)checkAuthorIdCmd.ExecuteScalar();

                if (authorIdCount == 0)
                {
                    MessageBox.Show("The specified author ID does not exist.");
                    return;
                }

                string checkInstituteQuery = "SELECT COUNT(*) FROM INSTITUTE WHERE UNIVERSITY_NAME = @UniversityName AND INSTITUTE_NAME = @InstituteName";
                SqlCommand checkInstituteCmd = new SqlCommand(checkInstituteQuery, con);
                checkInstituteCmd.Parameters.AddWithValue("@UniversityName", uniNameT.Text);
                checkInstituteCmd.Parameters.AddWithValue("@InstituteName", instNameT.Text);
                int instituteCount = (int)checkInstituteCmd.ExecuteScalar();

                if (instituteCount == 0)
                {
                    MessageBox.Show("The specified university or institute does not exist.");
                    return;
                }

                string checkSupervisorIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @SupervisorId";
                SqlCommand checkSupervisorIdCmd = new SqlCommand(checkSupervisorIdQuery, con);
                checkSupervisorIdCmd.Parameters.AddWithValue("@SupervisorId", supId.Text);
                int supervisorIdCount = (int)checkSupervisorIdCmd.ExecuteScalar();

                if (supervisorIdCount == 0 || supId.Text == authorId.Text)
                {
                    MessageBox.Show("The specified supervisor ID does not exist or is the same as the author ID.");
                    return;
                }

                if (!string.IsNullOrEmpty(cosupId.Text))
                {
                    string checkCoSupervisorIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @CoSupervisorId";
                    SqlCommand checkCoSupervisorIdCmd = new SqlCommand(checkCoSupervisorIdQuery, con);
                    checkCoSupervisorIdCmd.Parameters.AddWithValue("@CoSupervisorId", cosupId.Text);
                    int coSupervisorIdCount = (int)checkCoSupervisorIdCmd.ExecuteScalar();

                    if (coSupervisorIdCount == 0 || cosupId.Text == authorId.Text || cosupId.Text == supId.Text)
                    {
                        MessageBox.Show("The specified co-supervisor ID does not exist or is the same as the author or supervisor ID.");
                        return;
                    }
                }

                string insertThesisQuery = "INSERT INTO THESIS (THESIS_NO, TITLE, ABSTRACT, AUTHOR_ID, YEAR, TYPE, UNIVERSITY_NAME, INSTITUTE_NAME, PAGES, LANGUAGE_NAME, SUB_DATE) " +
                                           "VALUES (@ThesisNo, @Title, @Abstract, @AuthorId, @Year, @Type, @UniversityName, @InstituteName, @Pages, @LanguageName, @SubDate)";
                SqlCommand insertThesisCmd = new SqlCommand(insertThesisQuery, con);
                insertThesisCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                insertThesisCmd.Parameters.AddWithValue("@Title", title.Text);
                insertThesisCmd.Parameters.AddWithValue("@Abstract", abstrac.Text);
                insertThesisCmd.Parameters.AddWithValue("@AuthorId", authorId.Text);
                insertThesisCmd.Parameters.AddWithValue("@Year", yearValue);
                insertThesisCmd.Parameters.AddWithValue("@Type", type);
                insertThesisCmd.Parameters.AddWithValue("@UniversityName", uniNameT.Text);
                insertThesisCmd.Parameters.AddWithValue("@InstituteName", instNameT.Text);
                insertThesisCmd.Parameters.AddWithValue("@Pages", pagesValue);
                insertThesisCmd.Parameters.AddWithValue("@LanguageName", selectLang.SelectedValue);
                insertThesisCmd.Parameters.AddWithValue("@SubDate", subdatepick.Value);
                int thesisRowsAffected = insertThesisCmd.ExecuteNonQuery();

                if (thesisRowsAffected > 0)
                {
                    foreach (var item in subjectL.CheckedItems)
                    {
                        string insertThesisTopicQuery = "INSERT INTO THESIS_TOPIC (THESIS_NO, TOPIC_NAME) VALUES (@ThesisNo, @TopicName)";
                        SqlCommand insertThesisTopicCmd = new SqlCommand(insertThesisTopicQuery, con);
                        insertThesisTopicCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                        insertThesisTopicCmd.Parameters.AddWithValue("@TopicName", item.ToString());
                        insertThesisTopicCmd.ExecuteNonQuery();
                    }

                    string insertSupervisorQuery = "INSERT INTO SUPERVISOR (THESIS_NO, SUPERVISOR_ID, COSUPERVISOR_ID) VALUES (@ThesisNo, @SupervisorId, @CoSupervisorId)";
                    SqlCommand insertSupervisorCmd = new SqlCommand(insertSupervisorQuery, con);
                    insertSupervisorCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                    insertSupervisorCmd.Parameters.AddWithValue("@SupervisorId", supId.Text);
                    insertSupervisorCmd.Parameters.AddWithValue("@CoSupervisorId", string.IsNullOrEmpty(cosupId.Text) ? (object)DBNull.Value : cosupId.Text);
                    insertSupervisorCmd.ExecuteNonQuery();

                    MessageBox.Show("Thesis added successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the thesis.");
                }

                con.Close();
            }
        }
        private void updateThesis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(thesisNo.Text) || string.IsNullOrEmpty(title.Text) || string.IsNullOrEmpty(abstrac.Text) ||
        string.IsNullOrEmpty(authorId.Text) || string.IsNullOrEmpty(year.Text) || string.IsNullOrEmpty(uniNameT.Text) ||
        string.IsNullOrEmpty(instNameT.Text) || string.IsNullOrEmpty(pages.Text) || subjectL.CheckedItems.Count == 0 ||
        selectLang.SelectedItem == null || (!rad1.Checked && !rad2.Checked && !rad3.Checked && !rad4.Checked))
            {
                MessageBox.Show("All fields except Co-Supervisor ID must be filled, and at least one subject must be selected.");
                return;
            }

            if (!int.TryParse(thesisNo.Text, out int thesisNoValue) || !int.TryParse(year.Text, out int yearValue) || !int.TryParse(pages.Text, out int pagesValue))
            {
                MessageBox.Show("Thesis number, year, and pages must be numbers.");
                return;
            }

            string type = rad1.Checked ? "Master" : rad2.Checked ? "Doctorate" : rad3.Checked ? "Specialization in Medicine" : "Proficiency in Art";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkThesisNoQuery = "SELECT COUNT(*) FROM THESIS WHERE THESIS_NO = @ThesisNo";
                SqlCommand checkThesisNoCmd = new SqlCommand(checkThesisNoQuery, con);
                checkThesisNoCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                int thesisNoCount = (int)checkThesisNoCmd.ExecuteScalar();

                if (thesisNoCount == 0)
                {
                    MessageBox.Show("The specified thesis number does not exist.");
                    return;
                }

                string checkAuthorIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @AuthorId";
                SqlCommand checkAuthorIdCmd = new SqlCommand(checkAuthorIdQuery, con);
                checkAuthorIdCmd.Parameters.AddWithValue("@AuthorId", authorId.Text);
                int authorIdCount = (int)checkAuthorIdCmd.ExecuteScalar();

                if (authorIdCount == 0)
                {
                    MessageBox.Show("The specified author ID does not exist.");
                    return;
                }

                string checkInstituteQuery = "SELECT COUNT(*) FROM INSTITUTE WHERE UNIVERSITY_NAME = @UniversityName AND INSTITUTE_NAME = @InstituteName";
                SqlCommand checkInstituteCmd = new SqlCommand(checkInstituteQuery, con);
                checkInstituteCmd.Parameters.AddWithValue("@UniversityName", uniNameT.Text);
                checkInstituteCmd.Parameters.AddWithValue("@InstituteName", instNameT.Text);
                int instituteCount = (int)checkInstituteCmd.ExecuteScalar();

                if (instituteCount == 0)
                {
                    MessageBox.Show("The specified university or institute does not exist.");
                    return;
                }

                string checkSupervisorIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @SupervisorId";
                SqlCommand checkSupervisorIdCmd = new SqlCommand(checkSupervisorIdQuery, con);
                checkSupervisorIdCmd.Parameters.AddWithValue("@SupervisorId", supId.Text);
                int supervisorIdCount = (int)checkSupervisorIdCmd.ExecuteScalar();

                if (supervisorIdCount == 0 || supId.Text == authorId.Text)
                {
                    MessageBox.Show("The specified supervisor ID does not exist or is the same as the author ID.");
                    return;
                }

                if (!string.IsNullOrEmpty(cosupId.Text))
                {
                    string checkCoSupervisorIdQuery = "SELECT COUNT(*) FROM PERSON WHERE PERSON_ID = @CoSupervisorId";
                    SqlCommand checkCoSupervisorIdCmd = new SqlCommand(checkCoSupervisorIdQuery, con);
                    checkCoSupervisorIdCmd.Parameters.AddWithValue("@CoSupervisorId", cosupId.Text);
                    int coSupervisorIdCount = (int)checkCoSupervisorIdCmd.ExecuteScalar();

                    if (coSupervisorIdCount == 0 || cosupId.Text == authorId.Text || cosupId.Text == supId.Text)
                    {
                        MessageBox.Show("The specified co-supervisor ID does not exist or is the same as the author or supervisor ID.");
                        return;
                    }
                }

                string updateThesisQuery = "UPDATE THESIS SET TITLE = @Title, ABSTRACT = @Abstract, AUTHOR_ID = @AuthorId, YEAR = @Year, TYPE = @Type, " +
                                           "UNIVERSITY_NAME = @UniversityName, INSTITUTE_NAME = @InstituteName, PAGES = @Pages, LANGUAGE_NAME = @LanguageName, SUB_DATE = @SubDate " +
                                           "WHERE THESIS_NO = @ThesisNo";
                SqlCommand updateThesisCmd = new SqlCommand(updateThesisQuery, con);
                updateThesisCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                updateThesisCmd.Parameters.AddWithValue("@Title", title.Text);
                updateThesisCmd.Parameters.AddWithValue("@Abstract", abstrac.Text);
                updateThesisCmd.Parameters.AddWithValue("@AuthorId", authorId.Text);
                updateThesisCmd.Parameters.AddWithValue("@Year", yearValue);
                updateThesisCmd.Parameters.AddWithValue("@Type", type);
                updateThesisCmd.Parameters.AddWithValue("@UniversityName", uniNameT.Text);
                updateThesisCmd.Parameters.AddWithValue("@InstituteName", instNameT.Text);
                updateThesisCmd.Parameters.AddWithValue("@Pages", pagesValue);
                updateThesisCmd.Parameters.AddWithValue("@LanguageName", selectLang.SelectedValue);
                updateThesisCmd.Parameters.AddWithValue("@SubDate", subdatepick.Value);
                int thesisRowsAffected = updateThesisCmd.ExecuteNonQuery();

                if (thesisRowsAffected > 0)
                {
                    string deleteThesisTopicQuery = "DELETE FROM THESIS_TOPIC WHERE THESIS_NO = @ThesisNo";
                    SqlCommand deleteThesisTopicCmd = new SqlCommand(deleteThesisTopicQuery, con);
                    deleteThesisTopicCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                    deleteThesisTopicCmd.ExecuteNonQuery();

                    foreach (var item in subjectL.CheckedItems)
                    {
                        string insertThesisTopicQuery = "INSERT INTO THESIS_TOPIC (THESIS_NO, TOPIC_NAME) VALUES (@ThesisNo, @TopicName)";
                        SqlCommand insertThesisTopicCmd = new SqlCommand(insertThesisTopicQuery, con);
                        insertThesisTopicCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                        insertThesisTopicCmd.Parameters.AddWithValue("@TopicName", item.ToString());
                        insertThesisTopicCmd.ExecuteNonQuery();
                    }

                    string updateSupervisorQuery = "UPDATE SUPERVISOR SET SUPERVISOR_ID = @SupervisorId, COSUPERVISOR_ID = @CoSupervisorId WHERE THESIS_NO = @ThesisNo";
                    SqlCommand updateSupervisorCmd = new SqlCommand(updateSupervisorQuery, con);
                    updateSupervisorCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                    updateSupervisorCmd.Parameters.AddWithValue("@SupervisorId", supId.Text);
                    updateSupervisorCmd.Parameters.AddWithValue("@CoSupervisorId", string.IsNullOrEmpty(cosupId.Text) ? (object)DBNull.Value : cosupId.Text);
                    updateSupervisorCmd.ExecuteNonQuery();

                    MessageBox.Show("Thesis updated successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the thesis.");
                }

                con.Close();
            }
        }

        private void deleteThesis_Click(object sender, EventArgs e) //DELETE THESIS
        {
            if (string.IsNullOrEmpty(thesisNo.Text))
            {
                MessageBox.Show("Thesis number cannot be empty.");
                return;
            }

            if (!int.TryParse(thesisNo.Text, out int thesisNoValue))
            {
                MessageBox.Show("Thesis number must be numeric.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string checkThesisQuery = "SELECT COUNT(*) FROM THESIS WHERE THESIS_NO = @ThesisNo";
                SqlCommand checkThesisCmd = new SqlCommand(checkThesisQuery, con);
                checkThesisCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                int thesisCount = (int)checkThesisCmd.ExecuteScalar();

                if (thesisCount == 0)
                {
                    MessageBox.Show("The specified thesis number does not exist.");
                    return;
                }

                string deleteSupervisorQuery = "DELETE FROM SUPERVISOR WHERE THESIS_NO = @ThesisNo";
                SqlCommand deleteSupervisorCmd = new SqlCommand(deleteSupervisorQuery, con);
                deleteSupervisorCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                deleteSupervisorCmd.ExecuteNonQuery();

                string deleteThesisTopicQuery = "DELETE FROM THESIS_TOPIC WHERE THESIS_NO = @ThesisNo";
                SqlCommand deleteThesisTopicCmd = new SqlCommand(deleteThesisTopicQuery, con);
                deleteThesisTopicCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                deleteThesisTopicCmd.ExecuteNonQuery();

                string deleteKeywordQuery = "DELETE FROM THESIS_KEYWORD WHERE THESIS_NO = @ThesisNo";
                SqlCommand deleteKeywordCmd = new SqlCommand(deleteKeywordQuery, con);
                deleteKeywordCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                deleteKeywordCmd.ExecuteNonQuery();

                string deleteThesisQuery = "DELETE FROM THESIS WHERE THESIS_NO = @ThesisNo";
                SqlCommand deleteThesisCmd = new SqlCommand(deleteThesisQuery, con);
                deleteThesisCmd.Parameters.AddWithValue("@ThesisNo", thesisNoValue);
                int rowsAffected = deleteThesisCmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thesis deleted successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the thesis.");
                }

                con.Close();
            }
        }

        private void thesisSearch_Click(object sender, EventArgs e) //SEARCH THESIS
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string query = @"
            SELECT 
                T.THESIS_NO AS [THESIS NO], 
                T.TITLE, 
                T.ABSTRACT, 
                T.AUTHOR_ID AS [AUTHOR ID], 
                T.YEAR, 
                T.TYPE, 
                T.UNIVERSITY_NAME AS UNIVERSITY, 
                T.INSTITUTE_NAME AS INSTITUTE, 
                T.PAGES, 
                STRING_AGG(K.KEYWORD, ', ') AS KEYWORDS,
                STRING_AGG(TT.TOPIC_NAME, ', ') AS TOPICS,
                S.SUPERVISOR_ID AS [SUPERVISOR ID],
                S.COSUPERVISOR_ID AS [COSUPERVISOR ID],
                T.LANGUAGE_NAME AS LANGUAGE, 
                T.SUB_DATE AS [SUB DATE]
            FROM 
                THESIS T
            LEFT JOIN 
                SUPERVISOR S ON T.THESIS_NO = S.THESIS_NO
            LEFT JOIN 
                THESIS_KEYWORD K ON T.THESIS_NO = K.THESIS_NO
            LEFT JOIN 
                THESIS_TOPIC TT ON T.THESIS_NO = TT.THESIS_NO
            WHERE 
                1=1";

                if (!string.IsNullOrEmpty(thesisNoS.Text))
                {
                    if (!int.TryParse(thesisNoS.Text, out int thesisNoValue))
                    {
                        MessageBox.Show("Thesis number must be numeric.");
                        return;
                    }
                    query += " AND T.THESIS_NO = @ThesisNo";
                }

                if (!string.IsNullOrEmpty(AuthorIdS.Text))
                {
                    query += " AND T.AUTHOR_ID = @AuthorId";
                }

                query += " GROUP BY T.THESIS_NO, T.TITLE, T.ABSTRACT, T.AUTHOR_ID, T.YEAR, T.TYPE, T.UNIVERSITY_NAME, T.INSTITUTE_NAME, T.PAGES, T.LANGUAGE_NAME, T.SUB_DATE, S.SUPERVISOR_ID, S.COSUPERVISOR_ID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                if (!string.IsNullOrEmpty(thesisNoS.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@ThesisNo", thesisNoS.Text);
                }

                if (!string.IsNullOrEmpty(AuthorIdS.Text))
                {
                    da.SelectCommand.Parameters.AddWithValue("@AuthorId", AuthorIdS.Text);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;

                con.Close();
            }
        }
    }
}