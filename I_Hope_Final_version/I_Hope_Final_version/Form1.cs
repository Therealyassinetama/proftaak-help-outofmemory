using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Hope_Final_version
{
    internal partial class Form1 : Form
    {
        //
        // TO DO: Actie maken die een order uit de database verwijdert
        //        Deze aan een button linken
        // KOPPEL TABEL TUSSEN MEAL EN ORDER MAKEN
        //
        //
        //HOW IT WORKD?
        // listbox 3 verschillende orders, listbox 2 alle meals die in je order zit. en in listbox 1 alle ingredienten in je meal. 
        // Meal klaar druk op knop meal klaar om ALLEEN voorraad aan te passen in de database.
        // Order klaar druk je op ORDER READY en wordt er een signaal naar de arduino gestuurd?
        //
        //
        //Eerste versie zonder databse
        //
        //


        List<Order> orders = new List<Order>();
        Order order;
        Recipe recipe;
        Ingredient ingredient;

        public Form1() // Krijgt een Database mee vanuit het startscherm
        {
            InitializeComponent();
            for(int i = 0; i<1;i++)
            {
                Order order2 = new Order("order " + i.ToString());
                orders.Add(order2);
            }
            //order = orders[0];
            //recipe = orders[0].Recipes[0];
            // timer die om de 10 seconden(ofzo) de list met alle orders verniuewt
        }

        private void BT_MakeMeal_Click(object sender, EventArgs e)
        {
            // Process?
            //MySQL query die alle ingredienten ophaalt en heoveel
            //
            foreach (Order order in orders)
            {
                listBox3.Items.Add(order);
            }
            foreach (Recipe recipe in orders[0].Recipes)
            {
                listBox2.Items.Add(recipe);
            }
            foreach (Ingredient ingredient in orders[0].Recipes[0].ingredients)
            {
                listBox1.Items.Add(ingredient);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doet niks behalve een list laten zien.
            UpdateListBox();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update listbox 1 met alle benodigde ingredienten aan de hand van het geselecteerde object van listbox 2.
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            order = (Order)listBox3.Items[0];
            recipe = (Recipe)listBox2.Items[0];
            // ingredient = (Ingredient)listBox1.SelectedItem; deze functie verplaatsen naar updaten van database
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach(Order order in orders)
            {
                listBox3.Items.Add(order);
            }
            foreach (Recipe recipe in order.Recipes)
            {
                listBox2.Items.Add(recipe);
            }
            foreach (Ingredient ingredient in recipe.ingredients)
            {
                listBox1.Items.Add(ingredient);
            }
        }

        private void BT_Order_Ready_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update listbox 2 (en 3 op het eerste item van listbox 2) met alle items uit je order.

        }
    }
}
