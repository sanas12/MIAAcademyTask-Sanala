namespace MiaAcademyAutomation
{
    public class User
    {
        public required string ParentFirstName { get; set; }
        public required string ParentLastName { get; set; }
        public required string ParentEmail { get; set; }
        public required string ParentPhone { get; set; }
        public required string ParentFirstName1 { get; set; }
        public required string ParentLastName1 { get; set; }
        public required string ParentEmail1 { get; set; }
        public required string ParentPhone1 { get; set; }
        public required string Date { get; set; }


    }


    public class StudentInfo
    {
        public required string StudentFirstName { get; set; }
        public required string StudentLastName { get; set; }
        public required  string StudentPreferredName { get; set; }
        public required string StudentEmail { get; set; }
        public required string StudentPhone { get; set; }
        public required string StudentDOB { get; set; }
        public required string Gender { get; set; }
        public required string Account { get; set; }
        public required string Schooling { get; set; }
        public required List<string> MathCheckboxes { get; set; }
        public required List<string> EnglishCheckboxes { get; set; }
        public required string ScienceCheckbox { get; set; }
        public required string StudentTextArea { get; set; }
        public required string StudentChallenge { get; set; }
    }

   
}

