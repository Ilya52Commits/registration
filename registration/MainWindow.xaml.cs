using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace registration;
/// <summary>
/// Логика взаимодействия для MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    FillItems();
  }


  public List<Users> element = new List<Users>();
  private void FillItems()
  {
    var content = File.ReadAllLines("file.txt");


    foreach (var line in content)
    {
      var supStrings = line.Split(' ');
      var users = new Users();
      users.Id = supStrings[1];
      users.Name = supStrings[3];
      users.Sureame = supStrings[5];
      users.Email = supStrings[7];
      users.Phone = supStrings[9];
      users.Pasport = supStrings[11];

      element.Add(users);
    }

    listUsers.ItemsSource = element;
    listUsers.Items.Refresh();
  }
}

public class Users
{
  public string Id { get; set; }
  public string Name { get; set; }
  public string Sureame { get; set; }
  public string Phone { get; set; }
  public string Email { get; set; }
  public string Pasport { get; set; }
}