using AntiSterfProgramma.Model;
namespace AntiSterfProgramma;

public partial class Medication : ContentPage
{
	public Medication()
	{
		InitializeComponent();

        List<Medications> medication = new List<Medications>();
		medication.Add(new Medications() { MedicationName = "Bisoprolol", MedicationUse = "Heart Medication", MedicationUrl = "pills.png" });
		medication.Add(new Medications() { MedicationName = "Multi Vitamin", MedicationUse = "Vitimins", MedicationUrl = "vitamins.png" });
		medication.Add(new Medications() { MedicationName = "Wellbutrin", MedicationUse = "Antidepressants", MedicationUrl = "pills.png" });
		medication.Add(new Medications() { MedicationName = "Pantomed", MedicationUse = "Stomach Medication", MedicationUrl = "pills.png" });
		medication.Add(new Medications() { MedicationName = "Clexane", MedicationUse = "Anti Blood Clotting", MedicationUrl = "syringe.png" });

		MedicationCollection.ItemsSource = medication;
    }

	
	
	

}