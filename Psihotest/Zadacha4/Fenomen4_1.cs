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
    public partial class Fenomen4_1 : Form
    {
        public Fenomen4_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.fenomenologiya4 = richTextBox3.Text;
            Program.glavsved4 = richTextBox2.Text;
            fenomen4_2 fenomen4_2 = new fenomen4_2();
            fenomen4_2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadacha4 zadacha4 = new Zadacha4();
            zadacha4.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fenomen4_1_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya4;
            richTextBox2.Text = Program.glavsved4;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Данные приведенные классным руководителем отсутствуют.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Юра воспитывается мамой.. В школу пошел с восьми лет. Мама с работы всегда возвращалась домой поздно, и Юра привык находиться дома один. Выполнение им уроков она не контролировала по двум причинам.Во - первых, Юра часто спал, когда она приходила домой и, во - вторых, она считает, что учителя для того и существуют, чтобы обучать детей в школе. Во втором классе Юра практически не умел читать и считать. В третьем классе он жил и учился у бабушки в другом городе. Юра считал, что уже никогда не догонит сверстников, т.к.его уровень знаний соответствовал первому классу. Примерно с восьми лет мама и бабушка стали замечать, что Юра сначала мог взять без разрешения чью - то игрушку и положить её себе в карман, а в дальнейшем и деньги.Мама вспоминает два случая, когда сын выкрал у бабушки деньги и стоя на балконе,  кидал их детям, гуляющим во дворе.В другой раз мама заметила, что у неё пропали 2000 рублей, а Юра только что вышел из дому.Она побежала за ним и догнала его в магазине.В руках у него были пропавшие деньги. Мама схватила сына за руку и потащила к выходу.Но когда они оказались на улице, денег в руках у Юры уже не было.Он выкинул их по дороге из магазина. Семья живет в очень маленькой однокомнатной квартире.Вместе с ними проживает две кошки и большая собака.Мама часто в присутствии сына говорила, что животных она очень любит и они её дети.  К сыну она относится эмоционально равнодушно, но всегда стремится удовлетворить его желания. С детства Юра много времени проводил на улице.  Уходил гулять и возвращался домой, когда считал нужным.Часто было так, что мама проснется, а его нет, он уже гуляет.Причем, точного места его прогулок она никогда не знала. Дружит и гуляет Юра с ребятами из двора. В последнее время Юра часто стал посещать ночью компьютерные клубы. Мама относится к таким увлечениям сына позитивно.Её это устраивает,  поскольку она может дома встречаться с мужчиной. Юра часто меняет школы. Поменять учебное заведение маме предлагают завучи. Сейчас он учится в четвертой по счету школе. Успеваемость по русскому языку 2 - 3, по математике -4, по другим предметам - 3. Мама считает, что из - за лени сыну сложно учиться. В настоящий момент мама отмечает у Юры упрямство, замкнутость, капризность и резкую смену настроения.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Юра среднего телосложения, подвижный, с быстрыми, но не резкими движениями. Он много рассказывает о школе, о своем классе, о частых замечаниях по поведению.Считает, что учится ниже среднего. Он продолжает посещать ночью компьютерный клуб, но говорит, что уже устал от него, потому что там накурено. На вопросы психолога о воровстве Юра не отвечает, делая вид, что не услышал их. Правда в момент тестирования он отметил, что изредка воровство у него бывает.На вопросы о семейных взаимоотношениях, у него появлялась возбудимость, резкие движения руками, сбивчивая и быстрая речь,  сопровождающаяся смешками. Свою лень подросток рассматривает как нормальное состояние, а требование мамы, например,  навести порядок в своих вещах - придирками к нему. На исследование Юра согласился, в назначенное время приходил вовремя, но результаты тестирования его не интересовали.";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Мама: 'Считает, что её сын сплошная проблема. Что все трудности, с которыми могут встретиться родители в процессе воспитания можно обнаружить в её семье'. Самодиагноз: 'Считает, что с ним все в порядке,  он самостоятельный и никаких проблем у него нет'.";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
