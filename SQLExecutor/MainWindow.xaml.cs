using Microsoft.Win32;
using MySqlConnector;
using System;
using System.IO;
using System.Windows;

namespace SQLExecutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectionStringTextBox.Text = "Server=localhost;User ID=root;Password=root;";
        }

        private void SelectSQLScriptButton_Click(object sender, RoutedEventArgs e)
        {
            FileInfo? file = GetSQLScriptFile();
            string fileContent = ReadFileContent(file);
            ScriptTextBox.Text = fileContent;
        }

        private void ExecuteSQLScriptButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InfoTextBlock.Text = "Executing...";
                string connectionString = ConnectionStringTextBox.Text;
                ExecuteSQLScript(ScriptTextBox.Text, connectionString);
                InfoTextBlock.Text = "Successfully Executed!";
            }
            catch (Exception ex)
            {
                InfoTextBlock.Text = ex.ToString();
            }
        }

        private FileInfo? GetSQLScriptFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "SQL files (*.sql)|*.sql";
            if (fileDialog.ShowDialog() == true)
            {
                return new FileInfo(fileDialog.FileName);
            }

            return null;
        }

        private string ReadFileContent(FileInfo? file)
        {
            if (file == null) return String.Empty;
            string fileContent = File.ReadAllText(file.FullName);
            return fileContent;
        }

        private void ExecuteSQLScript(string sqlScript, string connectionString)
        {
            using var dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();

            using var command = new MySqlCommand(sqlScript, dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
