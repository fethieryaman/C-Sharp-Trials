using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace okul
{
    class Okul
    {       
        public static string csvPath = "C:/Users/ERYAMAN/Desktop/okul/okul/bin/Debug/okul.csv";
        public static string logFilePath = "C:/Users/ERYAMAN/Desktop/okul/okul/bin/Debug/logFile.txt";
        public static List<Student> listStudents = new List<Student>();
        public static List<Student> Students = new List<Student>();

        public static void Main(string[] args)
        {
            // CSV dosyasının olup olmadığını kontrol eder, yoksa istenilen özelliklerde yeni bir csv dosyası oluşturuyor.
            bool isCsvFileCreate = File.Exists(csvPath) ? true : createCsvFile();

            // Öğrenci isimleri tekrar etmeyen bir csv dosyası varsa log düşer, yoksa hata verip çıkıyor.
            if ( isCsvFileCreate &  isCsvFileRepeat())
                writeLogFile("Create CSV File is Succesfully..");
            else
                Environment.Exit(0);

            // Okuma işleminin sürekli method içlerinde tekrar edilmemesi için bütün öğrenciler listin içerisine alındı.
            createStudentsList();

            // Parametrelerin değerlendirildiği yer.
            switch (args.Length)
            {
                case 0:
                    studentsList(Students, "sortByAll"); break;
                    // sortByAll -- period -- period, ad, soyad, cinsiyet
                    // sortByGender -- period -- period, ad, soyad
                    // sortByPeriod -- name -- ad, soyad, cinsiyet
                case 1:
                    int response;
                    bool IsTrue = (int.TryParse(args[0], out response)) ? checkPeriods(response) : checkGenders(args[0]);
                    break;
                default:
                    Console.WriteLine("Hata: sadece bir argüman girebilirsiniz"); break;
            }

            Console.ReadKey();
        }

        // CSV dosyasındaki bütün öğrencilerin bir Student listesine eklendiği method
        public static List<Student> createStudentsList()
        {
            StreamReader csvFile = new StreamReader(csvPath);           
            while (!csvFile.EndOfStream)
            {
                String[] studentParameters = csvFile.ReadLine().Split(';');
                Student student = new Student(studentParameters[0], studentParameters[1], studentParameters[2], studentParameters[3]);
                Students.Add(student);
            }
            return Students;
        }

        // Csv dosyasının tekrar edip etmediğini kontrol eden method
        public static bool isCsvFileRepeat()
        {
            HashSet<string> studentNames = new HashSet<string>();
            foreach (Student student in Students)
                studentNames.Add(student.getName);
 
            return studentNames.Count == Students.Count;
        }

        // Öğrencinin döneminin tutarlı olup olmadığını kontrol eden method
        public static bool checkPeriods(int period)
        {
            if (period > 0 && period < 5)
            {
                foreach (Student student in Students)
                {
                    if (Convert.ToInt16(student.getPeriod) == period)
                        listStudents.Add(student);
                }

                studentsList (listStudents, "sortByPeriod");
                return true;
            }
            else
            {
                Console.WriteLine("Hata: devre numarası 1-4 aralıgında olmalı");
                return false;
            }           
        }

        // Öğrencinin cinsiyetinin tutarlı olup olmadığını kontrol eden method
        public static bool checkGenders(string gender)
        {
            if (gender == "k" || gender == "e" || gender == "E" || gender == "K")
            {
                foreach (Student student in Students)
                {
                    if (student.getGender.ToUpper() == gender.ToUpper())
                        listStudents.Add(student);
                }

                studentsList(listStudents, "sortByGender");
                return true;
            }
            else
            {
                Console.WriteLine("Hata: Taninmayan arguman : " + gender);
                return false;
            }
        }

        // İsteğe bağlı olarak sıralayan ve ekrana basan method
        public static bool studentsList(List<Student>listStudents, string sortArgument)
        {
            if (sortArgument == "sortByPeriod")
            {
                List<Student> sortlistStudents = listStudents.OrderBy(x => x.getName).ToList();
                foreach (Student student in sortlistStudents)
                    Console.WriteLine(student.getName + " " + student.getSurname + " " + student.getGender);
                
            }
            else if (sortArgument == "sortByGender")
            {
                List<Student> sortlistStudents = listStudents.OrderBy(x => x.getPeriod).ToList();
                foreach (Student student in sortlistStudents)               
                    Console.WriteLine(student.getPeriod + " " + student.getName + " " + student.getSurname);
                
            }
            else if (sortArgument == "sortByAll")
            {
                List<Student> sortlistStudents = listStudents.OrderBy(x => x.getPeriod).ToList();
                foreach (Student student in sortlistStudents)             
                    Console.WriteLine(student.getPeriod + " " + student.getName + " " + student.getSurname + " " + student.getGender);                
            }
            else
            {
                writeLogFile("Error is sortAndPrintTheList method...");
                Console.WriteLine("A software bug was encountered");
                Environment.Exit(0);
            }
                

            return true;
        }

        // Log dosyama kayıt düşen method
        public static bool writeLogFile(string message)
        {
            StringBuilder logFileContent = new StringBuilder();
            logFileContent.AppendLine(message + "\n History Information : " + DateTime.Now.ToString());
            File.AppendAllText(logFilePath, logFileContent.ToString());

            return true;
        }

        // İlgili yolda csv dosyasının olmaması durumunda, bulunan dizinde csv dosyasını oluşturan method
        public static bool createCsvFile()
        {

            StringBuilder csvContent = new StringBuilder();

            csvContent.AppendLine("Fethi;Eryaman;E;4");
            csvContent.AppendLine("Gizem;Ayselgil;K;4");
            csvContent.AppendLine("Safa;Genel;E;1");
            csvContent.AppendLine("Ali;Sen;E;3");
            csvContent.AppendLine("Ibrahim;Eroglu;E;2");
            csvContent.AppendLine("Zeynep;Yildiz;K;4");
            csvContent.AppendLine("Esra;Gulbahar;K;4");
            csvContent.AppendLine("Ismail;Yilmaz;E;1");
            csvContent.AppendLine("Cuneyt;Kas;E;2");
            csvContent.AppendLine("Kamil;Bahram;E;4");
            csvContent.AppendLine("Sila;Bayram;K;3");
            csvContent.AppendLine("ilknur;Aydogdu;K;3");
            csvContent.AppendLine("Baris;Yaman;E;2");
            csvContent.AppendLine("Su;Damla;K;3");
            csvContent.AppendLine("Umut;Bulut;E;3");
            csvContent.AppendLine("Mehmet;Yasar;E;2");
            csvContent.AppendLine("Serpil;Tuncel;K;3");
            csvContent.AppendLine("Mustafa;Kaya;E;2");
            csvContent.AppendLine("Miray;Gunes;K;3");
            csvContent.AppendLine("Gulnur;Aslan;K;2");

            File.AppendAllText(csvPath, csvContent.ToString());

            return true;
        }
    }
}
