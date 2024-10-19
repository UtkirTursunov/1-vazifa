using System;
using System.Security.Cryptography;

/**
1. Doira yuzi va aylana uzunligini hisoblash
Console dan raduisni qiymatini oling va erkanga doiraning yuzi (S=pi*radius^2) va 
aylana uzunligini (L=2*pi*radius) erkanga chiqaring.
Input: radius=3
Output: S=28.2743338823081, L=18.8495559215388
--------------
Input: radius=4.23
Output: S=56.2122031914168, L=26.5778738493697


System.Console.Write("Radiusni uzunligini kiriting: ");
string radAsString = Console.ReadLine();
double radius = Convert.ToDouble(radAsString);
double square = Math.PI*Math.Pow(radius,2);
double length = 2*Math.PI*radius;
System.Console.WriteLine($"Doiraning yuzi = {square}");
System.Console.WriteLine($"Aylananing usunligi = {length}");



2. Valyuta konvertri
Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
Input: qiymat=2, kurs=12400 so’m
Output: 24800 so’m
----------------
Input: qiymat=7.6, kurs=12400 so’m
Output: 94240 so’m


System.Console.Write("Almashtiriladigan summani kiriting: ");
string sumAsString = Console.ReadLine();
double summa = Convert.ToDouble(sumAsString);
double kursValyuta;
kursValyuta = 12400;
double convertSumma = summa*kursValyuta;
System.Console.WriteLine($"Sizning valyutangiz {convertSumma} so'mga convertasiya qilindi, marhamat pulingizni oling!");

**/


// 3. Yoshni hisoblash
// Foydalanuvchining tug’ilgan yilini (int x) consoledan oling. Uning yoshini kunlarda 
// ifodalang. Kabisa yilini hisobga olmang
// Input: x=2004
// Output: 6935
// -----------------
// Input: x= 1996
// Output: 9855

System.Console.Write("Tugilgan yilingizni kiriting: ");
string yearAsString = Console.ReadLine();
int yearOfBirth = Convert.ToInt32(yearAsString);
int currentYear = DateTime.Now.Year;
int disparity = (currentYear-yearOfBirth)*365;
System.Console.WriteLine($"Sizning yoshingiz kunlarda = {disparity} ga teng!");





