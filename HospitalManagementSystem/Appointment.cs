﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Appointment
    {
        private string doctorID, patientID, description;
        public Appointment(string doctorID, string patientID, string description)
        {
            this.doctorID = doctorID;
            this.patientID = patientID;
            this.description = description;
        }

        public string DoctorID
        {
            get { return doctorID; }
            set { doctorID = value; }
        }

        public string PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public override string ToString()
        {
            string[] doctorInfo = File.ReadAllLines($"Doctors\\{doctorID}.txt");
            string doctorName = doctorInfo[0].Split(';')[2];

            string[] patientInfo = File.ReadAllLines($"Patients\\{patientID}.txt");
            string patientName = patientInfo[0].Split(';')[2];

            return $"{doctorName,-20} | {patientName,-20} | {description,-20}";
        }
    }
}
