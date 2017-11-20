using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace okul
{

    [TestFixture]
    class Test
    {
        // True sonucu dosyanın tekrar etmediği anlamına gelir.
        [TestCase]
        public void testIsCsvFileRepeat()
        {
            Assert.IsTrue(Okul.isCsvFileRepeat());
        }

        // Csv dosyasının Students adındaki listeye aktarılmasının başarısını kontrol eder.
        [TestCase]
        public void testCreateStudentList()
        {
            Assert.AreEqual(Okul.Students, Okul.createStudentsList());
        }

        // Csv dosyasındaki satırların (öğrencilerin) 20 kişi mi olduğunu test eder.
        [TestCase]
        public void testNumberOfStudents()
        {
            Assert.AreEqual(20, Okul.Students.Count);
        }

        // Periyot değerlerini test eder.
        [TestCase]
        public void testCheckPeriods()
        {
            // Doğru çıktı vermesi gereken dört integer ifade
            Assert.IsTrue(Okul.checkPeriods(1));
            Assert.IsTrue(Okul.checkPeriods(2));
            Assert.IsTrue(Okul.checkPeriods(3));
            Assert.IsTrue(Okul.checkPeriods(4));

            // Denenmesi muhtemel integer ifadeler
            Assert.IsFalse(Okul.checkPeriods(-1));
            Assert.IsFalse(Okul.checkPeriods(0));
            Assert.IsFalse(Okul.checkPeriods(5));

        }

        // Cinsiyetleri test eder.
        [TestCase]
        public void testCheckGenders()
        {
            // Doğru çıktı vermesi gereken dört string ifadesi
            Assert.IsTrue(Okul.checkGenders("e"));
            Assert.IsTrue(Okul.checkGenders("E"));
            Assert.IsTrue(Okul.checkGenders("k"));
            Assert.IsTrue(Okul.checkGenders("K"));

            // Denenmesi muhtemel string değerleri
            Assert.IsFalse(Okul.checkGenders("Erkek"));
            Assert.IsFalse(Okul.checkGenders("ERKEK"));
            Assert.IsFalse(Okul.checkGenders("erkek"));
            Assert.IsFalse(Okul.checkGenders("KIZ"));
            Assert.IsFalse(Okul.checkGenders("Kız"));
            Assert.IsFalse(Okul.checkGenders("kız"));

        }


        // Sıralama ve istenilen düzende ekrana basmanın testini yapar.
        [TestCase]
        public void testSortAndPrintList()
        {
            // Doğru çıktı vermesi gereken dört string ifadesi
            Assert.IsTrue(Okul.studentsList(Okul.listStudents, "sortByPeriod"));
            Assert.IsTrue(Okul.studentsList(Okul.listStudents, "sortByGender"));
            Assert.IsTrue(Okul.studentsList(Okul.listStudents, "sortByAll"));

        }

        [TestCase]
        public void testWriteLogFile()
        {
            Assert.IsTrue(Okul.writeLogFile("message"));
        }

    }
}
