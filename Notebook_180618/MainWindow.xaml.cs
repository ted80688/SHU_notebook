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

namespace BasicWpfNotepad
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        // 開啟檔案按鈕
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後要有的動作
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;
                // 讀取檔案
                TextArea.Text = System.IO.File.ReadAllText(filePath);
            }
        }


        // 存檔檔案按鈕
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;

                // 儲存檔案
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }
        //新開一篇文章按鍵
        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            //清除文字
            TextArea.Clear();
        }
        //開啟舊檔按鍵
        private void AsBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;

                // 儲存檔案
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }
        //字體變小按鍵
        private void Small_Click(object sender, RoutedEventArgs e)
        {
           double fsize = TextArea.FontSize;
            if (fsize != 12.0)
            {
                TextArea.FontSize = 14;
            }
        }
        //字體變中等按鍵
        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            double fsize = TextArea.FontSize;
            if (fsize != 18.0)
            {
                TextArea.FontSize = 18;
            }
        }
        //字體變大按鍵
        private void Big_Click(object sender, RoutedEventArgs e)
        {
            double fsize = TextArea.FontSize;
            if (fsize != 24.0)
            {
                TextArea.FontSize = 24;
            }
        }
        //改變字背景顏色為灰色並改字體顏色為白色
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextArea.Background = Brushes.DimGray;
            TextArea.Foreground = Brushes.White;
        }
        //改變字背景顏色為白色並改字體顏色為灰色
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextArea.Background = Brushes.White;
            TextArea.Foreground = Brushes.Gray;
        }
    }
}
