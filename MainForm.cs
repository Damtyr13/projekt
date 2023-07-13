using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZakupów
{
    public partial class MainForm : Form
    {
        ItemManager itemManager = new ItemManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        } 

        private void InitializeGUI()
        {
            cmbUnits.Items.AddRange(Enum.GetNames(typeof (UnitTypes)));
            cmbUnits.SelectedIndex = (int)UnitTypes.szt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = false;

            ShoppingItem item = ReadInput(out success);

            if(success)
            {
                itemManager.AddItem(item);
                UpdateGUI();
            }
        }

        private ShoppingItem ReadInput(out bool success)
        {
            success = false;

            ShoppingItem item = new ShoppingItem();

            item.Description = ReadDescription(out success);

            if (!success)
                return null;

            item.Amount = ReadAmount(out success);

            if (!success)
                return null;
			item.Price = ReadPrice(out success);

			if (!success)
				return null;

			item.Unit = ReadUnit(out success);

            return item;
        }

        private double ReadAmount(out bool success)
        {
            double amount = 0.0;
            success = false;

            if(!double.TryParse(txtAmount.Text, out amount))
            {
                GiveMessage("Zła ilość");
                txtAmount.Focus();
                txtAmount.SelectionStart = 0;
                txtAmount.SelectionLength = txtAmount.TextLength;
            }
            else
            {
                success = true;
            }

            return amount;
        }
		private double ReadPrice(out bool success)
		{
			double price = 0.0;
			success = false;

			if (!double.TryParse(txtPrice.Text, out price))
			{
				GiveMessage("Zła wartość");
				txtPrice.Focus();
                txtPrice.SelectionStart = 0;
                txtPrice.SelectionLength = txtPrice.TextLength;
			}
			else
			{
				success = true;
			}

			return price;
		}

		private string ReadDescription(out bool success)
        {
            string name = string.Empty;
            success = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                GiveMessage("Wprowadź produkt");
                txtName.Focus();
                txtName.SelectionStart = 0;
                txtName.SelectionLength = txtName.TextLength;
            }
            else
            {
                name = txtName.Text;
                success = true;
            }

            return name;
        } 

        private UnitTypes ReadUnit(out bool success)
        {
            UnitTypes unit = UnitTypes.szt;
            success = false;

            if (!Enum.IsDefined(typeof(UnitTypes), cmbUnits.SelectedIndex))
            {
                GiveMessage("Wybierz prawidłowy typ jednostki");
                cmbUnits.Focus();
            }
            else
            {
                unit = (UnitTypes) cmbUnits.SelectedIndex;
                success = true;
            }

            return unit;
        }

        private void GiveMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

        public void UpdateGUI()
        {
            string[] list = itemManager.GetItemsInfoString();
            lstItems.Items.Clear();

            if (list == null)
                return;

            for (int i = 0; i < list.Length; i++)
            {
                lstItems.Items.Add(list[i]);
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedindex = lstItems.SelectedIndex;
            ShoppingItem item = null;

            item = itemManager.GetItem(selectedindex);

            if(item != null)
            {
                txtName.Text = item.Description;
                txtAmount.Text = item.Amount.ToString();
				txtPrice.Text = item.Price.ToString();
				cmbUnits.SelectedIndex = (int) item.Unit;
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedindex = lstItems.SelectedIndex;
            ShoppingItem item = null;
            bool success = false;

            item = ReadInput(out success);
            
            if (success && (item != null) && itemManager.ChangeItem(item, selectedindex))
            {
                UpdateGUI();
            }
            else
            {
                GiveMessage("Błąd: Nie zmieniono, najpierw wybierz element do zmiany");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedindex = lstItems.SelectedIndex;

            if (itemManager.DeleteItem(selectedindex))
            {
                UpdateGUI();
            }
            else
            {
                GiveMessage("Błąd: Nie usunięto, najpierw wybierz element do usunięcia");
            }
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		public static bool ReadAmount(string v)
		{
			throw new NotImplementedException();
		}
	}
}
