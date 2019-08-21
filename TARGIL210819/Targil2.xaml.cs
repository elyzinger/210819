using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TARGIL210819
{
    /// <summary>
    /// Interaction logic for Targil2.xaml
    /// </summary>
    public partial class Targil2 : Window
    {
        
        public Targil2()
        {
            InitializeComponent();
            

        }
        //private void SafeInvoke(Action work)
        //{
        //    if (Dispatcher.CheckAccess()) // CheckAccess returns true if you're on the dispatcher thread
        //    {
        //        work.Invoke();
        //        return;
        //    }
        //    this.Dispatcher.BeginInvoke(work);
        //}
        //private void startBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    Task t =  Task.Run(() =>
        //    {
        //        for (int i = 50; i >= 0; i--)
        //        {
        //            Action uiwork = () => { counter.Text = i.ToString(); };
        //            SafeInvoke(uiwork);
        //            Thread.Sleep(250);
        //        }
        //    });
        //}
        //private async void startBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    for (int i = 50; i >= 0; i--)
        //    {
        //        counter.Text = i.ToString();
        //        await Task.Run(() => { Thread.Sleep(250); });
        //    }
        //}
        //public void timer()
        //{
        //}

        public void startBtn_Click(object sender, EventArgs e)
        {

            //counter.Text = i.ToString();
            DispatcherTimer timer;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(250);

            timer.Tick += (sen1, e1) => {
                int number = Convert.ToInt32(counter.Text);
                number--;
                if (number <= 0)
                {
                    timer.Stop();
                };
                counter.Text = number.ToString();
            };

            timer.Start();
        }
    }
}
