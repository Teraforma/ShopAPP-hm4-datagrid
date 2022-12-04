using ShopApp.Classes;
using System.ComponentModel;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Windows.Forms;
using System.Xml;

namespace ShopApp
{
    public partial class Form1 : Form

    {

        private Controller controller1;//name,price,cOfOrigin,packaging date,decription,
        private string[] AddInfo1Names = new string[] { "Fresh by", "Pages" };
        private string[] AddInfo2Names = new string[] { "PerKilo/PerPiece", "Publisher" };
        public Form1()
        {
            
            InitializeComponent();
            controller1 = new Controller(Merch_dataGridView);
            Autors_textBox.Visible = false; //that, maybe, should be in an enother place!
        }

        public string[] boxesToStr()
        {
            string[] result = new string[8];
            result[0] = Name_textbox.Text;
            result[1] = Price_textBox.Text;
            result[2] = CofOrigin_textbox.Text;
            result[3] = ProducedDate_textbox.Text;
            result[4] = Descrip_textBox.Text;
            result[5] = AditinalInfo1_textBox.Text;
            result[6] = AditinalInfo2_textBox.Text;
            result[7] = Autors_textBox.Text;
            return result;
        }
        private void addNewRow_merch()
        {
            string[] newMerch_data = boxesToStr();
            controller1.AddNewGrid(newMerch_data);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // SetupDataGridView();
            //PopulateDataGridView();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchInput();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            addNewRow_merch();
        }

        private void aditinalInfo1_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SwitchInput()
        {
            switch_button.Text = controller1.ChangeStatus();
            if (switch_button.Text == "Book")
            {
                Autors_textBox.Visible = true;
            }else
            {
                Autors_textBox.Visible = false;
            }
            AditinalInfo1_textBox.Text = AddInfo1Names[controller1.GetState()];
            AditinalInfo2_textBox.Text = AddInfo2Names[controller1.GetState()];
        }

        

        private void Name_textbox_Enter(object sender, EventArgs e)
        {
            Controller.EnterChange(Name_textbox, "Name");
        }
        private void Name_textbox_Leave(object sender, EventArgs e)
        {
            Controller.LeaveChange(Name_textbox, "Name");
        }

        private void ProducedDate_textbox_Enter(object sender, EventArgs e)
        {
            Controller.EnterChange(ProducedDate_textbox, "Produced");
        }

        private void ProducedDate_textbox_Leave(object sender, EventArgs e)
        {
            Controller.LeaveChange(ProducedDate_textbox, "Produced");
        }

        private void CofOrigin_textbox_Leave(object sender, EventArgs e)
        {
            Controller.LeaveChange(CofOrigin_textbox, "Origin");
        }

        private void CofOrigin_textbox_Enter(object sender, EventArgs e)
        {
            Controller.EnterChange(CofOrigin_textbox, "Origin");
        }

        private void Descrip_textBox_Enter(object sender, EventArgs e)
        {
            Controller.EnterChange(Descrip_textBox, "Description");
        }

        private void Descrip_textBox_Leave(object sender, EventArgs e)
        {
            Controller.LeaveChange(Descrip_textBox, "Description");
        }

        private void Price_textBox_Enter(object sender, EventArgs e)
        {
            Controller.EnterChange(Price_textBox, "Price");
        }

        private void Price_textBox_Leave(object sender, EventArgs e)
        {
            Controller.LeaveChange(Price_textBox, "Price");
        }

        private void AditinalInfo1_textBox_Enter(object sender, EventArgs e)
        {
            
            controller1.EnterChange(AditinalInfo1_textBox, AddInfo1Names);
        }

        private void AditinalInfo1_textBox_Leave(object sender, EventArgs e)
        {
            controller1.LeaveChange(AditinalInfo1_textBox, AddInfo1Names);
        }

        private void AditinalInfo2_textBox_Enter(object sender, EventArgs e)
        {
            controller1.EnterChange(AditinalInfo2_textBox, AddInfo2Names);
        }

        private void AditinalInfo2_textBox_Leave(object sender, EventArgs e)
        {
            controller1.LeaveChange(AditinalInfo2_textBox, AddInfo2Names);
        }

        private void Autors_textBox_Enter(object sender, EventArgs e)
        {
            Controller.EnterChange(Autors_textBox, "Autors");
        }

        private void Autors_textBox_Leave(object sender, EventArgs e)
        {
            Controller.LeaveChange(Autors_textBox, "Autors");
        }

        private void Merch_dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.Merch_dataGridView.SelectedRows)
            {
                int index = item.Index;
                controller1.DeleteMerch(index);
                Merch_dataGridView.Rows.RemoveAt(index);
                
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }
    }
}