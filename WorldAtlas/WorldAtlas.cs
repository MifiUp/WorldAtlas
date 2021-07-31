using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace WorldAtlas
{
    public partial class WorldAtlasForm : Form
    {
        SQLiteConnection connection = null;
        SQLiteCommand command = null;
        SQLiteDataReader reader = null;
        ListViewItem item = null;
        public WorldAtlasForm()
        {
            InitializeComponent();
        }

        private void WorldAtlasForm_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            connection.Open(); // Открытие подключения
            try
            {
                command = new SQLiteCommand("SELECT * FROM CONTINENTS", connection); //команда для выбора всех континентов
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    item = new ListViewItem(new string[] { Convert.ToString(reader["CONTINENT"])});
                    ContLV.Items.Add(item); // заполнение ListView континентами
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              if(reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        private void ContLV_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void ContLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                CountryLV.Items.Clear();// очистка от старых значений
                int id;
                string continent;
                if (e.IsSelected == true) // проверка выбран ли item
                {
                    continent = e.Item.Text;
                    string commandtofind = $"SELECT ID FROM CONTINENTS WHERE CONTINENT='{continent}'";
                    command = new SQLiteCommand(commandtofind, connection);
                    object i = command.ExecuteScalar();
                    string strindid = i.ToString();
                    id = int.Parse(strindid); // получаем ID континента и переводим его из object в int
                }
                else { id = 0; };
                string stringforcountry = $"SELECT COUNTRY FROM COUNTRY WHERE IDOFCONT ={id}";// строка для выборки стран с ID континента
                SQLiteCommand commandforcoutry = new SQLiteCommand(stringforcountry, connection);
                reader = commandforcoutry.ExecuteReader();
                while (reader.Read())
                {
                    item = new ListViewItem(new string[] { Convert.ToString(reader["COUNTRY"]) });
                    CountryLV.Items.Add(item); // заполняем ListView стран
                }
            }
            catch
            {

            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close(); //закрытие SQlitedataReader
                }
            }



        }
    }
}
