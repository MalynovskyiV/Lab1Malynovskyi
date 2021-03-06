﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Lab1Malynovskyi
{
    internal class BirthMod
    {
        private DateTime _birth;
        internal bool Valid { get; private set; }
        internal string Age { get; private set; }
        internal string WestZodiac { get; private set; }
        internal string ChineseZodiac { get; private set; }

        internal BirthMod()
        {
            _birth = DateTime.Today;
        }

        internal DateTime Birth
        {
            get 
            {
                return _birth;
            }
            set
            {
                _birth = value;
                var today = DateTime.Today;
                var dyears = (today.Year - value.Year) - (today.DayOfYear >= _birth.DayOfYear? 0 : 1);
                var deltaDateTime = today - value;
                
                Valid = deltaDateTime.Days >= 0 && dyears <= 135;
                if (Valid)
                {
                    Age = dyears > 0? dyears+" year(s)" : deltaDateTime.Days+ " day(s)";
                    MessageBox.Show("Age " + Age);
                    ChineseZodiac = ChineseZodiaсs[(_birth.Year + 8) % 12];

                    var month = _birth.Month;
                    var day = _birth.Day;
                    int westZodiacNum;
                    switch (month)
                    {
                        case 1:  //January
                            westZodiacNum = day <= 20 ? 9 : 10;
                            MessageBox.Show("West Zodiac: " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 2: //February
                            westZodiacNum = day <= 19 ? 10 : 11;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 3: //March
                            westZodiacNum = day <= 20 ? 11 : 0;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 4: //April
                            westZodiacNum = day <= 20 ? 0 : 1;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 5: //May
                            westZodiacNum = day <= 20 ? 1 : 2;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 6: //June
                            westZodiacNum = day <= 20 ? 2 : 3;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 7: //Jule
                            westZodiacNum = day <= 21 ? 3 : 4;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 8: //August
                            westZodiacNum = day <= 22 ? 4 : 5;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 9: //September
                            westZodiacNum = day <= 21 ? 5 : 6;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 10: //October
                            westZodiacNum = day <= 21 ? 6 : 7;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 11: //November
                            westZodiacNum = day <= 21 ? 7 : 8;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        case 12: //December
                            westZodiacNum = day <= 21 ? 8 : 9;
                            MessageBox.Show("WestZodiac " + WesternZodiaсs[westZodiacNum]);
                            MessageBox.Show("Chinese Zodiac: " + ChineseZodiaсs[westZodiacNum]);
                            break;
                        default:
                            westZodiacNum = 0;
                            break;
                    }
                    WestZodiac = WesternZodiaсs[westZodiacNum];
                }
                else
                {
                    Age = WestZodiac = ChineseZodiac = "";
                }
            }
        }

        public bool IsBirth
        {
            get
            {
                var today = DateTime.Today;
                return today.Month == _birth.Month && today.Day == _birth.Day;
            }
        }

        private static readonly string[] WesternZodiaсs = {"Ram","Bull","Twins","Crab","Lion","Virgin","Scales","Scorpion","Archer","Mountain Sea-Goat","Water Bearer","Fish"};

        private static readonly string[] ChineseZodiaсs = {"Rat","Ox","Tiger","Rabbit","Dragon","Snake","Horse","Goat","Monkey","Rooster","Dog","Pig"};
    }
}