namespace Restaurant2
{
    public partial class Form1 : Form
    {
        private ChickenOrder chicken;
        private EggOrder egg;
        private int customerIndex;
        private object _food;
        private Employee employee = new Employee();
        public Form1()
        {
            InitializeComponent();
            comboBoxDrinkType.SelectedIndex = 0;
        }


        private void CustomerRequest_Click(object sender, EventArgs e)
        {
            int quantityChicken;
            int quantityEgg;
            try
            {
                if (!int.TryParse(txtbtnChickenCounter.Text, out quantityChicken) || quantityChicken < 0)
                {
                    MessageBox.Show("Вы ввели неверное число куриц");
                    return;
                }
                if (!int.TryParse(txtbtnEggCounter.Text, out quantityEgg) || quantityEgg < 0)
                {
                    MessageBox.Show("Вы ввели неверное исло яиц");
                    return;
                }
                employee.ReceiveRequest(quantityChicken, quantityEgg, (MenuItem)comboBoxDrinkType.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AllRequestsList()
        {        
            try
            {
                int currentClient;
                for (currentClient = 0; currentClient < 8; currentClient++)
                {
                    listBox1.Items.Insert(currentClient, employee.ServeFood()); 
                }  
            }
            catch
            {
                throw new Exception("������ � ����������� ������� ��������");
            }
        }
        private void ShowAllRequests_click(object sender, EventArgs e)
        {
            AllRequestsList();
        }
    }
}