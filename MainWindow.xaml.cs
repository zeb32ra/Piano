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


namespace WPFPiano
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int[] fourth_octave = new int[12] {262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494};
        public int[] fifth_octave = new int[12] {523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988};
        public int[] sixth_octave = new int[12] {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
        public int[] current_octave = new int[12];
        public int position;

        private void Do_Copy_Click(object sender, RoutedEventArgs e)
        {
            position = 0;
            Play_Note(current_octave, position);
        }

        private void Do_dies_Click(object sender, RoutedEventArgs e)
        {
            position = 1;
            Play_Note(current_octave, position);
        }

        private void Re_Click(object sender, RoutedEventArgs e)
        {
            position = 2;
            Play_Note(current_octave, position);
        }

        private void Re_Dies_Click(object sender, RoutedEventArgs e)
        {
            position = 3;
            Play_Note(current_octave, position);
        }

        private void Mi_Click(object sender, RoutedEventArgs e)
        {
            position = 4;
            Play_Note(current_octave, position);
        }

        private void Fa_Click(object sender, RoutedEventArgs e)
        {
            position = 5;
            Play_Note(current_octave, position);
        }

        private void Fa_Dies_Click(object sender, RoutedEventArgs e)
        {
            position = 6;
            Play_Note(current_octave, position);
        }

        private void Sol_Click(object sender, RoutedEventArgs e)
        {
            position = 7;
            Play_Note(current_octave, position);
        }

        private void Sol_Dies_Click(object sender, RoutedEventArgs e)
        {
            position = 8;
            Play_Note(current_octave, position);
        }

        private void La_Click(object sender, RoutedEventArgs e)
        {
            position = 9;
            Play_Note(current_octave, position);
        }

        private void La_Dies_Click(object sender, RoutedEventArgs e)
        {
            position = 10;
            Play_Note(current_octave, position);
        }

        private void Si_Click(object sender, RoutedEventArgs e)
        {
            position = 11;
            Play_Note(current_octave, position);
        }

        private void Fourth_Octave_Checked(object sender, RoutedEventArgs e)
        {
            current_octave = fourth_octave;
        }

        private void Fifth_Octave_Checked(object sender, RoutedEventArgs e)
        {
            current_octave = fifth_octave;
        }

        private void Sixth_Octave_Checked(object sender, RoutedEventArgs e)
        {
            current_octave = sixth_octave;
        }

        public static void Play_Note(int[] current_octave, int index)
        {
            Console.Beep(current_octave[index], 300);
        }
    }
}


