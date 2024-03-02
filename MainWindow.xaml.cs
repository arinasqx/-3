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

namespace Зад3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {
            private void MoveObject(double X, double Y)   
            {
                Canvas.SetLeft(objectToMove, Canvas.GetLeft(objectToMove) + X);  
                Canvas.SetTop(objectToMove, Canvas.GetTop(objectToMove) + Y);    
                                                                             
                double ширина = Math.Max(0, Math.Min(x.ActualWidth - objectToMove.ActualWidth, Canvas.GetLeft(objectToMove)));
                double высота = Math.Max(0, Math.Min(x.ActualHeight - objectToMove.ActualHeight, Canvas.GetTop(objectToMove)));
                Canvas.SetLeft(objectToMove, ширина);
                Canvas.SetTop(objectToMove, высота);
            }

            private void UpButton_Click(object sender, RoutedEventArgs e)  
            {
                MoveObject(0, -33);  //Сдвиг кнопочки на 33 пикселей вверх
            }

            private void DownButton_Click(object sender, RoutedEventArgs e)  
            {
                MoveObject(0, 33);   //Сдвиг кнопочки  на 33 пикселей вниз
            }

            private void LeftButton_Click(object sender, RoutedEventArgs e)   
            {
                MoveObject(-33, 0);   //Сдвиг кнопочки на 15 пикселей влево
            }

            private void RightButton_Click(object sender, RoutedEventArgs e)  
            {
                MoveObject(33, 0);   //Сдвиг кнопочки на 33 пикселей вправо
            }
        }
    }
