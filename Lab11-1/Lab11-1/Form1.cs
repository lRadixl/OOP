using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_1
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\source\repos\Lab11-1\db.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстових полів
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string groupname = groupTextBox.Text;
            DateTime birthDateValue = birthDateDateTimePicker.Value;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Запит на вставку даних
                string insertQuery = "INSERT INTO Діти (Ім_я, Прізвище, Назва_групи, Дата_народження) VALUES (?, ?, ?, ?)";

                // Виконуємо команду з параметрами
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@p1", name);
                    command.Parameters.AddWithValue("@p2", surname);
                    command.Parameters.AddWithValue("@p3", groupname);
                    command.Parameters.AddWithValue("@p4", birthDateValue.ToString("MM/dd/yyyy"));
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Дані успішно вставлені до бази даних.");
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = searchTextBox.Text;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Запит на пошук даних за критерієм
                string searchQuery = "SELECT * FROM Діти WHERE Прізвище = ?";

                using (OleDbCommand command = new OleDbCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@p0", searchCriteria);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder searchResults = new StringBuilder();

                        // Читаємо дані і формуємо результати пошуку
                        while (reader.Read())
                        {
                            string employeeId = reader["Id"].ToString();
                            string employeeName = reader["Ім_я"].ToString();
                            string employeeSurname = reader["Прізвище"].ToString();
                            string employeegroup = reader["Назва_групи"].ToString();
                            string employeeBirthDate = reader["Дата_народження"].ToString();

                            searchResults.AppendLine($"ID: {employeeId}");
                            searchResults.AppendLine($"Ім'я: {employeeName}");
                            searchResults.AppendLine($"Прізвище: {employeeSurname}");
                            searchResults.AppendLine($"Назва групи {employeegroup}");
                            searchResults.AppendLine($"Дата народження: {employeeBirthDate}");
                            searchResults.AppendLine();
                        }

                        // Виводимо результати пошуку у RichTextBox
                        searchResultsRichTextBox.Text = searchResults.ToString();
                    }
                }
            }
        }

        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Отримуємо дані з бази даних
                DataTable dataTable = RetrieveData(connection);

                // Відображаємо дані в DataGridView
                dataGridView.DataSource = dataTable;
            }
        }

        private DataTable RetrieveData(OleDbConnection connection)
        {
            // Запит на отримання даних
            string selectQuery = "SELECT * FROM Діти";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection))
            {
                // Створюємо нову таблицю
                DataTable dataTable = new DataTable();

                // Заповнюємо таблицю даними з бази даних
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Звіт 1: Загальна інформація про співробітників
                string reportQuery1 = "SELECT * FROM Діти";

                using (OleDbCommand command = new OleDbCommand(reportQuery1, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder report1 = new StringBuilder();

                        // Читаємо дані і формуємо звіт
                        while (reader.Read())
                        {
                            string employeeId = reader["Id"].ToString();
                            string employeeName = reader["Ім_я"].ToString();
                            string employeeSurname = reader["Прізвище"].ToString();
                            string employeegroup = reader["Назва_групи"].ToString();
                            string employeeBirthDate = reader["Дата_народження"].ToString();

                            report1.AppendLine($"ID: {employeeId}");
                            report1.AppendLine($"Ім'я: {employeeName}");
                            report1.AppendLine($"Прізвище: {employeeSurname}");
                            report1.AppendLine($"Назва групи {employeegroup}");
                            report1.AppendLine($"Дата народження: {employeeBirthDate}");
                            report1.AppendLine();
                        }

                        // Виводимо звіт 1 у RichTextBox
                        reportRichTextBox.Text = report1.ToString();
                    }

                }

                // Звіт 2: Звіт за критерієм вибору (наприклад, посада)
                string reportQuery2 = "SELECT * FROM Діти WHERE Назва_групи = ?";

                using (OleDbCommand command = new OleDbCommand(reportQuery2, connection))
                {
                    command.Parameters.AddWithValue("@p0", "Веселка"); // Замініть на вибраний критерій

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder report2 = new StringBuilder();

                        // Читаємо дані і формуємо звіт
                        while (reader.Read())
                        {
                            string employeeId = reader["Id"].ToString();
                            string employeeName = reader["Ім_я"].ToString();
                            string employeeSurname = reader["Прізвище"].ToString();
                            string employeegroup = reader["Назва_групи"].ToString();
                            string employeeBirthDate = reader["Дата_народження"].ToString();

                            report2.AppendLine($"ID: {employeeId}");
                            report2.AppendLine($"Ім'я: {employeeName}");
                            report2.AppendLine($"Прізвище: {employeeSurname}");
                            report2.AppendLine($"Назва групи {employeegroup}");
                            report2.AppendLine($"Дата народження: {employeeBirthDate}");
                            report2.AppendLine();
                        }

                        // Виводимо звіт 2 у RichTextBox
                        reportRichTextBox2.Text = report2.ToString();
                    }
                }
            }
        }

    }
}
