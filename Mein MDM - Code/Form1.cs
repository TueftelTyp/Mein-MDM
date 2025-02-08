using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace PersonData
{
    public partial class PersonForm : Form
    {
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbStrasse;
        private TextBox tbHausnummer;
        private TextBox tbPLZ;
        private TextBox tbOrt;
        private ComboBox cbLand;
        //private ComboBox cbFirma;
        private TextBox tbGeburt;
        private TextBox tbTelefon;
        private Button btnAdd;
        private ListBox lbPerson;
        private TextBox tbNotes;
        private SQLiteConnection connection;

        public PersonForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadPersonsToListBox();
        }

        private void InitializeDatabase()
        {
            string dbPath = "PersonData.db";
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            connection.Open();

            string sqlPersons = @"CREATE TABLE IF NOT EXISTS Persons (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT,
                        LastName TEXT,
                        Strasse TEXT,
                        Hausnummer TEXT,
                        PLZ TEXT,
                        Ort TEXT,
                        Land TEXT,
                        Geburtsdatum TEXT,
                        Firma TEXT,
                        Telefon TEXT,
                        Bemerkung TEXT)";

            string sqlFirmen = @"CREATE TABLE IF NOT EXISTS Firmen (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT UNIQUE)";

            string sqlLaender = @"CREATE TABLE IF NOT EXISTS Laender (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT UNIQUE)";

            using (SQLiteCommand command = new SQLiteCommand(sqlPersons, connection))
            {
                command.ExecuteNonQuery();
            }
            using (SQLiteCommand command = new SQLiteCommand(sqlFirmen, connection))
            {
                command.ExecuteNonQuery();
            }
            using (SQLiteCommand command = new SQLiteCommand(sqlLaender, connection))
            {
                command.ExecuteNonQuery();
            }

            LoadComboBoxData();
        }

        private bool AreAllFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbStrasse.Text) ||
                string.IsNullOrWhiteSpace(tbHausnummer.Text) ||
                string.IsNullOrWhiteSpace(tbPLZ.Text) ||
                string.IsNullOrWhiteSpace(tbOrt.Text) ||
                string.IsNullOrWhiteSpace(cbLand.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.", "Unvollständige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                return;
            }

            SaveNewComboBoxEntry(cbFirma.Text, "Firmen");
            SaveNewComboBoxEntry(cbLand.Text, "Laender");

            string sql = @"INSERT INTO Persons (FirstName, LastName, Strasse, Hausnummer, PLZ, Ort, Land, Geburtsdatum, Firma, Telefon, Bemerkung) 
                           VALUES (@FirstName, @LastName, @Strasse, @Hausnummer, @PLZ, @Ort, @Land, @Geburtsdatum, @Firma, @Telefon, @Bemerkung)";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                command.Parameters.AddWithValue("@LastName", tbLastName.Text);
                command.Parameters.AddWithValue("@Strasse", tbStrasse.Text);
                command.Parameters.AddWithValue("@Hausnummer", tbHausnummer.Text);
                command.Parameters.AddWithValue("@PLZ", tbPLZ.Text);
                command.Parameters.AddWithValue("@Ort", tbOrt.Text);
                command.Parameters.AddWithValue("@Land", cbLand.Text);
                command.Parameters.AddWithValue("@Geburtsdatum", tbGeburt.Text);
                command.Parameters.AddWithValue("@Firma", cbFirma.Text);
                command.Parameters.AddWithValue("@Telefon", tbTelefon.Text);
                command.Parameters.AddWithValue("@Bemerkung", tbNotes.Text);

                command.ExecuteNonQuery();
            }


            LoadComboBoxData();
            ClearTextBoxes();
            LoadPersonsToListBox();
        }

        private void LoadPersonsToListBox()
        {
            lbPerson.Items.Clear();
            string sql = "SELECT * FROM Persons";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string personData = $"{reader["FirstName"]} {reader["LastName"]}, ";
                        lbPerson.Items.Add(personData);
                    }
                }
            }
        }

        private void ClearTextBoxes()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbStrasse.Clear();
            tbHausnummer.Clear();
            tbPLZ.Clear();
            tbOrt.Clear();
            cbLand.Text = "";
            tbGeburt.Clear();
            cbFirma.Text = "";
            tbTelefon.Clear();
            tbNotes.Clear();
        }

        private void SaveNewComboBoxEntry(string value, string tableName)
        {
            if (string.IsNullOrWhiteSpace(value)) return;

            string checkSql = $"SELECT COUNT(*) FROM {tableName} WHERE Name = @Value";
            string insertSql = $"INSERT INTO {tableName} (Name) VALUES (@Value)";

            using (SQLiteCommand checkCommand = new SQLiteCommand(checkSql, connection))
            {
                checkCommand.Parameters.AddWithValue("@Value", value);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count == 0)  // Falls der Eintrag noch nicht existiert, speichere ihn
                {
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Value", value);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        private void LoadComboBoxData()
        {
            cbFirma.Items.Clear();
            cbLand.Items.Clear();

            string sqlFirmen = "SELECT Name FROM Firmen";
            string sqlLaender = "SELECT Name FROM Laender";

            using (SQLiteCommand command = new SQLiteCommand(sqlFirmen, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbFirma.Items.Add(reader["Name"].ToString());
                    }
                }
            }

            using (SQLiteCommand command = new SQLiteCommand(sqlLaender, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbLand.Items.Add(reader["Name"].ToString());
                    }
                }
            }
        }

        private void btnSuche_Click_1(object sender, EventArgs e)
        {
            string searchTerm = tbBegriff.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Bitte geben Sie einen Suchbegriff ein.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lbPerson.Items.Clear();
            string sql = @"SELECT * FROM Persons 
                   WHERE FirstName LIKE @SearchTerm 
                   OR LastName LIKE @SearchTerm
                   OR Firma LIKE @SearchTerm
                   OR Strasse LIKE @SearchTerm
                   OR PLZ LIKE @SearchTerm
                   OR Ort LIKE @SearchTerm
                   OR Land LIKE @SearchTerm
                   OR Telefon LIKE @SearchTerm";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string personData = $"{reader["FirstName"]} {reader["LastName"]}, {reader["Firma"]}";
                        lbPerson.Items.Add(personData);
                    }
                }
            }
        }

        private void btnClearSuche_Click_1(object sender, EventArgs e)
        {
            tbBegriff.Clear();  // Eingabefeld für den Suchbegriff leeren
            LoadPersonsToListBox();  // Alle Einträge wieder anzeigen
            ClearTextBoxes();
            cbLand.Text = "DEUTSCHLAND";
            cbFirma.Text = "";
        }

        private void lbPerson_DoubleClick(object sender, EventArgs e)
        {
            if (lbPerson.SelectedIndex != -1)
            {
                string selectedPerson = lbPerson.SelectedItem.ToString().TrimEnd(',', ' ');
                string[] nameParts = selectedPerson.Split(' ');

                if (nameParts.Length >= 2)
                {
                    string firstName = nameParts[0];
                    string lastName = nameParts[1];

                    string sql = "SELECT * FROM Persons WHERE FirstName = @FirstName AND LastName = @LastName";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbFirstName.Text = reader["FirstName"].ToString();
                                tbLastName.Text = reader["LastName"].ToString();
                                tbStrasse.Text = reader["Strasse"].ToString();
                                tbHausnummer.Text = reader["Hausnummer"].ToString();
                                tbPLZ.Text = reader["PLZ"].ToString();
                                tbOrt.Text = reader["Ort"].ToString();
                                cbLand.Text = reader["Land"].ToString();
                                tbGeburt.Text = reader["Geburtsdatum"].ToString();
                                cbFirma.Text = reader["Firma"].ToString();
                                tbTelefon.Text = reader["Telefon"].ToString();
                                tbNotes.Text = reader["Bemerkung"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbPerson.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wählen Sie eine Person aus der Liste aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedPerson = lbPerson.SelectedItem.ToString().TrimEnd(',', ' ');
            string[] nameParts = selectedPerson.Split(' ');

            if (nameParts.Length < 2)
            {
                MessageBox.Show("Ungültiges Namensformat.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = nameParts[0];
            string lastName = nameParts[1];

            //Neue Firma und neues Land in die Datenbank einfügen, falls sie nicht existieren
            SaveNewComboBoxEntry(cbFirma.Text, "Firmen");
            SaveNewComboBoxEntry(cbLand.Text, "Laender");

            string sql = @"UPDATE Persons 
                   SET FirstName = @FirstName, 
                       LastName = @LastName, 
                       Strasse = @Strasse, 
                       Hausnummer = @Hausnummer, 
                       PLZ = @PLZ, 
                       Ort = @Ort, 
                       Land = @Land, 
                       Geburtsdatum = @Geburtsdatum, 
                       Firma = @Firma, 
                       Telefon = @Telefon, 
                       Bemerkung = @Bemerkung
                   WHERE FirstName = @OldFirstName AND LastName = @OldLastName";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@FirstName", tbFirstName.Text);
                command.Parameters.AddWithValue("@LastName", tbLastName.Text);
                command.Parameters.AddWithValue("@Strasse", tbStrasse.Text);
                command.Parameters.AddWithValue("@Hausnummer", tbHausnummer.Text);
                command.Parameters.AddWithValue("@PLZ", tbPLZ.Text);
                command.Parameters.AddWithValue("@Ort", tbOrt.Text);
                command.Parameters.AddWithValue("@Land", cbLand.Text);
                command.Parameters.AddWithValue("@Geburtsdatum", tbGeburt.Text);
                command.Parameters.AddWithValue("@Firma", cbFirma.Text);
                command.Parameters.AddWithValue("@Telefon", tbTelefon.Text);
                command.Parameters.AddWithValue("@Bemerkung", tbNotes.Text);

                command.Parameters.AddWithValue("@OldFirstName", firstName);
                command.Parameters.AddWithValue("@OldLastName", lastName);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Person erfolgreich aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPersonsToListBox(); // Listbox aktualisieren
                    LoadComboBoxData(); // ComboBoxen neu laden, damit neue Firmen/Länder erscheinen
                    ClearTextBoxes();
                    cbFirma.Text = "";
                }
                else
                {
                    MessageBox.Show("Aktualisierung fehlgeschlagen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbPerson_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lbPerson.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)  // Falls ein gültiger Eintrag getroffen wurde
                {
                    lbPerson.SelectedIndex = index;  // Markiere den Eintrag
                    cmsPerson.Show(lbPerson, e.Location);  // Context-Menü öffnen
                }
            }
        }

        private void jetztLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPerson.SelectedIndex != -1)
            {
                string selectedPerson = lbPerson.SelectedItem.ToString().TrimEnd(',', ' ');
                string[] nameParts = selectedPerson.Split(' ');

                if (nameParts.Length >= 2)
                {
                    string firstName = nameParts[0];
                    string lastName = nameParts[1];

                    string sql = "DELETE FROM Persons WHERE FirstName = @FirstName AND LastName = @LastName";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Person erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPersonsToListBox(); // Aktualisieren Sie die ListBox
                            ClearTextBoxes(); // Leeren Sie die Textboxen
                        }
                        else
                        {
                            MessageBox.Show("Person konnte nicht gelöscht werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ungültiges Namensformat in der Liste.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Person zum Löschen aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbPerson.SelectedIndex != -1)
            {
                string selectedPerson = lbPerson.SelectedItem.ToString().TrimEnd(',', ' ');
                string[] nameParts = selectedPerson.Split(' ');

                if (nameParts.Length >= 2)
                {
                    string firstName = nameParts[0];
                    string lastName = nameParts[1];

                    string sql = "SELECT * FROM Persons WHERE FirstName = @FirstName AND LastName = @LastName";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbFirstName.Text = reader["FirstName"].ToString();
                                tbLastName.Text = reader["LastName"].ToString();
                                tbStrasse.Text = reader["Strasse"].ToString();
                                tbHausnummer.Text = reader["Hausnummer"].ToString();
                                tbPLZ.Text = reader["PLZ"].ToString();
                                tbOrt.Text = reader["Ort"].ToString();
                                cbLand.Text = reader["Land"].ToString();
                                tbGeburt.Text = reader["Geburtsdatum"].ToString();
                                cbFirma.Text = reader["Firma"].ToString();
                                tbTelefon.Text = reader["Telefon"].ToString();
                                tbNotes.Text = reader["Bemerkung"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void cbLand_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cbLand.DroppedDown = false; // Damit die Dropdown-Liste sich nicht öffnet
                int index = cbLand.SelectedIndex;
                if (index != -1)
                {
                    cmsComboBox.Tag = new Tuple<ComboBox, string>(cbLand, cbLand.Items[index].ToString());
                    cmsComboBox.Show(cbLand, e.Location);
                }
            }
        }

        private void cbFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cbFirma.DroppedDown = false;
                int index = cbFirma.SelectedIndex;
                if (index != -1)
                {
                    cmsComboBox.Tag = new Tuple<ComboBox, string>(cbFirma, cbFirma.Items[index].ToString());
                    cmsComboBox.Show(cbFirma, e.Location);
                }
            }
        }

        private void jetztLöschenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cmsComboBox.Tag is Tuple<ComboBox, string> data)
            {
                ComboBox comboBox = data.Item1;
                string valueToDelete = data.Item2;

                string tableName = (comboBox == cbLand) ? "Laender" : "Firmen";
                string sql = $"DELETE FROM {tableName} WHERE Name = @Value";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Value", valueToDelete);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{valueToDelete} wurde erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox.Items.Remove(valueToDelete); // Entferne den Eintrag aus der ComboBox
                    }
                    else
                    {
                        MessageBox.Show($"{valueToDelete} konnte nicht gelöscht werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TueftelTyp/Mein-MDM");

        }
    }
}
    
