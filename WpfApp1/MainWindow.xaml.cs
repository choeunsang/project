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

using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitNationControl();
            InitTypeControl();
        }

        private List<ComboModel> NationList = null;
        private List<ComboModel> StockTypeList = null;

        private void InitNationControl()
        {
            NationList = new List<ComboModel>();
            //NationList.Add(new ComboModel() { ComboVal = "ALL", ComboNm = "전체" });
            NationList.Add(new ComboModel() { ComboVal = "KOR", ComboNm = "한국" });
            NationList.Add(new ComboModel() { ComboVal = "CHI", ComboNm = "중국" });
            NationList.Add(new ComboModel() { ComboVal = "VET", ComboNm = "베트남" });
            NationList.Add(new ComboModel() { ComboVal = "IDN", ComboNm = "인도네시아" });

            cboNation.ItemsSource = NationList;
            cboNation.SelectedIndex = 0;
        }

        private void InitTypeControl()
        {
            StockTypeList = new List<ComboModel>();
            //StockTypeList.Add(new ComboModel() { ComboVal = "ALL", ComboNm = "전체" });
            StockTypeList.Add(new ComboModel() { ComboVal = "034220", ComboNm = "LG디스플레이" });
            //StockTypeList.Add(new ComboModel() { ComboVal = "CHI", ComboNm = "중국" });
            //StockTypeList.Add(new ComboModel() { ComboVal = "VET", ComboNm = "베트남" });
            //StockTypeList.Add(new ComboModel() { ComboVal = "IDN", ComboNm = "인도네시아" });

            cboStockType.ItemsSource = StockTypeList;
            cboStockType.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string gitHubAddress = string.Empty;
            gitHubAddress = "https://github.com/choeunsang/project.git";

            //MessageBox.Show("깃 허브 주소 : " + gitHubAddress + " 입니다. ddd");
            MessageBox.Show("깃 허브 주소 : " + gitHubAddress + " 입니다. ddd");
        }
    }
}
