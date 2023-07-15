using LegalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace LegalQuiz2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Increment { get; set; }

        DispatcherTimer time = new DispatcherTimer();
        private Quiz Quizs;
        string backButton = "";
        string nextButton = "";
        private int queue = -1;
        private int Lang;
        private List<int> Queues = new List<int>();
        private List<int> TanlanganVariant = new List<int>();
        private List<int> Logical_question_Id = new List<int>();
        private List<int> Logical_Cases_Id = new List<int>();
        private Dictionary<int, List<Quiz_Item>> Variants = new Dictionary<int, List<Quiz_Item>>();
        public int A;
        public int B;
        public int C;
        public int MaxQuizCount = 0;
        public MainWindow()
        {
            InitializeComponent();
            Text_Center.Visibility = Visibility.Hidden;
            Text_Variant.Visibility = Visibility.Hidden;
            Text_All.Visibility = Visibility.Hidden;
            Text_Center.Text = Text_Variant.Text = "";
            Button_Next.Visibility = Visibility.Hidden;
            Button_Back.Visibility = Visibility.Hidden;
            Button_Print.Visibility = Visibility.Hidden;
            A = B = C = 0;
        }

        private void Button_Click_Uz(object sender, RoutedEventArgs e)
        {
            if (Button_Uz.Content.Equals("O'zbek tili"))
            {
                Lang = 1;
                Button_Uz.Content = "Konstitusiyaviy huquq";
                Button_Ru.Content = "Huqubuzarliklar profilaktikasi";
                backButton = "Ortga";
                Button_Back.Visibility = Visibility.Visible;
            }
            else
            if (Button_Uz.Content.Equals("Konstitusiyaviy huquq"))
            {
                Button_Uz.Visibility = Visibility.Hidden;
                Button_Ru.Visibility = Visibility.Hidden;
                Button_Back.Visibility = Visibility.Hidden;
                Quizs = new Quiz(1, 1);
                Increment = 0;
                time.Interval = TimeSpan.FromSeconds(0.01);
                time.Tick += Time_Tick;
                time.Start();
            }
            else
            if (Button_Uz.Content.Equals("Конституционное право"))
            {
                Button_Uz.Visibility = Visibility.Hidden;
                Button_Ru.Visibility = Visibility.Hidden;
                Button_Back.Visibility = Visibility.Hidden;
                Quizs = new Quiz(1, 2);
                Increment = 0;
                time.Interval = TimeSpan.FromSeconds(0.01);
                time.Tick += Time_Tick;
                time.Start();
            }
            else
            {
                Button_Uz.Visibility = Visibility.Hidden;
                Button_Print.Visibility = Visibility.Visible;
                Text_Center.Visibility = Visibility.Visible;
                Text_Variant.Visibility = Visibility.Visible;
                Button_Next.Visibility = Visibility.Visible;
                if (Lang == 1)
                {
                    nextButton = "Keyingi variant";
                    backButton = "Ortga";
                }
                else
                {
                    nextButton = "Следующий вариант";
                    backButton = "Назад";
                }
                Generator(sender, e);
                Button_Uz.Content = "Var";

            }
        }

        private void Button_Click_Ru(object sender, RoutedEventArgs e)
        {
            if (Button_Ru.Content.Equals("Русский язык"))
            {
                Lang = 2;
                Button_Uz.Content = "Конституционное право";
                Button_Ru.Content = "Предотвращение преступления";
                backButton = "Назад";
                Button_Back.Visibility = Visibility.Visible;
            }
            else
            if (Button_Ru.Content.Equals("Предотвращение преступления"))
            {
                Button_Ru.Visibility = Visibility.Hidden;
                Button_Back.Visibility = Visibility.Hidden;
                Button_Uz.Visibility = Visibility.Hidden;
                Button_Back.Visibility = Visibility.Hidden;
                Quizs = new Quiz(2, 2);
                Increment = 0;
                time.Interval = TimeSpan.FromSeconds(0.01);
                time.Tick += Time_Tick;
                time.Start();
            }
            else
            if (Button_Ru.Content.Equals("Huqubuzarliklar profilaktikasi"))
            {
                Button_Ru.Visibility = Visibility.Hidden;
                Button_Uz.Visibility = Visibility.Hidden;
                Button_Back.Visibility = Visibility.Hidden;
                Quizs = new Quiz(2, 1);
                Increment = 0;
                time.Interval = TimeSpan.FromSeconds(0.01);
                time.Tick += Time_Tick;
                time.Start();
            }
            else
            {
                Button_Uz.Visibility = Visibility.Hidden;
                Button_Print.Visibility = Visibility.Visible;
                Text_Center.Visibility = Visibility.Visible;
                Text_Variant.Visibility = Visibility.Visible;
                Button_Next.Visibility = Visibility.Visible;
                Button_Back.Visibility = Visibility.Visible;

                if (Lang == 1)
                {
                    nextButton = "Keyingi variant";
                    backButton = "Ortga";
                }
                else
                {
                    nextButton = "Следующий вариант";
                    backButton = "Назад";
                }
                Generator(sender, e);
                Button_Uz.Content = "Var";
            }
        }

        private void Time_Tick(object? sender, EventArgs e)
        {
            Increment++;
            PB_1.Value = Increment;

            if (Increment == 100)
            {
                time.Stop();
                Hidden();
            }
        }

        private void Hidden()
        {
            Button_Back.Visibility = Visibility.Visible;
            Button_Uz.Visibility = Visibility.Hidden;
            PB_1.Visibility = Visibility.Hidden;
            Text_Prosent.Visibility = Visibility.Hidden;
            if (Lang == 1)
            {
                Button_Uz.Content = "Variantni tanlash";
            }
            else
                Button_Uz.Content = "Выберите вариант";

            Button_Uz.Visibility = Visibility.Visible;
        }

        private void Generator(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Variants.Clear();
            Logical_question_Id.Clear();
            Logical_Cases_Id.Clear();

            MaxQuizCount = Quizs.Logical_Cases_1.Count;

            if ((MaxQuizCount * 2) > Quizs.Logical_question_1.Count)
                MaxQuizCount = Quizs.Logical_question_1.Count / 2;

            for (int i = 0; i < MaxQuizCount; i++)
            {
                A = B = C = 0;
                CheckId(ref A, ref B, ref C);
                Variants.Add(i + 1, new List<Quiz_Item>()
                {
                    Quizs.Logical_question_1.Where(x => x.Id == A).FirstOrDefault(),
                    Quizs.Logical_question_1.Where(x => x.Id == B).FirstOrDefault(),
                    Quizs.Logical_Cases_1.Where(x => x.Id == C).FirstOrDefault()
                });
            }
            //int Number = random.Next(1, 50);
            //this.Text_Variant.Text = Number.ToString() + (Lang == 1 ? " - VARIANT" : " - ВАРИАНТ");
            //int j = 1;
            //foreach (var obj in Variants.Where(x => x.Key == Number))
            //{
            //    this.Text_Center.Text += j++.ToString() + "." + obj.Value[0].Question + "\n";
            //    this.Text_Center.Text += "\n";
            //    this.Text_Center.Text += j++.ToString() + "." + obj.Value[1].Question + "\n";
            //    this.Text_Center.Text += "\n";
            //    this.Text_Center.Text += j.ToString() + "." + obj.Value[2].Question + "\n" + obj.Value[2].Comment + "\n";
            //}
            //TanlanganVariant.Add(Number);

            TanlanganVariant.Clear();

            for (int i = 0; i < MaxQuizCount; i++)
            {
                int Number = 0;

                if (TanlanganVariant.Count == MaxQuizCount - 1)
                {
                    Number = Variants.Where(x => !TanlanganVariant.Contains(x.Key)).First().Key;
                }
                else
                {
                check_A: Number = random.Next(1, MaxQuizCount + 1);

                    if (Variants.Where(x => TanlanganVariant.Contains(Number)).Any())
                        goto check_A;
                }
                TanlanganVariant.Add(Number);
            }
            Button_Next_Click(sender, e);
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            queue++;
            if (queue >= MaxQuizCount)
            {
                queue = -1;
                Generator(sender, e);
            }
            TextBoxChanged();
            if (queue == MaxQuizCount - 1)
            {
                MessageBox.Show(Lang == 1 ? "Ushbu variant barcha oxirgi qaytarilmas tanlanma. Keyingi tanlanma yangi tasodifiy tuzilib yangi variantlar tuziladi." : "Этот вариант является последним безвозвратным вариантом. Следующий выбор будет новый случайный, и будут созданы новые варианты.");
            }
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            if ((Button_Uz.Content == "Konstitusiyaviy huquq" && Button_Ru.Content == "Huqubuzarliklar profilaktikasi") || (Button_Uz.Content == "Конституционное право" && Button_Ru.Content == "Предотвращение преступления"))
            {
                Button_Back.Visibility = Visibility.Hidden;
                Button_Uz.Content = "O'zbek tili";
                Button_Ru.Content = "Русский язык";
                return;
            }
            if (Button_Uz.Content == "Variantni tanlash" || Button_Uz.Content == "Выберите вариант")
            {
                PB_1.Visibility = Visibility.Visible;
                Text_Prosent.Visibility = Visibility.Visible;
                PB_1.Value = 0;
                Button_Ru.Visibility = Visibility.Visible;
                if (Lang == 1)
                {
                    Button_Uz.Content = "Konstitusiyaviy huquq";
                    Button_Ru.Content = "Huqubuzarliklar profilaktikasi";
                    return;
                }
                else
                {
                    Button_Uz.Content = "Конституционное право";
                    Button_Ru.Content = "Предотвращение преступления";
                    return;
                }

            }
            else
            if (queue >= 0)
                queue--;

            if (queue == -1)
            {
                Button_Uz.Visibility = Visibility.Visible;
                //Button_Ru.Visibility = Visibility.Visible;
                Text_Center.Visibility = Visibility.Hidden;
                Button_Next.Visibility = Visibility.Hidden;
                Text_Variant.Visibility = Visibility.Hidden;
                Button_Print.Visibility = Visibility.Hidden;

                if (Lang == 1)
                {
                    Button_Uz.Content = "Variantni tanlash";
                }
                else
                    Button_Uz.Content = "Выберите вариант";



                //if (Lang == 1)
                //{
                //    Button_Uz.Content = "Konstitusiyaviy huquq";
                //    Button_Ru.Content = "Huqubuzarliklar profilaktikasi";
                //    Button_Back.Content = "Ortga";
                //}
                //else
                //{
                //    Button_Uz.Content = "Конституционное право";
                //    Button_Ru.Content = "Предотвращение преступления";
                //    Button_Back.Content = "Назад";
                //}
            }

            if (queue >= 0)
                TextBoxChanged();



        }

        private void TextBoxChanged()
        {
            this.Text_Center.Text = "";
            this.Text_Variant.Text = TanlanganVariant[queue].ToString() + (Lang == 1 ? " - VARIANT" : " - ВАРИАНТ");
            int j = 1;
            var obj = Variants.First(x => x.Key == TanlanganVariant[queue]);
            {
                this.Text_Center.Text += j++.ToString() + "." + obj.Value[0].Question + "\n";
                this.Text_Center.Text += "\n";
                this.Text_Center.Text += j++.ToString() + "." + obj.Value[1].Question + "\n";
                this.Text_Center.Text += "\n";
                this.Text_Center.Text += j.ToString() + "." + obj.Value[2].Question + "\n" + obj.Value[2].Comment + "\n";
            }
        }

        private void ALL_Click()
        {
            Text_All.Visibility = Visibility.Visible;
            this.Text_Variant.Text = "VARIANTLAR";
            this.Text_All.Items.Clear();
            int Number = 1;
            int j = 1;
            foreach (var obj in Variants)
            {
                j = 1;
                this.Text_All.Items.Add(Number++.ToString() + " - VARIANT \n");
                this.Text_All.Items.Add(j++.ToString() + "." + obj.Value[0].Question + "\n");
                this.Text_All.Items.Add(j++.ToString() + "." + obj.Value[1].Question + "\n");
                this.Text_All.Items.Add(j.ToString() + "." + obj.Value[2].Question + "\n" + obj.Value[2].Comment + "\n\n");
            }
        }

        private void NEXT_Click()
        {
            int Number = 0;
            Random random = new Random();

            if (TanlanganVariant.Count == 49)
            {
                Number = Variants.Where(x => !TanlanganVariant.Contains(x.Key)).First().Key;
            }
            else
            {
            check_A: Number = random.Next(1, 50);

                if (Variants.Where(x => TanlanganVariant.Contains(Number)).Any())
                    goto check_A;
            }

            this.Text_Variant.Text = this.Text_Center.Text = String.Empty;
            this.Text_Variant.Text = Number.ToString() + (Lang == 1 ? " - VARIANT" : " - ВАРИАНТ");
            int j = 1;
            foreach (var obj in Variants.Where(x => x.Key == Number))
            {
                this.Text_Center.Text += j++.ToString() + "." + obj.Value[0].Question + "\n";
                this.Text_Center.Text += "\n";
                this.Text_Center.Text += j++.ToString() + "." + obj.Value[1].Question + "\n";
                this.Text_Center.Text += "\n";
                this.Text_Center.Text += j.ToString() + "." + obj.Value[2].Question + "\n" + obj.Value[2].Comment + "\n";
            }
            TanlanganVariant.Add(Number);

            if (TanlanganVariant.Count == 50)
            {
                MessageBox.Show(Lang == 1 ? "Ushbu variant barcha oxirgi qaytarilmas tanlanma. Keyingi tanlanma Yangi Tasodifiy tuzilib yangi variantlar tuziladi." : "Этот вариант является последним безвозвратным вариантом. Следующий выбор будет New Randomized, и будут созданы новые варианты.");
                TanlanganVariant.Clear();
            }
        }

        private void CheckId(ref int A, ref int B, ref int C)
        {
            Random random = new Random();
        check_A:
            A = random.Next(1, MaxQuizCount + 1);
            if (Logical_question_Id.Contains(A)) goto check_A;
            Logical_question_Id.Add(A);
        check_B:
            B = random.Next(MaxQuizCount + 1, (MaxQuizCount * 2 + 1));
            if (Logical_question_Id.Contains(B)) goto check_B;
            Logical_question_Id.Add(B);
        check_C:
            C = random.Next(1, MaxQuizCount + 1);
            if (Logical_Cases_Id.Contains(C)) goto check_C;
            Logical_Cases_Id.Add(C);

        }

        private void Button_Print_Click(object sender, RoutedEventArgs e)
        {
            var gdW = GD.Width;
            var gdH = GD.Width;
            var fontSize = Text_Center.FontSize;
            GD.Width = 793;
            GD.Height = 1122;
            GD.HorizontalAlignment = HorizontalAlignment.Left;
            Text_Center.VerticalAlignment = VerticalAlignment.Top;
            Text_Center.FontSize = 16;
            Text_Center.HorizontalAlignment = HorizontalAlignment.Left;
            Button_Next.Visibility = Visibility.Hidden;
            Button_Back.Visibility = Visibility.Hidden;
            Button_Print.Visibility = Visibility.Hidden;

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(GD, Text_Variant.Text);
            }
            GD.Width = gdW;
            GD.Height = gdH;
            Text_Center.FontSize = fontSize;
            GD.HorizontalAlignment = HorizontalAlignment.Center;
            Text_Center.VerticalAlignment = VerticalAlignment.Center;
            Text_Center.HorizontalAlignment = HorizontalAlignment.Center;
            Button_Next.Visibility = Visibility.Visible;
            Button_Back.Visibility = Visibility.Visible;
            Button_Print.Visibility = Visibility.Visible;
        }


    }
}
