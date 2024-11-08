using System.Xml.Serialization;

namespace tim_skit
{
    public class Bil
    {
        private string name;
        private string ålder;
        private string motor;
        private string namn2;
        private string ålder2;
        private string motor2;
        public void setname(string n) { name = n; }
        public string getname() { return name; }
        public void setålder(string å) { ålder = å; }
        public string getålder() {return ålder; }
        public void setmotor(string m) {motor = m; }
        public string getmotor() {return motor;}
        public void setname2(string n) { name = n; }
        public string getname2() { return name; }
        public void setålder2(string å) { ålder = å; }
        public string getålder2() {return ålder; }
        public void setmotor2(string m) {motor2 = m; }
        public string getmotor2() {return motor2;}
    }
}