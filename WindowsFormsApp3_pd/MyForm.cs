using System;
using System.Windows.Forms;

namespace WindowsFormsApp3_pd
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                tbResult.Text = "Невозможно сравнить даты!";
                MessageBox.Show("Поставьте начальную дату меньше конечной!", "Ошибка вычисления", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (dtpStart.Value.Date == dtpEnd.Value.Date)
            {
                tbResult.Text = "Прошли только часы/мин./сек.";
            }
            else // 21.12.2020 - 05.02.2022 -- 1 год 1 месяц 15 дней
            {
                int m = 0, y = 0;//Изменение месяца и года

                int day = dtpEnd.Value.Date.Day - dtpStart.Value.Date.Day;
                if (day < 0)
                {
                    day += DateTime.DaysInMonth(dtpStart.Value.Date.Year, dtpStart.Value.Date.Month); //добавляем количество дней в первом месяце 
                    m = 1; //месяцем меньше будет
                }

                int mon = dtpEnd.Value.Date.Month - dtpStart.Value.Date.Month - m;
                if (mon < 0)
                {
                    mon += 12;
                    y = 1; //на год меньше будет
                }
                int year = dtpEnd.Value.Date.Year - dtpStart.Value.Date.Year - y;
                tbResult.Text = $"Прошло дней: {day}, месяцев: {mon}, лет: {year}";
            }
        }

        private void tbFirst_Scroll(object sender, EventArgs e)
        {
            lblFirstStep.Text = tbFirst.Value.ToString();
            lblRes.Text = (tbFirst.Value * tbSecond.Value).ToString();

            if (chbQuadr.Checked)
            {
                tbSecond.Value = tbFirst.Value;
                lblRes.Text = (tbFirst.Value * tbSecond.Value).ToString();
                lblSecondStep.Text = lblFirstStep.Text;
            }
        }

        private void tbSecond_Scroll(object sender, EventArgs e)
        {
            lblSecondStep.Text = tbSecond.Value.ToString();
            lblRes.Text = (tbFirst.Value * tbSecond.Value).ToString();

            if (chbQuadr.Checked)
            {
                tbFirst.Value = tbSecond.Value;
                lblRes.Text = (tbFirst.Value * tbSecond.Value).ToString();
                lblFirstStep.Text = lblSecondStep.Text;
            }
        }

        private void chbQuadr_Click(object sender, EventArgs e)
        {
            if (chbQuadr.Checked)
            {
                gbResult.Text = "Квадрат";
                tbFirst.Value = tbSecond.Value;
                lblRes.Text = (tbFirst.Value * tbSecond.Value).ToString();
                lblFirstStep.Text = lblSecondStep.Text;
            }
            else if (!chbQuadr.Checked)
            {
                gbResult.Text = "Произведение";
                lblRes.Text = (tbFirst.Value * tbSecond.Value).ToString();
            }
        }
    }
}