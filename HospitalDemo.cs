using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        private Hospital hospital = new Hospital();

        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            AddTestData();

            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddDoctor(); break;
                    case "2": AddPatient(); break;
                    case "3": AddRoom(); break;
                    case "4": Hospitalize(); break;
                    case "5": AddRecord(); break;
                    case "6": ShowHistory(); break;
                    case "7": ShowStatistics(); break;
                    case "0": return;
                    default: Console.WriteLine("Невірний вибір"); break;
                }

                Console.WriteLine("Натисніть будь-яку клавішу...");
                Console.ReadKey();
            }
        }

        private void AddTestData()
        {
            hospital.RegisterPatient(new Patient(1, "Пацієнт 1", 25));
            hospital.RegisterPatient(new Patient(2, "Пацієнт 2", 30));
            hospital.RegisterPatient(new Patient(3, "Пацієнт 3", 35));

            hospital.CreateRoom(new HospitalRoom(101, 2));
            hospital.CreateRoom(new HospitalRoom(102, 3));

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);
        }

        private void ShowMenu()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===");
            Console.WriteLine("1. Додати лікаря");
            Console.WriteLine("2. Додати пацієнта");
            Console.WriteLine("3. Додати палату");
            Console.WriteLine("4. Госпіталізувати");
            Console.WriteLine("5. Додати запис");
            Console.WriteLine("6. Історія");
            Console.WriteLine("7. Статистика");
            Console.WriteLine("0. Вийти");
            Console.Write("Виберіть: ");
        }

        private void AddDoctor()
        {
            Console.Write("Ім'я лікаря: ");
            string name = Console.ReadLine();
            Console.Write("Спеціалізація: ");
            string spec = Console.ReadLine();

            hospital.AddDoctor(new Doctor(1, name, spec));
        }

        private void AddPatient()
        {
            Console.Write("Ім'я пацієнта: ");
            string name = Console.ReadLine();

            hospital.RegisterPatient(new Patient(1, name, 30));
        }

        private void AddRoom()
        {
            hospital.CreateRoom(new HospitalRoom(101, 2));
        }

        private void Hospitalize()
        {
            hospital.HospitalizePatient(1, 101);
        }

        private void AddRecord()
        {
            if (hospital.Patients.Count > 0 && hospital.Doctors.Count > 0)
            {
                Console.Write("Опис: ");
                string desc = Console.ReadLine();

                hospital.AddMedicalRecord(new MedicalRecord(
                    hospital.Patients[0],
                    hospital.Doctors[0],
                    DateTime.Now,
                    desc
                ));
            }
        }

        private void ShowHistory()
        {
            if (hospital.Patients.Count > 0)
            {
                var history = hospital.GetPatientHistory(1);
                foreach (var record in history)
                {
                    Console.WriteLine($"{record.Date.ToShortDateString()} - {record.Doctor.Name}: {record.Description}");
                }
            }
        }

        private void ShowStatistics()
        {
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
