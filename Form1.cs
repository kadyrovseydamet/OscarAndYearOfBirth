﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oscarandbirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string years = textBox1.Text;
            int years1 = Convert.ToInt32(years);
            if (years1 > 2021)
            {
                label5.Text = "Еще не известно, скоро узнаем...";
            }
            if (years1 < 1929)
            {
                label5.Text = "Тогда не существовало премии Оскар!";
            }
            if (years1 == 1929 & years1 < 1930)
            {
                label5.Text = "Примию Оскара получил фильм 'Крылья'";
            }
            if (years1 == 1930 & years1 < 1931)
            {
                label5.Text = "Примию Оскара получили фильмы: '1) Бродвейская мелодия 1929-го года и   2) На западном фронте без перемен'";
            }
            if (years1 == 1931 & years1 < 1932)
            {
                label5.Text = "Примию Оскара получил фильм 'Симарон'";
            }
            if (years1 == 1932 & years1 < 1934)
            {
                label5.Text = "Примию Оскара получил фильм 'Гранд Отель'";
            }
            if (years1 == 1934 & years1 < 1935)
            {
                label5.Text = "Примию Оскара получил фильм 'Кавалькада'";
            }
            if (years1 == 1935 & years1 < 1936)
            {
                label5.Text = "Примию Оскара получил фильм 'Это случилось однажды ночью'";
            }
            if (years1 == 1936 & years1 < 1937)
            {
                label5.Text = "Примию Оскара получил фильм 'Мятеж на Баунти'";
            }
            if (years1 == 1937 & years1 < 1938)
            {
                label5.Text = "Примию Оскара получил фильм 'Великий Зигфилд'";
            }
            if (years1 == 1938 & years1 < 1939)
            {
                label5.Text = "Примию Оскара получил фильм 'Жизнь Эмиля Золя'";
            }
            if (years1 == 1939 & years1 < 1940)
            {
                label5.Text = "Примию Оскара получил фильм 'С собой не унесешь'";
            }
            if (years1 == 1940 & years1 < 1941)
            {
                label5.Text = "Примию Оскара получил фильм 'Унесенные ветром'";
            }
            if (years1 == 1941 & years1 < 1942)
            {
                label5.Text = "Примию Оскара получил фильм 'Ребекка'";
            }
            if (years1 == 1942 & years1 < 1943)
            {
                label5.Text = "Примию Оскара получил фильм 'Как зелена была моя долина'";
            }
            if (years1 == 1943 & years1 < 1944)
            {
                label5.Text = "Примию Оскара получил фильм 'Миссис Минивер'";
            }
            if (years1 == 1944 & years1 < 1945)
            {
                label5.Text = "Примию Оскара получил фильм 'Касабланка'";
            }
            if (years1 == 1945 & years1 < 1946)
            {
                label5.Text = "Примию Оскара получил фильм 'Идти своим путем'";
            }
            if (years1 == 1946 & years1 < 1947)
            {
                label5.Text = "Примию Оскара получил фильм 'Потерянный уик-энд'";
            }
            if (years1 == 1947 & years1 < 1948)
            {
                label5.Text = "Примию Оскара получил фильм 'Лучшие годы нашей жизни'";
            }
            if (years1 == 1948 & years1 < 1949)
            {
                label5.Text = "Примию Оскара получил фильм 'Джентльменское соглашение'";
            }
            if (years1 == 1949 & years1 < 1950)
            {
                label5.Text = "Примию Оскара получил фильм 'Гамлет'";
            }
            if (years1 == 1950 & years1 < 1951)
            {
                label5.Text = "Примию Оскара получил фильм 'Вся королевская рать'";
            }
            if (years1 == 1951 & years1 < 1952)
            {
                label5.Text = "Примию Оскара получил фильм 'Все о Еве'";
            }
            if (years1 == 1952 & years1 < 1953)
            {
                label5.Text = "Примию Оскара получил фильм 'Американец в Париже'";
            }
            if (years1 == 1953 & years1 < 1954)
            {
                label5.Text = "Примию Оскара получил фильм 'Величайшее шоу мира'";
            }
            if (years1 == 1954 & years1 < 1955)
            {
                label5.Text = "Примию Оскара получил фильм 'Отныне и во веки веков'";
            }
            if (years1 == 1955 & years1 < 1956)
            {
                label5.Text = "Примию Оскара получил фильм 'В порту'";
            }
            if (years1 == 1956 & years1 < 1957)
            {
                label5.Text = "Примию Оскара получил фильм 'Марти'";
            }
            if (years1 == 1957 & years1 < 1958)
            {
                label5.Text = "Примию Оскара получил фильм 'Вокруг Света за 80 дней'";
            }
            if (years1 == 1958 & years1 < 1959)
            {
                label5.Text = "Примию Оскара получил фильм 'Мост через реку Квай'";
            }
            if (years1 == 1959 & years1 < 1960)
            {
                label5.Text = "Примию Оскара получил фильм 'Жижи'";
            }
            if (years1 == 1960 & years1 < 1961)
            {
                label5.Text = "Примию Оскара получил фильм 'Бен-Гур'";
            }
            if (years1 == 1961 & years1 < 1962)
            {
                label5.Text = "Примию Оскара получил фильм 'Квартира'";
            }
            if (years1 == 1962 & years1 < 1963)
            {
                label5.Text = "Примию Оскара получил фильм 'Вестсайдская история'";
            }
            if (years1 == 1963 & years1 < 1964)
            {
                label5.Text = "Примию Оскара получил фильм 'Лоуренс Аравийский'";
            }
            if (years1 == 1964 & years1 < 1965)
            {
                label5.Text = "Примию Оскара получил фильм 'Том Джонс'";
            }
            if (years1 == 1965 & years1 < 1966)
            {
                label5.Text = "Примию Оскара получил фильм 'Моя прекрасная леди'";
            }
            if (years1 == 1966 & years1 < 1967)
            {
                label5.Text = "Примию Оскара получил фильм 'Звуки музыки'";
            }
            if (years1 == 1967 & years1 < 1968)
            {
                label5.Text = "Примию Оскара получил фильм 'Человек на все времена'";
            }
            if (years1 == 1968 & years1 < 1969)
            {
                label5.Text = "Примию Оскара получил фильм 'Полуночная жара'";
            }
            if (years1 == 1969 & years1 < 1970)
            {
                label5.Text = "Примию Оскара получил фильм 'Оливер!'";
            }
            if (years1 == 1970 & years1 < 1971)
            {
                label5.Text = "Примию Оскара получил фильм 'Полуночный ковбой'";
            }
            if (years1 == 1971 & years1 < 1972)
            {
                label5.Text = "Примию Оскара получил фильм 'Паттон'";
            }
            if (years1 == 1972 & years1 < 1973)
            {
                label5.Text = "Примию Оскара получил фильм 'Французкий связной'";
            }
            if (years1 == 1973 & years1 < 1974)
            {
                label5.Text = "Примию Оскара получил фильм 'Крестный отец'";
            }
            if (years1 == 1974 & years1 < 1975)
            {
                label5.Text = "Примию Оскара получил фильм 'Афера'";
            }
            if (years1 == 1975 & years1 < 1976)
            {
                label5.Text = "Примию Оскара получил фильм 'Крестный отец 2'";
            }
            if (years1 == 1976 & years1 < 1977)
            {
                label5.Text = "Примию Оскара получил фильм 'Пролетая над гнездом кукушки'";
            }
            if (years1 == 1977 & years1 < 1978)
            {
                label5.Text = "Примию Оскара получил фильм 'Рокки'";
            }
            if (years1 == 1978 & years1 < 1979)
            {
                label5.Text = "Примию Оскара получил фильм 'Энни Холл'";
            }
            if (years1 == 1979 & years1 < 1980)
            {
                label5.Text = "Примию Оскара получил фильм 'Охотник на оленей'";
            }
            if (years1 == 1980 & years1 < 1981)
            {
                label5.Text = "Примию Оскара получил фильм 'Крамер против Крамера'";
            }
            if (years1 == 1981 & years1 < 1982)
            {
                label5.Text = "Примию Оскара получил фильм 'Обыкновенные люди'";
            }
            if (years1 == 1982 & years1 < 1983)
            {
                label5.Text = "Примию Оскара получил фильм 'Огненные колесницы'";
            }
            if (years1 == 1983 & years1 < 1984)
            {
                label5.Text = "Примию Оскара получил фильм 'Ганди'";
            }
            if (years1 == 1984 & years1 < 1985)
            {
                label5.Text = "Примию Оскара получил фильм 'Язык нежности'";
            }
            if (years1 == 1985 & years1 < 1986)
            {
                label5.Text = "Примию Оскара получил фильм 'Амадей'";
            }
            if (years1 == 1986 & years1 < 1987)
            {
                label5.Text = "Примию Оскара получил фильм 'Из Африки'";
            }
            if (years1 == 1987 & years1 < 1988)
            {
                label5.Text = "Примию Оскара получил фильм 'Взвод'";
            }
            if (years1 == 1988 & years1 < 1989)
            {
                label5.Text = "Примию Оскара получил фильм 'Последний император'";
            }
            if (years1 == 1989 & years1 < 1990)
            {
                label5.Text = "Примию Оскара получил фильм 'Человек дождя'";
            }
            if (years1 == 1990 & years1 < 1991)
            {
                label5.Text = "Примию Оскара получил фильм 'Шофер мисс Дейзи'";
            }
            if (years1 == 1991 & years1 < 1992)
            {
                label5.Text = "Примию Оскара получил фильм 'Танцующий с волками'";
            }
            if (years1 == 1992 & years1 < 1993)
            {
                label5.Text = "Примию Оскара получил фильм 'Молчание ягнят'";
            }
            if (years1 == 1993 & years1 < 1994)
            {
                label5.Text = "Примию Оскара получил фильм 'Непрощенный'";
            }
            if (years1 == 1994 & years1 < 1995)
            {
                label5.Text = "Примию Оскара получил фильм 'Список Шиндлера'";
            }
            if (years1 == 1995 & years1 < 1996)
            {
                label5.Text = "Примию Оскара получил фильм 'Форест Гамп'";
            }
            if (years1 == 1996 & years1 < 1997)
            {
                label5.Text = "Примию Оскара получил фильм 'Храброе сердце'";
            }
            if (years1 == 1997 & years1 < 1998)
            {
                label5.Text = "Примию Оскара получил фильм 'Английский пациент'";
            }
            if (years1 == 1998 & years1 < 1999)
            {
                label5.Text = "Примию Оскара получил фильм 'Титаник'";
            }
            if (years1 == 1999 & years1 < 2000)
            {
                label5.Text = "Примию Оскара получил фильм 'Влюбленный Шекспир'";
            }
            if (years1 == 2000 & years1 < 2001)
            {
                label5.Text = "Примию Оскара получил фильм 'Красота по-американски'";
            }
            if (years1 == 2001 & years1 < 2002)
            {
                label5.Text = "Примию Оскара получил фильм 'Гладиатор'";
            }
            if (years1 == 2002 & years1 < 2003)
            {
                label5.Text = "Примию Оскара получил фильм 'Игры разума'";
            }
            if (years1 == 2003 & years1 < 2004)
            {
                label5.Text = "Примию Оскара получил фильм 'Чикаго'";
            }
            if (years1 == 2004 & years1 < 2005)
            {
                label5.Text = "Примию Оскара получил фильм 'Властелин колец: Возращение короля'";
            }
            if (years1 == 2005 & years1 < 2006)
            {
                label5.Text = "Примию Оскара получил фильм 'Малышка на миллион'";
            }
            if (years1 == 2006 & years1 < 2007)
            {
                label5.Text = "Примию Оскара получил фильм 'Столкновение'";
            }
            if (years1 == 2007 & years1 < 2008)
            {
                label5.Text = "Примию Оскара получил фильм 'Отступники'";
            }
            if (years1 == 2008 & years1 < 2009)
            {
                label5.Text = "Примию Оскара получил фильм 'Старикам тут не место'";
            }
            if (years1 == 2009 & years1 < 2010)
            {
                label5.Text = "Примию Оскара получил фильм 'Миллионер из трущоб'";
            }
            if (years1 == 2010 & years1 < 2011)
            {
                label5.Text = "Примию Оскара получил фильм 'Повелитель бури'";
            }
            if (years1 == 2011 & years1 < 2012)
            {
                label5.Text = "Примию Оскара получил фильм 'Король говорит!'";
            }
            if (years1 == 2012 & years1 < 2013)
            {
                label5.Text = "Примию Оскара получил фильм 'Артист'";
            }
            if (years1 == 2013 & years1 < 2014)
            {
                label5.Text = "Примию Оскара получил фильм 'Опрерация «Арго»'";
            }
            if (years1 == 2014 & years1 < 2015)
            {
                label5.Text = "Примию Оскара получил фильм '12 лет рабства'";
            }
            if (years1 == 2015 & years1 < 2016)
            {
                label5.Text = "Примию Оскара получил фильм 'Бёрдмэн'";
            }
            if (years1 == 2016 & years1 < 2017)
            {
                label5.Text = "Примию Оскара получил фильм 'В центре внимания'";
            }
            if (years1 == 2017 & years1 < 2018)
            {
                label5.Text = "Примию Оскара получил фильм 'Лунный свет'";
            }
            if (years1 == 2018 & years1 < 2019)
            {
                label5.Text = "Примию Оскара получил фильм 'Форма воды'";
            }
            if (years1 == 2019 & years1 < 2020)
            {
                label5.Text = "Примию Оскара получил фильм 'Зеленая книга'";
            }
            if (years1 == 2020 & years1 < 2021)
            {
                label5.Text = "Примию Оскара получил фильм 'Паразиты'";
            }
            if (years1 == 2021)
            {
                label5.Text = "Примию Оскара получил фильм 'Земля кочевников'";
            }
        }
    }
}
