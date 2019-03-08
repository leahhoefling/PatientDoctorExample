using System.Collections.Generic;

namespace patientDrExample
{
    public class Patient
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //relationship to Doctor
        public Doctor Doctor { get; set; }

        //Specific Patient's Medication List
        public List<PatientMedication> PatientMedicationList { get; set; }
    }
}