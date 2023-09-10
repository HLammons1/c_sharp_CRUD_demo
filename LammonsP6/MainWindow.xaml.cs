//Hayden Lammons HLammons1@cnm.edu
//LammonsP6, implement command design pattern

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LammonsP6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<InventoryItem> inventoryItems;
        private List<IInventoryCommand> commands;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            inventoryItems = new List<InventoryItem>();
            commands = new List<IInventoryCommand>();
            lbInventory.ItemsSource = inventoryItems;
        }

        private void btnAddOne_Click(object sender, RoutedEventArgs e)
        {
            InventoryItem newItem = new InventoryItem(tbName.Text);
            AddOneCommand newCmd = new AddOneCommand(newItem, inventoryItems);
            newCmd.Do();
            commands.Add(newCmd);
            lbInventory.Items.Refresh();
        }

        private void btnRandomAmt_Click(object sender, RoutedEventArgs e)
        {
            InventoryItem newItem = new InventoryItem(tbName.Text);
            AddMultipleCommand newCmd = new AddMultipleCommand(newItem, inventoryItems);
            newCmd.Do();
            commands.Add(newCmd);
            lbInventory.Items.Refresh();
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (commands.Count > 0)
            {
                commands.Last().Undo();
                commands.Remove(commands.Last());
                lbInventory.Items.Refresh();
            }
        }
    }
}
