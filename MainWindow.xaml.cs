
using System.Windows;
using System.Windows.Controls;
using SalesJournal.Pages;

namespace SalesJournal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Pages And Frames
        public Frame       salesFrame;
        public SalesPage   salesPage;
        public Frame       ordersFrame;
        public OrdersPage  ordersPage;
        public Frame       archiveFrame;
        public ArchivePage archivePage;
        public Frame       stockFrame;
        public StockPage   stockPage;
        public Frame       statsFrame;
        public StatsPage   statsPage;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            BindPagesToTabs();
            
        }
        
        public void BindPagesToTabs()
        {
            Thickness plugC = new Thickness(0);
            

            salesFrame = new Frame();
            ordersFrame = new Frame(); 
            archiveFrame = new Frame(); 
            stockFrame = new Frame();
            statsFrame = new Frame();

            salesPage = new SalesPage();
            ordersPage = new OrdersPage();
            archivePage = new ArchivePage();
            stockPage = new StockPage();
            statsPage = new StatsPage();

            salesFrame.Content = salesPage;
            SalesTab.Content = salesFrame;
            ordersFrame.Content = ordersPage;
            OrdersTab.Content = ordersFrame;
            statsFrame.Content = statsPage;
            StatsTab.Content = statsFrame;

            stockFrame.Content = stockPage;
            StockTab.Content = stockFrame;
            archiveFrame.Content = archivePage;
            ArchiveTab.Content = archiveFrame;
            
        }
    }
}
