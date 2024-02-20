using System.Windows;
using System.IO;

namespace registration
{
  /// <summary>
  /// Логика взаимодействия для CreateUser.xaml
  /// </summary>
  public partial class CreateUser : Window
  {
    public CreateUser()
    {
      InitializeComponent();
    }

    private static string file = "file.txt";

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      var id = textID.Text.Trim();
      var name = textName.Text.Trim();
      var surename = textSurename.Text.Trim();
      var email = textEmail.Text.Trim();
      var phone = textPhone.Text.Trim();
      var pasport = textPasport.Text.Trim();

      if (IsNumberAlreadyRegistred(phone))
      {
        MessageBox.Show("Номер уже зарегестрирован");
        return;
      }

      File.AppendAllText(file, $"ID {id} Имя {name} Фамилия {surename} Почта {email} Телефон {phone} Паспорт {pasport}\n");

      var MainWindod = new MainWindow();
      MainWindod.Show();
      this.Close();
    }

    private static bool IsNumberAlreadyRegistred(string str)
    {
      var content = File.ReadAllLines("file.txt");


      foreach (var line in content)
      {
        var supStrings = line.Split(' ');

        if (supStrings[9] == str)
          return true;
      }

      return false;
    }

    public static bool IsPhoneCorrect(string str)
    {
      if (str.Length != 11 || str.Length != 12)
        return false;

      return true;
    }
  }
}
