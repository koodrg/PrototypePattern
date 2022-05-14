using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototypePattern
{
    public class Student : Prototype
    {
        public string Name { get; set; }

        public string Class { get; set; }

        public int Age { get; set; }

        public Address Address { get; set; }
        public Student(string name, string studenClass, int age, Address address)
        {
            this.Name = name;
            this.Class = studenClass;
            this.Age = age;
            this.Address = address;
        }

        public Object ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }

        public Object DeepCopy()
        {
            Student student = (Student)this.MemberwiseClone();
            student.Address = new Address(this.Address.Province, this.Address.Ward, this.Address.District);
            return student;
        }

        public override string ToString()
        {
            return "Name: " + Name + "; Class: " + Class + "; Age:" + Age + "; Address: { Provice: " + Address.Province + ", Ward: " + Address.Ward + ", District: " + Address.District + " }";
        }
    }
}
