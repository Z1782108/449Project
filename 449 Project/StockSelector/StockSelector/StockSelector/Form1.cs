using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockSelector
{
    public partial class StockSelector : Form
    {
        public StockSelector()
        {
            InitializeComponent();
        }

        //set initital vars for holding selections
        public string sectorVar = "";
        public Boolean volatilityVar = false;
        public Boolean liquidityVar = false;
        public Boolean priceVar = false;

        //set sector selection
        private void SectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectorVar = SectorComboBox.SelectedIndex.ToString();
            if (sectorVar == "Sector")
            {
                MessageBox.Show("Please select a sector.");
            }
        }

        //set volatility range
        private void VolatilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string volatilityChoice = VolatilityComboBox.Text;
            if (volatilityChoice == "Volatility")
            {
                MessageBox.Show("Please select a volatility value.");
            }
            else if (volatilityChoice == "Stable")
            {
                volatilityVar = true;
            }
            else
            {
                volatilityVar = false;
            }
        }

        //set liquidity range
        private void LiquidityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string liquidityChoice = LiquidityComboBox.Text;
            if (liquidityChoice == "Liquidity")
            {
                MessageBox.Show("Please select a liquidity value.");
            }
            else if (liquidityChoice == "Low Trade Volume(More price control, harder to sell)")
            {
                liquidityVar = true;
            }
            else
            {
                liquidityVar = false;
            }
        }

        //Set price range
        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string priceChoice = VolatilityComboBox.Text;
            if (priceChoice == "Price")
            {
                MessageBox.Show("Please select a price range.");
            }
            else if (priceChoice == "Buget")
            {
                priceVar = true;
            }
            else
            {
                priceVar = false;
            }
        }

        private void StockSelectorButton_Click(object sender, EventArgs e)
        {
            string liqQuery = "";
            string volaQuery = "";
            string priceQuery = "";
            string sectorQuery = "";

            //set query variable
            if (liquidityVar == true)
            {
                liqQuery = "SELECT StockName FROM Stocks WHERE Volume = LOW";
            }
            else
            {
                liqQuery = "SELECT StockName FROM Stocks WHERE Volume = HIGH";
            }

            if (volatilityVar == true)
            {
                volaQuery = " AND Growth = STABLE";
            }
            else
            {
                volaQuery = " AND Growth = GROWTH";
            }

            if (priceVar == true)
            {
                priceQuery = " AND Price = BUDGET";
            }
            else
            {
                priceQuery = " AND Growth = BUDGET OR ANY";
            }

            sectorQuery = " AND Sector = " + sectorVar;

            string selectionQuery = liqQuery + volaQuery + priceQuery + sectorQuery;

            //open connection and query
            string connString = Properties.Settings.Default.Database1ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                selectionQuery, connection))
                {
                    //Output to listbox
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ticker = (string)reader["StockName"];

                            this.resultsListBox.Items.Add(ticker);
                        }

                        reader.Close();

                        //close connection
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
        }
    }
}
