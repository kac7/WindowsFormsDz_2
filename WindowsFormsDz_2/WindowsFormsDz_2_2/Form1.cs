﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz_2_2
{
    //Задание 7
    //Написать программу, вычисляющую сколько осталось времени до указанной даты(дата вводится с клавиатуры в Edit). 
    //Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах, секундах 
    //(для первых двух вариантов ответ дробный). 
    //Для переключения между вариантами желательно использовать переключатели (RadioButton).
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRes.Click += ResClick;
            btnOk.Click += OkClick;
            textInput.Enter += TextInputEnter;
        }

        private void TextInputEnter(object sender, EventArgs e)
        {
            label.Visible = false;
            textInput.BackColor = Color.Wheat;
        }

        private void OkClick(object sender, EventArgs e)
        {
            try
            {
                DateTime dayT = new DateTime();
                dayT = DateTime.Parse(textInput.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan tempDay = dayT - dayNow;
                if (dayT > dayNow)
                {
                    if (YearRadio.Checked)
                    {
                        textOutput.Text = (tempDay.TotalDays / 365).ToString();
                    }
                    if (MonthRadio.Checked)
                    {
                        textOutput.Text = (tempDay.TotalDays / 30).ToString();
                    }
                    if (DayRadio.Checked)
                    {
                        textOutput.Text = ((int)tempDay.TotalDays).ToString();
                    }
                    if (minutesRadio.Checked)
                    {
                        textOutput.Text = ((int)tempDay.TotalMinutes).ToString();
                    }
                    if (secondsRadio.Checked)
                    {
                        textOutput.Text = ((int)tempDay.TotalSeconds).ToString();
                    }
                }
                else
                {
                    textOutput.Text = "Эта дата уже прошла!";
                }
            }
            catch (Exception)
            {
                label.Visible = true;
                textInput.BackColor = Color.LightCoral;
            }
           
        }

        private void ResClick(object sender, EventArgs e)
        {
            textInput.Clear();
            textOutput.Clear();
            label.Visible = false;
            textInput.BackColor = Color.White;
            YearRadio.Checked = true;
        }
    }
}
