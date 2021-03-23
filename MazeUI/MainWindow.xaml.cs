using MazeSimulator;
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

namespace MazeUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IMaze Maze;
        IMazeRunner MazeRunner;
        Simulator Simulator;
        public MainWindow()
        {
            InitializeComponent();
            SetUpSimulation();
        }

        //Run a maze
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numberOfMovesMade = Simulator.MazeTrial(Maze, MazeRunner);

            this.txtNumberOfMovesMadePrintOut.Text =  numberOfMovesMade.ToString() ;
        }

        private void SetUpSimulation()
        {
            MazeRunner = new MazeRunnerJumper();
            Maze = new SquareMaze();
            Simulator = new Simulator();
        }
    }
}
