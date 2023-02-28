using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Lab_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DateTime currentTime = DateTime.Now;

            int hours = currentTime.Hour;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;

            txt_result_box1.Text = $"{hours:00}:{minutes:00}:{seconds:00}";
        }
        //---------------------------------------------------------------------------------1

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(var_a.Text);
            double b = Convert.ToDouble(var_b.Text);
            double c = Convert.ToDouble(var_c.Text);

            double result = ((b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c))/2 * a) - Math.Pow(a, 3) * c + Math.Pow(b, -2);
            result_var.Text = Convert.ToString(result);
        }

        //захист від "дурня"
        private void var_a_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                var_a.SelectedText = ",";
                var_a.CaretIndex = var_a.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                btn_result.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        private void var_b_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                var_b.SelectedText = ",";
                var_b.CaretIndex = var_b.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                btn_result.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        private void var_c_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                var_c.SelectedText = ",";
                var_c.CaretIndex = var_c.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                btn_result.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        //---------------------------------------------------------------------------------2
        private void btn_result1_Click(object sender, RoutedEventArgs e)
        {
            int t = Convert.ToInt32(txt_hours.Text);
            int n = Convert.ToInt32(txt_minutes.Text);
            int k = Convert.ToInt32(txt_seconds.Text);

            

            if ((t >= 0 && t <= 23) && (n >= 0 && n <= 59) && (k >= 0 && k <= 59))
            {
                DateTime currentTime = DateTime.Now;

                DateTime newTime = currentTime.AddHours(t).AddMinutes(n).AddSeconds(k);

                txt_result_box2.Text = $"{newTime}";
            }
            
        }

        //захист від "дурня"

        private void txt_hours_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                txt_hours.SelectedText = ",";
                txt_hours.CaretIndex = txt_hours.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                btn_result1.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        private void txt_minutes_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                txt_minutes.SelectedText = ",";
                txt_minutes.CaretIndex = txt_minutes.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                btn_result1.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        private void txt_seconds_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                txt_seconds.SelectedText = ",";
                txt_seconds.CaretIndex = txt_seconds.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                btn_result1.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        //---------------------------------------------------------------------------------3
        private void num_btn_Click(object sender, RoutedEventArgs e)
        {
            int result = Convert.ToInt32(num_txt.Text);

            if(num_txt.Text.Length == 4) {
                int sumFirstTwoDigits = (result / 1000) + ((result / 100) % 10); // Сума двох перших цифр
                int sumLastTwoDigits = ((result / 10) % 10) + (result % 10); // Сума двох останніх цифр
                
                if(sumFirstTwoDigits == sumLastTwoDigits)
                {
                    num_txt_res.Text = "True";
                }
                else
                {
                    num_txt_res.Text = "False";
                }
            }
            else
            {
                num_txt_res.Text = "Введене число є не чотирьохзначним!";
            }
        }

        //захист від "дурня"

        private void num_txt_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                num_txt.SelectedText = ",";
                num_txt.CaretIndex = num_txt.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                num_btn.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        //---------------------------------------------------------------------------------4

        private void num_btn_day_Click(object sender, RoutedEventArgs e)
        {
            int dayOfYear = Convert.ToInt32(num_txt_day.Text);

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int month = 0;
            int dayOfMonth = 0;
            for (int i = 0; i < daysInMonth.Length; i++)
            {
                if (dayOfYear <= daysInMonth[i])
                {
                    month = i + 1;
                    dayOfMonth = dayOfYear;
                    break;
                }
                dayOfYear -= daysInMonth[i];
            }


            txt_day_res1.Text = "Порядковий номер дня: " + Convert.ToString(dayOfYear);
            txt_day_res2.Text = "День місяця: " + Convert.ToString(dayOfMonth);
            txt_day_res3.Text = "Місяць: " + Convert.ToString(month);
        }

        //захист від "дурня"

        private void num_txt_day_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                num_txt_day.SelectedText = ",";
                num_txt_day.CaretIndex = num_txt_day.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                num_btn_day.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        //---------------------------------------------------------------------------------5

        private void num_btn_digit_Click(object sender, RoutedEventArgs e)
        {
            string numberStr = num_txt_digit.Text;
            char[] digits = numberStr.ToCharArray();
            char[] uniqueDigits = digits.Distinct().ToArray();
            if (digits.Length == uniqueDigits.Length)
            {
                num_txt_digit1.Text = "Цифри числа є різними!";
            }
            else
            {
                num_txt_digit1.Text = "Цифри числа не є різними!";
            }
        }

        //захист від "дурня"

        private void num_txt_digit_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                num_txt_digit.SelectedText = ",";
                num_txt_digit.CaretIndex = num_txt_digit.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                num_btn_digit.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }

        //---------------------------------------------------------------------------------6
        private void array_btn_Click(object sender, RoutedEventArgs e)
        {
            //перетворюємо рядок в масив
            string input = array_txt.Text;
            string[] stringArray = input.Split(',');

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i].Trim());
            }
            //intArray - масив, отриманий з рядку
            //перевертаємо цей масив
            int[] Rev(int[] arr)
            {
                int[] result = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    result[i] = arr[arr.Length - i - 1];
                }
                return result;
            }

            //перетворення перевернутий масив в рядок

            string arrString = "";
            for (int i = 0; i < Rev(intArray).Length; i++)
            {
                arrString += Rev(intArray)[i].ToString();
                if (i < Rev(intArray).Length - 1)
                {
                    arrString += ", ";
                }
            }
                array_res.Text = arrString;
        }

        //захист від "дурня"

        private void array_txt_KeyPress(object sender, KeyEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e

            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemComma)
            {
                // Digit or comma
                return;
            }
            if (e.Key == Key.OemPeriod)
            {
                // крапка замінена комою
                e.Handled = true;
                array_txt.SelectedText = ",";
                array_txt.CaretIndex = array_txt.SelectionStart + 1;
                return;
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                // Enter key, set focus to OK button
                e.Handled = true;
                array_btn.Focus();
                return;
            }
            // Other characters are not allowed
            e.Handled = true;
        }
        //---------------------------------------------------------------------------------7
        private void word_count_btn_Click(object sender, RoutedEventArgs e)
        {
            string countStr = word_count_txt.Text;

            string[] words = countStr.Split(' ');

            int wordCount = words.Length;

            word_count_res.Text = "Кількість слів: " + wordCount;
        }
        



        /*
        private void var_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (var_a.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Key.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btn_result.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }*/

    }
    }
