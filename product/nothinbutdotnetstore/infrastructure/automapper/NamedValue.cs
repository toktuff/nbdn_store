namespace nothinbutdotnetstore.infrastructure.automapper
{
    public class NamedValue
    {
        public NamedValue(string name, object value)
        {
            this.name = name;
            this.value = value;
        }

        public string name { get; set; }
        public object value { get; set; }
    }
}