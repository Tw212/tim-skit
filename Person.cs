using System.Xml.Serialization;

namespace tim_skit
{
    public class Bil
    {
        public string name;
        public string ålder;
        public string motor;
       
       public string Name
       {
            get { return name; }
            set { name = value; }
       }
       
       public Bil(string n, string å, string m){
        name=n;
        ålder=å;
        motor=m;
       }
    }
}