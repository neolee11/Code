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

namespace ConvertDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            TxtOutput.Clear();

            var input = TxtInput.Text;

            var inputSep = input.Split(new char[] {'\n'});
 


            foreach (var aDateStr in inputSep)
            {
                if (aDateStr == "\r" || aDateStr == "\n" || aDateStr == "")
                {
                    TxtOutput.Text += "\n";
                }
                else
                {
                    //TxtOutput.Text += aDate;
                    var dateSep = aDateStr.Trim().Split(new char[] {' '});
                    var day = dateSep[0];
                    var month = ConvertMonth(dateSep[1]);
                    var year = dateSep[2];

                    var newDate = new DateTime(int.Parse(year), month, int.Parse(day));

                    TxtOutput.Text += newDate.ToString() + "\n";
                }
            }

        }

        private int ConvertMonth(string month)
        {
            month = month.ToUpper();

            switch (month)
            {
                case "JAN":
                    return 1;        
                    break;
                case "FEB":
                    return 2;
                    break;
                case "MAR":
                    return 3;
                    break;
                case "APR":
                    return 4;
                    break;
                case "MAY":
                    return 5;
                    break;
                case "JUN":
                    return 6;
                    break;
                case "JUL":
                    return 7;
                    break;
                case "AUG":
                    return 8;
                    break;
                case "SEP":
                    return 9;
                    break;
                case "OCT":
                    return 10;
                    break;
                case "NOV":
                    return 11;
                    break;
                case "DEC":
                    return 12;
                    break;
                default:
                    throw new Exception("There is not month " + month);
                    break;
            }

        }
    }
}
