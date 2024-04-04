using System.Data;
using System.Data.SQLite;
using NLog;
using NLog.Config;

namespace hotel
{
    public partial class MainForm : Form
    {   
        SQLiteConnection сonnect = new SQLiteConnection("Data Source=../../../database/DbForHotel.db");
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MainForm()
        {
            InitializeComponent();
            loaddata();
            LogManager.Configuration = new XmlLoggingConfiguration("../../../logg/NLog.config");
            logger.Info("успешно открыта форма 'MainForm'");
        }
         public void loaddata()
        {
            try { 
            logger.Info("загрузка данных из БД");
            string connectionString = "Data Source=../../../database/DbForHotel.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM GuestsTable", connection))
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Guests");
                    gueststable.DataSource = ds.Tables["Guests"];
                }
            } 
            }
            catch (Exception ex)
            {
                logger.Error(ex, "произошла ошибка при загрузке данных из БД");
            }
            
        }

        public void reservedbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                logger.Info("нажата кнопка \"Зарезервировано\". загрузка данных из таблицы БД, где поле Статус = 'Зарезервировано'");
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter("SELECT * FROM GuestsTable WHERE Статус = 'Зарезервировано'", сonnect);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                gueststable.DataSource = dt;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "произошла ошибка при загрузке данных из БД");
            }
        }
        public void freebtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                logger.Info("нажата кнопка \"Свободно\". загрузка данных из таблицы БД, где поле Статус = 'Свободно'");
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter("SELECT * FROM GuestsTable WHERE Статус = 'Свободно'", сonnect);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                gueststable.DataSource = dt;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "произошла ошибка при загрузке данных из БД");
            }
        }

        public void occupiedbtn_CheckedChanged(object sender, EventArgs e)
        {     
            try
            {
                logger.Info("нажата кнопка \"Занято\". загрузка данных из таблицы БД, где поле Статус = 'Занято'");
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter("SELECT * FROM GuestsTable WHERE Статус = 'Занято'", сonnect);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                gueststable.DataSource = dt;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "произошла ошибка при загрузке данных из БД");
            }
        }
        public void checkingoutbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                logger.Info("нажата кнопка \"Выселяются\". загрузка данных из таблицы БД, где поле Статус = 'Выселяются'");
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter("SELECT * FROM GuestsTable WHERE Статус = 'Выселяются'", сonnect);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                gueststable.DataSource = dt;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "произошла ошибка при загрузке данных из БД");
            }
        }
         public void timer_Tick(object sender, EventArgs e)
        {
            timelabel.Text = $" {DateTime.Now.ToShortDateString()}    {DateTime.Now.ToLongTimeString()}";
            timer.Start();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            timelabel.Text = $" {DateTime.Now.ToShortDateString()}    {DateTime.Now.ToLongTimeString()}";
        }
        public void gueststable_DoubleClick(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap("../../../icons/" + this.gueststable.CurrentRow.Cells[7].Value.ToString());
            guestpic.Image = image;
            txtnbr.Text = this.gueststable.CurrentRow.Cells[0].Value.ToString();
            txtstatus.Text = this.gueststable.CurrentRow.Cells[1].Value.ToString();
            txtbname.Text = this.gueststable.CurrentRow.Cells[2].Value.ToString();
            txtbstoppedby.Text = this.gueststable.CurrentRow.Cells[4].Value.ToString();
            txtbcheckingout.Text = this.gueststable.CurrentRow.Cells[5].Value.ToString();
            logger.Info($"была открыта карточка для номера {txtnbr.Text}");
        }
        public void searchbtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tboxsearch.Text, out int num))
            {
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter("SELECT * FROM GuestsTable WHERE Номер ='" + tboxsearch.Text + "'", сonnect);
                DataTable sqldt = new DataTable();
                sqlda.Fill(sqldt);
                gueststable.DataSource = sqldt;
            }
            else
            {
                tboxsearch.Clear();
                logger.Error("ошибка: неправильный формат");
                MessageBox.Show("неправильный формат", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showguestcardbtn_Click(object sender, EventArgs e)
        {
            logger.Info("была нажата кнопка 'Посмотреть карточку гостя'");
            GuestForm guest = new GuestForm();
            if (!(this.gueststable.CurrentRow is null))
            {
                guest.txtboxname.Text = this.gueststable.CurrentRow.Cells[2].Value.ToString();
                guest.txtboxbirthday.Text = this.gueststable.CurrentRow.Cells[3].Value.ToString();
                guest.txtboxstoppedby.Text = this.gueststable.CurrentRow.Cells[4].Value.ToString();
                guest.txtboxchekingout.Text = this.gueststable.CurrentRow.Cells[5].Value.ToString();
                guest.txtboxwithAnimal.Text = this.gueststable.CurrentRow.Cells[6].Value.ToString();
                guest.Show();
            }
            else if ((this.gueststable.CurrentRow is null))
            {
                logger.Error("ошибка: непрвильно выбран номер гостя");
                MessageBox.Show("выберите один из номеров гостей", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
