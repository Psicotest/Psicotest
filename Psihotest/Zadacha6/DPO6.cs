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
    public partial class DPO6 : Form
    {
        public DPO6()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.obsledovaniya6 = richTextBox2.Text;
            Zadacha6 zadacha6 = new Zadacha6();
            zadacha6.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zadacha6 zadacha6 = new Zadacha6();
            zadacha6.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedindex = listBox1.SelectedIndex;
            switch (selectedindex)
            {
                case 0:
                    label5.Text = "Данные об успеваимости.";
                    richTextBox1.Text = "Успеваемость: в школу пошел в 6 лет 10 месяцев. Получается все хуже, чем у брата. Мальчик  особых усилий не прилагает, чтобы у него получилось лучше, но, тем не менее, из-за этого расстраивается.";
                    break;
                case 1:
                    label5.Text = "Методика 'Сложная фигура' А.Реем.";
                    richTextBox1.Text = "Восприятие пространственных представлений  Полученные данные: 15 баллов Измерительная шкала: высокий – 14 - 20 баллов средний – 8 - 13 баллов низкий – 1 - 7 баллов Норма: 8 - 13 баллов Вывод: высокий уровень развития восприятия(пространственных представлений) Зрительная память Полученные данные: 11 баллов Измерительная шкала: высокий – 11 - 20 баллов средний – 6 - 10 низкий – 1 - 5 баллов Норма: 6 - 10 баллов Вывод: высокий уровень развития зрительной памяти Венгер А.Л., Цукерман Г.А.Психологическое обследование младших школьников. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – С.31 - 34";
                    break;
                case 2:
                    label5.Text = "Методика 'Кодирование'.";
                    richTextBox1.Text = "Концентрация внимания Полученные данные: 0 ошибок Измерительная шкала: высокий – 0 - 1 ошибка средний – 2 - 3 ошибки низкий – более 3 ошибок Норма: 2 - 3 ошибки Вывод: высокий уровень концентрации внимания Устойчивость внимания Полученные данные: за 2 минуты просмотрено 19 знаков из 120 Измерительная шкала: высокий – 48 - 120 знаков за 2 минуты средний – 20 - 47 знаков за 2 минуты низкий – 0 - 19 знаков за 2 минуты Норма: 20 - 47 знака за 2 минуты Вывод:  низкий уровень устойчивости внимания Венгер А.Л., Цукерман Г.А.Психологическое обследование младших школьников. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – С.37 - 39.";
                    break;
                case 3:
                    label5.Text = "Методика 'Корректурная проба' Бурдона.";
                    richTextBox1.Text = "Концентрация внимания Полученные данные: О ошибок Измерительная шкала: высокий – 0 - 2 ошибка средний – 3 - 4 ошибки низкий – более 5 ошибок Норма: 3 - 4 ошибки Вывод: высокий уровень   концентрации внимания Устойчивость внимания Полученные данные: за 10 минут просмотрено  218 знаков из 1200 знаков Измерительная шкала: высокий –  800 – 1200 знаков средний – 600 – 799 знаков низкий – 1 - 599 Норма: 600 - 799 знаков Вывод:  низкий уровень устойчивости внимания Практикум по возрастной психологии: Учеб.пособие / Под ред.Л.А.Головей, Е.Ф.Рыбалко. – СПб.:Речь, 2006. – С.145 - 148.";
                    break;
                case 4:
                    label5.Text = "Методика 'Запомни и расставь точки'.";
                    richTextBox1.Text = "Полученные данные: 6 баллов  Измерительная шкала: высокий – 10 баллов(объем внимания 6 единиц и выше) средний – 8 - 9 баллов(объем внимания 4 - 5 единиц) низкий – 0 - 7 баллов(объем внимания 3 и менее единиц) Норма: 8 - 9 баллов(объем внимания 4 - 5 единиц) Вывод: низкий объем внимания Немов Р.С.Психология.В 3 - х кн. Кн.1.: Психодиагностика.Введение в научное психологическое исследование с элементами математической статистики. – М.: Изд - во ВЛАДОС, 2007. – С.81 - 83.";
                    break;
                case 5:
                    label5.Text = "Методика 'Оценка переключения внимания'.";
                    richTextBox1.Text = "Полученные данные: 2 балла Измерительная шкала: высокий – 8 - 10 баллов средний – 6 - 7 баллов низкий – 0 - 5 Норма: 6 - 7 баллов Вывод:  низкий уровень переключения внимания Немов Р.С.Психология.В 3 - х кн.Кн.1.: Психодиагностика.Введение в научное психологическое исследование с элементами математической статистики. – М.: Изд - во ВЛАДОС, 2007. – С.178 - 179.";
                    break;
                case 6:
                    label5.Text = "Методика '10 слов'.";
                    richTextBox1.Text = "Полученные данные: 6 баллов Измерительная шкала: высокий – 8 - 10 баллов средний – 4 - 7 баллов низкий – 0 - 3 балла Норма: 4 - 7 баллов Вывод:  средний уровень развития словесной(слуховой памяти) Венгер А.Л., Цукерман Г.А.Психологическое обследование младших школьников. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – С.34 - 37.";
                    break;
                case 7:
                    label5.Text = "Методика 'Долговременная память'.";
                    richTextBox1.Text = "Полученные данные: коэффициент долговременной памяти – 50 % Измерительная шкала: высокий – 75 - 100 % средний – 50 - 75 % низкий – ниже 50 % Норма:  50 - 75 % баллов Вывод: средний уровень развития долговременной    памяти Ануфриев А.Ф., Костромина С.Н.Как преодолеть трудности в обучении детей. Психодиагностические таблицы. Психодиагностические методики. Коррекционные упражнения. – М.:Изд - во «Ось - 89», 2001. – С. 42 - 43";
                    break;
                case 8:
                    label5.Text = "Методика 'Исключение слов'.";
                    richTextBox1.Text = "Полученные данные: 19 баллов Измерительная шкала: высокий – 14 - 19 баллов средний – 7 - 13 баллов низкий – 0 - 6 баллов Норма: 5 - 7 баллов Вывод:   высокий уровень развития вербально-логического мышления(обобщения) Рогов Е.И.Настольная книга практического психолога. В 2 кн.Кн.1.:Система работы психолога с детьми разного возраста: учеб.пособие. – М.: Изд - во ВЛАДОС - ПРЕСС, 2008. – С. 96 - 98.";
                    break;
                case 9:
                    label5.Text = "Прогрессивные матрицы Равена.";
                    richTextBox1.Text = "Полученные данные: 41 балл Измерительная шкала: высокий – 41 - 60 баллов средний – 21 - 40 баллов низкий – 1 - 20 баллов Норма: 21 - 40 баллов Вывод: высокий уровень развития наглядно-образного мышления(классификации)";
                    break;
                case 10:
                    label5.Text = "Тест Д.Векслера.";
                    richTextBox1.Text = "Общий интеллект Полученные данные: 98 баллов Измерительная шкала: высокий – свыше 120   баллов средний – 90 - 119 баллов низкий – ниже 90 баллов Норма: 90 - 119 баллов Вывод: средний уровень общего интеллекта(коэффициент умственного развития) Вербальный интеллект(показатель развития словесного мышления) Полученные данные: 52 балла Измерительная шкала: высокий – выше 60 баллов средний –  45 - 59 баллов низкий – ниже 45 баллов Норма:  45 - 59 Вывод: средний уровень  вербального интеллекта(показатель развития словесного мышления) Невербальный интеллект(показатель развития действенного мышления) Полученные данные: 46 баллов Измерительная шкала: высокий – выше 60 баллов средний –  45 - 59 баллов низкий – ниже 45 баллов Норма:  45 - 59 Вывод: средний уровень  невербального интеллекта(показатель развития действенного мышления) Ведущее предприятие России по комплексному обеспечению психологической практики – ИМАТОН(Госстандарт России).Инструментарий: диагностика, коррекция, развитие.";
                    break;
                case 11:
                    label5.Text = "Рисуночный тест К.Маховера.";
                    richTextBox1.Text = "Полученные данные: 18 баллов Измерительная шкала: высокий – 17 - 26 баллов средний – 12 - 16 баллов низкий – 0 - 11 баллов Норма: 12 - 16 баллов Вывод: высокий уровень познавательного развития Венгер А.Л.Психологические рисуночные тесты. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – 159 с.";
                    break;
                case 12:
                    label5.Text = "Методика диагностики ШТ А.М.Прихожан.";
                    richTextBox1.Text = "Полученные данные: 6 баллов Измерительная шкала: высокий – 7 - 12 баллов средний – 4 - 6 баллов низкий –  0 - 3 баллов Норма: 4 - 6 баллов Вывод: средний уровень общей тревожности Прихожан А.М.Тревожность у детей и подростков: психологическая природа и возрастная динамика. – М.: МПСИ; Воронеж: Изд - во НПО «МОДЕК», 2000.";
                    break;
                case 13:
                    label5.Text = "Шкала явной тревожности.";
                    richTextBox1.Text = "Полученные данные: 4 стена Измерительная шкала: высокий – 7 - 10 стенов средний – 3 - 6 стенов низкий –  1 - 2 стена Норма: 3 - 6 стенов Вывод:  средний уровень тревожности Прихожан А.М.Тревожность у детей и подростков: психологическая природа и возрастная динамика. – М.: МПСИ; Воронеж: Изд - во НПО «МОДЕК», 2000. – С. 233 - 241.";
                    break;
                case 14:
                    label5.Text = "Тест школьной тревожности Филлипса.";
                    richTextBox1.Text = "Общая тревожность Полученные данные: 3 балла Измерительная шкала: высокий –  15 - 22 балла средний –  9 - 14 баллов низкий –  0 - 8 балла Норма: 9 - 14 баллов Вывод: низкий уровень общей школьной тревожности Переживания социального стресса Полученные данные: 3 балла Измерительная шкала: высокий – 8 - 11 баллов средний – 5 - 7 баллов низкий –  0 - 4 балла Норма: 5 - 7 баллов Вывод: низкий уровень переживания социального стресса Фрустрация потребности в достижении успеха Полученные данные: 5 баллов Измерительная шкала: высокий – 9 - 13 баллов средний – 5 - 8 баллов низкий –  0 - 4 балла Норма: 5 - 8 баллову Вывод: средний уровень выраженности фрустрации потребности в достижении успеха Страх самовыражения Полученные данные: 0 баллов Измерительная шкала: высокий – 5 - 6 баллов средний – 3 - 4 баллов низкий –  0 - 2 балла Норма: 3 - 4 баллов Вывод: страх самовыражения не выражен Страх ситуации проверки знаний Полученные данные: 1 балл Измерительная шкала: высокий – 5 - 6 баллов средний – 3 - 4 баллов низкий –  0 - 2 балла Норма: 3 - 4 баллов Вывод: страх ситуации проверки знаний не выражен Страх не соответствовать ожиданиям окружающих Полученные данные: 2 балла Измерительная шкала: высокий – 4 - 5 баллов средний – 2 - 3 баллов низкий –  0 - 1 балла Норма: 2 - 3 баллов Вывод:  средний уровень выраженности страха несоответствовать ожиданиям окружающих Низкая физиологическая сопротивляемость стрессу Полученные данные: 0 баллов Измерительная шкала: высокий – 4 - 5 баллов средний – 2 - 3 баллов низкий –  0 - 1 балла Норма: 2 - 3 баллов Вывод: нормальный уровень физиологической сопротивляемости стрессу Проблемы и страхи в отношениях с учителями Полученные данные: 2 балла Измерительная шкала: высокий – 6 - 8 баллов средний – 4 - 5 баллов низкий –  0 - 3 балла Норма: 4 - 5 баллов Вывод: проблемы и страхи в отношениях с учителями не выражены Практикум по возрастной психологии: Учеб.пособие / Под ред.Л.А.Головей, Е.Ф.Рыбалко. – СПб.:Речь, 2006. – С.323 - 327.";
                    break;
                case 15:
                    label5.Text = "Шкала личностной тревожности А.М.Прихожан.";
                    richTextBox1.Text = "Общая тревожность Полученные данные: 5 стенов Измерительная шкала: высокий – 7 - 10 стенов средний – 3 - 6 стенов низкий –  1 - 2 стена Норма: 3 - 6 стенов Вывод:  средний уровень школьной тревожности Межличностная тревожность Полученные данные: 7 стенов Измерительная шкала: высокий – 7 - 10 стенов средний – 3 - 6 стенов низкий –  1 - 2 стена Норма: 3 - 6 стенов Вывод:  высокий уровень межличностной тревожности Магическая тревожность Полученные данные: 5 стенов Измерительная шкала: высокий – 7 - 10 стенов средний – 3 - 6 стенов низкий –  1 - 2 стена Норма: 3 - 6 стенов Вывод: средний уровень магической тревожности Самооценочная тревожность Полученные данные: 4 стена Измерительная шкала: высокий – 7 - 10 стенов средний – 3 - 6 стенов низкий –  1 - 2 стена Норма: 3 - 6 стенов Вывод:  средний уровень самооценочной тревожности Прихожан А.М.Тревожность у детей и подростков: психологическая природа и возрастная динамика. – М.: МПСИ; Воронеж: Изд - во НПО «МОДЕК», 2000. – С. 242 - 251.";
                    break;
                case 16:
                    label5.Text = "Анкета для определения шк мотив.";
                    richTextBox1.Text = "Полученные данные: 24 балла Измерительная шкала: высокий – 25 - 30 баллов средний – 15 - 24 балла низкий – 0 - 14 баллов Норма: 15 - 24 балла Вывод: средний уровень сформированности школьной мотивации(отношения к себе как к школьнику) Ануфриев А.Ф., Костромина С.Н.Как преодолеть трудности в обучении детей. Психодиагностические таблицы. Психодиагностические методики. Коррекционные упражнения. – М.:Изд - во «Ось - 89», 2001. – 116 - 117";
                    break;
                case 17:
                    label5.Text = "Методика ИННПЗ Е.П. Ильин, Н.А.Курдюкова.";
                    richTextBox1.Text = "Полученные данные: Мотивация на приобретение знаний – 9 баллов Мотивационная направленность на отметку – 10 баллов Измерительная шкала: высокий – 7 - 12 баллов средний – 6 - 8 баллов низкий – 0 - 5 баллов Норма: 6 - 8 баллов Вывод:  высокая мотивация на приобретение знаний и мотивационная направленность на отметку Практикум по возрастной психологии: Учеб.пособие / Под ред.Л.А.Головей, Е.Ф.Рыбалко. – СПб.:Речь, 2006. – С.460 - 461.";
                    break;
                case 18:
                    label5.Text = "Методика ИОКУ Г.Н.Казанцева";
                    richTextBox1.Text = "Вывод: Ребенка привлекает изучение всех школьных предметов. Для него они интересны, легко усваиваются и нравится как преподает учитель. " +
                                        "Ребенок учится с целью, чтобы быть грамотным, умным, получить глубокие знания, нравится получать хорошие оценки. " +
                                        "Практикум по возрастной психологии: Учеб.пособие / Под ред.Л.А.Головей, Е.Ф.Рыбалко. – СПб.:Речь, 2006. – С.461 - 462.";
                    break;
                case 19:
                    label5.Text = "Методика лесенка.";
                    richTextBox1.Text = "Полученные данные: " +
                                        "5 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий – 4 - 5 баллов " +
                                        "средний – 3 балла " +
                                        "низкий – 1 - 2 балла " +
                                        "Норма: 3 балла " +
                                        "Вывод: высокая самооценка(высокий уровень комфортности и субъективного отношения к себе) " +
                                        "Все идет нормально? Комплект диагностических методик для комплексного обследования младших школьников / Авт.Сост.В.И.Екимова, А.Г.Демидова. – М.:АРКТИ, 2007. – С.25.";
                    break;
                case 20:
                    label5.Text = "Методика ШДПСК С.Хартер.";
                    richTextBox1.Text = "Полученные данные: " +
                                        "Познавательная компетентность – 20 баллов " +
                                        "Компетентность в общении – 14 баллов " +
                                        "Компетентность во внеурочной деятельности – 16 баллов " +
                                        "Общее самоприятие – 22 балла " +
                                        "Измерительная шкала: " +
                                        "высокий – 18 - 28 баллов " +
                                        "средний – 10 - 17 баллов " +
                                        "низкий – 0 - 9 баллов " +
                                        "Норма: 10 - 17 баллов " +
                                        "Выводы: высокий уровень самооценки относительно познавательной компетентности, средний уровень самооценки относительно компетентности в общении, средний уровень самооценки относительно компетентности во внеурочной деятельности, высокое общее самоприятие " +
                                        "Чернышова Н.С.Характер младшего школьника: учеб.пособие. – М.: Флинта: Наука, 2006. – С.283 - 287.";
                    break;
                case 21:
                    label5.Text = "Методика Дембо-Рубинштейн А.М.Прихожан.";
                    richTextBox1.Text = "Уровень притязания " +
                                        "Полученные данные: " +
                                        "100 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –75 - 100 баллов " +
                                        "средний – 60 - 74 баллов " +
                                        "низкий – 0 - 59 баллов " +
                                        "Норма: 60 - 74 баллов " +
                                        "Вывод:  максимально высокий уровень притязания " +
                                        "Самооценка личностных качеств " +
                                        "Полученные данные: " +
                                        "90 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –60 - 100 баллов " +
                                        "средний – 45 - 59 баллов " +
                                        "низкий – 0 - 44 баллов " +
                                        "Норма: 45 - 59 баллов " +
                                        "Вывод: высокая самооценка личностных качеств " +
                                        "Практикум по возрастной психологии: Учеб.пособие / Под ред.Л.А.Головей, Е.Ф.Рыбалко. – СПб.:Речь, 2006. – С.469 - 471.";
                    break;
                case 22:
                    label5.Text = "Проективный тест НЖ М.З.Дукаревич.";
                    richTextBox1.Text = "Полученные данные: образ животного нестандартный, слишком вычурный; у животного имеются ресницы, много украшающих деталей, животное с большим ртом и зубами " +
                                        "Выводы: выражено стремление продемонстрировать свою непохожесть на других, высокая вербальная агрессия, демонстративность, истероидность" +
                                        "Венгер А.Л.Психологические рисуночные тесты. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – 159 с.";
                    break;
                case 23:
                    label5.Text = "Рисуночный тест РЧ К.Маховера.";
                    richTextBox1.Text = "Полученные данные: уменьшенный размер человека  " +
                                        "Вывод: сниженное настроение, высокая депрессия " +
                                        "Венгер А.Л.Психологические рисуночные тесты. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – 159 с.";
                    break;
                case 24:
                    label5.Text = "Опросник Р. Кеттела (дет вар).";
                    richTextBox1.Text = "Полученные данные: " +
                                        "•	Экстравертность - интровертность – 3 балла " +
                                        "•	Уверенность в себе – 8 баллов " +
                                        "•	Невозбудимость(уравновешенность) - эмоциональная возбудимость(импульсивность, неуравновешенность) – 8 баллов " +
                                        "•	Независимость - беспечность – 8 баллов " +
                                        "•	Благоразумие - склонность к риску – 5 баллов " +
                                        "•	Добросовестность(ответственность) - недобросовестность – 4 балла " +
                                        "•	Смелость(решительность) - нерешительность – 5 баллов " +
                                        "•	Практичность(умение полагаться на себя) – непрактичность(мечтательность) – 10 баллов " +
                                        "•	Оптимизм - пессимизм – 8 баллов " +
                                        "•	Самоконтроль – 6 баллов " +
                                        "•	Невозмутимость(спокойствие) - высокое нервное напряжение – 4 балла " +
                                        "Измерительная шкала: " +
                                        "высокий –8 - 10 баллов(экстравертность) " +
                                        "средний – 4 - 7 баллов " +
                                        "низкий – 1 - 3 балла(интровертность) " +
                                        "Норма: 4 - 7 балла " +
                                        "Выводы:  интровертная направленность, высокая уверенность в себе, высокая эмоциональная возбудимость, неуравновешенность, импульсивность, высокая независимость, средний уровень благоразумия, средний уровень добросовестности, средний уровень смелости. Также выражена непрактичность(мечтательность), пессимизм.Средний уровень самоконтроля и невозмутимости. " +
                                        "Немов Р.С.Психология.В 3 - х кн.Кн.1.: Психодиагностика.Введение в научное психологическое исследование с элементами математической статистики. – М.: Изд - во ВЛАДОС, 2007. – С.227 - 225.";
                    break;
                case 25:
                    label5.Text = "Рисуночный тест ДДЧ Бака и Хэммера.";
                    richTextBox1.Text = "Полученные данные: дом не имеет дверей, на окнах решетки, наличие забора " +
                                        "Вывод: низкий уровень  социальной адаптированности " +
                                        "Венгер А.Л., Цукерман Г.А.Психологическое обследование младших школьников. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – С.48 - 52.";
                    break;
                case 26:
                    label5.Text = "Методика 'Пиктиграмма' А.Р.Лурия в модификации В.Г.Меньшикова.";
                    richTextBox1.Text = "Полученные данные: на всех рисунках крупное изображение собственного облика. Также на рисунках присутствует небольшое количество людей; схематичное изображение человека; почти на всех рисунках ребенок изображает себя одного; изображение собственного облика в анфас. На рисунке  «Отдых в семье» - изобразил себя и брата " +
                                        "Вывод: доминирующий тип поведения, высокая потребность в общении со сверстниками, которая остается неудовлетворенной; испытывает трудности в общении со сверстниками. Кроме того, доминирующая сфера общения в семье – общение с братом. " +
                                        "Чернышова Н.С.Характер младшего школьника: учеб.пособие. – М.: Флинта: Наука, 2006. – С.265 - 269.";
                    break;
                case 27:
                    label5.Text = "Методика Рене Жиля.";
                    richTextBox1.Text = "Тип поведения в сфере общения " +
                                        "Полученные данные: " +
                                        "4 балла " +
                                        "Измерительная шкала: " +
                                        "высокий –4 баллов " +
                                        "средний – 2 - 3 баллов " +
                                        "низкий – 0 - 1 балла " +
                                        "Норма: 2 - 3 балла " +
                                        "Вывод: высокий уровень доминантности " +
                                        "Социальная адекватность поведения " +
                                        "Полученные данные: " +
                                        "2 балла " +
                                        "Измерительная шкала: " +
                                        "высокий –8 - 10 баллов " +
                                        "средний – 4 - 7 баллов " +
                                        "низкий – 1 - 3 балла " +
                                        "Норма: 4 - 7 балла " +
                                        "Вывод: низкий уровень социальной адекватности поведения " +
                                        "Общительность " +
                                        "Полученные данные: " +
                                        "2 балла " +
                                        "Измерительная шкала: " +
                                        "высокий –4 балла " +
                                        "средний – 2 - 3 балла " +
                                        "низкий – 0 - 1 балл " +
                                        "Норма: 2 - 3 балла " +
                                        "Вывод: средний уровень  общительности " +
                                        "Закрытость, отгороженность " +
                                        "Полученные данные: " +
                                        "7 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –10 - 15 баллов " +
                                        "средний – 6 - 9 баллов " +
                                        "низкий – 0 - 5 балл " +
                                        "Норма: 2 - 3 балла " +
                                        "Вывод: средний уровень закрытости, отгороженности " +
                                        "Любознательность " +
                                        "Полученные данные: " +
                                        "8 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –8 - 10 баллов " +
                                        "средний – 4 - 7 баллов " +
                                        "низкий – 0 - 3 балл " +
                                        "Норма: 4 - 7 балла " +
                                        "Вывод: высокий уровень любознательности " +
                                        "Взаимоотношения со сверстниками " +
                                        "Полученные данные: " +
                                        "7 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –15 - 20 баллов " +
                                        "средний – 8 - 14 баллов " +
                                        "низкий – 0 - 7 балл " +
                                        "Норма:  8 - 14 балла " +
                                        "Вывод:  низкий уровень  общения со сверстниками " +
                                        "Взаимоотношения в семье " +
                                        "Полученные данные: " +
                                        "7 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий – 8 - 10 баллов " +
                                        "средний – 4 - 7 баллов " +
                                        "низкий – 0 - 3 балл " +
                                        "Норма:  4 - 7 баллов " +
                                        "Вывод: ребенок привязан к отцу и матери в одинаковой мере" +
                                        "Отношение к учителю(авторитетному взрослому) " +
                                        "Полученные данные: " +
                                        "8 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –15 - 20 баллов " +
                                        "средний – 8 - 14 баллов " +
                                        "низкий – 0 - 7 балл " +
                                        "Норма:   8 - 14 баллов " +
                                        "Вывод:  положительное отношение к учителю(авторитетному взрослому) " +
                                        "Райгородский Д.Я.Практическая психодиагностика. Методики и тесты.Учебное пособие. – Самара: Изд.дом «БАХРАХ - М», 2001. – С.418 - 436.";
                    break;
                case 28:
                    label5.Text = "Методика 'Рисунок семьи' Халсома и Хэрримсома.";
                    richTextBox1.Text = "Полученные данные: " +
                                        "Фигуры матери и отца на рисунке одинакового размера; себя изобразил рядом с братом; собственную фигуру изобразил на пьедестале " +
                                        "Вывод: мать и отец в одинаковой мере значимы для ребенка; выражено тесное общение с братом; высокое стремление ребенка на лидирующее положение в семье  " +
                                        "Венгер А.Л., Цукерман Г.А.Психологическое обследование младших школьников. – М.: Изд - во ВЛАДОС - ПРЕСС, 2007. – С.56 - 60.";
                    break;
                case 29:
                    label5.Text = "Опросник СДШ.";
                    richTextBox1.Text = "Полученные данные: " +
                                        "96 баллов " +
                                        "Измерительная шкала: " +
                                        "высокий –84 - 120 баллов " +
                                        "средний – 41 - 83 балла " +
                                        "низкий – менее 40 баллов " +
                                        "Норма:  41 - 83 балла " +
                                        "Вывод: высокий уровень благополучия взаимоотношений в семье " +
                                        "Практикум по возрастной психологии: Учеб.пособие / Под ред.Л.А.Головей, Е.Ф.Рыбалко. – СПб.:Речь, 2006. – С.638 - 640.";
                    break;
                case 30:
                    label5.Text = "Опросник ВРР.";
                    richTextBox1.Text = "Полученные данные: " +
                                        "•	Нетребовательность - требовательность – 10 баллов " +
                                        "•	Мягкость - строгость – 18 баллов " +
                                        "•	Автономность - контроль – 41 балл " +
                                        "•	Эмоциональная дистанция-близость – 16 баллов " +
                                        "•	Отвержение - принятие – 23 балла " +
                                        "•	Отсутствие сотрудничества-сотрудничество – 24 балла " +
                                        "•	Тревожность за ребенка – 24 балла " +
                                        "•	Непоследовательность - последовательность – 6 баллов " +
                                        "•	Воспитательная конфронтация в семье – 12 баллов " +
                                        "•	Удовлетворенность отношениями с ребенком – 13 баллов " +
                                        "Измерительная шкала(для автономности - контроля и отвержения - принятия): " +
                                        "высокий–36 - 50 баллов " +
                                        "средний – 16 - 35 баллов " +
                                        "низкий – 0 - 15 балла " +
                                        "Норма: 16 - 35 балла " +
                                        "Измерительная шкала(для всех остальных шкал): " +
                                        "высокий–15 - 25 баллов " +
                                        "средний – 10 - 14 баллов " +
                                        "низкий – 0 - 9 балла " +
                                        "Норма: 10 - 14 балла " +
                                        "Выводы: средний уровень требовательности и принятия в детско - родительских отношениях, а также воспитательной конфронтации в семье. При этом выражена непоследовательность родителей в процессе воспитания ребенка и проявляется строгость в воспитании. Высокий уровень контроля со стороны родителей(гиперопека) и эмоциональной близости в детско - родительских отношениях, а также сотрудничества в детско - родительских отношениях.Высоким уровнем также обладает тревожность в детско - родительских отношениях.Уровень удовлетворенности детско - родительскими отношениями – средний. " +
                                        "Широкова Г.А., Жадько Е.Г.Практикум детского психолога. – Ростов н/ Д: Феникс, 2005. – С.23 - 27.";
                    break;
                case 31:
                    label5.Text = "Беседа с мамой о личн особ Ив.";
                    richTextBox1.Text = "Беседа с мамой о личностных особенностях Ивана: Он очень хочет быть лидером, но у него это не получается, лидером остается Никита, из-за этого ребенок очень сильно переживает. Иван каждый день наблюдает, что у Никиты все получается лучше, чем у него, из-за этого страдает. Часто говорит родителям: «Меня никто не любит», «Меня все обижают».  Если мама улыбается, ему кажется, что она смеется над ним, и он говорит: «Не смейся надо мной». Болезненно переживает удачи брата.";
                    break;
            }
        }

        private void DPO6_Load(object sender, EventArgs e)
        {
            richTextBox3.Text = Program.fenomenologiya6;
            richTextBox2.Text = Program.obsledovaniya6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
