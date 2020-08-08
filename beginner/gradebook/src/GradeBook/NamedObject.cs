namespace GradeBook
{
    public class NamedObject
    {
        // Creates our field in the background - private string name
        public string Name { get; set; }

        public NamedObject(string name)
        {
            Name = name;
        }

    }
}