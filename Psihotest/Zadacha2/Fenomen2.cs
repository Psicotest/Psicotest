﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psihotest
{
    public partial class Fenomen2 : Form
    {
        public Fenomen2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha2 zadacha2 = new Zadacha2();
            zadacha2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fenomen2_2 fenomen2_2 = new Fenomen2_2();
            fenomen2_2.Show();
            this.Close();
            Program.fenomenologiya2 = richTextBox3.Text;
            Program.glavsved2 = richTextBox2.Text;
        }

        private void Fenomen2_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya2;
            richTextBox2.Text = Program.glavsved2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Данные приведенные классным руководителем отсутствуют.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Дима родился в полной семье. Роды были сложные. До 3 - х лет наблюдался у невропатолога с диагнозом ВЧРТ, ПЭП. В возрасте трех лет родители Димы развелись, но ещё два года жили в одной квартире, в разных комнатах.Конфликты между ними происходили на глазах у ребенка. Когда Диме было шесть лет, мама вышла второй раз замуж, и они переехали жить в другой город.Вскоре в семье Димы родился ещё один ребенок. В новой семье сложилась психологически благоприятная обстановка.Дима знает, что его воспитывает отчим.Отношения между ними нормальные. Отношения между Димой и его братом в целом дружеские.Но иногда они могут подраться, после чего сразу мирятся. Зачинщиком этих ссор чаще бывает Дима, возможно из - за ревности к брату. В школе учителя его отмечают как старательного ученика.Со слов классного руководителя сверстники в классе принимают Диму.Но не смотря на это, гулять ходит эпизодически.Бывают периоды, когда он сидит дома, играет в компьютер или смотрит телевизор. На улицу гулять не ходит.Иногда начинает звонить своим приятелям и искать, с кем бы пойти погулять.Одно время  ходил в бассейн, но из-за частых простуд перестал его посещать. Дима всегда был очень разборчив в еде и чрезмерно брезгливым.Любит есть только те продукты, которые ему нравятся.Если в семье приготовили не любимое блюдо - может отказаться от еды и остаться голодным. Бывают периоды, когда ест с аппетитом, но иногда вовсе не хочет есть В последнее время родители стали отмечать у него смены настроения. Стал редко улыбаться.Часто выглядит угрюмым.Проснувшись утром в хорошем настроении со школы , домой может придти в плохом. И наоборот. Такие смены настроения могут происходить по незначительным причинам и несколько раз в день.Но все-таки мама отмечает, что если интересы и потребности сына удовлетворяются, он остается довольным. Если нет -он угрюмым.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "В физическом развитии Дима не отличается от сверстников. К обследованию отнесся с интересом.Считает, что может использовать полученные о нем данные для саморазвития.Дима выглядит уверенным в себе, но немного зажатым. Каждый вечер забирает брата из детского сада.Хочет пойти в бассейн, но считает, что у него тогда не хватит времени делать уроки.Свои перепады настроения объясняет частично несправедливым отношением к нему родителей, частично особенностями характера.Со сверстниками из школы после уроков общаться не может, т.к.ему надо долго добираться домой.Во дворе все сверстники сидят за компьютерами. 'Зову гулять приятелей, но не всегда удается' - говорит Дима.";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Мама: 'Некоторые особенности характера передались по наследству, некоторые появились из-за семейных трудностей. Отсутствие друзей объяснить не может'. Самодиагноз: 'Настроения зависит от того, как ко мне относятся люди.Еда - дело вкуса.Друзей мало, потому что в школу ехать надо, а во дворе никто нехочет гулять'.";
        }
    }
}
