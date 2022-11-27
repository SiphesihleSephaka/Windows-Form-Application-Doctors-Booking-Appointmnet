using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp3
{
    internal class Registration_dLogin
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string idnumber { get; set; }
        public string gender { get; set; }
        public string cellnumber { get; set; }
        public string email { get; set; }
        public string homeaddress { get; set; }
        public string city { get; set; }
        public string password1 { get; set; }
        public string password2 { get; set; }


        //Methods
        public string SaveTxtFiles()
        {
            string feedback;
            string filePath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\PatientRegistrationTextFile\{idnumber}.txt");
            //Assign path to where you save your patient users
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name \t{name}");
                    writer.WriteLine($"Surname \t{surname}");
                    writer.WriteLine($"IDNumber \t{idnumber}");
                    writer.WriteLine($"Gender \t{gender}");
                    writer.WriteLine($"PhoneNumber \t{cellnumber}");
                    writer.WriteLine($"Email \t{email}");
                    writer.WriteLine($"HomeAddress \t{homeaddress}");
                    writer.WriteLine($"City \t{city}");
                    writer.WriteLine($"Password \t{password1}");
                    writer.WriteLine($"ConfirmPassword \t{password2}");
                    feedback = "Congratulations!\nRegistered successfully!";
                }
                return feedback;
            }
            catch (Exception)
            {
                return "Invalid directory!";
            }
        }





        public string LoginTxtFiles()
        {
            string feedback = "";
            string filePath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\PatientRegistrationTextFile\{idnumber}.txt");
            //Assing path to where patient users files are stored
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArray = new string[2];
                        lineArray = line.Split('\t');
                        if (lineArray[1] == password1)
                        {

                            feedback = "Access granted!";
                            string dest = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Patients\{idnumber}.txt");
                            string Mypath = filePath;
                            reader.Close();
                            File.Copy(Mypath, dest, true);


                            return feedback;
                        }
                        else
                        {
                            feedback = "Incorrect password!";
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                feedback = "Incorrect IDnumber!!!";
            }
            return feedback;

        }




        public string LoggedPatient()
        {
            List<string> details = new List<string>();
            string[] path = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Patients");
            //Assign path to a folder where a logged patient file is situated

            if (path.Length != 0)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    StreamReader reader = new StreamReader(path[i]);
                    string[] lineArray = new string[2];
                    string line = reader.ReadLine();

                    while (line != null)
                    {

                        lineArray = line.Split('\t');
                        details.Add(lineArray[1]);
                        line = reader.ReadLine();

                    }
                    reader.Close();

                }
                string Info = $"{details[0]},{details[1]},{details[2]},{details[3]},{details[4]},{details[5]},{details[6]},{details[7]}";


                return Info;

            }
            else
            {

                return "You have not logged in ";
            }



        }





        public string Password()
        {
            List<string> details = new List<string>();
            string[] path = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Patients");
            //Assign path to a folder where a logged patient file is situated

            for (int i = 0; i < path.Length; i++)
            {
                StreamReader reader = new StreamReader(path[i]);
                string[] lineArray = new string[2];
                string line = reader.ReadLine();

                while (line != null)
                {

                    lineArray = line.Split('\t');
                    details.Add(lineArray[1]);
                    line = reader.ReadLine();

                }
                reader.Close();

            }




            string password = details[8];
            return password;
        }



        public string LoggedDoc()
        {
            List<string> details = new List<string>();
            string[] path = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Doctor");
            //Assign path to a folder where a logged doctor file is situated

            for (int i = 0; i < path.Length; i++)
            {
                StreamReader reader = new StreamReader(path[i]);
                string[] lineArray = new string[2];
                string line = reader.ReadLine();

                int index = 0;

                while (line != null)
                {

                    lineArray = line.Split('\t');
                    details.Add(lineArray[1]);
                    line = reader.ReadLine();
                    index++;

                    if (index > 9)
                    {
                        break;
                    }

                }
                reader.Close();
            }

                string info = ($"{details[0]},{details[1]},{details[2]},{details[3]},{details[4]},{details[5]},{details[6]},{details[7]} , {details[8]}");
            return info;
        }


        public string LoggedDocName()
        {
            string[] details = LoggedDoc().Split(',');
            string name = details[0];
            string lastname = details[1];
            return $"Dr " + name + " " + lastname;
        }

        public string DoctorNameSplit()
        {
            string[] details = LoggedDocName().Split(' ');
            string[] name = details;
            string Dr, N, S;
            Dr = name[0];
            N = name[1];
            S = name[2];

            return N;
        }

        public string LoggedPName()
        {
            string[] details = LoggedPatient().Split(',');
            string name = details[0];
            return name;
        }



        public string ViewBooking()
        {
            List<string> info = new List<string>();
            List<string> Pbookings = new List<string>();

            string[] bookings = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\ScheduleBookings");
            //Assign path to a folder where bookings are stored

            for (int i = 0; i < bookings.Length; i++)
            {
                StreamReader reader = new StreamReader(bookings[i]);
                string[] lineArray = new string[2];
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineArray = line.Split('\t');

                    if (lineArray[1] == LoggedPName())
                    {
                        Pbookings.Add(bookings[i]);
                    }
                    line = reader.ReadLine();
                }
            }

            for (int i = 0; i < Pbookings.Count; i++)
            {
                StreamReader reader = new StreamReader(Pbookings[i]);
                string line = reader.ReadLine();
                string[] lineArray = new string[2];
                while (line != null)
                {
                    lineArray = line.Split('\t');
                    info.Add(lineArray[1]);
                    line = reader.ReadLine();
                }



            }

            string fileNumber, Category, Doctor, Date, time;
            fileNumber = info[0];
            Category = info[1];
            Doctor = info[2];
            Date = info[3];
            time = info[4];

            string BookInfo = $"{fileNumber},{Category},{Doctor},{Date},{time}";
            return BookInfo;

        }

        public string[] ViewDBooking()
        {

            List<string> Pbookings = new List<string>();

            string[] bookings = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\ScheduleBookings");
            //Assign path to a folder where bookings are stored

            if (bookings.Length > 0)
            {
                for (int i = 0; i < bookings.Length; i++)
                {
                    StreamReader reader = new StreamReader(bookings[i]);
                    string[] lineArray = new string[2];
                    string line = reader.ReadLine();

                    while (line != null)
                    {

                        lineArray = line.Split('\t');
                        if (lineArray[1] == LoggedDocName())
                        {
                            Pbookings.Add(bookings[i]);
                        }
                        line = reader.ReadLine();
                    }
                }

            }
            else
            {
                MessageBox.Show("There are no bookings at this time ");
            }


            List<string> all = new List<string>();


            if (Pbookings.Count > 0)
            {
                MessageBox.Show("You have " + Pbookings.Count.ToString() + " Bookings");
                for (int i = 0; i < Pbookings.Count; i++)
                {
                    List<string> info = new List<string>();
                    StreamReader reader = new StreamReader(Pbookings[i]);
                    string line = reader.ReadLine();
                    string[] lineArray = new string[2];
                    while (line != null)
                    {
                        lineArray = line.Split('\t');
                        info.Add(lineArray[1]);
                        line = reader.ReadLine();
                    }

                    reader.Close();
                    string fileNumber, Category, Doctor, Date, time;
                    fileNumber = info[0];
                    Category = info[1];
                    Doctor = info[2];
                    Date = info[3];
                    time = info[4];

                    string BookInfo = $"{fileNumber},{Category},{Doctor},{Date},{time},{info[5]}";
                    all.Add(BookInfo);
                }


            }
            else
            {
                MessageBox.Show("There are no bookings available");
            }



            return all.ToArray();

        }

        public string[] InitializeDoc()
        {
            List<string> DocNames = new List<string>();

            string[] path = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\Doc&AdminReg");
            //Assign path to a folder where  doctor users files are situated

            if (path.Length > 0)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    List<string> details = new List<string>();
                    StreamReader reader = new StreamReader(path[i]);
                    string[] lineArray = new string[2];
                    string line = reader.ReadLine();



                    using (reader)
                    {
                        while (line != null)
                        {

                            lineArray = line.Split('\t');

                            details.Add(lineArray[1]);
                            line = reader.ReadLine();
                        }
                    }
                    reader.Close();
                    string info = ($"{details[0]} {details[1]}");
                    DocNames.Add(info);

                }

            }

            return DocNames.ToArray();



        }

        public string[] AdminViewBookings()
        {
            List<string> all = new List<string>();


            string[] files = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\ScheduleBookings");
            //Assign path to a folder where bookings are stored
            for (int i = 0; i < files.Length; i++)
            {
                StreamReader reader = new StreamReader(files[i]);
                List<string> info = new List<string>();

                string line = reader.ReadLine();
                string[] lineArray = new string[2];
                while (line != null)
                {
                    lineArray = line.Split('\t');
                    info.Add(lineArray[1]);
                    line = reader.ReadLine();
                }

                reader.Close();

                string fileNumber, Category, Doctor, Date, time;
                fileNumber = info[0];
                Category = info[1];
                Doctor = info[2];
                Date = info[3];
                time = info[4];
                string name = info[5];

                string BookInfo = $"{fileNumber},{Category},{Doctor},{Date},{time},{name}";
                all.Add(BookInfo);

            }


            return all.ToArray();

        }


        public void DocLogout()
        {
            string[] logs = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Doctor");
            //Assign path to a folder where a logged doctor file is situated

            /*for (int i = 0; i <logs.Length; i++)
            {
                string file = logs[i];
                File.Delete(file);
            }*/

        }

        public void PatientLogout()
        {

            string[] logs = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Doctor");
            //Assign path to a folder where a logged patient file is situated

            for (int i = 0; i < logs.Length; i++)
            {
                string file = logs[i];
                File.Delete(file);
            }

        }

        public string DocLoginTxtFiles()
        {
            string feedback = "";
            string filePath = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\Doc&AdminReg\{idnumber}.txt");
            //Assign path to a folder where  doctor users files are situated

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArray = new string[2];
                        lineArray = line.Split('\t');
                        if (lineArray[1] == password1)
                        {

                            feedback = "Access granted!";
                            string dest = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\LOGGED\Doctor\{idnumber}.txt");
                            //Assign dest path to a folder where a logged doctor file is situated
                            string Mypath = filePath;
                            File.Copy(Mypath, dest, true);

                            return feedback;
                        }
                        else
                        {
                            feedback = "Incorrect password!";
                        }
                        line = reader.ReadLine();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                feedback = "Incorrect Email!!!" + ex;
            }
            return feedback;

        }


        public string SearchPatient()
        {
            string path = ($@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\PatientRegistrationTextFile\{idnumber}.txt");
            //Assign path to Patients users folder
            List<string> details = new List<string>();
            try
            {
                StreamReader reader = new StreamReader(path);
                string[] lineArray = new string[2];
                string line = reader.ReadLine();

                int index = 0;

                while (line != null)
                {

                    lineArray = line.Split('\t');
                    details.Add(lineArray[1]);
                    line = reader.ReadLine();
                    index++;

                    if (index > 9)
                    {
                        break;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ID not found");

            }



            string info = ($"{details[0]},{details[1]},{details[2]},{details[3]},{details[4]},{details[5]},{details[6]},{details[7]}");
            return info;


        }

        public string[] AdminViewPatients()
        {

            string[] files = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\PatientRegistrationTextFile");
            MessageBox.Show(files.Length.ToString());
            //Assign path to patient users folder 


            List<string> all = new List<string>();
            for (int i = 0; i < files.Length; i++)
            {
                List<string> details = new List<string>();
                try
                {
                    StreamReader reader = new StreamReader(files[i]);
                    string[] lineArray = new string[2];
                    string line = reader.ReadLine();

                    int index = 0;

                    while (line != null)
                    {

                        lineArray = line.Split('\t');
                        details.Add(lineArray[1]);
                        line = reader.ReadLine();
                        index++;

                        if (index > 9)
                        {
                            break;
                        }


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID not found");

                }

                string info = ($"{details[0]},{details[1]},{details[2]},{details[3]},{details[4]},{details[5]},{details[6]},{details[7]}");
                all.Add(info);

            }

            return all.ToArray();
        }

        public string[] AdminViewDoctors()
        {

            string[] path = Directory.GetFiles(@"C:\Users\Siphesihle Sephaka\OneDrive - Durban University of Technology\Documents\SECOND YEAR\APDA 101\project APDP\Doc&AdminReg");
            //Assign path to a folder where  doctor users files is situated

            List<string> all = new List<string>();

            if (path.Length > 0)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    List<string> details = new List<string>();
                    StreamReader reader = new StreamReader(path[i]);
                    string[] lineArray = new string[2];
                    string line = reader.ReadLine();

                    int index = 0;

                    while (line != null)
                    {

                        lineArray = line.Split('\t');
                        details.Add(lineArray[1]);
                        line = reader.ReadLine();
                        index++;

                        if (index > 9)
                        {
                            break;
                        }

                    }
                    reader.Close();
                    string info = ($"{details[0]},{details[1]},{details[2]},{details[3]},{details[4]},{details[5]},{details[6]},{details[7]},{details[8]}");
                    all.Add(info);

                }
            }

            return all.ToArray();
        }
    }
}