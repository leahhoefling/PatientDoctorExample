using System.Collections.Generic;

namespace patientDrExample
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Specific Patient's Medication List
        public List<PatientMedication> PatientMedicationList { get; set; }
    }
}