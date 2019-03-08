using System.Collections.Generic;

namespace patientDrExample
{
    public class PatientMedication
    {
        public int Id { get; set; }
        public int Dosage { get; set; }
        public string Units { get; set; }
        public int NumOfRefills { get; set; }

        //relationships to patient and medication
        public Patient Patient { get; set; }
        public Medication Medication { get; set; }

    }

}