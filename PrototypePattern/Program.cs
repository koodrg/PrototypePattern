using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Ha Noi", "Ha Dong", "Nguyen Trai");
            Student originalStudent = new Student("Nguyen Van A", "PMCL2018", 22, address);
            Student studentShallowCopy = (Student)originalStudent.ShallowCopy();
            Student studentDeepCopy = (Student)originalStudent.DeepCopy();

            Console.WriteLine("Before change address:");
            Console.WriteLine("original Student: " + originalStudent);
            Console.WriteLine("shallow Student: " + studentShallowCopy);
            Console.WriteLine("deep Student: " + studentDeepCopy);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("After shallow Student change address:");
            studentShallowCopy.Address.District = "Thanh Xuan";
            Console.WriteLine("original Student: " + originalStudent);
            Console.WriteLine("shallow Student: " + studentShallowCopy);
            Console.WriteLine("deep Student: " + studentDeepCopy);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("After deep Student change address:");
            studentDeepCopy.Address.District = "Cau Giay";
            Console.WriteLine("original Student: " + originalStudent);
            Console.WriteLine("shallow Student: " + studentShallowCopy);
            Console.WriteLine("deep Student: " + studentDeepCopy);

            Console.ReadKey();
        }
    }
}
